﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestAutomationWordPress.PageObjects {
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
    internal class MenuObjects {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal MenuObjects() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TestAutomationWordPress.PageObjects.MenuObjects", typeof(MenuObjects).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .//*[@id=&apos;menu-posts&apos;].
        /// </summary>
        internal static string Posts {
            get {
                return ResourceManager.GetString("Posts", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .//*[@id=&apos;menu-posts&apos;]//child::a[text()=&quot;Add New&quot;].
        /// </summary>
        internal static string Posts_AddNew {
            get {
                return ResourceManager.GetString("Posts_AddNew", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .//*[@id=&apos;menu-posts&apos;]//child::a[text()=&quot;All Posts&quot;].
        /// </summary>
        internal static string Posts_AllPost {
            get {
                return ResourceManager.GetString("Posts_AllPost", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .//*[@id=&apos;menu-posts&apos;]//child::a[text()=&quot;Categories&quot;].
        /// </summary>
        internal static string Posts_Categories {
            get {
                return ResourceManager.GetString("Posts_Categories", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .//*[@id=&apos;menu-posts&apos;]//child::a[text()=&quot;Tags&quot;].
        /// </summary>
        internal static string Posts_Tags {
            get {
                return ResourceManager.GetString("Posts_Tags", resourceCulture);
            }
        }
    }
}
