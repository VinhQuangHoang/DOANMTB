#pragma checksum "D:\DOANMTB\aaaaaaaaaa\MotoBike_Shop_layout\MotoBike_Shop\21-11-2021\Areas\admin\Views\SanPhams\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6d7d3feb40514413e43b1e80f5574c519eecdb6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_admin_Views_SanPhams_Index), @"mvc.1.0.view", @"/Areas/admin/Views/SanPhams/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6d7d3feb40514413e43b1e80f5574c519eecdb6", @"/Areas/admin/Views/SanPhams/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d758dfbba3109aad51f725da09241bd4cbe32633", @"/Areas/admin/Views/_ViewImports.cshtml")]
    public class Areas_admin_Views_SanPhams_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<_21_11_2021.Areas.admin.Models.SanPham>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "IdShowModal", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:white;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\DOANMTB\aaaaaaaaaa\MotoBike_Shop_layout\MotoBike_Shop\21-11-2021\Areas\admin\Views\SanPhams\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""wrapper"">
    <!-- Main Sidebar Container -->
    <!-- Content Wrapper. Contains page content -->
    <div class=""content-wrapper"">
        <!-- Content Header (Page header) -->
        <section class=""content-header"">
            <div class=""container-fluid"">
                <div class=""row mb-2"">
                    <div class=""col-sm-6"">
                        <h1>Sản phẩm</h1>
                    </div>
                    <div class=""col-sm-6"">
                        <ol class=""breadcrumb float-sm-right"">
                            <li class=""breadcrumb-item""><a href=""#"">Trang chủ</a></li>
                            <li class=""breadcrumb-item active"">Sản phẩm</li>
                        </ol>
                    </div>
                </div>
            </div><!-- /.container-fluid -->
        </section>

        <!-- Main content -->
        <section class=""content"">
            <div class=""container-fluid"">
                <div class=""row"">
                ");
            WriteLiteral("    <div class=\"col-12\">\r\n                        <div class=\"card\">\r\n                            <div class=\"card-header\">\r\n                                <h3 class=\"card-title\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6d7d3feb40514413e43b1e80f5574c519eecdb66400", async() => {
                WriteLiteral("<i class=\"fas fa-plus-circle\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </h3>
                            </div>
                            <!-- /.card-header -->
                            <div class=""card-body"">
                                <table id=""example2"" class=""table table-bordered table-hover"">
                                    <thead>
                                        <tr>
                                            <th>Mã sản phẩm</th>
                                            <th>Tên sản phẩm</th>
                                            <th>Giá cuối</th>
                                            <th>Hạng Mục</th>
                                            <th>Trang thái</th>
                                        </tr>
                                    </thead>
                                    <tbody>
");
#nullable restore
#line 53 "D:\DOANMTB\aaaaaaaaaa\MotoBike_Shop_layout\MotoBike_Shop\21-11-2021\Areas\admin\Views\SanPhams\Index.cshtml"
                                         foreach (var item in Model)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr>\r\n                                                <td>");
#nullable restore
#line 56 "D:\DOANMTB\aaaaaaaaaa\MotoBike_Shop_layout\MotoBike_Shop\21-11-2021\Areas\admin\Views\SanPhams\Index.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.MaSanPham));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 57 "D:\DOANMTB\aaaaaaaaaa\MotoBike_Shop_layout\MotoBike_Shop\21-11-2021\Areas\admin\Views\SanPhams\Index.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.TenSanPham));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 58 "D:\DOANMTB\aaaaaaaaaa\MotoBike_Shop_layout\MotoBike_Shop\21-11-2021\Areas\admin\Views\SanPhams\Index.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.GiaDaKhuyenMai));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 59 "D:\DOANMTB\aaaaaaaaaa\MotoBike_Shop_layout\MotoBike_Shop\21-11-2021\Areas\admin\Views\SanPhams\Index.cshtml"
                                               Write(Html.DisplayFor(modleItem => item.HangMuc));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 60 "D:\DOANMTB\aaaaaaaaaa\MotoBike_Shop_layout\MotoBike_Shop\21-11-2021\Areas\admin\Views\SanPhams\Index.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.TrangThai));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                                <td>
                                                    <div class=""container-fluid"">
                                                        <button type=""button"" class=""btn btn-primary btn-lg"" data-toggle=""modal"" data-target=""#flipFlop"">
                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6d7d3feb40514413e43b1e80f5574c519eecdb611079", async() => {
                WriteLiteral(" Xóa ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 64 "D:\DOANMTB\aaaaaaaaaa\MotoBike_Shop_layout\MotoBike_Shop\21-11-2021\Areas\admin\Views\SanPhams\Index.cshtml"
                                                                                          WriteLiteral(item.MaSanPham);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                        </button>
                                                        <button type=""button"" class=""btn btn-primary btn-lg"" data-dismiss=""modal"">
                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6d7d3feb40514413e43b1e80f5574c519eecdb613661", async() => {
                WriteLiteral("Sửa");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 67 "D:\DOANMTB\aaaaaaaaaa\MotoBike_Shop_layout\MotoBike_Shop\21-11-2021\Areas\admin\Views\SanPhams\Index.cshtml"
                                                                                   WriteLiteral(item.MaSanPham);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                        </button>
                                                        <button type=""button"" class=""btn btn-primary btn-lg"" data-dismiss=""modal"">
                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6d7d3feb40514413e43b1e80f5574c519eecdb616234", async() => {
                WriteLiteral("Chi Tiết");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 70 "D:\DOANMTB\aaaaaaaaaa\MotoBike_Shop_layout\MotoBike_Shop\21-11-2021\Areas\admin\Views\SanPhams\Index.cshtml"
                                                                                      WriteLiteral(item.MaSanPham);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
                                                </td>
                                            </tr>
                                            <!--Modal-->
");
            WriteLiteral("                                            <!--End modal-->\r\n");
#nullable restore
#line 78 "D:\DOANMTB\aaaaaaaaaa\MotoBike_Shop_layout\MotoBike_Shop\21-11-2021\Areas\admin\Views\SanPhams\Index.cshtml"
                                                                                                                

                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </tbody>
                                </table>
                            </div>
                            <!-- /.card-body -->
                        </div>
                        <!-- /.card -->
                        <!-- /.card -->
                    </div>
                    <!-- /.col -->
                </div>
                <!-- /.row -->
            </div>
            <!-- /.container-fluid -->
        </section>
        <!-- /.content -->
    </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<_21_11_2021.Areas.admin.Models.SanPham>> Html { get; private set; }
    }
}
#pragma warning restore 1591
