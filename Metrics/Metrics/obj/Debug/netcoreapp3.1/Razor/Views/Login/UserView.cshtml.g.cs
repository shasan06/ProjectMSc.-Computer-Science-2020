#pragma checksum "C:\Users\sabrina\Desktop\ProjectSetup\ProjectMSc.-Computer-Science-2020\Metrics\Metrics\Views\Login\UserView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "726970c3b4448e359f38fc08daf33875a02f39c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_UserView), @"mvc.1.0.view", @"/Views/Login/UserView.cshtml")]
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
#nullable restore
#line 1 "C:\Users\sabrina\Desktop\ProjectSetup\ProjectMSc.-Computer-Science-2020\Metrics\Metrics\Views\_ViewImports.cshtml"
using Metrics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sabrina\Desktop\ProjectSetup\ProjectMSc.-Computer-Science-2020\Metrics\Metrics\Views\_ViewImports.cshtml"
using Metrics.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"726970c3b4448e359f38fc08daf33875a02f39c8", @"/Views/Login/UserView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e52f247c216964ab9f807c7ca9489571ec285941", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_UserView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Registration>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\sabrina\Desktop\ProjectSetup\ProjectMSc.-Computer-Science-2020\Metrics\Metrics\Views\Login\UserView.cshtml"
  
    ViewData["Title"] = "UserView";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Welcome</h1>\r\n\r\n<ul>\r\n    ");
#nullable restore
#line 10 "C:\Users\sabrina\Desktop\ProjectSetup\ProjectMSc.-Computer-Science-2020\Metrics\Metrics\Views\Login\UserView.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</ul>\r\n\r\n<div class=\"form-row\">\r\n    <div class=\"form-group col-md-6\">\r\n");
            WriteLiteral("        <a class=\"btn btn-primary btn-block\"");
            BeginWriteAttribute("href", " href=\"", 345, "\"", 426, 1);
#nullable restore
#line 16 "C:\Users\sabrina\Desktop\ProjectSetup\ProjectMSc.-Computer-Science-2020\Metrics\Metrics\Views\Login\UserView.cshtml"
WriteAttributeValue("", 352, Url.Action("Index","Test", new { registrationId = Model.RegistrationId }), 352, 74, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\">Start 1</a>\r\n        \r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Registration> Html { get; private set; }
    }
}
#pragma warning restore 1591