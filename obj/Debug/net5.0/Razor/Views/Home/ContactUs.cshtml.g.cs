#pragma checksum "C:\Users\Admin\Desktop\New folder\Pro3_Sem3\Pro3_Sem3\Views\Home\ContactUs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96a041b4dbf2894e6bd23ba96e352cb64dfbcb35"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ContactUs), @"mvc.1.0.view", @"/Views/Home/ContactUs.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96a041b4dbf2894e6bd23ba96e352cb64dfbcb35", @"/Views/Home/ContactUs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b26446643e76dab2b1714337323c173ebb6ec0d8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ContactUs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return validateForm(event)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Admin\Desktop\New folder\Pro3_Sem3\Pro3_Sem3\Views\Home\ContactUs.cshtml"
  
    ViewData["Title"] = "";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!--<div class=""header-bottom"">-->
    <!--header-bottom-->
    <!--<div class=""container"">
        <div class=""row"">
            <div class=""col-sm-9"">
                <div class=""navbar-header"">
                    <button type=""button"" class=""navbar-toggle"" data-toggle=""collapse"" data-target="".navbar-collapse"">
                        <span class=""sr-only"">Toggle navigation</span>
                        <span class=""icon-bar""></span>
                        <span class=""icon-bar""></span>
                        <span class=""icon-bar""></span>
                    </button>
                </div>
                <div class=""mainmenu pull-left"">
                    <ul class=""nav navbar-nav collapse navbar-collapse"">
                        <li><a href='");
#nullable restore
#line 23 "C:\Users\Admin\Desktop\New folder\Pro3_Sem3\Pro3_Sem3\Views\Home\ContactUs.cshtml"
                                Write(Url.Action("Index", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' class=""active"">Home</a></li>-->

                        <!-- <li class=""dropdown""><a href=""#"">Blog<i class=""fa fa-angle-down""></i></a>
                            <ul role=""menu"" class=""sub-menu"">
                                <li><a href=""blog.html"">Blog List</a></li>
                                <li><a href=""blog-single.html"">Blog Single</a></li>
                            </ul>
                        </li>  -->
                        <!--<li><a href=""");
#nullable restore
#line 31 "C:\Users\Admin\Desktop\New folder\Pro3_Sem3\Pro3_Sem3\Views\Home\ContactUs.cshtml"
                                    Write(Url.Action("ConTactUs", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Contact Us</a></li>\r\n                        <li><a href=\"");
#nullable restore
#line 32 "C:\Users\Admin\Desktop\New folder\Pro3_Sem3\Pro3_Sem3\Views\Home\ContactUs.cshtml"
                                Write(Url.Action("AboutUs", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">About Us</a></li>
                    </ul>
                </div>
            </div>-->
            <!--<div class=""col-sm-3"">
                <form action="""" method=""POST"">

                    <div class=""search_box pull-right"">
                        <input type=""text"" name=""keyword"" placeholder=""Search..."" />-->
            <!-- <input type=""submit"" class=""fa fa-search"" value=""Tìm""> -->
            <!--</div>
                </form>

            </div>-->
        <!--</div>
    </div>
</div>-->


<style>
    /* Mã CSS */
    h1 {
        text-align: center;
    }
    .form {
        text-align: center;
    }

    #form1 {
        width: 600px;
        background: #fff;
        margin: 0 auto;
    }

        #form1 input {
            width: 100%;
            box-sizing: border-box;
            font-size: 18px;
            color: #555;
            display: block;
            line-height: 1.2;
            background-color: #fff;
            border-radius: 20px;");
            WriteLiteral(@"
            margin-bottom: 10px;
            height: 50px;
            padding: 0 20px 0 23px;
            border: 0;
            box-shadow: 0 5px 20px 0 rgb(0 0 0 / 5%);
            -moz-box-shadow: 0 5px 20px 0 rgba(0,0,0,.05);
            -webkit-box-shadow: 0 5px 20px 0 rgb(0 0 0 / 5%);
            -o-box-shadow: 0 5px 20px 0 rgba(0,0,0,.05);
            -ms-box-shadow: 0 5px 20px 0 rgba(0,0,0,.05);
        }

            #form1 input:focus {
                border: 0;
                outline: none;
                box-shadow: 0 5px 20px 0 rgb(250 66 81 / 10%);
                -moz-box-shadow: 0 5px 20px 0 rgba(250,66,81,.1);
                -webkit-box-shadow: 0 5px 20px 0 rgb(250 66 81 / 10%);
                -o-box-shadow: 0 5px 20px 0 rgba(250,66,81,.1);
                -ms-box-shadow: 0 5px 20px 0 rgba(250,66,81,.1);
            }

        #form1 #fcontent {
            outline: none;
            min-height: 150px;
        }

        #form1 input[type=submit] {
          ");
            WriteLiteral(@"  background-color: #bd59d4;
            height: 42px;
            padding: 5px 20px;
            border-radius: 21px;
            font-size: 14px;
            text-tranforms: uppercase;
            color: #fff;
            border: 0;
            box-shadow: 0 10px 30px 0 rgb(189 89 212 / 50%);
            -moz-box-shadow: 0 10px 30px 0 rgba(189,89,212,.5);
            -webkit-box-shadow: 0 10px 30px 0 rgb(189 89 212 / 50%);
            -o-box-shadow: 0 10px 30px 0 rgba(189,89,212,.5);
            -ms-box-shadow: 0 10px 30px 0 rgba(189,89,212,.5);
        }

        #form1 input[type=""submit""]:hover {
            background: #CC4949;
        }
    .error {
        color: red;
        size: 80%
    }

    .hidden {
        display: none;
    }
</style>
<h1>Contact Us</h1>
<div class=""form"">
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96a041b4dbf2894e6bd23ba96e352cb64dfbcb359700", async() => {
                WriteLiteral(@"
        <input type=""text"" id=""fname"" name=""fname"" required placeholder=""FullName""><br>
        <input type=""email"" id=""femail"" name=""femail"" required placeholder=""Email""  ><br>
        <input type=""text"" id=""myform_phone"" name=""phone"" required placeholder=""Phone""/>
        <div id=""phone_error"" class=""error hidden"">
            Please enter a valid phone number: (123) 456-7890
        </div>
        <input type=""text"" id=""fcontent"" name=""fcontent"" placeholder=""Comment"" required><br>
        <input type=""submit"" value=""Submit"">
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 131 "C:\Users\Admin\Desktop\New folder\Pro3_Sem3\Pro3_Sem3\Views\Home\ContactUs.cshtml"
AddHtmlAttributeValue("", 4391, Url.Action("ThankYou", "Home"), 4391, 31, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>

<script>
    function validatePhoneNumber(input_str) {
        var re = /^[\+]?[(]?[0-9]{3}[)]?[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{4,6}$/im;

        return re.test(input_str);
    }

    
    function validateForm(event) {
        var phone = document.getElementById('myform_phone').value;
        if (!validatePhoneNumber(phone)) {
            document.getElementById('phone_error').classList.remove('hidden');
            return false;
        } else {
            document.getElementById('phone_error').classList.add('hidden');
            alert(""Send success"")
            return true;
        }
        event.preventDefault();
    }

    document.getElementById('myform').addEventListener('submit', validateForm);
</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
