﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PrismAuth.Resources {
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
    public class StringResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal StringResource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("PrismAuth.Resources.StringResource", typeof(StringResource).Assembly);
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
        ///   Looks up a localized string similar to You are already logged in..
        /// </summary>
        public static string AlreadyLogined {
            get {
                return ResourceManager.GetString("AlreadyLogined", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You are already registered..
        /// </summary>
        public static string AlreadyRegistered {
            get {
                return ResourceManager.GetString("AlreadyRegistered", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to successfully logged in..
        /// </summary>
        public static string CompletedLogin {
            get {
                return ResourceManager.GetString("CompletedLogin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Successfully registered..
        /// </summary>
        public static string CompletedRegister {
            get {
                return ResourceManager.GetString("CompletedRegister", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You are not logged in. please login first..
        /// </summary>
        public static string DoNotLogined {
            get {
                return ResourceManager.GetString("DoNotLogined", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You are not registered. please register first..
        /// </summary>
        public static string DoNotRegistered {
            get {
                return ResourceManager.GetString("DoNotRegistered", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to register..
        /// </summary>
        public static string FaildRegister {
            get {
                return ResourceManager.GetString("FaildRegister", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to hint: /login [password].
        /// </summary>
        public static string LoginHint {
            get {
                return ResourceManager.GetString("LoginHint", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Password not incorrect!.
        /// </summary>
        public static string NotIncorrectPasswd {
            get {
                return ResourceManager.GetString("NotIncorrectPasswd", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to hint: /register [password].
        /// </summary>
        public static string RegisterHint {
            get {
                return ResourceManager.GetString("RegisterHint", resourceCulture);
            }
        }
    }
}
