﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Marketplace.Exceptions {
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
    public class ResourceErrorMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ResourceErrorMessages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Marketplace.Exceptions.ResourceErrorMessages", typeof(ResourceErrorMessages).Assembly);
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
        ///   Looks up a localized string similar to The CPF is invalid, must be at the format XXXXXXXXX.
        /// </summary>
        public static string CPF_INVALIDO {
            get {
                return ResourceManager.GetString("CPF_INVALIDO", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The email is already registred..
        /// </summary>
        public static string EMAIL_REPETIDO {
            get {
                return ResourceManager.GetString("EMAIL_REPETIDO", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The email is invalid..
        /// </summary>
        public static string EMAIL_USER_INVALIDO {
            get {
                return ResourceManager.GetString("EMAIL_USER_INVALIDO", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The user&apos;s email is required..
        /// </summary>
        public static string EMAIL_USER_VAZIO {
            get {
                return ResourceManager.GetString("EMAIL_USER_VAZIO", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown error..
        /// </summary>
        public static string ERRO_DESCONHECIDO {
            get {
                return ResourceManager.GetString("ERRO_DESCONHECIDO", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The user&apos;s email and/or password is invalid..
        /// </summary>
        public static string LOGIN_INVALIDO {
            get {
                return ResourceManager.GetString("LOGIN_INVALIDO", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The name is required..
        /// </summary>
        public static string NOME_VAZIO {
            get {
                return ResourceManager.GetString("NOME_VAZIO", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The actual password is incorrect..
        /// </summary>
        public static string SENHA_ATUAL_INVALIDA {
            get {
                return ResourceManager.GetString("SENHA_ATUAL_INVALIDA", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The password must have at least 6 characters.
        /// </summary>
        public static string SENHA_USER_INVALIDO {
            get {
                return ResourceManager.GetString("SENHA_USER_INVALIDO", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The user&apos;s password is required..
        /// </summary>
        public static string SENHA_USER_VAZIO {
            get {
                return ResourceManager.GetString("SENHA_USER_VAZIO", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The last name is required..
        /// </summary>
        public static string SOBRENOME_VAZIO {
            get {
                return ResourceManager.GetString("SOBRENOME VAZIO", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The phone must be at the format XX X XXXX-XXXX.
        /// </summary>
        public static string TELEFONE_USER_INVALIDO {
            get {
                return ResourceManager.GetString("TELEFONE_USER_INVALIDO", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The user&apos;s phone is required..
        /// </summary>
        public static string TELEFONE_USER_VAZIO {
            get {
                return ResourceManager.GetString("TELEFONE_USER_VAZIO", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Login again on the App..
        /// </summary>
        public static string TOKEN_EXPIRADO {
            get {
                return ResourceManager.GetString("TOKEN_EXPIRADO", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You are not allowed to access this feature..
        /// </summary>
        public static string USUARIO_SEM_PERMISSAO {
            get {
                return ResourceManager.GetString("USUARIO_SEM_PERMISSAO", resourceCulture);
            }
        }
    }
}
