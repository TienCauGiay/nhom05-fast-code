﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Nhom05_Core.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class ResourceVN {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ResourceVN() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Nhom05_Core.Resources.ResourceVN", typeof(ResourceVN).Assembly);
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
        ///   Looks up a localized string similar to Không tìm thấy tài nguyên.
        /// </summary>
        public static string Exception_NotFound_Default {
            get {
                return ResourceManager.GetString("Exception_NotFound_Default", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Lỗi hệ thống.
        /// </summary>
        public static string Exception_System_default {
            get {
                return ResourceManager.GetString("Exception_System_default", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Dữ liệu không hợp lệ, vui lòng kiểm tra lại.
        /// </summary>
        public static string Exception_Validate_Default {
            get {
                return ResourceManager.GetString("Exception_Validate_Default", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Lỗi nhập liệu từ người dùng.
        /// </summary>
        public static string Validate_User_Input_Error {
            get {
                return ResourceManager.GetString("Validate_User_Input_Error", resourceCulture);
            }
        }
    }
}
