#pragma checksum "E:\poit\Visual Studio Projects\WebCoffee\WebCoffee\Views\Menu\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39da328e7aba0b844861b1f86c4752beb2312166"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Menu_Details), @"mvc.1.0.view", @"/Views/Menu/Details.cshtml")]
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
#line 1 "E:\poit\Visual Studio Projects\WebCoffee\WebCoffee\Views\_ViewImports.cshtml"
using WebCoffee;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\poit\Visual Studio Projects\WebCoffee\WebCoffee\Views\_ViewImports.cshtml"
using WebCoffee.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\poit\Visual Studio Projects\WebCoffee\WebCoffee\Views\_ViewImports.cshtml"
using WebCoffee.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\poit\Visual Studio Projects\WebCoffee\WebCoffee\Views\_ViewImports.cshtml"
using WebCoffee.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\poit\Visual Studio Projects\WebCoffee\WebCoffee\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\poit\Visual Studio Projects\WebCoffee\WebCoffee\Views\Menu\Details.cshtml"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39da328e7aba0b844861b1f86c4752beb2312166", @"/Views/Menu/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"944a6052c9965c72a4b3b491475688305b993881", @"/Views/_ViewImports.cshtml")]
    public class Views_Menu_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Bag", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("product_item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "E:\poit\Visual Studio Projects\WebCoffee\WebCoffee\Views\Menu\Details.cshtml"
  
    ViewData["Title"] = "Details";
    var similar = await context.Products.Where(x => x.Category.Name == Model.Category.Name && x.Id != Model.Id)
        .Include(x => x.Category)
        .Include(x => x.Photo)
        .ToListAsync();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"page\">\r\n    <div class=\"details-product\">\r\n        <div class=\"details-product-body\">\r\n            <div class=\"details-product-img\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 509, "\"", 564, 1);
#nullable restore
#line 16 "E:\poit\Visual Studio Projects\WebCoffee\WebCoffee\Views\Menu\Details.cshtml"
WriteAttributeValue("", 515, Url.Content(Model.Photo.Path + Model.Photo.Name), 515, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"img\" />\r\n            </div>\r\n            <div class=\"details-product-description-wrapper\">\r\n                <div class=\"details-product-title\">\r\n                    ");
#nullable restore
#line 20 "E:\poit\Visual Studio Projects\WebCoffee\WebCoffee\Views\Menu\Details.cshtml"
               Write(Model.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" \"");
#nullable restore
#line 20 "E:\poit\Visual Studio Projects\WebCoffee\WebCoffee\Views\Menu\Details.cshtml"
                                     Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n                </div>\r\n                <div class=\"details-product-description\">\r\n                    ");
#nullable restore
#line 23 "E:\poit\Visual Studio Projects\WebCoffee\WebCoffee\Views\Menu\Details.cshtml"
               Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39da328e7aba0b844861b1f86c4752beb23121667408", async() => {
                WriteLiteral(@"
                    <div>
                        Порция
                    </div>
                    <div class=""detailts_inputs"">
                        <input class=""details_portions_input"" id=""portion1"" type=""radio"" name=""portion"" value=""100"" checked />
                        <input class=""details_portions_input"" id=""portion2"" type=""radio"" name=""portion"" value=""200"" />
                        <input class=""details_portions_input"" id=""portion3"" type=""radio"" name=""portion"" value=""300"" />
                        <label class=""details_portions_label"" id=""portion1label"" for=""portion1"">100</label>
                        <label class=""details_portions_label"" id=""portion2label"" for=""portion2"">200</label>
                        <label class=""details_portions_label"" id=""portion3label"" for=""portion3"">300</label>
                    </div>
                    <div>
                        <input type=""number"" name=""amount"" value=""1"" />
                    </div>
                    <div class=""d");
                WriteLiteral("etails-product-price\">\r\n                        ");
#nullable restore
#line 41 "E:\poit\Visual Studio Projects\WebCoffee\WebCoffee\Views\Menu\Details.cshtml"
                   Write(Model.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(" BYN\r\n                    </div>\r\n                    <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 2164, "\"", 2181, 1);
#nullable restore
#line 43 "E:\poit\Visual Studio Projects\WebCoffee\WebCoffee\Views\Menu\Details.cshtml"
WriteAttributeValue("", 2172, Model.Id, 2172, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <input type=\"submit\" value=\"Добавить в корзину\" />\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"details_similar\">\r\n        <div class=\"details_similar_header\">Похожие</div>\r\n        <div class=\"menu-products\">\r\n");
#nullable restore
#line 52 "E:\poit\Visual Studio Projects\WebCoffee\WebCoffee\Views\Menu\Details.cshtml"
             foreach (var product in similar)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39da328e7aba0b844861b1f86c4752beb231216611667", async() => {
                WriteLiteral("\r\n                    <div class=\"product-title\">\r\n                        ");
#nullable restore
#line 56 "E:\poit\Visual Studio Projects\WebCoffee\WebCoffee\Views\Menu\Details.cshtml"
                   Write(product.Category.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" \"");
#nullable restore
#line 56 "E:\poit\Visual Studio Projects\WebCoffee\WebCoffee\Views\Menu\Details.cshtml"
                                           Write(product.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"\r\n                    </div>\r\n                    <div class=\"product-img\">\r\n                        <span class=\"product-item-price\">");
#nullable restore
#line 59 "E:\poit\Visual Studio Projects\WebCoffee\WebCoffee\Views\Menu\Details.cshtml"
                                                    Write(product.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                        <img");
                BeginWriteAttribute("src", " src=\"", 2897, "\"", 2956, 1);
#nullable restore
#line 60 "E:\poit\Visual Studio Projects\WebCoffee\WebCoffee\Views\Menu\Details.cshtml"
WriteAttributeValue("", 2903, Url.Content(product.Photo.Path + product.Photo.Name), 2903, 53, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"photo\" />\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2550, "~/Menu/Details/", 2550, 15, true);
#nullable restore
#line 54 "E:\poit\Visual Studio Projects\WebCoffee\WebCoffee\Views\Menu\Details.cshtml"
AddHtmlAttributeValue("", 2565, product.Id, 2565, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 63 "E:\poit\Visual Studio Projects\WebCoffee\WebCoffee\Views\Menu\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ApplicationDbContext context { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
