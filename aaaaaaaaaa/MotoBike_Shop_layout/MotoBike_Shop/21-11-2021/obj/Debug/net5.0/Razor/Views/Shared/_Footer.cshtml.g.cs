#pragma checksum "D:\aaaaaaaaaa\MotoBike_Shop_layout\MotoBike_Shop\21-11-2021\Views\Shared\_Footer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd3a9518b1b40358bbcf62b032784f631c1f79d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Footer), @"mvc.1.0.view", @"/Views/Shared/_Footer.cshtml")]
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
#line 1 "D:\aaaaaaaaaa\MotoBike_Shop_layout\MotoBike_Shop\21-11-2021\Views\_ViewImports.cshtml"
using _21_11_2021;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\aaaaaaaaaa\MotoBike_Shop_layout\MotoBike_Shop\21-11-2021\Views\_ViewImports.cshtml"
using _21_11_2021.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\aaaaaaaaaa\MotoBike_Shop_layout\MotoBike_Shop\21-11-2021\Views\_ViewImports.cshtml"
using _21_11_2021.Areas.admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd3a9518b1b40358bbcf62b032784f631c1f79d9", @"/Views/Shared/_Footer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b619cb8e9467ab000b47c2ab8672d9c01778cfef", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Footer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("400px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("400px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<!-- Start Instagram Feed  -->\r\n<div class=\"instagram-box\">\r\n    <div class=\"main-instagram owl-carousel owl-theme\">\r\n");
#nullable restore
#line 4 "D:\aaaaaaaaaa\MotoBike_Shop_layout\MotoBike_Shop\21-11-2021\Views\Shared\_Footer.cshtml"
         foreach (var item in ViewBag.Foot)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\aaaaaaaaaa\MotoBike_Shop_layout\MotoBike_Shop\21-11-2021\Views\Shared\_Footer.cshtml"
             if (item.TrangThai == true)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"item\">\r\n                    <div class=\"ins-inner-box\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fd3a9518b1b40358bbcf62b032784f631c1f79d95098", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 350, "~/footshow/", 350, 11, true);
#nullable restore
#line 10 "D:\aaaaaaaaaa\MotoBike_Shop_layout\MotoBike_Shop\21-11-2021\Views\Shared\_Footer.cshtml"
AddHtmlAttributeValue("", 361, item.Hinh, 361, 10, false);

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
            WriteLiteral("\r\n                        <div class=\"hov-in\">\r\n                            <a href=\"#\"><i class=\"fab fa-instagram\"></i></a>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 16 "D:\aaaaaaaaaa\MotoBike_Shop_layout\MotoBike_Shop\21-11-2021\Views\Shared\_Footer.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\aaaaaaaaaa\MotoBike_Shop_layout\MotoBike_Shop\21-11-2021\Views\Shared\_Footer.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
</div>
<!-- End Instagram Feed  -->
<!-- Start Footer  -->
<footer>
    <div class=""footer-main"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-4 col-md-12 col-sm-12"">
                    <div class=""footer-widget"">
                        <h4>About ThewayShop</h4>
                        <p>
                            Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.
                        </p>
                        <ul>
                            <li><a href=""#""><i class=""fab fa-facebook"" aria-hidden=""true""></i></a></li>
                            <li><a href=""#""><i class=""fab fa-twitter"" aria-hidden=""true""></i></a></li>
                            <li><a href=""#""><i class=""fab fa-linkedin"" aria-hidden=""true""></i></a></li>
                     ");
            WriteLiteral(@"       <li><a href=""#""><i class=""fab fa-google-plus"" aria-hidden=""true""></i></a></li>
                            <li><a href=""#""><i class=""fa fa-rss"" aria-hidden=""true""></i></a></li>
                            <li><a href=""#""><i class=""fab fa-pinterest-p"" aria-hidden=""true""></i></a></li>
                            <li><a href=""#""><i class=""fab fa-whatsapp"" aria-hidden=""true""></i></a></li>
                        </ul>
                    </div>
                </div>
                <div class=""col-lg-4 col-md-12 col-sm-12"">
                    <div class=""footer-link"">
                        <h4>Information</h4>
                        <ul>
                            <li><a href=""#"">About Us</a></li>
                            <li><a href=""#"">Customer Service</a></li>
                            <li><a href=""#"">Our Sitemap</a></li>
                            <li><a href=""#"">Terms &amp; Conditions</a></li>
                            <li><a href=""#"">Privacy Policy</a></li>
             ");
            WriteLiteral(@"               <li><a href=""#"">Delivery Information</a></li>
                        </ul>
                    </div>
                </div>
                <div class=""col-lg-4 col-md-12 col-sm-12"">
                    <div class=""footer-link-contact"">
                        <h4>Contact Us</h4>
                        <ul>
                            <li>
                                <p><i class=""fas fa-map-marker-alt""></i>Address: Su???i M??, <br>Nh?? anh Ph??t P??o,<br> PS: G???n ???? L???t, L??m ?????ng</p>
                            </li>
                            <li>
                                <p><i class=""fas fa-phone-square""></i>Phone: <a href=""tel:+84-907231374"">+84-907231374</a></p>
                            </li>
                            <li>
                                <p><i class=""fas fa-envelope""></i>Email: <a href=""mailto:contactinfo@gmail.com"">lilkhavipro@gmail.com</a></p>
                            </li>
                        </ul>
                    </div>
      ");
            WriteLiteral("          </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</footer>\r\n<!-- End Footer  -->");
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
