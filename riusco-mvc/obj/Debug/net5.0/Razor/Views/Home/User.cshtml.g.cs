#pragma checksum "/home/pello/OneDrive/Projects/C#/riusco/riusco-mvc/Views/Home/User.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8cac76af64404b57473b9596864501956ece762"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_User), @"mvc.1.0.view", @"/Views/Home/User.cshtml")]
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
#line 1 "/home/pello/OneDrive/Projects/C#/riusco/riusco-mvc/Views/_ViewImports.cshtml"
using riusco_mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/pello/OneDrive/Projects/C#/riusco/riusco-mvc/Views/_ViewImports.cshtml"
using riusco_mvc.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/pello/OneDrive/Projects/C#/riusco/riusco-mvc/Views/_ViewImports.cshtml"
using riusco_mvc.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/pello/OneDrive/Projects/C#/riusco/riusco-mvc/Views/_ViewImports.cshtml"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/pello/OneDrive/Projects/C#/riusco/riusco-mvc/Views/_ViewImports.cshtml"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/pello/OneDrive/Projects/C#/riusco/riusco-mvc/Views/_ViewImports.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/pello/OneDrive/Projects/C#/riusco/riusco-mvc/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/pello/OneDrive/Projects/C#/riusco/riusco-mvc/Views/_ViewImports.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8cac76af64404b57473b9596864501956ece762", @"/Views/Home/User.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"839f65472df25f9da46477c881265826530ef94e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_User : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/home/pello/OneDrive/Projects/C#/riusco/riusco-mvc/Views/Home/User.cshtml"
  
    ViewData["Title"] = Model.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8cac76af64404b57473b9596864501956ece7624760", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("base", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d8cac76af64404b57473b9596864501956ece7625018", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n<div class=\"text-center\">\n    <img alt=\"profile_pic\"");
            BeginWriteAttribute("src", " src=\"", 154, "\"", 186, 2);
            WriteAttributeValue("", 160, "/images/users/", 160, 14, true);
#nullable restore
#line 11 "/home/pello/OneDrive/Projects/C#/riusco/riusco-mvc/Views/Home/User.cshtml"
WriteAttributeValue("", 174, Model.Image, 174, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"border-radius: 50%; width: 25vh; height: 25vh;\"/>\n    <p class=\"display-4\" style=\"font-size: 6vh; font-weight: bold; margin-bottom: 5vh\">");
#nullable restore
#line 12 "/home/pello/OneDrive/Projects/C#/riusco/riusco-mvc/Views/Home/User.cshtml"
                                                                                  Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    <p class=\"display-4\" style=\"font-size: 3.5vh;\">Email: <a");
            BeginWriteAttribute("href", " href=\"", 408, "\"", 434, 2);
            WriteAttributeValue("", 415, "mailto:", 415, 7, true);
#nullable restore
#line 13 "/home/pello/OneDrive/Projects/C#/riusco/riusco-mvc/Views/Home/User.cshtml"
WriteAttributeValue("", 422, Model.Email, 422, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 13 "/home/pello/OneDrive/Projects/C#/riusco/riusco-mvc/Views/Home/User.cshtml"
                                                                                   Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\n    <p class=\"display-4\" style=\"font-size: 3.5vh;\">City: ");
#nullable restore
#line 14 "/home/pello/OneDrive/Projects/C#/riusco/riusco-mvc/Views/Home/User.cshtml"
                                                    Write(Model.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    <p class=\"display-4\" style=\"font-size: 4vh; margin-top: 5vh; font-weight: bold\">Products listed</p>\n    ");
#nullable restore
#line 16 "/home/pello/OneDrive/Projects/C#/riusco/riusco-mvc/Views/Home/User.cshtml"
Write(await Html.RenderComponentAsync<riusco_mvc.Components.ProductOverview>(RenderMode.ServerPrerendered, new { userId = Model.UserId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n\n<script src=\"_framework/blazor.server.js\"></script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IConfiguration Configuration { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
