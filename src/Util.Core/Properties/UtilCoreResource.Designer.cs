﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Util.Properties {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class UtilCoreResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal UtilCoreResource() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Util.Properties.UtilCoreResource", typeof(UtilCoreResource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   重写当前线程的 CurrentUICulture 属性，对
        ///   使用此强类型资源类的所有资源查找执行重写。
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
        ///   查找类似 仅允许添加一个条件,条件：{0} 的本地化字符串。
        /// </summary>
        public static string CanOnlyOneCondition {
            get {
                return ResourceManager.GetString("CanOnlyOneCondition", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 当前操作的数据已被其他人修改，请刷新后重试 的本地化字符串。
        /// </summary>
        public static string ConcurrencyExceptionMessage {
            get {
                return ResourceManager.GetString("ConcurrencyExceptionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 天 的本地化字符串。
        /// </summary>
        public static string Days {
            get {
                return ResourceManager.GetString("Days", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 其他用户正在执行该操作,请稍后再试 的本地化字符串。
        /// </summary>
        public static string GlobalDuplicateRequest {
            get {
                return ResourceManager.GetString("GlobalDuplicateRequest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 小时 的本地化字符串。
        /// </summary>
        public static string Hours {
            get {
                return ResourceManager.GetString("Hours", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 标识不能为空 的本地化字符串。
        /// </summary>
        public static string IdIsEmpty {
            get {
                return ResourceManager.GetString("IdIsEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 毫秒 的本地化字符串。
        /// </summary>
        public static string Milliseconds {
            get {
                return ResourceManager.GetString("Milliseconds", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 分 的本地化字符串。
        /// </summary>
        public static string Minutes {
            get {
                return ResourceManager.GetString("Minutes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 秒 的本地化字符串。
        /// </summary>
        public static string Seconds {
            get {
                return ResourceManager.GetString("Seconds", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 类型 {0} 不是枚举 的本地化字符串。
        /// </summary>
        public static string TypeNotEnum {
            get {
                return ResourceManager.GetString("TypeNotEnum", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 请不要重复提交 的本地化字符串。
        /// </summary>
        public static string UserDuplicateRequest {
            get {
                return ResourceManager.GetString("UserDuplicateRequest", resourceCulture);
            }
        }
    }
}
