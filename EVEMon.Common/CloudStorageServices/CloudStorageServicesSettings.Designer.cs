﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EVEMon.Common.CloudStorageServices {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    public sealed partial class CloudStorageServicesSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static CloudStorageServicesSettings defaultInstance = ((CloudStorageServicesSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new CloudStorageServicesSettings())));
        
        public static CloudStorageServicesSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public uint BCUserID {
            get {
                return ((uint)(this["BCUserID"]));
            }
            set {
                this["BCUserID"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string BCAPIKey {
            get {
                return ((string)(this["BCAPIKey"]));
            }
            set {
                this["BCAPIKey"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3C3490E986D448B1E5379147115E887E4E045554")]
        public string BCApplicationKey {
            get {
                return ((string)(this["BCApplicationKey"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UploadAlways {
            get {
                return ((bool)(this["UploadAlways"]));
            }
            set {
                this["UploadAlways"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool DownloadAlways {
            get {
                return ((bool)(this["DownloadAlways"]));
            }
            set {
                this["DownloadAlways"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UseImmediately {
            get {
                return ((bool)(this["UseImmediately"]));
            }
            set {
                this["UseImmediately"] = value;
            }
        }
    }
}