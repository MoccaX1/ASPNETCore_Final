#pragma checksum "C:\Users\home\Desktop\ASPCore\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HoiDap\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c241b6cc89c1fbce77fc1cce5f92c4aec4f414cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_HoiDap_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/HoiDap/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/HoiDap/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_HoiDap_Index))]
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
#line 1 "C:\Users\home\Desktop\ASPCore\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\_ViewImports.cshtml"
using ASPCore_Final;

#line default
#line hidden
#line 2 "C:\Users\home\Desktop\ASPCore\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\_ViewImports.cshtml"
using ASPCore_Final.Models;

#line default
#line hidden
#line 2 "C:\Users\home\Desktop\ASPCore\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HoiDap\Index.cshtml"
using ReflectionIT.Mvc.Paging;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c241b6cc89c1fbce77fc1cce5f92c4aec4f414cc", @"/Areas/Admin/Views/HoiDap/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b88735fcb76687533fa848e18cb76dff3784b38", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_HoiDap_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReflectionIT.Mvc.Paging.PagingList<ASPCore_Final.Models.HoiDap>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:80px;height:80px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Xem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "HoiDap", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Xoa", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\Users\home\Desktop\ASPCore\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HoiDap\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(247, 231, true);
            WriteLiteral("\r\n<div class=\"bootstrap-tab animated wow slideInUp\" data-wow-delay=\".5s\">\r\n    <div class=\"bs-example bs-example-tabs\" role=\"tabpanel\" data-example-id=\"togglable-tabs\">\r\n        <ul id=\"myTab\" class=\"nav nav-tabs\" role=\"tablist\">\r\n");
            EndContext();
#line 12 "C:\Users\home\Desktop\ASPCore\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HoiDap\Index.cshtml"
              
                ESHOPContext db = new ESHOPContext();
                var hoiDapsChuaDoc = db.HoiDap.Where(p => p.TrangThaiTl == false).OrderByDescending(p=>p.NgayDua).ToList();
                int c_hoiDapsChuaDoc = db.HoiDap.Where(p => p.TrangThaiTl == false).ToList().Count();
                var hoiDapsDaDoc = db.HoiDap.Where(p => p.TrangThaiTl == true).OrderByDescending(p => p.NgayDua).ToList();
                int c_hoiDapsDaDoc = db.HoiDap.Where(p => p.TrangThaiTl == true).ToList().Count();
            

#line default
#line hidden
            BeginContext(1016, 203, true);
            WriteLiteral("            <li role=\"presentation\" class=\"active\"><a href=\"#home\" id=\"home-tab\" role=\"tab\" data-toggle=\"tab\" aria-controls=\"home\" aria-expanded=\"true\">Phản hồi chưa đọc<span class=\"badge badge-info\">");
            EndContext();
            BeginContext(1220, 16, false);
#line 19 "C:\Users\home\Desktop\ASPCore\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HoiDap\Index.cshtml"
                                                                                                                                                                                                      Write(c_hoiDapsChuaDoc);

#line default
#line hidden
            EndContext();
            BeginContext(1236, 195, true);
            WriteLiteral("</span></a></li>\r\n            <li role=\"presentation\"><a href=\"#profile\" role=\"tab\" id=\"profile-tab\" data-toggle=\"tab\" aria-controls=\"profile\">Phản hồi đã đọc <span class =\"badge badge-info\">");
            EndContext();
            BeginContext(1432, 14, false);
#line 20 "C:\Users\home\Desktop\ASPCore\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HoiDap\Index.cshtml"
                                                                                                                                                                            Write(c_hoiDapsDaDoc);

#line default
#line hidden
            EndContext();
            BeginContext(1446, 265, true);
            WriteLiteral(@"</span></a></li>
        </ul>
        <div id=""myTabContent"" class=""tab-content"">
            <div role=""tabpanel"" class=""tab-pane fade in active bootstrap-tab-text"" id=""home"" aria-labelledby=""home-tab"">
                <div class=""bootstrap-tab-text-grids"">
");
            EndContext();
#line 25 "C:\Users\home\Desktop\ASPCore\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HoiDap\Index.cshtml"
                     foreach (var item in hoiDapsChuaDoc)
                    {


#line default
#line hidden
            BeginContext(1795, 63, true);
            WriteLiteral("                        <div class=\"bootstrap-tab-text-grid\">\r\n");
            EndContext();
#line 29 "C:\Users\home\Desktop\ASPCore\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HoiDap\Index.cshtml"
                              
                                KhachHang khachHang = db.KhachHang.SingleOrDefault(p => p.MaKh == item.MaKh);
                            

#line default
#line hidden
            BeginContext(2032, 104, true);
            WriteLiteral("                            <div class=\"bootstrap-tab-text-grid-left\">\r\n                                ");
            EndContext();
            BeginContext(2136, 104, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "56faa2d82052451d8c508c013bc5d6d7", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2146, "~/UserAvatar/", 2146, 13, true);
#line 33 "C:\Users\home\Desktop\ASPCore\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HoiDap\Index.cshtml"
AddHtmlAttributeValue("", 2159, khachHang.Hinh, 2159, 15, false);

#line default
#line hidden
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
            EndContext();
            BeginContext(2240, 203, true);
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"bootstrap-tab-text-grid-right\">\r\n                                <ul>\r\n\r\n                                    <li><a href=\"#\">");
            EndContext();
            BeginContext(2444, 15, false);
#line 38 "C:\Users\home\Desktop\ASPCore\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HoiDap\Index.cshtml"
                                               Write(khachHang.HoTen);

#line default
#line hidden
            EndContext();
            BeginContext(2459, 51, true);
            WriteLiteral("</a></li>\r\n                                    <li>");
            EndContext();
            BeginContext(2510, 143, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d8f8af5ac304bbbb67528e0606f7b77", async() => {
                BeginContext(2580, 69, true);
                WriteLiteral("<span class=\"glyphicon glyphicon-share\" aria-hidden=\"true\"></span>Xem");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 39 "C:\Users\home\Desktop\ASPCore\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HoiDap\Index.cshtml"
                                                                                      WriteLiteral(item.MaHd);

#line default
#line hidden
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
            EndContext();
            BeginContext(2653, 77, true);
            WriteLiteral("</li>\r\n                                    <li style=\"font-size:small\"><span>");
            EndContext();
            BeginContext(2731, 12, false);
#line 40 "C:\Users\home\Desktop\ASPCore\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HoiDap\Index.cshtml"
                                                                 Write(item.NgayDua);

#line default
#line hidden
            EndContext();
            BeginContext(2743, 126, true);
            WriteLiteral("</span></li>\r\n                                </ul>\r\n                                <p>\r\n                                    ");
            EndContext();
            BeginContext(2870, 11, false);
#line 43 "C:\Users\home\Desktop\ASPCore\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HoiDap\Index.cshtml"
                               Write(item.CauHoi);

#line default
#line hidden
            EndContext();
            BeginContext(2881, 203, true);
            WriteLiteral("\r\n                                </p>\r\n                            </div>\r\n                            <br />\r\n                            <div class=\"clearfix\"> </div>\r\n                        </div>\r\n");
            EndContext();
#line 49 "C:\Users\home\Desktop\ASPCore\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HoiDap\Index.cshtml"

                    }

#line default
#line hidden
            BeginContext(3109, 307, true);
            WriteLiteral(@"                </div>
                </div>
            <div role=""tabpanel"" class=""tab-pane fade bootstrap-tab-text"" id=""profile"" aria-labelledby=""profile-tab"">
                <div class=""bootstrap-tab-text-grids"">
                    <div class=""bootstrap-tab-text-grids"" style=""margin:0 0 5em;"">
");
            EndContext();
#line 56 "C:\Users\home\Desktop\ASPCore\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HoiDap\Index.cshtml"
                         foreach (var item in hoiDapsDaDoc)
                        {


#line default
#line hidden
            BeginContext(3506, 63, true);
            WriteLiteral("                        <div class=\"bootstrap-tab-text-grid\">\r\n");
            EndContext();
#line 60 "C:\Users\home\Desktop\ASPCore\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HoiDap\Index.cshtml"
                              
                                KhachHang khachHang = db.KhachHang.SingleOrDefault(p => p.MaKh == item.MaKh);
                            

#line default
#line hidden
            BeginContext(3743, 104, true);
            WriteLiteral("                            <div class=\"bootstrap-tab-text-grid-left\">\r\n                                ");
            EndContext();
            BeginContext(3847, 104, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "dc2d5ce3228b4579a0243b711cfc22cb", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3857, "~/UserAvatar/", 3857, 13, true);
#line 64 "C:\Users\home\Desktop\ASPCore\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HoiDap\Index.cshtml"
AddHtmlAttributeValue("", 3870, khachHang.Hinh, 3870, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3951, 201, true);
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"bootstrap-tab-text-grid-right\">\r\n                                <ul>\r\n                                    <li><a href=\"#\">");
            EndContext();
            BeginContext(4153, 15, false);
#line 68 "C:\Users\home\Desktop\ASPCore\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HoiDap\Index.cshtml"
                                               Write(khachHang.HoTen);

#line default
#line hidden
            EndContext();
            BeginContext(4168, 51, true);
            WriteLiteral("</a></li>\r\n                                    <li>");
            EndContext();
            BeginContext(4219, 120, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd5890917eb648f3a2c378f29f3fcd8d", async() => {
                BeginContext(4265, 70, true);
                WriteLiteral("<span class=\"glyphicon glyphicon-trash\" aria-hidden=\"true\"></span>Xóa");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 69 "C:\Users\home\Desktop\ASPCore\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HoiDap\Index.cshtml"
                                                              WriteLiteral(item.MaHd);

#line default
#line hidden
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
            EndContext();
            BeginContext(4339, 77, true);
            WriteLiteral("</li>\r\n                                    <li style=\"font-size:small\"><span>");
            EndContext();
            BeginContext(4417, 12, false);
#line 70 "C:\Users\home\Desktop\ASPCore\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HoiDap\Index.cshtml"
                                                                 Write(item.NgayDua);

#line default
#line hidden
            EndContext();
            BeginContext(4429, 126, true);
            WriteLiteral("</span></li>\r\n                                </ul>\r\n                                <p>\r\n                                    ");
            EndContext();
            BeginContext(4556, 11, false);
#line 73 "C:\Users\home\Desktop\ASPCore\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HoiDap\Index.cshtml"
                               Write(item.CauHoi);

#line default
#line hidden
            EndContext();
            BeginContext(4567, 205, true);
            WriteLiteral("\r\n                                </p>\r\n                            </div>\r\n\r\n                            <div class=\"clearfix\"> </div>\r\n                            <br />\r\n                        </div>\r\n");
            EndContext();
#line 80 "C:\Users\home\Desktop\ASPCore\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HoiDap\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(4803, 155, true);
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n            <nav class=\"navbar-default justify-content-center\">\r\n\r\n                ");
            EndContext();
            BeginContext(4959, 135, false);
#line 86 "C:\Users\home\Desktop\ASPCore\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HoiDap\Index.cshtml"
           Write(await this.Component.InvokeAsync("Pager", new { pagingList = this.Model, @searchString = @ViewBag.SearchString, @class = "page-item" }));

#line default
#line hidden
            EndContext();
            BeginContext(5094, 68, true);
            WriteLiteral("\r\n\r\n\r\n            </nav>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReflectionIT.Mvc.Paging.PagingList<ASPCore_Final.Models.HoiDap>> Html { get; private set; }
    }
}
#pragma warning restore 1591
