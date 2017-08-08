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
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Tobasco.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to AnymonousPropertySet.
        /// </summary>
        internal static string AnymonousPropertySet {
            get {
                return ResourceManager.GetString("AnymonousPropertySet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to public override ExpandoObject ToAnonymous()
        ///{
        ///	dynamic anymonous = base.ToAnonymous();
        ///	%AnymonousPropertySet%
        ///	return anymonous;
        ///}.
        /// </summary>
        internal static string ClassDapperMethod {
            get {
                return ResourceManager.GetString("ClassDapperMethod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to %Namespaces%
        ///
        ///namespace %OwnNamespace%
        ///{
        ///	%Attributes%
        ///	public %Abstract% partial %Type% %ClassName%%Extension% %BaseClass%
        ///	{
        ///		%Constructor%
        ///		
        ///		%Properties%
        ///		
        ///		%Methods%	
        ///	}
        ///}.
        /// </summary>
        internal static string ClassFile {
            get {
                return ResourceManager.GetString("ClassFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to public SqlConnection GetConnection()
        ///{
        ///	SqlConnection connection = null;
        ///	SqlConnection tempConnection = null;
        ///	try
        ///	{
        ///		tempConnection = new SqlConnection(_connectionstring);
        ///		tempConnection.Open();
        ///		connection = tempConnection;
        ///		tempConnection = null;
        ///	}
        ///	finally
        ///	{
        ///		tempConnection?.Dispose();
        ///	}
        ///	return connection;
        ///}.
        /// </summary>
        internal static string ConnectionFactoryGetConnection {
            get {
                return ResourceManager.GetString("ConnectionFactoryGetConnection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to %ConstructorFields%
        ///public %Name%(%ConstructorParameters%)
        ///{
        ///	%FieldWithParameter%
        ///	%CustomImplementation%
        ///}.
        /// </summary>
        internal static string Constructor {
            get {
                return ResourceManager.GetString("Constructor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to public IEnumerable&lt;T&gt; Save(IEnumerable&lt;T&gt; entities)
        ///{
        ///	var enumerable = entities as IList&lt;T&gt; ?? entities.ToList();
        ///	foreach (var entity in enumerable)
        ///	{
        ///		Save(entity);
        ///	}
        ///	return enumerable;
        ///}.
        /// </summary>
        internal static string GenericRepositoryBulkSave {
            get {
                return ResourceManager.GetString("GenericRepositoryBulkSave", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to public void Delete(T entity)
        ///{
        ///	using (var connection = ConnectionFactory.GetConnection())
        ///	{
        ///		connection.Execute($&quot;[dbo].[{ typeof(T).Name}_Delete]&quot;,
        ///			new {entity.Id, entity.RowVersion, entity.ModifiedBy },
        ///			commandType: CommandType.StoredProcedure);
        ///	}
        ///}.
        /// </summary>
        internal static string GenericRepositoryDelete {
            get {
                return ResourceManager.GetString("GenericRepositoryDelete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to public T GetById(long id)
        ///{
        ///	T entity;
        ///	using (var connection = ConnectionFactory.GetConnection())
        ///	{
        ///		entity = connection.QuerySingle&lt;T&gt;($&quot;[dbo].[{ typeof(T).Name}_GetById]&quot;,
        ///			new {Id = id},
        ///			commandType: CommandType.StoredProcedure);
        ///	}
        ///	entity.MarkOld();
        ///	return entity;
        ///}.
        /// </summary>
        internal static string GenericRepositoryGetById {
            get {
                return ResourceManager.GetString("GenericRepositoryGetById", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to public T Insert(T entity)
        ///{
        ///	using (var connection = ConnectionFactory.GetConnection())
        ///	{
        ///		connection.Query&lt;long, byte[], T&gt;($&quot;[dbo].[{typeof(T).Name}_Insert]&quot;, (id, rowversion) =&gt;
        ///		{
        ///			entity.Id = id;
        ///			entity.RowVersion = rowversion;
        ///			return entity;
        ///		}, ToAnonymous(entity, false), splitOn: &quot;RowVersion&quot;, commandType: CommandType.StoredProcedure);
        ///	}
        ///	entity.MarkOld();
        ///	return entity;
        ///}.
        /// </summary>
        internal static string GenericRepositoryInsert {
            get {
                return ResourceManager.GetString("GenericRepositoryInsert", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to public T Save(T entity)
        ///{
        ///	if(entity.IsDeleted)
        ///	{
        ///		Delete(entity);
        ///		return entity;
        ///	}
        ///	if(entity.IsNew)
        ///	{
        ///		return Insert(entity);
        ///	}
        ///	if(entity.IsDirty)
        ///	{
        ///		return Update(entity);
        ///	}
        ///	return entity;
        ///}.
        /// </summary>
        internal static string GenericRepositorySave {
            get {
                return ResourceManager.GetString("GenericRepositorySave", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to private DynamicParameters ToAnonymous(T entity, bool includeRowVersion)
        ///{
        ///	dynamic anonymousEntity = entity.ToAnonymous();
        ///	anonymousEntity.Id = entity.Id;
        ///	var parameters = new DynamicParameters(anonymousEntity);
        ///	if (includeRowVersion)
        ///	{
        ///		parameters.Add(&quot;RowVersion&quot;, entity.RowVersion, DbType.Binary);
        ///	}
        ///	return parameters;
        ///}.
        /// </summary>
        internal static string GenericRepositoryToAnonymous {
            get {
                return ResourceManager.GetString("GenericRepositoryToAnonymous", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to public T Update(T entity)
        ///{
        ///	using (var connection = ConnectionFactory.GetConnection())
        ///	{
        ///		try
        ///		{
        ///			entity.RowVersion = connection.ExecuteScalar&lt;byte[]&gt;($&quot;[dbo].[{ typeof(T).Name}_Update]&quot;,
        ///				ToAnonymous(entity, true),
        ///				commandType: CommandType.StoredProcedure);
        ///		}
        ///		catch(SqlException ex)
        ///		{
        ///			if (ex.Number == 50000 &amp;&amp; ex.Class == 16 &amp;&amp; ex.Message.Contains(&quot; is al gewijzigd door een andere gebruiker.&quot;))
        ///			{
        ///				throw new DBConcurrencyException($&quot;Dirty write detected while updatin [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string GenericRepositoryUpdate {
            get {
                return ResourceManager.GetString("GenericRepositoryUpdate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to %Namespaces%
        ///
        ///namespace %OwnNamespace%
        ///{
        ///	public partial %Type% %InterfaceName%%Extension%
        ///	{
        ///		%Properties%
        ///			
        ///		%Methods%	
        ///	}
        ///}.
        /// </summary>
        internal static string InterfaceFile {
            get {
                return ResourceManager.GetString("InterfaceFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to public List&lt;%PropertyValueType%&gt; %PropertyName% { get; } = new List&lt;%PropertyValueType%&gt;();.
        /// </summary>
        internal static string PropertyChildCollection {
            get {
                return ResourceManager.GetString("PropertyChildCollection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to private %PropertyValueType% _%PropertyName%;
        ///
        ///%BusinessRules%
        ///public %PropertyValueType% %PropertyName%
        ///{
        ///	get { return _%PropertyName%; }
        ///	set { SetField(ref _%PropertyName%, value, nameof(%PropertyName%)); }
        ///}.
        /// </summary>
        internal static string PropertyDapperDefault {
            get {
                return ResourceManager.GetString("PropertyDapperDefault", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to %BusinessRules%
        ///public %PropertyValueType% %PropertyName% { get; set; }.
        /// </summary>
        internal static string PropertyDefault {
            get {
                return ResourceManager.GetString("PropertyDefault", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to PropertyName.
        /// </summary>
        internal static string PropertyName {
            get {
                return ResourceManager.GetString("PropertyName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to public %PropertyValueType% %PropertyName% { get; private set; }.
        /// </summary>
        internal static string PropertyReadonlyGuid {
            get {
                return ResourceManager.GetString("PropertyReadonlyGuid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to PropertyValueType.
        /// </summary>
        internal static string PropertyValueType {
            get {
                return ResourceManager.GetString("PropertyValueType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .
        /// </summary>
        internal static string RepositoryGetById {
            get {
                return ResourceManager.GetString("RepositoryGetById", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to public %EntityName% Save(%EntityName%  %EntityNameLowerCase%)
        ///{
        ///	%SaveChild%
        ///	
        ///	%EntityNameLowerCase% = _genericRepository.Save(%EntityNameLowerCase%);
        ///	
        ///	%SaveChildCollections%
        ///	
        ///	return %EntityNameLowerCase%;
        ///}.
        /// </summary>
        internal static string RepositorySave {
            get {
                return ResourceManager.GetString("RepositorySave", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to public %EntityName% Save(%EntityName%  %EntityNameLowerCase%)
        ///{
        ///	using (var trans = new TransactionScope())
        ///	{
        ///		%SaveChild%
        ///		
        ///		%EntityNameLowerCase% = _genericRepository.Save(%EntityNameLowerCase%);
        ///		
        ///		%SaveChildCollections%
        ///		
        ///		return %EntityNameLowerCase%;
        ///		trans.Complete();
        ///	}
        ///}.
        /// </summary>
        internal static string RepositorySaveWithTransaction {
            get {
                return ResourceManager.GetString("RepositorySaveWithTransaction", resourceCulture);
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
        ///   Looks up a localized string similar to CREATE TABLE [dbo].[%TableName%_historie] (
        ///    [Id]                          bigint             NOT NULL
        ///   %TableProperties%
        ///   ,[RowVersion]                  binary(8)          NOT NULL
        ///   ,[ModifiedBy]                  nvarchar (256)     NOT NULL
        ///   ,[ModifiedOn]                  DATETIME2(7)       NOT NULL
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
        ///   Looks up a localized string similar to CREATE PROCEDURE [dbo].[%TableName%_Insert]
        ///    @Id bigint output,
        ///	%StpParameter%
        ///    @ModifiedBy nvarchar(256)
        ///AS
        ///BEGIN
        ///    SET NOCOUNT ON;
        ///
        ///    INSERT
        ///      INTO [dbo].%TableName% 
        ///	       (
        ///			%StpPropertyNames%
        ///			[ModifiedBy],
        ///		    [ModifiedOn]
        ///		   )
        ///	OUTPUT Inserted.Id
        ///		  ,Inserted.[RowVersion]
        ///		  ,Inserted.ModifiedOn
        ///    VALUES
        ///         (
        ///		   %StpParameterName%
        ///           @ModifiedBy,
        ///           SYSDATETIME()
        ///          );
        ///END;.
        /// </summary>
        internal static string SqlInsertStp {
            get {
                return ResourceManager.GetString("SqlInsertStp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE TABLE [dbo].[%TableName%](
        ///	 [Id]			bigint	IDENTITY (1,1)  NOT NULL
        ///	,[RowVersion]   rowversion         		NOT NULL
        ///	%TableProperties%
        ///	,[ModifiedBY]	nvarchar(256)			NOT NULL
        ///	 CONSTRAINT [DF_{%TableName%}_ModifiedBy] DEFAULT SUSER_SNAME()
        ///	,[ModifiedOn]	datetime2(7)			NOT NULL
        ///	 CONSTRAINT [DF_{%TableName%}_ModifiedOn] DEFAULT SYSDATETIME()
        ///	 CONSTRAINT [PK_{%TableName%}] PRIMARY KEY CLUSTERED (Id ASC)
        ///);.
        /// </summary>
        internal static string SqlTable {
            get {
                return ResourceManager.GetString("SqlTable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE TRIGGER [dbo].td_%TableName%
        ///            ON [dbo].%TableName%
        ///		   FOR DELETE
        ///AS
        ///BEGIN
        ///	INSERT
        ///	  INTO [dbo].%TableName%_historie(
        ///			Id,
        ///		    [RowVersion],
        ///           %StpPropertyNames%
        ///		    [ModifiedBy],
        ///		    [ModifiedOn],
        ///		    [DeletedBy],
        ///		    [DeletedAt]
        ///            )
        ///	SELECT Deleted.Id,
        ///	       Deleted.[RowVersion],
        ///		  %StpPropertyNames%
        ///		   Deleted.ModifiedBy,
        ///		   Deleted.ModifiedOn,
        ///		   ISNULL(LTRIM(RTRIM(CONVERT(nvarchar(128), CONTEXT_INFO()))), SUSER_SNAME()),
        /// [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SqlTriggerDelete {
            get {
                return ResourceManager.GetString("SqlTriggerDelete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE TRIGGER [dbo].tu_%TableName%
        ///            ON [dbo].%TableName%
        ///           FOR UPDATE
        ///AS
        ///BEGIN
        ///    INSERT
        ///      INTO [dbo].%TableName%_historie(
        ///			Id,
        ///		    [RowVersion],
        ///		   %StpPropertyNames%
        ///            [ModifiedBy],
        ///            [ModifiedOn],
        ///            DeletedBy,
        ///            DeletedAt
        ///           )
        ///    SELECT DELETED.Id,
        ///           DELETED.[RowVersion],
        ///		  %StpPropertyNames%
        ///           Deleted.ModifiedBy,
        ///           Deleted.ModifiedOn,
        ///           NULL,
        ///           NULL
        ///      [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SqlTriggerUpdate {
            get {
                return ResourceManager.GetString("SqlTriggerUpdate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE PROCEDURE [dbo].[%TableName%_Update]
        ///		@Id [bigint],
        ///		%StpParameter%
        ///        @RowVersion [rowversion],
        ///        @ModifiedBy nvarchar(256)
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
        ///			    %TableName%.ModifiedB [rest of string was truncated]&quot;;.
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
