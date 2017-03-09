﻿//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     런타임 버전:4.0.30319.42000
//
//     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
//     이러한 변경 내용이 손실됩니다.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PrismAuth.Resources {
    using System;
    
    
    /// <summary>
    ///   지역화된 문자열 등을 찾기 위한 강력한 형식의 리소스 클래스입니다.
    /// </summary>
    // 이 클래스는 ResGen 또는 Visual Studio와 같은 도구를 통해 StronglyTypedResourceBuilder
    // 클래스에서 자동으로 생성되었습니다.
    // 멤버를 추가하거나 제거하려면 .ResX 파일을 편집한 다음 /str 옵션을 사용하여 ResGen을
    // 다시 실행하거나 VS 프로젝트를 다시 빌드하십시오.
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
        ///   이 클래스에서 사용하는 캐시된 ResourceManager 인스턴스를 반환합니다.
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
        ///   이 강력한 형식의 리소스 클래스를 사용하여 모든 리소스 조회에 대한 현재 스레드의 CurrentUICulture
        ///   속성을 재정의합니다.
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
        ///   You are already logged in.과(와) 유사한 지역화된 문자열을 찾습니다.
        /// </summary>
        public static string AlreadyLogined {
            get {
                return ResourceManager.GetString("AlreadyLogined", resourceCulture);
            }
        }
        
        /// <summary>
        ///   You are already registered.과(와) 유사한 지역화된 문자열을 찾습니다.
        /// </summary>
        public static string AlreadyRegistered {
            get {
                return ResourceManager.GetString("AlreadyRegistered", resourceCulture);
            }
        }
        
        /// <summary>
        ///   successfully logged in.과(와) 유사한 지역화된 문자열을 찾습니다.
        /// </summary>
        public static string CompletedLogin {
            get {
                return ResourceManager.GetString("CompletedLogin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Successfully registered.과(와) 유사한 지역화된 문자열을 찾습니다.
        /// </summary>
        public static string CompletedRegister {
            get {
                return ResourceManager.GetString("CompletedRegister", resourceCulture);
            }
        }
        
        /// <summary>
        ///   You are not logged in. please login first.과(와) 유사한 지역화된 문자열을 찾습니다.
        /// </summary>
        public static string DoNotLogined {
            get {
                return ResourceManager.GetString("DoNotLogined", resourceCulture);
            }
        }
        
        /// <summary>
        ///   You are not registered. please register first.과(와) 유사한 지역화된 문자열을 찾습니다.
        /// </summary>
        public static string DoNotRegistered {
            get {
                return ResourceManager.GetString("DoNotRegistered", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Failed to login.과(와) 유사한 지역화된 문자열을 찾습니다.
        /// </summary>
        public static string FaildLogin {
            get {
                return ResourceManager.GetString("FaildLogin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Failed to register.과(와) 유사한 지역화된 문자열을 찾습니다.
        /// </summary>
        public static string FaildRegister {
            get {
                return ResourceManager.GetString("FaildRegister", resourceCulture);
            }
        }
        
        /// <summary>
        ///   hint: /login [password]과(와) 유사한 지역화된 문자열을 찾습니다.
        /// </summary>
        public static string LoginHint {
            get {
                return ResourceManager.GetString("LoginHint", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Password not incorrect!과(와) 유사한 지역화된 문자열을 찾습니다.
        /// </summary>
        public static string NotIncorrectPasswd {
            get {
                return ResourceManager.GetString("NotIncorrectPasswd", resourceCulture);
            }
        }
        
        /// <summary>
        ///   hint: /reg [password]과(와) 유사한 지역화된 문자열을 찾습니다.
        /// </summary>
        public static string RegisterHint {
            get {
                return ResourceManager.GetString("RegisterHint", resourceCulture);
            }
        }
    }
}
