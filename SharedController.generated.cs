// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;
namespace T4MVC {
    public class SharedController {

        static readonly ViewNames s_views = new ViewNames();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewNames Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewNames {
            static readonly _Layouts s_Layouts = new _Layouts();
            public _Layouts Layouts { get { return s_Layouts; } }
            public partial class _Layouts{
                public readonly string _Layout = "~/Views/Shared/Layouts/_Layout.cshtml";
                public readonly string BlogLayout = "~/Views/Shared/Layouts/BlogLayout.cshtml";
            }
            static readonly _Partials s_Partials = new _Partials();
            public _Partials Partials { get { return s_Partials; } }
            public partial class _Partials{
                public readonly string Navigation = "~/Views/Shared/Partials/Navigation.cshtml";
                static readonly _Blog s_Blog = new _Blog();
                public _Blog Blog { get { return s_Blog; } }
                public partial class _Blog{
                    public readonly string Comment = "~/Views/Shared/Partials/Blog/Comment.cshtml";
                    public readonly string Post = "~/Views/Shared/Partials/Blog/Post.cshtml";
                }
            }
        }
    }

}

#endregion T4MVC
#pragma warning restore 1591
