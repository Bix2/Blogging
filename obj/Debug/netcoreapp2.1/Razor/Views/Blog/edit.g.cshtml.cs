#pragma checksum "/Users/Bibi/Sites/Blogging/Views/Blog/edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8dc13836c92f3c08e209964292b0903b73ebccc3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_edit), @"mvc.1.0.view", @"/Views/Blog/edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blog/edit.cshtml", typeof(AspNetCore.Views_Blog_edit))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/Bibi/Sites/Blogging/Views/_ViewImports.cshtml"
using Blogging;

#line default
#line hidden
#line 2 "/Users/Bibi/Sites/Blogging/Views/_ViewImports.cshtml"
using Blogging.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dc13836c92f3c08e209964292b0903b73ebccc3", @"/Views/Blog/edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3ec54e0fe361e6e94184b822de2b59336071011", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Blogging.Models.Post>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/Users/Bibi/Sites/Blogging/Views/Blog/edit.cshtml"
  
    ViewBag.Title = "Edit";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(107, 16, true);
            WriteLiteral("\n<h2>Edit</h2>\n\n");
            EndContext();
#line 9 "/Users/Bibi/Sites/Blogging/Views/Blog/edit.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(156, 23, false);
#line 11 "/Users/Bibi/Sites/Blogging/Views/Blog/edit.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(180, 37, true);
            WriteLiteral("        <h4>Post</h4>\n        <hr />\n");
            EndContext();
            BeginContext(226, 64, false);
#line 14 "/Users/Bibi/Sites/Blogging/Views/Blog/edit.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(300, 37, false);
#line 15 "/Users/Bibi/Sites/Blogging/Views/Blog/edit.cshtml"
   Write(Html.HiddenFor(model => model.PostId));

#line default
#line hidden
            EndContext();
            BeginContext(339, 45, true);
            WriteLiteral("        <div class=\"form-group\">\n            ");
            EndContext();
            BeginContext(385, 35, false);
#line 18 "/Users/Bibi/Sites/Blogging/Views/Blog/edit.cshtml"
       Write(Html.LabelFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(420, 17, true);
            WriteLiteral("\n                ");
            EndContext();
            BeginContext(438, 94, false);
#line 19 "/Users/Bibi/Sites/Blogging/Views/Blog/edit.cshtml"
           Write(Html.EditorFor(model => model.Title, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(532, 17, true);
            WriteLiteral("\n                ");
            EndContext();
            BeginContext(550, 83, false);
#line 20 "/Users/Bibi/Sites/Blogging/Views/Blog/edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.Title, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(633, 16, true);
            WriteLiteral("\n        </div>\n");
            EndContext();
            BeginContext(650, 45, true);
            WriteLiteral("        <div class=\"form-group\">\n            ");
            EndContext();
            BeginContext(696, 37, false);
#line 24 "/Users/Bibi/Sites/Blogging/Views/Blog/edit.cshtml"
       Write(Html.LabelFor(model => model.Content));

#line default
#line hidden
            EndContext();
            BeginContext(733, 13, true);
            WriteLiteral("\n            ");
            EndContext();
            BeginContext(747, 114, false);
#line 25 "/Users/Bibi/Sites/Blogging/Views/Blog/edit.cshtml"
       Write(Html.TextAreaFor(model => model.Content, new { @class="form-control", @rows = 5, @placeholder = "model.Content" }));

#line default
#line hidden
            EndContext();
            BeginContext(861, 15, true);
            WriteLiteral(" \n\n            ");
            EndContext();
            BeginContext(877, 85, false);
#line 27 "/Users/Bibi/Sites/Blogging/Views/Blog/edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.Content, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(962, 16, true);
            WriteLiteral("\n        </div>\n");
            EndContext();
            BeginContext(979, 121, true);
            WriteLiteral("        <div class=\"form-group\">\n            <input type=\"submit\" value=\"Save\" class=\"btn btn-success\" />\n        </div>\n");
            EndContext();
#line 33 "/Users/Bibi/Sites/Blogging/Views/Blog/edit.cshtml"
}

#line default
#line hidden
            BeginContext(1102, 11, true);
            WriteLiteral("\n<div>\n    ");
            EndContext();
            BeginContext(1114, 40, false);
#line 36 "/Users/Bibi/Sites/Blogging/Views/Blog/edit.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(1154, 7, true);
            WriteLiteral("\n</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Blogging.Models.Post> Html { get; private set; }
    }
}
#pragma warning restore 1591
