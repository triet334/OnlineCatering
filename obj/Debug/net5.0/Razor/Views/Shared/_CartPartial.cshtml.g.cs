#pragma checksum "C:\Users\Admin\Desktop\New folder\Pro3_Sem3\Pro3_Sem3\Views\Shared\_CartPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f3d912e7d2c6518e2e5404d16b85b811668e44b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__CartPartial), @"mvc.1.0.view", @"/Views/Shared/_CartPartial.cshtml")]
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
#nullable restore
#line 4 "C:\Users\Admin\Desktop\New folder\Pro3_Sem3\Pro3_Sem3\Views\Shared\_CartPartial.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\Desktop\New folder\Pro3_Sem3\Pro3_Sem3\Views\Shared\_CartPartial.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f3d912e7d2c6518e2e5404d16b85b811668e44b", @"/Views/Shared/_CartPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b26446643e76dab2b1714337323c173ebb6ec0d8", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__CartPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 9 "C:\Users\Admin\Desktop\New folder\Pro3_Sem3\Pro3_Sem3\Views\Shared\_CartPartial.cshtml"
  
    var session = HttpContextAccessor.HttpContext.Session;
    string jsoncart = session.GetString(Pro3_Sem3.Controllers.CartController.CARTKEY);
    if (jsoncart != null)
    {
        var cart = JsonConvert.DeserializeObject<List<CartItem>>(jsoncart);

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span asp-route=\"cart\">(");
#nullable restore
#line 15 "C:\Users\Admin\Desktop\New folder\Pro3_Sem3\Pro3_Sem3\Views\Shared\_CartPartial.cshtml"
                           Write(cart.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</span>\r\n");
#nullable restore
#line 16 "C:\Users\Admin\Desktop\New folder\Pro3_Sem3\Pro3_Sem3\Views\Shared\_CartPartial.cshtml"

    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
