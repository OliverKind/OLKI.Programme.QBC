﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OLKI.Programme.QuBC.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.1.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public bool ListItems_ShowSystem {
            get {
                return ((bool)(this["ListItems_ShowSystem"]));
            }
            set {
                this["ListItems_ShowSystem"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public bool ListItems_ShowWithoutAccess {
            get {
                return ((bool)(this["ListItems_ShowWithoutAccess"]));
            }
            set {
                this["ListItems_ShowWithoutAccess"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("qubc")]
        public string ProjectFile_DefaultExtension {
            get {
                return ((string)(this["ProjectFile_DefaultExtension"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Sicherungsvorlage (*.qubc)|*.qubc|Sicherungsvorlage (*.qbc)|*.qbc|Sicherungsvorla" +
            "ge (*.xml)|*.xml|Alle Dateien (*.*)|*.*")]
        public string ProjectFile_FilterList {
            get {
                return ((string)(this["ProjectFile_FilterList"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int ProjectFile_FilterIndex {
            get {
                return ((int)(this["ProjectFile_FilterIndex"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public string ProjectFile_DefaultPath {
            get {
                return ((string)(this["ProjectFile_DefaultPath"]));
            }
            set {
                this["ProjectFile_DefaultPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("yyyy-MM-dd__HH-mm-ss")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public string _UNUSED_Logfile_DateFormat {
            get {
                return ((string)(this["_UNUSED_Logfile_DateFormat"]));
            }
            set {
                this["_UNUSED_Logfile_DateFormat"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Logdatei (*.log)|*.log|Textdatei (*.txt)|*.txt|Alle Dateien (*.*)|*.*")]
        public string _UNUSED_Logfile_FilterList {
            get {
                return ((string)(this["_UNUSED_Logfile_FilterList"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int _UNUSED_Logfile_FilterIndex {
            get {
                return ((int)(this["_UNUSED_Logfile_FilterIndex"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public string Startup_DefaultFileOpen {
            get {
                return ((string)(this["Startup_DefaultFileOpen"]));
            }
            set {
                this["Startup_DefaultFileOpen"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public bool ListItems_ExpandTreeNodeOnSingleClick {
            get {
                return ((bool)(this["ListItems_ExpandTreeNodeOnSingleClick"]));
            }
            set {
                this["ListItems_ExpandTreeNodeOnSingleClick"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("QuBC.Project")]
        public string FileAssociation_ExtensionFile {
            get {
                return ((string)(this["FileAssociation_ExtensionFile"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("QuBC Project")]
        public string FileAssociation_ExtensionDescription {
            get {
                return ((string)(this["FileAssociation_ExtensionDescription"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Project_Symbol.ico")]
        public string FileAssociation_ExtensionIconFile {
            get {
                return ((string)(this["FileAssociation_ExtensionIconFile"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public bool FileAssociation_CheckOnStartup {
            get {
                return ((bool)(this["FileAssociation_CheckOnStartup"]));
            }
            set {
                this["FileAssociation_CheckOnStartup"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public string RecentFiles_FileList {
            get {
                return ((string)(this["RecentFiles_FileList"]));
            }
            set {
                this["RecentFiles_FileList"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("4")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public int RecentFiles_MaxLength {
            get {
                return ((int)(this["RecentFiles_MaxLength"]));
            }
            set {
                this["RecentFiles_MaxLength"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("|")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public string RecentFiles_Seperator {
            get {
                return ((string)(this["RecentFiles_Seperator"]));
            }
            set {
                this["RecentFiles_Seperator"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public bool Internal_SettingsUpgradet {
            get {
                return ((bool)(this["Internal_SettingsUpgradet"]));
            }
            set {
                this["Internal_SettingsUpgradet"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool Internal_CheckAdminRights {
            get {
                return ((bool)(this["Internal_CheckAdminRights"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1;2")]
        public string ProjectFile_VersionCompatibleNative {
            get {
                return ((string)(this["ProjectFile_VersionCompatibleNative"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ProjectFile_VersionCompatibleConvert {
            get {
                return ((string)(this["ProjectFile_VersionCompatibleConvert"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public bool Copy_DirectoryAttributes {
            get {
                return ((bool)(this["Copy_DirectoryAttributes"]));
            }
            set {
                this["Copy_DirectoryAttributes"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public bool Copy_FileAttributes {
            get {
                return ((bool)(this["Copy_FileAttributes"]));
            }
            set {
                this["Copy_FileAttributes"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("yyyyMMddHHmmss")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public string Copy_FileExisitngAddTextDateFormat {
            get {
                return ((string)(this["Copy_FileExisitngAddTextDateFormat"]));
            }
            set {
                this["Copy_FileExisitngAddTextDateFormat"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("__{{$LastWriteTime}}")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public string Copy_FileExisitngAddTextDefault {
            get {
                return ((string)(this["Copy_FileExisitngAddTextDefault"]));
            }
            set {
                this["Copy_FileExisitngAddTextDefault"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public bool ListItems_ShowHidden {
            get {
                return ((bool)(this["ListItems_ShowHidden"]));
            }
            set {
                this["ListItems_ShowHidden"] = value;
            }
        }
    }
}
