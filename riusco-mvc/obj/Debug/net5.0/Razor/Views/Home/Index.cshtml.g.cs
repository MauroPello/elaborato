#pragma checksum "/home/pello/OneDrive/Projects/C#/riusco/riusco-mvc/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b928cca5fec9d1aef5e8ca2cb2b86fcbdafa9e1a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b928cca5fec9d1aef5e8ca2cb2b86fcbdafa9e1a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"839f65472df25f9da46477c881265826530ef94e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GenericUserViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("login-container"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("register-container"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: none;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/home/pello/OneDrive/Projects/C#/riusco/riusco-mvc/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Rius.Co.";
    Layout = "NotLoggedLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b928cca5fec9d1aef5e8ca2cb2b86fcbdafa9e1a7151", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("base", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b928cca5fec9d1aef5e8ca2cb2b86fcbdafa9e1a7409", async() => {
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
            WriteLiteral("\n\n");
#nullable restore
#line 11 "/home/pello/OneDrive/Projects/C#/riusco/riusco-mvc/Views/Home/Index.cshtml"
 if (Model.Outcome == "error")
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""alert alert-danger alert-dismissible"" style=""z-index: 10000; margin-top: 1%; margin-left: 10%; margin-right: 10%;"">
        <a href=""#"" class=""close"" data-dismiss=""alert"" aria-label=""close"">&times;</a>
        Wrong Credentials!
    </div>
");
#nullable restore
#line 17 "/home/pello/OneDrive/Projects/C#/riusco/riusco-mvc/Views/Home/Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Logo Rius.co. e Green Coin</h1>
<div style=""padding: 5vh 5vw;"">
    <h4>
    Lorem ipsum dolor sit amet, consectetur adipiscing elit. In nec ipsum ullamcorper, euismod ante id, aliquam metus. Maecenas facilisis enim eu ligula euismod accumsan. Quisque et aliquet lorem, quis egestas ante. Phasellus scelerisque felis non diam vehicula, et scelerisque justo congue. 
    </h4>
</div>
<div style=""padding: 5vh 0; background-color: lightgrey"">
    <div style=""margin: auto; background-color: black; width: 70%; height: 67vh;""><span style=""margin: auto; color: white;"">Video</span></div>
</div>
<div style=""padding: 5vh 5vw;"">
<h4>
Morbi efficitur euismod tortor, vitae ultricies urna auctor non. Phasellus condimentum eu eros vel tristique. Sed id nulla vitae erat venenatis molestie. Aenean urna urna, mattis volutpat pharetra eget, aliquet ac libero. Praesent commodo mi et aliquam pulvinar. Nullam semper lectus vel ex porttitor, sed pulvinar arcu volutpat. Vestibulum libero leo, lacinia non velit ut, aliquam malesuad");
            WriteLiteral(@"a urna. Donec tempus fermentum purus quis finibus. In porttitor neque nisl, at aliquam ante aliquam et. Sed varius mi est, non ultrices nunc lobortis id. Duis semper odio felis, quis mattis ante pellentesque at. In id nulla nisi. 
</h4>
</div>
<div style=""padding: 5vh 0; background-color: lightgrey;"">
<div style=""display: flex; justify-content: center; width: 100%;"">
    <button class=""btn btn-primary"" onclick=""enableRegister();"" style=""margin-right: 1vw;"" >Login</button>
    <button class=""btn btn-primary"" onclick=""enableLogin();"" >Register</button>
</div>
<div style=""display: flex; justify-content: center; width: 100%;"">
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b928cca5fec9d1aef5e8ca2cb2b86fcbdafa9e1a11557", async() => {
                WriteLiteral("\n        <div class=\"omrs-input-group\">\n            <label class=\"omrs-input-underlined\">\n                <input type=\"email\" name=\"email\"");
                BeginWriteAttribute("value", " value=\"", 2324, "\"", 2344, 1);
#nullable restore
#line 42 "/home/pello/OneDrive/Projects/C#/riusco/riusco-mvc/Views/Home/Index.cshtml"
WriteAttributeValue("", 2332, Model.Email, 2332, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" placeholder="" "" required>
                <span class=""omrs-input-label"">Email</span>
                <span class=""omrs-input-helper"">Enter email</span>
            </label>
        </div>
        <div class=""omrs-input-group"">
            <label class=""omrs-input-underlined"">
                <input type=""password"" name=""password"" pattern="".{8,24}"" data-toggle=""password"" placeholder="" "" required>
                <span class=""omrs-input-label"">Password</span>
                <span class=""omrs-input-helper"">Enter password (8-24 chars)</span>
                <svg xmlns=""http://www.w3.org/2000/svg"" class=""password-toggle"" width=""24"" height=""24"" viewBox=""0 0 24 24"">
                    <path fill=""true""
                          d=""M 12.00,3.82
                                                                                                          C 6.55,3.82 1.89,7.21 0.00,12.00
                                                                                                            1.89,16.79 6.55,20.18 12.0");
                WriteLiteral(@"0,20.18
                                                                                                            17.46,20.18 22.11,16.79 24.00,12.00
                                                                                                            22.11,7.21 17.46,3.82 12.00,3.82 Z
                                                                                                          M 12.00,17.45
                                                                                                          C 8.99,17.45 6.55,15.01 6.55,12.00
                                                                                                            6.55,8.99 8.99,6.55 12.00,6.55
                                                                                                            15.01,6.55 17.45,8.99 17.45,12.00
                                                                                                            17.45,15.01 15.01,17.45 12.00,17.45 Z
                                         ");
                WriteLiteral(@"                                                                 M 12.00,8.73
                                                                                                          C 10.19,8.73 8.73,10.19 8.73,12.00
                                                                                                            8.73,13.81 10.19,15.27 12.00,15.27
                                                                                                            13.81,15.27 15.27,13.81 15.27,12.00
                                                                                                            15.27,10.19 13.81,8.73 12.00,8.73 Z""/></svg>
            </label>
        </div>
        <div class=""form-group"" style=""text-align: center;"">
            <button type=""submit"" name=""button"" value=""login"" class=""btn btn-primary"">Submit</button>
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b928cca5fec9d1aef5e8ca2cb2b86fcbdafa9e1a16772", async() => {
                WriteLiteral("\n        <div class=\"omrs-input-group\">\n            <label class=\"omrs-input-underlined\">\n                <input type=\"email\" name=\"email\"");
                BeginWriteAttribute("value", " value=\"", 5541, "\"", 5561, 1);
#nullable restore
#line 78 "/home/pello/OneDrive/Projects/C#/riusco/riusco-mvc/Views/Home/Index.cshtml"
WriteAttributeValue("", 5549, Model.Email, 5549, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" placeholder="" "" required>
                <span class=""omrs-input-label"">Email</span>
                <span class=""omrs-input-helper"">Enter email</span>
            </label>
        </div>
        <div class=""omrs-input-group"">
            <label class=""omrs-input-underlined"">
                <input type=""text"" name=""name"" placeholder="" "" required>
                <span class=""omrs-input-label"">Name</span>
                <span class=""omrs-input-helper"">Enter name</span>
            </label>
        </div>
        <div class=""omrs-input-group"">
            <label class=""omrs-input-underlined"">
                <input type=""password"" name=""password"" pattern="".{8,24}"" data-toggle=""password"" placeholder="" "" required>
                <span class=""omrs-input-label"">Password</span>
                <span class=""omrs-input-helper"">Enter password (8-24 chars)</span>
                <svg xmlns=""http://www.w3.org/2000/svg"" class=""password-toggle"" width=""24"" height=""24"" viewBox=""0 0 24 24"">
                    <path fill");
                WriteLiteral(@"=""true""
                          d=""M 12.00,3.82
                                                                                                          C 6.55,3.82 1.89,7.21 0.00,12.00
                                                                                                            1.89,16.79 6.55,20.18 12.00,20.18
                                                                                                            17.46,20.18 22.11,16.79 24.00,12.00
                                                                                                            22.11,7.21 17.46,3.82 12.00,3.82 Z
                                                                                                          M 12.00,17.45
                                                                                                          C 8.99,17.45 6.55,15.01 6.55,12.00
                                                                                                            6.55,8.99 8.99,6.55 12.00,6.55
      ");
                WriteLiteral(@"                                                                                                      15.01,6.55 17.45,8.99 17.45,12.00
                                                                                                            17.45,15.01 15.01,17.45 12.00,17.45 Z
                                                                                                          M 12.00,8.73
                                                                                                          C 10.19,8.73 8.73,10.19 8.73,12.00
                                                                                                            8.73,13.81 10.19,15.27 12.00,15.27
                                                                                                            13.81,15.27 15.27,13.81 15.27,12.00
                                                                                                            15.27,10.19 13.81,8.73 12.00,8.73 Z""/></svg>
            </label>
        </div>
      ");
                WriteLiteral(@"  <div class=""omrs-input-group"">
            <label class=""omrs-input-underlined"">
                <input type=""text"" name=""city"" placeholder="" "" required>
                <span class=""omrs-input-label"">City</span>
                <span class=""omrs-input-helper"">Enter city</span>
            </label>
        </div>
        <div style=""margin-bottom: 1.5rem;"">
            <h5 style=""color: grey"">Image</h5>
            <div class=""image-upload-wrap"">
                <input class=""file-upload-input"" type='file' name=""image"" onchange=""readURL(this);"" accept=""image/*""/>
                <div class=""drag-text"">
                    <h3>Drag and drop a file or select add Image</h3>
                </div>
            </div>
            <div class=""file-upload-content"">
                <img class=""file-upload-image"" src=""#"" alt=""your image""/>
                <div class=""image-title-wrap"">
                    <button type=""button"" onclick=""removeUpload()"" class=""btn btn-danger"">Remove <span class=""image-title""> Image</sp");
                WriteLiteral("an></button>\n                </div>\n            </div>\n        </div>\n        <div class=\"form-group\" style=\"text-align: center;\">\n            <button type=\"submit\" name=\"button\" value=\"register\" class=\"btn btn-primary\">Submit</button>\n        </div>\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n</div>\n\n<div style=\"padding: 5vh 5vw;\">\n<h2 class=\"text-center\" style=\"font-weight: 500;\">These are the currently available products!</h2>\n");
#nullable restore
#line 145 "/home/pello/OneDrive/Projects/C#/riusco/riusco-mvc/Views/Home/Index.cshtml"
Write(await Html.RenderComponentAsync<riusco_mvc.Components.ProductOverview>(RenderMode.ServerPrerendered, new { userId = 0 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n\n<script src=\"_framework/blazor.server.js\"></script>\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $('.custom-file-input').on(""change"", function () {
                var fileName = $(this).val().split(""\\"").pop();
                $(this).next('.custom-file-label').html(fileName);
            });
        });
        
        function enableLogin() {
           document.getElementById(""login-container"").style.display = ""none"";
           document.getElementById(""register-container"").style.display = ""block"";
        }
        
        function enableRegister() {
           document.getElementById(""login-container"").style.display = ""block"";
           document.getElementById(""register-container"").style.display = ""none"";
        }
    </script>
");
            }
            );
            WriteLiteral("\n<style>\n    .container {\n        margin: 0!important;\n        padding: 0!important;\n        width: 100%!important;\n        max-width: 100%!important;\n    }\n</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GenericUserViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591