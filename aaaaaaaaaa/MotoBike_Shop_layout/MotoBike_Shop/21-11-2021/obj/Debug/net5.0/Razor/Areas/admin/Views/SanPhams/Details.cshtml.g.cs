#pragma checksum "D:\DOANMTB\aaaaaaaaaa\MotoBike_Shop_layout\MotoBike_Shop\21-11-2021\Areas\admin\Views\SanPhams\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8fd375366c1575121c6183f2944cf70b51e20bda"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_admin_Views_SanPhams_Details), @"mvc.1.0.view", @"/Areas/admin/Views/SanPhams/Details.cshtml")]
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
#line 1 "D:\DOANMTB\aaaaaaaaaa\MotoBike_Shop_layout\MotoBike_Shop\21-11-2021\Areas\admin\Views\_ViewImports.cshtml"
using _21_11_2021;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DOANMTB\aaaaaaaaaa\MotoBike_Shop_layout\MotoBike_Shop\21-11-2021\Areas\admin\Views\_ViewImports.cshtml"
using _21_11_2021.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fd375366c1575121c6183f2944cf70b51e20bda", @"/Areas/admin/Views/SanPhams/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d758dfbba3109aad51f725da09241bd4cbe32633", @"/Areas/admin/Views/_ViewImports.cshtml")]
    public class Areas_admin_Views_SanPhams_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<_21_11_2021.Areas.admin.Models.SanPham>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("profile-user-img img-fluid img-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("User profile picture"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:white;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\DOANMTB\aaaaaaaaaa\MotoBike_Shop_layout\MotoBike_Shop\21-11-2021\Areas\admin\Views\SanPhams\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""content-wrapper"">
    <!-- Content Header (Page header) -->
    <section class=""content-header"">
        <div class=""container-fluid"">
            <div class=""row mb-2"">
                <div class=""col-sm-6"">
                    <h1>Chi tiết</h1>
                </div>
                <div class=""col-sm-6"">
                    <ol class=""breadcrumb float-sm-right"">
                        <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
                        <li class=""breadcrumb-item active"">Chi tiết sản phẩm</li>
                    </ol>
                </div>
            </div>
        </div><!-- /.container-fluid -->
    </section>

    <!-- Main content -->
    <section class=""content"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-md-3"">
                        <!-- Profile Image -->
                        <div class=""card card-primary card-outline"">
                            <div class=""card-body box");
            WriteLiteral("-profile\">\r\n                                <div class=\"text-center\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8fd375366c1575121c6183f2944cf70b51e20bda7205", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1321, "~/pro/", 1321, 6, true);
#nullable restore
#line 35 "D:\DOANMTB\aaaaaaaaaa\MotoBike_Shop_layout\MotoBike_Shop\21-11-2021\Areas\admin\Views\SanPhams\Details.cshtml"
AddHtmlAttributeValue("", 1327, Html.DisplayFor(model => model.HinhAnh), 1327, 40, false);

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
            WriteLiteral("\r\n                                </div>\r\n\r\n                                <h3 class=\"profile-username text-center\">Tên sản phẩm: ");
#nullable restore
#line 39 "D:\DOANMTB\aaaaaaaaaa\MotoBike_Shop_layout\MotoBike_Shop\21-11-2021\Areas\admin\Views\SanPhams\Details.cshtml"
                                                                                  Write(Html.DisplayFor(model => model.TenSanPham));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n                                <p class=\"text-muted text-center\">Hạng mục: ");
#nullable restore
#line 41 "D:\DOANMTB\aaaaaaaaaa\MotoBike_Shop_layout\MotoBike_Shop\21-11-2021\Areas\admin\Views\SanPhams\Details.cshtml"
                                                                       Write(Html.DisplayFor(model => model.HangMuc));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                                <ul class=\"list-group list-group-unbordered mb-3\">\r\n                                    <li class=\"list-group-item\">\r\n                                        <b>Giá </b> <a class=\"float-right\"><del>");
#nullable restore
#line 45 "D:\DOANMTB\aaaaaaaaaa\MotoBike_Shop_layout\MotoBike_Shop\21-11-2021\Areas\admin\Views\SanPhams\Details.cshtml"
                                                                           Write(Html.DisplayFor(model => model.Gia));

#line default
#line hidden
#nullable disable
            WriteLiteral("</del></a>\r\n                                    </li>\r\n                                    <li class=\"list-group-item\">\r\n                                        <b>Giá khuyến mãi</b> <a class=\"float-right\">");
#nullable restore
#line 48 "D:\DOANMTB\aaaaaaaaaa\MotoBike_Shop_layout\MotoBike_Shop\21-11-2021\Areas\admin\Views\SanPhams\Details.cshtml"
                                                                                Write(Html.DisplayFor(model => model.GiaKhuyenMai));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                    </li>\r\n                                    <li class=\"list-group-item\">\r\n                                        <b>Giá thực</b> <a class=\"float-right\" style=\"color:red;\">");
#nullable restore
#line 51 "D:\DOANMTB\aaaaaaaaaa\MotoBike_Shop_layout\MotoBike_Shop\21-11-2021\Areas\admin\Views\SanPhams\Details.cshtml"
                                                                                             Write(Html.DisplayFor(model => model.GiaDaKhuyenMai));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                                    </li>
                                </ul>
                            </div>
                            <!-- /.card-body -->
                        </div>


                </div>
                <!-- /.col -->
                <div class=""col-md-9"">
                    <div class=""card"">
                        <div class=""card-header p-2"">
                            <ul class=""nav nav-pills"">
                                <li class=""nav-item""><a class=""nav-link active"" href=""#activity"" data-toggle=""tab"">Chi tiết</a></li>
                                <li class=""nav-item""><a class=""nav-link"" href=""#settings"" data-toggle=""tab"">Thông tin</a></li>
                            </ul>
                        </div><!-- /.card-header -->
                        <div class=""card-body"">
                            <div class=""tab-content"">
                                <div class=""active tab-pane"" id=""activity"">
                                   ");
            WriteLiteral(@" <!-- Post -->
                                    <div class=""post"">
                                        <div class=""user-block"">
                                            <span class=""username"">
                                                <p>
                                                    ");
#nullable restore
#line 77 "D:\DOANMTB\aaaaaaaaaa\MotoBike_Shop_layout\MotoBike_Shop\21-11-2021\Areas\admin\Views\SanPhams\Details.cshtml"
                                               Write(Html.Raw(Model.ChiTiet));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                </p>
                                            </span>
                                        </div>
                                    </div>
                                    <!-- /.post -->
                                </div>
                                <!-- /.tab-pane -->
                                <!-- /.tab-pane -->

                                <div class=""tab-pane"" id=""settings"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8fd375366c1575121c6183f2944cf70b51e20bda13815", async() => {
                WriteLiteral(@"
                                        <div class=""form-group row"">
                                            <label for=""inputName"" class=""col-sm-2 col-form-label"">Mã sản phẩm</label>
                                            <div class=""col-sm-10"">
                                                ");
#nullable restore
#line 92 "D:\DOANMTB\aaaaaaaaaa\MotoBike_Shop_layout\MotoBike_Shop\21-11-2021\Areas\admin\Views\SanPhams\Details.cshtml"
                                           Write(Html.DisplayFor(model => model.MaSanPham));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                            </div>
                                        </div>
                                        <div class=""form-group row"">
                                            <label for=""inputEmail"" class=""col-sm-2 col-form-label"">Mã khuyến mãi</label>
                                            <div class=""col-sm-10"">
                                                ");
#nullable restore
#line 98 "D:\DOANMTB\aaaaaaaaaa\MotoBike_Shop_layout\MotoBike_Shop\21-11-2021\Areas\admin\Views\SanPhams\Details.cshtml"
                                           Write(Html.DisplayFor(model => model.MaKhuyenMai));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                            </div>
                                        </div>
                                        <div class=""form-group row"">
                                            <label for=""inputName2"" class=""col-sm-2 col-form-label"">Mã loại sản phẩm</label>
                                            <div class=""col-sm-10"">
                                                ");
#nullable restore
#line 104 "D:\DOANMTB\aaaaaaaaaa\MotoBike_Shop_layout\MotoBike_Shop\21-11-2021\Areas\admin\Views\SanPhams\Details.cshtml"
                                           Write(Html.DisplayFor(model => model.MaLoaiSanPham));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                            </div>
                                        </div>
                                        <div class=""form-group row"">
                                            <label for=""inputSkills"" class=""col-sm-2 col-form-label"">Trạng thái</label>
                                            <div class=""col-sm-10"">
                                                ");
#nullable restore
#line 110 "D:\DOANMTB\aaaaaaaaaa\MotoBike_Shop_layout\MotoBike_Shop\21-11-2021\Areas\admin\Views\SanPhams\Details.cshtml"
                                           Write(Html.DisplayFor(model => model.TrangThai));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                            </div>
                                        </div>
                                        <div class=""form-group row"">
                                            <div class=""offset-sm-2 col-sm-10"">
                                                <button type=""button"" class=""btn btn-primary btn-lg"" data-dismiss=""modal"">
                                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8fd375366c1575121c6183f2944cf70b51e20bda17380", async() => {
                    WriteLiteral("Edit");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 116 "D:\DOANMTB\aaaaaaaaaa\MotoBike_Shop_layout\MotoBike_Shop\21-11-2021\Areas\admin\Views\SanPhams\Details.cshtml"
                                                                           WriteLiteral(Model.MaSanPham);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                                </button>
                                            </div>
                                            <div class=""offset-sm-2 col-sm-10"">
                                                <button type=""button"" class=""btn btn-primary btn-lg"" data-dismiss=""modal"">
                                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8fd375366c1575121c6183f2944cf70b51e20bda20161", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                </button>\r\n                                            </div>\r\n\r\n                                        </div>\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </div>
                                <!-- /.tab-pane -->
                            </div>
                            <!-- /.tab-content -->
                        </div><!-- /.card-body -->
                    </div>
                    <!-- /.card -->
                </div>
                <!-- /.col -->
            </div>
            <!-- /.row -->
        </div><!-- /.container-fluid -->
    </section>
    <!-- /.content -->
</div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<_21_11_2021.Areas.admin.Models.SanPham> Html { get; private set; }
    }
}
#pragma warning restore 1591
