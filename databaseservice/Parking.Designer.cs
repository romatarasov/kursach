﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace databaseservice {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.6.0.0")]
    public sealed partial class Parking : global::System.Configuration.ApplicationSettingsBase {
        
        private static Parking defaultInstance = ((Parking)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Parking())));
        
        public static Parking Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=.\\SQLEXPRESS;Initial Catalog=parking;Integrated Security=True")]
        public string Connection {
            get {
                return ((string)(this["Connection"]));
            }
            set {
                this["Connection"] = value;
            }
        }
    }
}
