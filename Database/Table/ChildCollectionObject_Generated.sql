﻿CREATE TABLE [dbo].[ChildCollectionObject](
	 [Id]			bigint	IDENTITY (1,1)  NOT NULL
	,[RowVersion]   rowversion         		NOT NULL
	,[UId]          uniqueidentifier        NOT NULL CONSTRAINT [DF_{ChildCollectionObject}_UId] DEFAULT NEWID()
	,TestChildProp1 money NOT NULL
,TestChildProp2 smallmoney NOT NULL
,FileMetOverervingId bigint NOT NULL
	,[ModifiedBy]	nvarchar(256)			NOT NULL
	 CONSTRAINT [DF_ChildCollectionObject_ModifiedBy] DEFAULT SUSER_SNAME()
	,[ModifiedOn]	datetime2(7)			NOT NULL
	 CONSTRAINT [DF_ChildCollectionObject_ModifiedOn] DEFAULT SYSDATETIME()
 	,[ModifiedOnUTC] datetime2(7)			   NOT NULL
	 CONSTRAINT [DF_ChildCollectionObject_ModifiedOnUTC] DEFAULT SYSUTCDATETIME()
	,CONSTRAINT [PK_ChildCollectionObject] PRIMARY KEY CLUSTERED (Id ASC)
	 ,CONSTRAINT [FK_ChildCollectionObject_FileMetOverervingId] FOREIGN KEY (FileMetOverervingId) REFERENCES [dbo].[FileMetOvererving] ([Id])

);
GO
CREATE TABLE [dbo].[ChildCollectionObject_historie] (
    [Id]                          bigint             NOT NULL
   ,[RowVersion]                  binary(8)          NOT NULL
   ,[UId]                         uniqueidentifier   NOT NULL
   ,TestChildProp1 money NOT NULL
,TestChildProp2 smallmoney NOT NULL
,FileMetOverervingId bigint NOT NULL   
   ,[ModifiedBy]                  nvarchar (256)     NOT NULL
   ,[ModifiedOn]                  DATETIME2(7)       NOT NULL
   ,DeletedBy                     nvarchar(256)      NULL
   ,DeletedAt                     datetime2(7)       NULL
);
GO
CREATE NONCLUSTERED INDEX IX_ChildCollectionObject_historie_Id
                       ON [dbo].ChildCollectionObject_historie
                         (Id ASC)
                  INCLUDE(ModifiedOn);
GO
CREATE NONCLUSTERED INDEX IX_UQ_ChildCollectionObject_UId
                       ON [dbo].ChildCollectionObject
                         ([UId] ASC
                         )
GO
CREATE NONCLUSTERED INDEX IX_ChildCollectionObject_FileMetOverervingId ON [dbo].[ChildCollectionObject] (FileMetOverervingId ASC)
GO

GO
CREATE TRIGGER [dbo].tu_ChildCollectionObject
            ON [dbo].ChildCollectionObject
           FOR UPDATE
AS
BEGIN
    INSERT
      INTO [dbo].ChildCollectionObject_historie(
		   Id,
[UId],
[RowVersion],
TestChildProp1,
TestChildProp2,
FileMetOverervingId,
ModifiedBy,
ModifiedOn,
DeletedBy,
DeletedAt
           )
    SELECT 
		  Deleted.Id,
Deleted.[UId],
Deleted.[rowversion],
Deleted.TestChildProp1,
Deleted.TestChildProp2,
Deleted.FileMetOverervingId,
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
[UId],
[RowVersion],
TestChildProp1,
TestChildProp2,
FileMetOverervingId,
ModifiedBy,
ModifiedOn,
DeletedBy,
DeletedAt
            )
	SELECT 
		  Deleted.Id,
Deleted.[UId],
Deleted.[rowversion],
Deleted.TestChildProp1,
Deleted.TestChildProp2,
Deleted.FileMetOverervingId,
Deleted.ModifiedBy,
Deleted.ModifiedOn,
ISNULL(LTRIM(RTRIM(CONVERT(nvarchar(128), CONTEXT_INFO()))), SUSER_SNAME()),
SYSDATETIME()
	  FROM Deleted;
END;

GO
EXEC sp_addextendedproperty N'Description', 'ChildCollectionObject', 'SCHEMA', N'dbo', 'TABLE', N'ChildCollectionObject', NULL, NULL
GO
EXEC sp_addextendedproperty N'Description', 'This is TestChildProp1', 'SCHEMA', N'dbo', 'TABLE', N'ChildCollectionObject', 'COLUMN', N'TestChildProp1'
GO
EXEC sp_addextendedproperty N'Description', 'This is TestChildProp2', 'SCHEMA', N'dbo', 'TABLE', N'ChildCollectionObject', 'COLUMN', N'TestChildProp2'
GO
EXEC sp_addextendedproperty N'Description', 'This is FileMetOverervingId', 'SCHEMA', N'dbo', 'TABLE', N'ChildCollectionObject', 'COLUMN', N'FileMetOverervingId'
GO
