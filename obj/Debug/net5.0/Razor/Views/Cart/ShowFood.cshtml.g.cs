#pragma checksum "C:\Users\Admin\Desktop\New folder\Pro3_Sem3\Pro3_Sem3\Views\Cart\ShowFood.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d80b0ac0d55f388cbb0e9739d878d8ca9f091df0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_ShowFood), @"mvc.1.0.view", @"/Views/Cart/ShowFood.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d80b0ac0d55f388cbb0e9739d878d8ca9f091df0", @"/Views/Cart/ShowFood.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b26446643e76dab2b1714337323c173ebb6ec0d8", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_ShowFood : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Pro3_Sem3.Models.Food>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ShowCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Admin\Desktop\New folder\Pro3_Sem3\Pro3_Sem3\Views\Cart\ShowFood.cshtml"
  
    ViewData["Title"] = "ShowFood";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ShowFood</h1>\r\n\r\n<p>\r\n    \r\n    <a name=\"payID\">Hoa don NO : ");
#nullable restore
#line 12 "C:\Users\Admin\Desktop\New folder\Pro3_Sem3\Pro3_Sem3\Views\Cart\ShowFood.cshtml"
                            Write(ViewBag.paymentID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "C:\Users\Admin\Desktop\New folder\Pro3_Sem3\Pro3_Sem3\Views\Cart\ShowFood.cshtml"
           Write(Html.DisplayNameFor(model => model.Foodname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "C:\Users\Admin\Desktop\New folder\Pro3_Sem3\Pro3_Sem3\Views\Cart\ShowFood.cshtml"
           Write(Html.DisplayNameFor(model => model.Foodimage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "C:\Users\Admin\Desktop\New folder\Pro3_Sem3\Pro3_Sem3\Views\Cart\ShowFood.cshtml"
           Write(Html.DisplayNameFor(model => model.Foodstatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "C:\Users\Admin\Desktop\New folder\Pro3_Sem3\Pro3_Sem3\Views\Cart\ShowFood.cshtml"
           Write(Html.DisplayNameFor(model => model.Foodprice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 30 "C:\Users\Admin\Desktop\New folder\Pro3_Sem3\Pro3_Sem3\Views\Cart\ShowFood.cshtml"
           Write(Html.DisplayNameFor(model => model.Fooddescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 33 "C:\Users\Admin\Desktop\New folder\Pro3_Sem3\Pro3_Sem3\Views\Cart\ShowFood.cshtml"
           Write(Html.DisplayNameFor(model => model.Cater.Catername));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 39 "C:\Users\Admin\Desktop\New folder\Pro3_Sem3\Pro3_Sem3\Views\Cart\ShowFood.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 42 "C:\Users\Admin\Desktop\New folder\Pro3_Sem3\Pro3_Sem3\Views\Cart\ShowFood.cshtml"
           Write(Html.DisplayFor(modelItem => item.Foodname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 45 "C:\Users\Admin\Desktop\New folder\Pro3_Sem3\Pro3_Sem3\Views\Cart\ShowFood.cshtml"
           Write(Html.DisplayFor(modelItem => item.Foodimage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 48 "C:\Users\Admin\Desktop\New folder\Pro3_Sem3\Pro3_Sem3\Views\Cart\ShowFood.cshtml"
           Write(Html.DisplayFor(modelItem => item.Foodstatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 51 "C:\Users\Admin\Desktop\New folder\Pro3_Sem3\Pro3_Sem3\Views\Cart\ShowFood.cshtml"
           Write(Html.DisplayFor(modelItem => item.Foodprice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 54 "C:\Users\Admin\Desktop\New folder\Pro3_Sem3\Pro3_Sem3\Views\Cart\ShowFood.cshtml"
           Write(Html.DisplayFor(modelItem => item.Fooddescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 57 "C:\Users\Admin\Desktop\New folder\Pro3_Sem3\Pro3_Sem3\Views\Cart\ShowFood.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cater.Catername));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n\r\n                <a");
            BeginWriteAttribute("href", " href=\'", 1662, "\'", 1728, 1);
#nullable restore
#line 61 "C:\Users\Admin\Desktop\New folder\Pro3_Sem3\Pro3_Sem3\Views\Cart\ShowFood.cshtml"
WriteAttributeValue("", 1669, Url.Action("AddMenu","User",new { food_id = item.Foodid }), 1669, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" >Chọn món ban dau</a> \r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d80b0ac0d55f388cbb0e9739d878d8ca9f091df09056", async() => {
                WriteLiteral("Show Cart");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 62 "C:\Users\Admin\Desktop\New folder\Pro3_Sem3\Pro3_Sem3\Views\Cart\ShowFood.cshtml"
                                                                 WriteLiteral(item.Foodid);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" \r\n               \r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 66 "C:\Users\Admin\Desktop\New folder\Pro3_Sem3\Pro3_Sem3\Views\Cart\ShowFood.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Pro3_Sem3.Models.Food>> Html { get; private set; }
    }
}
#pragma warning restore 1591
