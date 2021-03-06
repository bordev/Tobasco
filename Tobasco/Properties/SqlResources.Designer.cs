﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tobasco.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class SqlResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SqlResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Tobasco.Properties.SqlResources", typeof(SqlResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to EXEC sp_addextendedproperty N&apos;Description&apos;, &apos;%Description%&apos;, &apos;SCHEMA&apos;, N&apos;dbo&apos;, &apos;TABLE&apos;, N&apos;%TableName%&apos;, &apos;COLUMN&apos;, N&apos;%Columnname%&apos;
        ///GO.
        /// </summary>
        internal static string DescriptionColumn {
            get {
                return ResourceManager.GetString("DescriptionColumn", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to EXEC sp_addextendedproperty N&apos;Description&apos;, &apos;%Description%&apos;, &apos;SCHEMA&apos;, N&apos;dbo&apos;, &apos;TABLE&apos;, N&apos;%TableName%&apos;, NULL, NULL
        ///GO
        ///%DescriptionColumns%.
        /// </summary>
        internal static string DescriptionTable {
            get {
                return ResourceManager.GetString("DescriptionTable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE PROCEDURE [dbo].%TableName%_GetFullById
        ///	@id bigint
        ///AS
        ///BEGIN
        ///            SET NOCOUNT ON;
        ///
        ///	%DeclareChilds%
        ///
        ///	%Childs_GetById%
        ///
        ///	%ChildCollection_GetByParentIdStp%
        ///
        ///	SELECT Id,
        ///		   [RowVersion],
        ///           %StpPropertyNames%
        ///		   [ModifiedBy],
        ///		   [ModifiedOn]
        ///	  FROM %TableName%
        ///	 WHERE %TableName%.Id = @id;
        ///END;.
        /// </summary>
        internal static string GetFullObjectByEntity {
            get {
                return ResourceManager.GetString("GetFullObjectByEntity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE PROCEDURE [dbo].%TableName%_GetFullByUId
        ///	@UId uniqueidentifier
        ///AS
        ///BEGIN
        ///          SET NOCOUNT ON;
        ///
        ///	DECLARE @id bigint;
        ///	
        ///	SELECT @id = Id
        ///	  FROM %TableName%
        ///	 WHERE %TableName%.[UId] = @UId;
        ///
        ///	EXEC [dbo].%TableName%_GetFullById @id
        ///END;.
        /// </summary>
        internal static string GetFullObjectByEntityUid {
            get {
                return ResourceManager.GetString("GetFullObjectByEntityUid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE PROCEDURE [dbo].%TableName%_GetFullById
        ///	@id bigint
        ///AS
        ///BEGIN
        ///            SET NOCOUNT ON;
        ///
        ///	%DeclareChilds%
        ///
        ///	%Childs_GetById%
        ///
        ///	%ChildCollection_GetByParentIdStp%
        ///
        ///	SELECT Id,
        ///				 Uid,
        ///		   [RowVersion],
        ///           %StpPropertyNames%
        ///		   [ModifiedBy],
        ///		   [ModifiedOn]
        ///	  FROM %TableName%
        ///	 WHERE %TableName%.Id = @id;
        ///END;.
        /// </summary>
        internal static string GetFullObjectByEntityWithUid {
            get {
                return ResourceManager.GetString("GetFullObjectByEntityWithUid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE PROCEDURE [dbo].%TableName%_GetFullByIds
        ///	@Ids AS [dbo].BigintType READONLY
        ///AS
        ///BEGIN
        ///            SET NOCOUNT ON;
        ///	%DeclareChildIdLists%
        ///	%Childs_GetByIds%
        ///
        ///	%ChildCollection_GetByIds%	
        ///
        ///	SELECT Id,
        ///		   [RowVersion],
        ///           %StpPropertyNames%
        ///		   [ModifiedBy],
        ///		   [ModifiedOn]
        ///	  FROM %TableName%
        ///	  WHERE EXISTS (SELECT 1
        ///                     FROM @Ids
        ///                    WHERE [@Ids].Id = %TableName%.Id
        ///                  );
        ///END;.
        /// </summary>
        internal static string GetFullObjectByIds {
            get {
                return ResourceManager.GetString("GetFullObjectByIds", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE PROCEDURE [dbo].%TableName%_GetFullByIds
        ///	@Ids AS [dbo].BigintType READONLY
        ///AS
        ///BEGIN
        ///            SET NOCOUNT ON;
        ///	%DeclareChildIdLists%
        ///	%Childs_GetByIds%
        ///
        ///	%ChildCollection_GetByIds%	
        ///
        ///	SELECT Id,
        ///				Uid,	
        ///		   [RowVersion],
        ///           %StpPropertyNames%
        ///		   [ModifiedBy],
        ///		   [ModifiedOn]
        ///	  FROM %TableName%
        ///	  WHERE EXISTS (SELECT 1
        ///                     FROM @Ids
        ///                    WHERE [@Ids].Id = %TableName%.Id
        ///                  );
        ///END;.
        /// </summary>
        internal static string GetFullObjectByIdsWithUid {
            get {
                return ResourceManager.GetString("GetFullObjectByIdsWithUid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE PROCEDURE [dbo].[%TableName%_Delete]
        ///		@Id [bigint]
        ///       ,@RowVersion [rowversion]
        ///       ,@ModifiedBy nvarchar(256)
        ///AS
        ///BEGIN
        ///		SET NOCOUNT ON;
        ///		
        ///		DECLARE @Context varbinary(128) = CAST(CAST(ISNULL(@ModifiedBy, SUSER_SNAME()) AS char(256)) AS varbinary(256));
        ///		
        ///		DELETE 
        ///		  FROM [dbo].%TableName%
        ///		 WHERE %TableName%.Id = @Id
        ///		   AND %TableName%.[RowVersion] = @RowVersion
        ///
        ///		DECLARE @RowCountBig AS bigint = ROWCOUNT_BIG();
        ///		
        ///		SET CONTEXT_INFO 0x;
        ///		
        ///		IF @RowCountBig = 0
        /// [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SqlDeleteStp {
            get {
                return ResourceManager.GetString("SqlDeleteStp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE PROCEDURE [dbo].[%TableName%_GetById]
        ///    @Id bigint
        ///AS
        ///BEGIN
        ///    SET NOCOUNT ON;
        ///
        ///	SELECT Id,
        ///		   [RowVersion],
        ///		   %StpPropertyNames%
        ///		   ModifiedBy,
        ///		   ModifiedOn
        ///	  FROM [dbo].%TableName%
        ///	 WHERE Id = @Id;
        ///END;.
        /// </summary>
        internal static string SqlGetByIdStp {
            get {
                return ResourceManager.GetString("SqlGetByIdStp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE PROCEDURE [dbo].%TableName%_GetFullBy%ReferenceName%
        ///	@%ReferenceName% bigint
        ///AS
        ///BEGIN
        ///
        ///	DECLARE @Ids AS [dbo].BigintType;
        ///	INSERT INTO @Ids
        ///	SELECT Id
        ///	  FROM %TableName%
        ///	 WHERE %TableName%.%ReferenceName% = @%ReferenceName%;
        ///
        ///	EXEC [dbo].%TableName%_GetFullByIds @Ids;
        ///END;.
        /// </summary>
        internal static string SqlGetByReferenceId {
            get {
                return ResourceManager.GetString("SqlGetByReferenceId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE PROCEDURE [dbo].%TableName%_GetFullBy%ReferenceName%s
        ///	@%ReferenceName% [dbo].BigintType READONLY
        ///AS
        ///BEGIN
        ///
        ///	DECLARE @Ids AS [dbo].BigintType;
        ///	INSERT INTO @Ids
        ///	SELECT  %TableName%.Id
        ///	  FROM %TableName%
        ///	 WHERE EXISTS( 
        ///						SELECT 1 
        ///						FROM @%ReferenceName%
        ///						WHERE %TableName%.%ReferenceName% = [@%ReferenceName%].Id
        ///					);
        ///
        ///	EXEC [dbo].%TableName%_GetFullByIds @Ids;
        ///END;.
        /// </summary>
        internal static string SqlGetByReferenceIdList {
            get {
                return ResourceManager.GetString("SqlGetByReferenceIdList", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE TABLE [dbo].[%TableName%_historie] (
        ///    [Id]                          bigint             NOT NULL
        ///   ,[RowVersion]                  binary(8)          NOT NULL
        ///   %TableProperties%   
        ///   ,[ModifiedBy]                  nvarchar (256)     NOT NULL
        ///   ,[ModifiedOn]                  datetime2(7)       NOT NULL
        ///   ,[ModifiedOnUTC] 			  datetime2(7)	     NOT NULL
        ///   ,DeletedBy                     nvarchar(256)     NULL
        ///   ,DeletedAt                     datetime2(7)      NULL
        ///);.
        /// </summary>
        internal static string SqlHistorieTable {
            get {
                return ResourceManager.GetString("SqlHistorieTable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE TABLE [dbo].[%TableName%_historie] (
        ///    [Id]                          bigint             NOT NULL
        ///   ,[RowVersion]                  binary(8)          NOT NULL
        ///   ,[UId]                         uniqueidentifier   NOT NULL
        ///   %TableProperties%   
        ///   ,[ModifiedBy]                  nvarchar (256)     NOT NULL
        ///   ,[ModifiedOn]                  datetime2(7)       NOT NULL
        ///   ,[ModifiedOnUTC] 			  datetime2(7)	     NOT NULL
        ///   ,DeletedBy                     nvarchar(256)      NULL
        ///   ,DeletedAt   [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SqlHistorieTableWithUid {
            get {
                return ResourceManager.GetString("SqlHistorieTableWithUid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE VIEW [dbo].%TableName%_historie_view
        ///	WITH SCHEMABINDING
        ///AS
        ///	WITH CTE_historie 
        ///	    (Id,
        ///		 [RowVersion],
        ///		%StpPropertyNames%		   
        ///		 DeletedBy,
        ///		 DeletedAt,              
        ///		 [FromSource]
        ///		) AS
        ///	(
        ///		SELECT Id,
        ///			   [RowVersion],
        ///			  %StpPropertyNames%		   
        ///			   DeletedBy,
        ///			   DeletedAt,
        ///			   &apos;History&apos;
        ///		  FROM [dbo].%TableName%_historie
        ///		  
        ///		 UNION ALL
        ///		 
        ///		SELECT Id,
        ///			   [RowVersion],
        ///			   %StpPropertyNames%			   
        ///			   NULL,
        ///			   NULL,
        ///			   &apos;Main&apos;
        ///		  F [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SqlHistorieView {
            get {
                return ResourceManager.GetString("SqlHistorieView", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE VIEW [dbo].%TableName%_historie_view
        ///	WITH SCHEMABINDING
        ///AS
        ///	WITH CTE_historie 
        ///	    (Id,
        ///		 [UId],
        ///		 [RowVersion],		 
        ///		%StpPropertyNames%		   
        ///		 DeletedBy,
        ///		 DeletedAt,              
        ///		 [FromSource]
        ///		) AS
        ///	(
        ///		SELECT Id,
        ///			   [UId],
        ///			   [RowVersion],
        ///			  %StpPropertyNames%		   
        ///			   DeletedBy,
        ///			   DeletedAt,
        ///			   &apos;History&apos;
        ///		  FROM [dbo].%TableName%_historie
        ///		  
        ///		 UNION ALL
        ///		 
        ///		SELECT Id,
        ///		       [UId],
        ///			   [RowVersion],
        ///			   %StpPropertyNames%			   
        /// [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SqlHistorieViewWithUid {
            get {
                return ResourceManager.GetString("SqlHistorieViewWithUid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE PROCEDURE [dbo].[%TableName%_Insert]
        ///	%StpParameter%
        ///AS
        ///BEGIN
        ///    SET NOCOUNT ON;
        ///
        ///    INSERT
        ///      INTO [dbo].%TableName% 
        ///	       (
        ///			%StpPropertyNames%
        ///		   )
        ///	OUTPUT Inserted.Id
        ///		  ,Inserted.[RowVersion]
        ///		  ,Inserted.ModifiedOn
        ///    VALUES
        ///         (
        ///		   %StpParameterName%
        ///          );
        ///END;.
        /// </summary>
        internal static string SqlInsertStp {
            get {
                return ResourceManager.GetString("SqlInsertStp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE PROCEDURE [dbo].[%TableName%_Insert]
        ///	%StpParameter%
        ///AS
        ///BEGIN
        ///    SET NOCOUNT ON;
        ///
        ///    INSERT
        ///      INTO [dbo].%TableName% 
        ///	       (
        ///			%StpPropertyNames%
        ///		   )
        ///	OUTPUT Inserted.Id
        ///              ,Inserted.[UId]
        ///		  ,Inserted.[RowVersion]
        ///		  ,Inserted.ModifiedOn
        ///    VALUES
        ///         (
        ///		   %StpParameterName%
        ///          );
        ///END;.
        /// </summary>
        internal static string SqlInsertStpWithUid {
            get {
                return ResourceManager.GetString("SqlInsertStpWithUid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE PROCEDURE [dbo].[%TableName%_Merge]
        ///		@DataTable [dbo].[%TableName%MergeType] READONLY,
        ///        @ModifiedBy nvarchar(256),
        ///		@ModifiedOn datetime2(7),    
        ///		@AbortOnConcurrency bit
        ///AS
        ///BEGIN
        ///		SET NOCOUNT ON;
        ///		
        ///		IF OBJECT_ID(&apos;tempdb..#output&apos;) IS NOT NULL
        ///		BEGIN
        ///			DROP TABLE #output
        ///		END
        ///		
        ///		CREATE TABLE #output 
        ///					(Id                   int           NOT NULL PRIMARY KEY
        ///	                 ,[RowVersion]         binary(8)     NOT NULL
        ///					 %TableProperties%
        ///                   [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SqlMergeStp {
            get {
                return ResourceManager.GetString("SqlMergeStp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE TYPE [dbo].[%TableName%MergeType] AS TABLE(
        ///	 [Id] [bigint] NULL	
        ///	,[RowVersion] [varbinary](8) NULL
        ///	%TableProperties%
        ///	,[Delete_Flag] [bit] NULL
        ///	,[Id_Intern] [bigint] NOT NULL
        ///).
        /// </summary>
        internal static string SqlMergeType {
            get {
                return ResourceManager.GetString("SqlMergeType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE TABLE [dbo].[%TableName%](
        ///	 [Id]			 bigint	IDENTITY (1,1)     NOT NULL
        ///	,[RowVersion]    rowversion         	   NOT NULL
        ///	%TableProperties%
        ///	,[ModifiedBy]	 nvarchar(256)			   NOT NULL
        ///	 CONSTRAINT [DF_%TableName%_ModifiedBy]    DEFAULT SUSER_SNAME()
        ///	,[ModifiedOn]	 datetime2(7)			   NOT NULL
        ///	 CONSTRAINT [DF_%TableName%_ModifiedOn]    DEFAULT SYSDATETIME()
        ///	,[ModifiedOnUTC] datetime2(7)			   NOT NULL
        ///	 CONSTRAINT [DF_%TableName%_ModifiedOnUTC] DEFAULT SYSUTCDATETIME()
        ///	,CONSTRAINT [PK_%Tab [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SqlTable {
            get {
                return ResourceManager.GetString("SqlTable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE TABLE [dbo].[%TableName%](
        ///	 [Id]			bigint	IDENTITY (1,1)  NOT NULL
        ///	,[RowVersion]   rowversion         		NOT NULL
        ///	,[UId]          uniqueidentifier        NOT NULL CONSTRAINT [DF_{%TableName%}_UId] DEFAULT NEWID()
        ///	%TableProperties%
        ///	,[ModifiedBy]	nvarchar(256)			NOT NULL
        ///	 CONSTRAINT [DF_%TableName%_ModifiedBy] DEFAULT SUSER_SNAME()
        ///	,[ModifiedOn]	datetime2(7)			NOT NULL
        ///	 CONSTRAINT [DF_%TableName%_ModifiedOn] DEFAULT SYSDATETIME()
        /// 	,[ModifiedOnUTC] datetime2(7)			   NOT NULL
        ///	 CONSTRAI [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SqlTableWithUid {
            get {
                return ResourceManager.GetString("SqlTableWithUid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE TRIGGER [dbo].[td_%TableName%]
        ///            ON [dbo].%TableName%
        ///		   FOR DELETE
        ///AS
        ///BEGIN
        ///
        ///    -- SET NOCOUNT ON added to prevent extra result sets from
        ///    -- interfering with SELECT statements.
        ///    SET NOCOUNT ON;
        ///
        ///	INSERT
        ///	  INTO [dbo].%TableName%_historie(
        ///           %StpPropertyNames%
        ///            )
        ///	SELECT 		  %StpDeletetedPropertyNames%
        ///	  FROM Deleted;
        ///END;.
        /// </summary>
        internal static string SqlTriggerDelete {
            get {
                return ResourceManager.GetString("SqlTriggerDelete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE TRIGGER [dbo].[td_%TableName%]
        ///            ON [dbo].%TableName%
        ///		   FOR DELETE
        ///AS
        ///BEGIN
        ///
        ///    -- SET NOCOUNT ON added to prevent extra result sets from
        ///    -- interfering with SELECT statements.
        ///    SET NOCOUNT ON;
        ///
        ///	INSERT
        ///	  INTO [dbo].%TableName%_historie(
        ///           %StpPropertyNames%
        ///            )
        ///	SELECT 
        ///		  %StpDeletetedPropertyNames%
        ///	  FROM Deleted;
        ///END;.
        /// </summary>
        internal static string SqlTriggerDeleteWithUid {
            get {
                return ResourceManager.GetString("SqlTriggerDeleteWithUid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE TRIGGER [dbo].[tu_%TableName%]
        ///            ON [dbo].%TableName%
        ///           FOR UPDATE
        ///AS
        ///BEGIN
        ///
        ///    -- SET NOCOUNT ON added to prevent extra result sets from
        ///    -- interfering with SELECT statements.
        ///    SET NOCOUNT ON;
        ///
        ///    INSERT
        ///      INTO [dbo].%TableName%_historie(
        ///		   %StpPropertyNames%
        ///           )
        ///    SELECT 
        ///		  %StpDeletetedPropertyNames%
        ///      FROM Deleted;
        ///END;.
        /// </summary>
        internal static string SqlTriggerUpdate {
            get {
                return ResourceManager.GetString("SqlTriggerUpdate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE TRIGGER [dbo].[tu_%TableName%]
        ///            ON [dbo].%TableName%
        ///           FOR UPDATE
        ///AS
        ///BEGIN
        ///
        ///    -- SET NOCOUNT ON added to prevent extra result sets from
        ///    -- interfering with SELECT statements.
        ///    SET NOCOUNT ON;
        ///
        ///
        ///    INSERT
        ///      INTO [dbo].%TableName%_historie(
        ///		   %StpPropertyNames%
        ///           )
        ///    SELECT 
        ///		  %StpDeletetedPropertyNames%
        ///      FROM Deleted;
        ///END;.
        /// </summary>
        internal static string SqlTriggerUpdateWithUid {
            get {
                return ResourceManager.GetString("SqlTriggerUpdateWithUid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE PROCEDURE [dbo].[%TableName%_Update]
        ///		%StpParameter%
        ///AS
        ///BEGIN
        ///		SET NOCOUNT ON;
        ///		
        ///		IF OBJECT_ID(&apos;tempdb..#Output&apos;) IS NOT NULL
        ///		BEGIN
        ///			DROP TABLE #Output;
        ///		END;
        ///
        ///		CREATE TABLE #Output ([RowVersion]     binary(8)    NOT NULL
        ///							  ,ModifiedOn      datetime2(7) NOT NULL
        ///							 );
        ///
        ///		UPDATE [dbo].%TableName%
        ///		   SET 
        ///				%UpdateSetTableParemeters%            
        ///		OUTPUT Inserted.[RowVersion]
        ///			  ,Inserted.ModifiedOn
        ///		  INTO #Output ([RowVersion]
        ///						,ModifiedOn
        ///					 [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SqlUpdateStp {
            get {
                return ResourceManager.GetString("SqlUpdateStp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to StpParameter.
        /// </summary>
        internal static string StpParameter {
            get {
                return ResourceManager.GetString("StpParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to StpParameterName.
        /// </summary>
        internal static string StpParameterName {
            get {
                return ResourceManager.GetString("StpParameterName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to StpPropertyNames.
        /// </summary>
        internal static string StpPropertyNames {
            get {
                return ResourceManager.GetString("StpPropertyNames", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to TableName.
        /// </summary>
        internal static string TableName {
            get {
                return ResourceManager.GetString("TableName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to TableProperties.
        /// </summary>
        internal static string TableProperties {
            get {
                return ResourceManager.GetString("TableProperties", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UpdateSetTableParemeters.
        /// </summary>
        internal static string UpdateSetTableParemeters {
            get {
                return ResourceManager.GetString("UpdateSetTableParemeters", resourceCulture);
            }
        }
    }
}
