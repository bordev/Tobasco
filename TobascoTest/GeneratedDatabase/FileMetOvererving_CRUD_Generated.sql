﻿CREATE PROCEDURE [dbo].[FileMetOvererving_Insert]
    @Id bigint output,
    @TestChildProp1 nvarchar(100),
    @TestChildProp2 int,
    @TestChildProp3 bigint,
    @TestChildProp4 datetime2(7),
    @TestChildProp5 tinyint,
    @TestChildProp6 decimal(12,2),
    @TestChildProp7Id bigint,
    @ModifiedBy nvarchar(256)
AS
BEGIN
     SET NOCOUNT ON;

     INSERT
       INTO [dbo].FileMetOvererving
           (
            TestChildProp1,
            TestChildProp2,
            TestChildProp3,
            TestChildProp4,
            TestChildProp5,
            TestChildProp6,
            TestChildProp7Id,
            [ModifiedBy],
            [ModifiedOn]
           )
     OUTPUT Inserted.Id
           ,Inserted.[RowVersion]
           ,Inserted.ModifiedOn
     VALUES
           (
            @TestChildProp1,
            @TestChildProp2,
            @TestChildProp3,
            @TestChildProp4,
            @TestChildProp5,
            @TestChildProp6,
            @TestChildProp7Id,
            @ModifiedBy,
            SYSDATETIME()
           );
END;
GO

CREATE PROCEDURE [dbo].[FileMetOvererving_Update]
    @Id [bigint],
    @TestChildProp1 nvarchar(100),
    @TestChildProp2 int,
    @TestChildProp3 bigint,
    @TestChildProp4 datetime2(7),
    @TestChildProp5 tinyint,
    @TestChildProp6 decimal(12,2),
    @TestChildProp7Id bigint,
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

     UPDATE [dbo].FileMetOvererving
        SET
            FileMetOvererving.TestChildProp1 = @TestChildProp1,
            FileMetOvererving.TestChildProp2 = @TestChildProp2,
            FileMetOvererving.TestChildProp3 = @TestChildProp3,
            FileMetOvererving.TestChildProp4 = @TestChildProp4,
            FileMetOvererving.TestChildProp5 = @TestChildProp5,
            FileMetOvererving.TestChildProp6 = @TestChildProp6,
            FileMetOvererving.TestChildProp7Id = @TestChildProp7Id,
            FileMetOvererving.ModifiedBy = ISNULL(@ModifiedBy, SUSER_SNAME()),
            FileMetOvererving.ModifiedOn = SYSDATETIME()
     OUTPUT Inserted.[RowVersion]
           ,Inserted.ModifiedOn
       INTO #Output
           ([RowVersion]
           ,ModifiedOn
           )
      WHERE FileMetOvererving.Id = @Id
        AND FileMetOvererving.[RowVersion] = @RowVersion

     DECLARE @RowCountBig AS bigint = ROWCOUNT_BIG();

     IF @RowCountBig = 0
     BEGIN
         DECLARE @message AS nvarchar(2048) = CONCAT(QUOTENAME(OBJECT_SCHEMA_NAME(@@PROCID)), '.', OBJECT_NAME(@@PROCID), N': '
                                                    ,N'Concurrency probleem. '
                                                    ,N'De FileMetOvererving-rij met Id=', @Id, N' en RowVersion=', CAST(@RowVersion AS binary(8)), N' kon niet gewijzigd worden door ', @ModifiedBy, N'. '
                                                    ,N'De rij was tussendoor gewijzigd of verwijderd door een andere gebruiker.'
                                                    );
         THROW 55501, @message, 1;
     END;

     SELECT #Output.[RowVersion]
           ,#Output.ModifiedOn
       FROM #Output;
END;
GO

CREATE PROCEDURE [dbo].[FileMetOvererving_Delete]
    @Id [bigint],
    @RowVersion rowversion,
    @ModifiedBy nvarchar(256)
AS
BEGIN
     SET NOCOUNT ON;

     DECLARE @Context varbinary(128) = CAST(CAST(ISNULL(@ModifiedBy, SUSER_SNAME()) AS char(256)) AS varbinary(256));
     SET CONTEXT_INFO @Context;

     DELETE
       FROM [dbo].FileMetOvererving
      WHERE FileMetOvererving.Id = @Id
        AND FileMetOvererving.[RowVersion] = @RowVersion;

     DECLARE @RowCountBig AS bigint = ROWCOUNT_BIG();

     SET CONTEXT_INFO 0x;

     IF @RowCountBig = 0
     BEGIN
         DECLARE @message AS nvarchar(2048) = CONCAT(QUOTENAME(OBJECT_SCHEMA_NAME(@@PROCID)), '.', OBJECT_NAME(@@PROCID), N': '
                                                    ,N'Concurrency probleem. '
                                                    ,N'De FileMetOvererving-rij met Id=', @Id, N' en RowVersion=', CAST(@RowVersion AS binary(8)), N' kon niet verwijderd worden door ', @ModifiedBy, N'. '
                                                    ,N'De rij was tussendoor gewijzigd of verwijderd door een andere gebruiker.'
                                                    );
         THROW 55501, @message, 1;
     END;

END;
GO

