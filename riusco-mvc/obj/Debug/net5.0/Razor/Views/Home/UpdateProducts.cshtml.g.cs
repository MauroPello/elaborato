#pragma checksum "/home/pello/OneDrive/Projects/C#/riusco/riusco-mvc/Views/Home/UpdateProducts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f86a0b050efd80e44211404e136be7186a32da9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_UpdateProducts), @"mvc.1.0.view", @"/Views/Home/UpdateProducts.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f86a0b050efd80e44211404e136be7186a32da9", @"/Views/Home/UpdateProducts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"839f65472df25f9da46477c881265826530ef94e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_UpdateProducts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GenericProductViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/home/pello/OneDrive/Projects/C#/riusco/riusco-mvc/Views/Home/UpdateProducts.cshtml"
  
    ViewData["Title"] = "Update Products";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 6 "/home/pello/OneDrive/Projects/C#/riusco/riusco-mvc/Views/Home/UpdateProducts.cshtml"
 if (Model.Outcome == "error")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger alert-dismissible\" style=\"z-index: 10000; margin-top: 1%; margin-left: 10%; margin-right: 10%;\">\n        <a href=\"#\" class=\"close\" data-dismiss=\"alert\" aria-label=\"close\">&times;</a>\n        Error Occurred!\n    </div>\n");
#nullable restore
#line 12 "/home/pello/OneDrive/Projects/C#/riusco/riusco-mvc/Views/Home/UpdateProducts.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 14 "/home/pello/OneDrive/Projects/C#/riusco/riusco-mvc/Views/Home/UpdateProducts.cshtml"
 if (Model.Outcome == "success")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-info alert-dismissible\" style=\"z-index: 10000; margin-top: 1%; margin-left: 10%; margin-right: 10%;\">\n        <a href=\"#\" class=\"close\" data-dismiss=\"alert\" aria-label=\"close\">&times;</a>\n        Product Updated!\n    </div>\n");
#nullable restore
#line 20 "/home/pello/OneDrive/Projects/C#/riusco/riusco-mvc/Views/Home/UpdateProducts.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"text-center\">\n    <h1 class=\"display-4\">");
#nullable restore
#line 23 "/home/pello/OneDrive/Projects/C#/riusco/riusco-mvc/Views/Home/UpdateProducts.cshtml"
                     Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n</div>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f86a0b050efd80e44211404e136be7186a32da97167", async() => {
                WriteLiteral("\n    <div class=\"omrs-input-group\">\n        <label class=\"omrs-input-underlined\">\n            <input type=\"text\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 939, "\"", 956, 1);
#nullable restore
#line 29 "/home/pello/OneDrive/Projects/C#/riusco/riusco-mvc/Views/Home/UpdateProducts.cshtml"
WriteAttributeValue("", 947, Model.Id, 947, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" placeholder="" "" required>
            <span class=""omrs-input-label"">Product ID</span>
            <span class=""omrs-input-helper"">Enter product ID</span>
        </label>
    </div>
    <div class=""omrs-input-group"">
        <label class=""omrs-input-underlined"">
            <input type=""text"" name=""name""");
                BeginWriteAttribute("value", " value=\"", 1264, "\"", 1283, 1);
#nullable restore
#line 36 "/home/pello/OneDrive/Projects/C#/riusco/riusco-mvc/Views/Home/UpdateProducts.cshtml"
WriteAttributeValue("", 1272, Model.Name, 1272, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" placeholder="" "">
            <span class=""omrs-input-label"">Name</span>
            <span class=""omrs-input-helper"">Enter new name</span>
        </label>
    </div>
    <div class=""omrs-input-group"">
        <label class=""omrs-input-underlined"">
            <textarea name=""description"" rows=""3"" placeholder="" "" ></textarea>
            <span class=""omrs-input-label"">Description</span>
            <span class=""omrs-input-helper"">Enter new description</span>
        </label>
    </div>
    <div class=""omrs-input-group"">
        <label class=""omrs-input-underlined"">
            <input type=""text"" name=""price"" pattern=""\d*"" placeholder="" "" >
            <span class=""omrs-input-label"">Price</span>
            <span class=""omrs-input-helper"">Enter new price</span>
        </label>
    </div>
    <div style=""margin-bottom: 1.5rem;"">
        <h5 style=""color: grey"">Image</h5>
        <div class=""image-upload-wrap"">
            <input class=""file-upload-input"" type='file' name=""image"" onchange=""readURL(this);"" accept");
                WriteLiteral(@"=""image/*"" />
            <div class=""drag-text"">
                <h3>Drag and drop a file or select add Image</h3>
            </div>
        </div>
        <div class=""file-upload-content"">
            <img class=""file-upload-image"" src=""#"" alt=""your image""/>
            <div class=""image-title-wrap"">
                <button type=""button"" onclick=""removeUpload()"" class=""btn btn-danger"">Remove <span class=""image-title"">Image</span></button>
            </div>
        </div>
    </div>
    <div class=""form-group"">
        <button type=""submit"" class=""btn btn-primary"">Submit</button>
    </div>
    
");
                DefineSection("Scripts", async() => {
                    WriteLiteral(@"
        <script>
            $(document).ready(function () {
                $('.custom-file-input').on(""change"", function () {
                    var fileName = $(this).val().split(""\\"").pop();
                    $(this).next('.custom-file-label').html(fileName);
                });
            });
        </script>
    ");
                }
                );
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GenericProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591