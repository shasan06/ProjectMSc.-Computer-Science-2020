#pragma checksum "C:\Users\sabrina\Desktop\ProjectSetup\ProjectMSc.-Computer-Science-2020\Metrics\Metrics\Views\Test\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3534a9c80ca23b33e905b9aeae5a4f33f6b030b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Test_Index), @"mvc.1.0.view", @"/Views/Test/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3534a9c80ca23b33e905b9aeae5a4f33f6b030b0", @"/Views/Test/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e52f247c216964ab9f807c7ca9489571ec285941", @"/Views/_ViewImports.cshtml")]
    public class Views_Test_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Test>>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\sabrina\Desktop\ProjectSetup\ProjectMSc.-Computer-Science-2020\Metrics\Metrics\Views\Test\Index.cshtml"
  
    ViewData["Title"] = "Test";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\sabrina\Desktop\ProjectSetup\ProjectMSc.-Computer-Science-2020\Metrics\Metrics\Views\Test\Index.cshtml"
 if (!Model.Any())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>There are no tests associated with the user</p>\r\n");
#nullable restore
#line 10 "C:\Users\sabrina\Desktop\ProjectSetup\ProjectMSc.-Computer-Science-2020\Metrics\Metrics\Views\Test\Index.cshtml"
                                                

}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\sabrina\Desktop\ProjectSetup\ProjectMSc.-Computer-Science-2020\Metrics\Metrics\Views\Test\Index.cshtml"
     foreach (var test in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>This is the test ID for this test: ");
#nullable restore
#line 17 "C:\Users\sabrina\Desktop\ProjectSetup\ProjectMSc.-Computer-Science-2020\Metrics\Metrics\Views\Test\Index.cshtml"
                                         Write(test.Testid);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3534a9c80ca23b33e905b9aeae5a4f33f6b030b04651", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 354, "~/images/image/", 354, 15, true);
#nullable restore
#line 19 "C:\Users\sabrina\Desktop\ProjectSetup\ProjectMSc.-Computer-Science-2020\Metrics\Metrics\Views\Test\Index.cshtml"
AddHtmlAttributeValue("", 369, test.ImageName, 369, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 20 "C:\Users\sabrina\Desktop\ProjectSetup\ProjectMSc.-Computer-Science-2020\Metrics\Metrics\Views\Test\Index.cshtml"
        int k = 4;
        for (int i= 0; i < k; i++)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\sabrina\Desktop\ProjectSetup\ProjectMSc.-Computer-Science-2020\Metrics\Metrics\Views\Test\Index.cshtml"
       Write(Html.DisplayFor(modelitem => test.TestsQ[0]));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\sabrina\Desktop\ProjectSetup\ProjectMSc.-Computer-Science-2020\Metrics\Metrics\Views\Test\Index.cshtml"
                                                         
        }

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\sabrina\Desktop\ProjectSetup\ProjectMSc.-Computer-Science-2020\Metrics\Metrics\Views\Test\Index.cshtml"
     
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Test>> Html { get; private set; }
    }
}
#pragma warning restore 1591
