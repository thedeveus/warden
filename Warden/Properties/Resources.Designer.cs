﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Warden.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Warden.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Could not find process id for {0}.
        /// </summary>
        internal static string Exception_Could_Not_Find_Process_Id {
            get {
                return ResourceManager.GetString("Exception_Could_Not_Find_Process_Id", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error while trying to launch your app: {0}.
        /// </summary>
        internal static string Exception_Error_Trying_To_Launch_App {
            get {
                return ResourceManager.GetString("Exception_Error_Trying_To_Launch_App", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid Process Type.
        /// </summary>
        internal static string Exception_Invalid_Process_Type {
            get {
                return ResourceManager.GetString("Exception_Invalid_Process_Type", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to initialize due to a lack of administrator privileges..
        /// </summary>
        internal static string Exception_No_Admin {
            get {
                return ResourceManager.GetString("Exception_No_Admin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No WardenOptions were set..
        /// </summary>
        internal static string Exception_No_Options {
            get {
                return ResourceManager.GetString("Exception_No_Options", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Warden is not initialized..
        /// </summary>
        internal static string Exception_Not_Initialized {
            get {
                return ResourceManager.GetString("Exception_Not_Initialized", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Process could not be launched: {0}.
        /// </summary>
        internal static string Exception_Process_Not_Launched {
            get {
                return ResourceManager.GetString("Exception_Process_Not_Launched", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Process could not be launched for unknown reasons.
        /// </summary>
        internal static string Exception_Process_Not_Launched_Unknown {
            get {
                return ResourceManager.GetString("Exception_Process_Not_Launched_Unknown", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Process could not start. FileName ({0}) Arguments ({1}).
        /// </summary>
        internal static string Exception_Process_Not_Start {
            get {
                return ResourceManager.GetString("Exception_Process_Not_Start", resourceCulture);
            }
        }
    }
}
