﻿CREATE PROCEDURE [dbo].[ChildObjectDac_Insert]
    @Id bigint output,
    @DataId bigint,
    @Roltype tinyint,
    @RelatieId bigint,
    @ModifiedBy nvarchar(256)
AS
BEGIN
     SET NOCOUNT ON;

     INSERT
       INTO [dbo].ChildObjectDac
           (
            DataId,
            Roltype,
            RelatieId,
            [ModifiedBy],
            [ModifiedOn]
           )
     OUTPUT Inserted.Id
           ,Inserted.[RowVersion]
           ,Inserted.ModifiedOn
     VALUES
           (
            @DataId,
            @Roltype,
            @RelatieId,
            @ModifiedBy,
            SYSDATETIME()
           );
END;
GO

CREATE PROCEDURE [dbo].[ChildObjectDac_Update]
    @Id [bigint],
    @DataId bigint,
    @Roltype tinyint,
    @RelatieId bigint,
    @RowVersion [rowversion],
    @ModifiedBy nvarchar(256)
AS
BEGIN
     SET NOCOUNT ON;

     IF OBJECT_ID('tempdb..#Output') IS NOT NULL
     BEGIN
         DROP TABLE #Output;
     END;

     CREATE TABLE #Output ([RowVersion]     binary(8)    NOT NULL
                          ,ModifiedOn       datetime2(7) NOT NULL
                          );

     UPDATE [dbo].ChildObjectDac
        SET
            ChildObjectDac.DataId = @DataId,
            ChildObjectDac.Roltype = @Roltype,
            ChildObjectDac.RelatieId = @RelatieId,
            ChildObjectDac.ModifiedBy = ISNULL(@ModifiedBy, SUSER_SNAME()),
            ChildObjectDac.ModifiedOn = SYSDATETIME()
     OUTPUT Inserted.[RowVersion]
           ,Inserted.ModifiedOn
       INTO #Output
           ([RowVersion]
           ,ModifiedOn
           )
      WHERE ChildObjectDac.Id = @Id
        AND ChildObjectDac.[RowVersion] = @RowVersion

     DECLARE @RowCountBig AS bigint = ROWCOUNT_BIG();

     IF @RowCountBig = 0
     BEGIN
         DECLARE @message AS nvarchar(2048) = CONCAT(QUOTENAME(OBJECT_SCHEMA_NAME(@@PROCID)), '.', OBJECT_NAME(@@PROCID), N': '
                                                    ,N'Concurrency probleem. '
                                                    ,N'De ChildObjectDac-rij met Id=', @Id, N' en RowVersion=', CAST(@RowVersion AS binary(8)), N' kon niet gewijzigd worden door ', @ModifiedBy, N'. '
                                                    ,N'De rij was tussendoor gewijzigd of verwijderd door een andere gebruiker.'
                                                    );
         THROW 55501, @message, 1;
     END;

     SELECT #Output.[RowVersion]
           ,#Output.ModifiedOn
       FROM #Output;
END;
GO

CREATE PROCEDURE [dbo].[ChildObjectDac_Delete]
    @Id [bigint],
    @RowVersion rowversion,
    @ModifiedBy nvarchar(256)
AS
BEGIN
     SET NOCOUNT ON;

     DECLARE @Context varbinary(128) = CAST(CAST(ISNULL(@ModifiedBy, SUSER_SNAME()) AS char(256)) AS varbinary(256));
     SET CONTEXT_INFO @Context;

     DELETE
       FROM [dbo].ChildObjectDac
      WHERE ChildObjectDac.Id = @Id
        AND ChildObjectDac.[RowVersion] = @RowVersion;

     DECLARE @RowCountBig AS bigint = ROWCOUNT_BIG();

     SET CONTEXT_INFO 0x;

     IF @RowCountBig = 0
     BEGIN
         DECLARE @message AS nvarchar(2048) = CONCAT(QUOTENAME(OBJECT_SCHEMA_NAME(@@PROCID)), '.', OBJECT_NAME(@@PROCID), N': '
                                                    ,N'Concurrency probleem. '
                                                    ,N'De ChildObjectDac-rij met Id=', @Id, N' en RowVersion=', CAST(@RowVersion AS binary(8)), N' kon niet verwijderd worden door ', @ModifiedBy, N'. '
                                                    ,N'De rij was tussendoor gewijzigd of verwijderd door een andere gebruiker.'
                                                    );
         THROW 55501, @message, 1;
     END;

END;
GO

