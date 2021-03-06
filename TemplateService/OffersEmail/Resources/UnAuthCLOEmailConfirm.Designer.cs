//
// Copyright (c) Microsoft Corporation. All rights reserved. 
// Licensed under the MIT license. See LICENSE.txt file in the project root for full license information.
//

// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

namespace OffersEmail.Resources {
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
    public class UnAuthCLOEmailConfirm {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal UnAuthCLOEmailConfirm() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("OffersEmail.Resources.UnAuthCLOEmailConfirm", typeof(UnAuthCLOEmailConfirm).Assembly);
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
        ///   Looks up a localized string similar to Hello,
        ///
        ///Please click the link below to confirm your email address with Bing Offers. {0}                                                                                                               *************************************************************************************************************************                                    NOTE: If this is not you and you think you have received this email in error, please contact Bing Offers support at : http://bingoffers.uservoice.com/forum [rest of string was truncated]&quot;;.
        /// </summary>
        public static string ConfirmEmailTextContent {
            get {
                return ResourceManager.GetString("ConfirmEmailTextContent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Confirm your email address.
        /// </summary>
        public static string EmailConfirmLine1 {
            get {
                return ResourceManager.GetString("EmailConfirmLine1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please click the link below to confirm your email address with Bing Offers. .
        /// </summary>
        public static string EmailConfirmLine2 {
            get {
                return ResourceManager.GetString("EmailConfirmLine2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Confirm email.
        /// </summary>
        public static string EmailConfirmLine3 {
            get {
                return ResourceManager.GetString("EmailConfirmLine3", resourceCulture);
            }
        }
    }
}