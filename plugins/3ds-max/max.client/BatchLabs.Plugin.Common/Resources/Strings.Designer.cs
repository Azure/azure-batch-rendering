﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BatchLabs.Plugin.Common.Resources {
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
    public class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("BatchLabs.Plugin.Common.Resources.Strings", typeof(Strings).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error caught while calling BatchLabs.
        /// </summary>
        public static string BatchLabs_RequestError {
            get {
                return ResourceManager.GetString("BatchLabs_RequestError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Calling out to data UI in BatchLabs.
        /// </summary>
        public static string ManageData_Log {
            get {
                return ResourceManager.GetString("ManageData_Log", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Calling out to jobs UI in BatchLabs.
        /// </summary>
        public static string MonitorJobs_Log {
            get {
                return ResourceManager.GetString("MonitorJobs_Log", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Calling out to pools UI in BatchLabs.
        /// </summary>
        public static string MonitorPools_Log {
            get {
                return ResourceManager.GetString("MonitorPools_Log", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to get assets from scene.
        /// </summary>
        public static string SubmitJob_Assets_Error {
            get {
                return ResourceManager.GetString("SubmitJob_Assets_Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error showing job submission form.
        /// </summary>
        public static string SubmitJob_Error {
            get {
                return ResourceManager.GetString("SubmitJob_Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Encountered an error getting 3ds max icon.
        /// </summary>
        public static string SubmitJob_Icon_Error {
            get {
                return ResourceManager.GetString("SubmitJob_Icon_Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Gathering up information about the job.
        /// </summary>
        public static string SubmitJob_Log {
            get {
                return ResourceManager.GetString("SubmitJob_Log", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to get missing assets from scene.
        /// </summary>
        public static string SubmitJob_MissingAssets_Error {
            get {
                return ResourceManager.GetString("SubmitJob_MissingAssets_Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Submit a Job to BatchLabs.
        /// </summary>
        public static string SubmitJob_Title {
            get {
                return ResourceManager.GetString("SubmitJob_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Uncaught exception occurred.
        /// </summary>
        public static string UncaughtException_Title {
            get {
                return ResourceManager.GetString("UncaughtException_Title", resourceCulture);
            }
        }
    }
}
