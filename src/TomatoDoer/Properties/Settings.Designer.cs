﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TomatoDoer.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string EvernoteUserEmail {
            get {
                return ((string)(this["EvernoteUserEmail"]));
            }
            set {
                this["EvernoteUserEmail"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Pomodoro")]
        public string EvernoteMailTag {
            get {
                return ((string)(this["EvernoteMailTag"]));
            }
            set {
                this["EvernoteMailTag"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Done")]
        public string EvernoteMailNotebook {
            get {
                return ((string)(this["EvernoteMailNotebook"]));
            }
            set {
                this["EvernoteMailNotebook"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("{0} tomato(es) — at {1}.")]
        public string EvernoteMailSubject {
            get {
                return ((string)(this["EvernoteMailSubject"]));
            }
            set {
                this["EvernoteMailSubject"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Win+Control+F12")]
        public string KeyboardShortcut_StartOrSquash {
            get {
                return ((string)(this["KeyboardShortcut_StartOrSquash"]));
            }
            set {
                this["KeyboardShortcut_StartOrSquash"] = value;
            }
        }
    }
}
