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
        ///		%Properties%		
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
        ///        {
        ///            SqlConnection connection = null;
        ///            SqlConnection tempConnection = null;
        ///            try
        ///            {
        ///                tempConnection = new SqlConnection(_connectionstring);
        ///                tempConnection.Open();
        ///                connection = tempConnection;
        ///                tempConnection = null;
        ///            }
        ///            finally
        ///            {
        ///                tempConnection?.Dispose();
        ///            }
        ///
        ///            return connec [rest of string was truncated]&quot;;.
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
        ///   Looks up a localized string similar to [System.Diagnostics.CodeAnalysis.SuppressMessage(&quot;Microsoft.Maintainability&quot;, &quot;CA1506: AvoidExcessiveClassCoupling&quot;, Justification = &quot;Generated file&quot;)]
        ///public override void Load()
        ///{
        ///    %DIParams%
        ///}.
        /// </summary>
        internal static string DependencyInjection {
            get {
                return ResourceManager.GetString("DependencyInjection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to %Namespaces%
        ///
        ///namespace %OwnNamespace%
        ///{
        ///	%Attributes%
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
        ///   Looks up a localized string similar to protected virtual void NinjectBinder&lt;T, TY&gt;() 
        ///			where TY : class, T
        ///			where T : class
        ///{
        ///    Bind&lt;T&gt;().To&lt;TY&gt;()%BindingScope%;
        ///}.
        /// </summary>
        internal static string NinjectBinder {
            get {
                return ResourceManager.GetString("NinjectBinder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to private void Dispose(bool disposing)
        ///        {
        ///            if (!_disposed)
        ///            {
        ///                if (disposing)
        ///                {
        ///                    // ReSharper disable once UseNullPropagation
        ///                    if (_connection != null)
        ///                    {
        ///                        // ReSharper disable once InconsistentlySynchronizedField
        ///                        _connection.Dispose();
        ///                    }
        ///                }
        ///
        ///                _disposed = true;
        ///            }
        ///         [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string PrivateDispose {
            get {
                return ResourceManager.GetString("PrivateDispose", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to %Description%
        ///public List&lt;%PropertyValueType%&gt; %PropertyName% { get; } = new List&lt;%PropertyValueType%&gt;();.
        /// </summary>
        internal static string PropertyChildCollection {
            get {
                return ResourceManager.GetString("PropertyChildCollection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to private %PropertyValueType% _%PropertyParameterName%;
        ///%Description%
        ///%BusinessRules%
        ///public %PropertyValueType% %PropertyName%
        ///{
        ///	get { return _%PropertyParameterName%; }
        ///	set { SetField(ref _%PropertyParameterName%, value, nameof(%PropertyName%)); }
        ///}.
        /// </summary>
        internal static string PropertyDapperDefault {
            get {
                return ResourceManager.GetString("PropertyDapperDefault", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to %Description%
        ///%BusinessRules%
        ///public %PropertyValueType% %PropertyName% { get; set; }.
        /// </summary>
        internal static string PropertyDefault {
            get {
                return ResourceManager.GetString("PropertyDefault", resourceCulture);
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
        ///   Looks up a localized string similar to public void Dispose()
        ///        {
        ///            Dispose(true);
        ///            GC.SuppressFinalize(this);
        ///        }.
        /// </summary>
        internal static string PublicDispose {
            get {
                return ResourceManager.GetString("PublicDispose", resourceCulture);
            }
        }
    }
}
