#pragma checksum "D:\aaaaaaaaaa\MotoBike_Shop_layout\MotoBike_Shop\21-11-2021\Views\TinTuc\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2446dd07a203bb8ff1e706187f32e1087e78fe03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TinTuc_Index), @"mvc.1.0.view", @"/Views/TinTuc/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2446dd07a203bb8ff1e706187f32e1087e78fe03", @"/Views/TinTuc/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b619cb8e9467ab000b47c2ab8672d9c01778cfef", @"/Views/_ViewImports.cshtml")]
    public class Views_TinTuc_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-thumbnail img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"    <!-- Start All Title Box -->
<div class=""all-title-box"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <h2>ABOUT US</h2>
                <ul class=""breadcrumb"">
                    <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
                    <li class=""breadcrumb-item active"">NEWS</li>
                </ul>
            </div>
        </div>
    </div>
</div>
<!-- End All Title Box -->
<!-- Start About Page  -->
<div class=""about-box-main"">
    <div class=""container"">
");
#nullable restore
#line 19 "D:\aaaaaaaaaa\MotoBike_Shop_layout\MotoBike_Shop\21-11-2021\Views\TinTuc\Index.cshtml"
         foreach (var item in ViewBag.TinTuc)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row\">\r\n                <div class=\"col-lg-6\">\r\n                    <h2 class=\"noo-sh-title\">");
#nullable restore
#line 23 "D:\aaaaaaaaaa\MotoBike_Shop_layout\MotoBike_Shop\21-11-2021\Views\TinTuc\Index.cshtml"
                                        Write(item.TenTinTuc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <p>\r\n                        ");
#nullable restore
#line 25 "D:\aaaaaaaaaa\MotoBike_Shop_layout\MotoBike_Shop\21-11-2021\Views\TinTuc\Index.cshtml"
                   Write(Html.Raw(item.ChiTiet));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n                    </p>\r\n                </div>\r\n                <div class=\"col-lg-6\">\r\n                    <div class=\"banner-frame\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2446dd07a203bb8ff1e706187f32e1087e78fe035739", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1042, "~/tintuc/", 1042, 9, true);
#nullable restore
#line 30 "D:\aaaaaaaaaa\MotoBike_Shop_layout\MotoBike_Shop\21-11-2021\Views\TinTuc\Index.cshtml"
AddHtmlAttributeValue("", 1051, item.Hinh, 1051, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 34 "D:\aaaaaaaaaa\MotoBike_Shop_layout\MotoBike_Shop\21-11-2021\Views\TinTuc\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

        <div class=""row my-5"">
            <div class=""col-sm-6 col-lg-4"">
                <div class=""service-block-inner"">
                    <h3>We are Trusted</h3>
                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. </p>
                </div>
            </div>
            <div class=""col-sm-6 col-lg-4"">
                <div class=""service-block-inner"">
                    <h3>We are Professional</h3>
                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. </p>
                </div>
            </div>
            <div class=""col-sm-6 col-lg-4"">
                <div class=""service-block-inner"">
                    <h3>We are Expert</h3>
                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. </p>
              ");
            WriteLiteral(@"  </div>
            </div>
        </div>
        <div class=""row my-4"">
            <div class=""col-12"">
                <h2 class=""noo-sh-title"">Meet Our Team</h2>
            </div>
            <div class=""col-sm-6 col-lg-3"">
                <div class=""hover-team"">
                    <div class=""our-team"">
                        <img src=""images/img-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 2556, "\"", 2562, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                        <div class=""team-content"">
                            <h3 class=""title"">Williamson</h3> <span class=""post"">Web Developer</span>
                        </div>
                        <ul class=""social"">
                            <li>
                                <a href=""#"" class=""fab fa-facebook""></a>
                            </li>
                            <li>
                                <a href=""#"" class=""fab fa-twitter""></a>
                            </li>
                            <li>
                                <a href=""#"" class=""fab fa-google-plus""></a>
                            </li>
                            <li>
                                <a href=""#"" class=""fab fa-youtube""></a>
                            </li>
                        </ul>
                        <div class=""icon""> <i class=""fa fa-plus"" aria-hidden=""true""></i> </div>
                    </div>
                    <div class=""team-description"">
      ");
            WriteLiteral(@"                  <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent urna diam, maximus ut ullamcorper quis, placerat id eros. Duis semper justo sed condimentum rutrum. Nunc tristique purus turpis. Maecenas vulputate. </p>
                    </div>
                    <hr class=""my-0"">
                </div>
            </div>
            <div class=""col-sm-6 col-lg-3"">
                <div class=""hover-team"">
                    <div class=""our-team"">
                        <img src=""images/img-2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 4122, "\"", 4128, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                        <div class=""team-content"">
                            <h3 class=""title"">Kristiana</h3> <span class=""post"">Web Developer</span>
                        </div>
                        <ul class=""social"">
                            <li>
                                <a href=""#"" class=""fab fa-facebook""></a>
                            </li>
                            <li>
                                <a href=""#"" class=""fab fa-twitter""></a>
                            </li>
                            <li>
                                <a href=""#"" class=""fab fa-google-plus""></a>
                            </li>
                            <li>
                                <a href=""#"" class=""fab fa-youtube""></a>
                            </li>
                        </ul>
                        <div class=""icon""> <i class=""fa fa-plus"" aria-hidden=""true""></i> </div>
                    </div>
                    <div class=""team-description"">
       ");
            WriteLiteral(@"                 <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent urna diam, maximus ut ullamcorper quis, placerat id eros. Duis semper justo sed condimentum rutrum. Nunc tristique purus turpis. Maecenas vulputate. </p>
                    </div>
                    <hr class=""my-0"">
                </div>
            </div>
            <div class=""col-sm-6 col-lg-3"">
                <div class=""hover-team"">
                    <div class=""our-team"">
                        <img src=""images/img-3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 5687, "\"", 5693, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                        <div class=""team-content"">
                            <h3 class=""title"">Steve Thomas</h3> <span class=""post"">Web Developer</span>
                        </div>
                        <ul class=""social"">
                            <li>
                                <a href=""#"" class=""fab fa-facebook""></a>
                            </li>
                            <li>
                                <a href=""#"" class=""fab fa-twitter""></a>
                            </li>
                            <li>
                                <a href=""#"" class=""fab fa-google-plus""></a>
                            </li>
                            <li>
                                <a href=""#"" class=""fab fa-youtube""></a>
                            </li>
                        </ul>
                        <div class=""icon""> <i class=""fa fa-plus"" aria-hidden=""true""></i> </div>
                    </div>
                    <div class=""team-description"">
    ");
            WriteLiteral(@"                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent urna diam, maximus ut ullamcorper quis, placerat id eros. Duis semper justo sed condimentum rutrum. Nunc tristique purus turpis. Maecenas vulputate. </p>
                    </div>
                    <hr class=""my-0"">
                </div>
            </div>
            <div class=""col-sm-6 col-lg-3"">
                <div class=""hover-team"">
                    <div class=""our-team"">
                        <img src=""images/img-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 7255, "\"", 7261, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                        <div class=""team-content"">
                            <h3 class=""title"">Williamson</h3> <span class=""post"">Web Developer</span>
                        </div>
                        <ul class=""social"">
                            <li>
                                <a href=""#"" class=""fab fa-facebook""></a>
                            </li>
                            <li>
                                <a href=""#"" class=""fab fa-twitter""></a>
                            </li>
                            <li>
                                <a href=""#"" class=""fab fa-google-plus""></a>
                            </li>
                            <li>
                                <a href=""#"" class=""fab fa-youtube""></a>
                            </li>
                        </ul>
                        <div class=""icon""> <i class=""fa fa-plus"" aria-hidden=""true""></i> </div>
                    </div>
                    <div class=""team-description"">
      ");
            WriteLiteral(@"                  <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent urna diam, maximus ut ullamcorper quis, placerat id eros. Duis semper justo sed condimentum rutrum. Nunc tristique purus turpis. Maecenas vulputate. </p>
                    </div>
                    <hr class=""my-0"">
                </div>
            </div>
        </div>
    </div>
</div>
<!-- End About Page -->");
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
