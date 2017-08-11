﻿CREATE TABLE [dbo].[ChildCollectionObject](
	 [Id]			bigint	IDENTITY (1,1)  NOT NULL
	,[RowVersion]   rowversion         		NOT NULL
	,TestChildProp1 nvarchar(100) NOT NULL
,FileMetOverervingId bigint NOT NULL
	,[ModifiedBY]	nvarchar(256)			NOT NULL
	 CONSTRAINT [DF_ChildCollectionObject_ModifiedBy] DEFAULT SUSER_SNAME()
	,[ModifiedOn]	datetime2(7)			NOT NULL
	 CONSTRAINT [DF_ChildCollectionObject_ModifiedOn] DEFAULT SYSDATETIME()
	 CONSTRAINT [PK_ChildCollectionObject] PRIMARY KEY CLUSTERED (Id ASC)
	 ,CONSTRAINT [FK_ChildCollectionObject_FileMetOverervingId] FOREIGN KEY (FileMetOverervingId) REFERENCES [dbo].[FileMetOvererving] ([Id])

);
GO
CREATE TABLE [dbo].[ChildCollectionObject_historie] (
    [Id]                          bigint             NOT NULL
   ,[RowVersion]                  binary(8)          NOT NULL
   ,TestChildProp1 nvarchar(100) NOT NULL
,FileMetOverervingId bigint NOT NULL   
   ,[ModifiedBy]                  nvarchar (256)     NOT NULL
   ,[ModifiedOn]                  DATETIME2(7)       NOT NULL
   ,DeletedBy                     nvarchar(256)     NULL
   ,DeletedAt                     datetime2(7)      NULL
);
GO
-- ================================================================================
-- I n d e x e s
-- ================================================================================

CREATE NONCLUSTERED INDEX IX_ChildCollectionObject_historie_Id
                       ON [dbo].ChildCollectionObject_historie
                         (Id ASC)
                  INCLUDE(ModifiedOn);
GO
CREATE NONCLUSTERED INDEX IX_ChildCollectionObject_FileMetOverervingId ON [dbo].[ChildCollectionObject] (FileMetOverervingId ASC)
GO

GO
-- ================================================================================
-- T r i g g e r s
-- ================================================================================

CREATE TRIGGER [dbo].tu_ChildCollectionObject
            ON [dbo].ChildCollectionObject
           FOR UPDATE
AS
BEGIN
    INSERT
      INTO [dbo].ChildCollectionObject_historie(
			Id,
		    [RowVersion],
		   TestChildProp1,
FileMetOverervingId,
            [ModifiedBy],
            [ModifiedOn],
            DeletedBy,
            DeletedAt
           )
    SELECT DELETED.Id,
           DELETED.[RowVersion],
		  TestChildProp1,
FileMetOverervingId,
           Deleted.ModifiedBy,
           Deleted.ModifiedOn,
           NULL,
           NULL
      FROM Deleted;
END;
GO
CREATE TRIGGER [dbo].td_ChildCollectionObject
            ON [dbo].ChildCollectionObject
		   FOR DELETE
AS
BEGIN
	INSERT
	  INTO [dbo].ChildCollectionObject_historie(
			Id,
		    [RowVersion],
           TestChildProp1,
FileMetOverervingId,
		    [ModifiedBy],
		    [ModifiedOn],
		    [DeletedBy],
		    [DeletedAt]
            )
	SELECT Deleted.Id,
	       Deleted.[RowVersion],
		  TestChildProp1,
FileMetOverervingId,
		   Deleted.ModifiedBy,
		   Deleted.ModifiedOn,
		   ISNULL(LTRIM(RTRIM(CONVERT(nvarchar(128), CONTEXT_INFO()))), SUSER_SNAME()),
		   SYSDATETIME()
	  FROM Deleted;
END;

