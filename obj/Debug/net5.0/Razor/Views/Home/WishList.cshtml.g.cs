#pragma checksum "C:\Users\Admin\Desktop\New folder\Pro3_Sem3\Pro3_Sem3\Views\Home\WishList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af5c3e046bedb2ffeba9bd81afe30e20ce45a43b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_WishList), @"mvc.1.0.view", @"/Views/Home/WishList.cshtml")]
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
#line 1 "C:\Users\Admin\Desktop\New folder\Pro3_Sem3\Pro3_Sem3\Views\_ViewImports.cshtml"
using Pro3_Sem3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Desktop\New folder\Pro3_Sem3\Pro3_Sem3\Views\_ViewImports.cshtml"
using Pro3_Sem3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af5c3e046bedb2ffeba9bd81afe30e20ce45a43b", @"/Views/Home/WishList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b26446643e76dab2b1714337323c173ebb6ec0d8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_WishList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Pro3_Sem3.Models.ViewHome>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("max-width: 100%; border-radius: 5%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div class=\"features_items\">\r\n    <!--features_items-->\r\n    <h2 class=\"title text-center\">WishList</h2>\r\n");
#nullable restore
#line 6 "C:\Users\Admin\Desktop\New folder\Pro3_Sem3\Pro3_Sem3\Views\Home\WishList.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-sm-4\">\r\n            <div class=\"product-image-wrapper\">\r\n                <div class=\"single-products\">\r\n                    <div class=\"productinfo text-center\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\'", 409, "\'", 489, 1);
#nullable restore
#line 12 "C:\Users\Admin\Desktop\New folder\Pro3_Sem3\Pro3_Sem3\Views\Home\WishList.cshtml"
WriteAttributeValue("", 416, Url.Action("DetailsCaterer", "Home",new { id = item.CaterersN.Caterid }), 416, 73, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "af5c3e046bedb2ffeba9bd81afe30e20ce45a43b4875", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 531, "~/images/caterer/", 531, 17, true);
#nullable restore
#line 13 "C:\Users\Admin\Desktop\New folder\Pro3_Sem3\Pro3_Sem3\Views\Home\WishList.cshtml"
AddHtmlAttributeValue("", 548, item.CaterersN.Photo, 548, 21, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n                            <h2>");
#nullable restore
#line 16 "C:\Users\Admin\Desktop\New folder\Pro3_Sem3\Pro3_Sem3\Views\Home\WishList.cshtml"
                           Write(item.CaterersN.Caterfullname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n                            <p>");
#nullable restore
#line 18 "C:\Users\Admin\Desktop\New folder\Pro3_Sem3\Pro3_Sem3\Views\Home\WishList.cshtml"
                          Write(item.CaterersN.Caterphone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </a>\r\n\r\n                    </div>\r\n                </div>\r\n                <div class=\"choose\">\r\n                    <ul class=\"nav nav-pills nav-justified\">\r\n");
#nullable restore
#line 25 "C:\Users\Admin\Desktop\New folder\Pro3_Sem3\Pro3_Sem3\Views\Home\WishList.cshtml"
                         if (@item.wishlist)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li><a");
            BeginWriteAttribute("href", " href=\'", 1053, "\'", 1134, 1);
#nullable restore
#line 27 "C:\Users\Admin\Desktop\New folder\Pro3_Sem3\Pro3_Sem3\Views\Home\WishList.cshtml"
WriteAttributeValue("", 1060, Url.Action("RemoveWishListN", "Home",new { id = item.CaterersN.Caterid }), 1060, 74, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"wishlist\"><i class=\"fa fa-plus-square\"></i>Remove to WishList</a></li>\r\n");
#nullable restore
#line 28 "C:\Users\Admin\Desktop\New folder\Pro3_Sem3\Pro3_Sem3\Views\Home\WishList.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li><a");
            BeginWriteAttribute("href", " href=\'", 1333, "\'", 1410, 1);
#nullable restore
#line 31 "C:\Users\Admin\Desktop\New folder\Pro3_Sem3\Pro3_Sem3\Views\Home\WishList.cshtml"
WriteAttributeValue("", 1340, Url.Action("AddWishList", "Home",new { id = item.CaterersN.Caterid }), 1340, 70, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-plus-square\"></i>Add to WishList</a></li>\r\n");
#nullable restore
#line 32 "C:\Users\Admin\Desktop\New folder\Pro3_Sem3\Pro3_Sem3\Views\Home\WishList.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 37 "C:\Users\Admin\Desktop\New folder\Pro3_Sem3\Pro3_Sem3\Views\Home\WishList.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div>\r\n<!--San pham moi-->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Pro3_Sem3.Models.ViewHome>> Html { get; private set; }
    }
}
#pragma warning restore 1591
