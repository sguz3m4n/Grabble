﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Grabble.Repository.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Grabble.Repository.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to dariot86_grabble.
        /// </summary>
        internal static string connDatabase {
            get {
                return ResourceManager.GetString("connDatabase", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Order;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False.
        /// </summary>
        internal static string connLocalMSSQLLocalDB {
            get {
                return ResourceManager.GetString("connLocalMSSQLLocalDB", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Data Source=(localdb)\ProjectsV13;Initial Catalog=Order;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False.
        /// </summary>
        internal static string connLocalProjectsV13 {
            get {
                return ResourceManager.GetString("connLocalProjectsV13", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UpdatedPassword1!.
        /// </summary>
        internal static string connPassword {
            get {
                return ResourceManager.GetString("connPassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 143.95.227.53.
        /// </summary>
        internal static string connServer {
            get {
                return ResourceManager.GetString("connServer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Data Source=grabble.database.windows.net;Initial Catalog=Order;User ID=gr4bbl3;Password=T34mK1tj12019;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False.
        /// </summary>
        internal static string connStage {
            get {
                return ResourceManager.GetString("connStage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to dariot86_grabusr.
        /// </summary>
        internal static string connUserId {
            get {
                return ResourceManager.GetString("connUserId", resourceCulture);
            }
        }
    }
}
