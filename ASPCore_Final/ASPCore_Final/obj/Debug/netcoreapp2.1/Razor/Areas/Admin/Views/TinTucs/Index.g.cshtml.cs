#pragma checksum "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\TinTucs\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c5464552935c6344f538b7236ff5f326c443670"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_TinTucs_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/TinTucs/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/TinTucs/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_TinTucs_Index))]
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
#line 1 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\_ViewImports.cshtml"
using ASPCore_Final;

#line default
#line hidden
#line 2 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\_ViewImports.cshtml"
using ASPCore_Final.Models;

#line default
#line hidden
#line 3 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\TinTucs\Index.cshtml"
using ReflectionIT.Mvc.Paging;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c5464552935c6344f538b7236ff5f326c443670", @"/Areas/Admin/Views/TinTucs/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b88735fcb76687533fa848e18cb76dff3784b38", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_TinTucs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReflectionIT.Mvc.Paging.PagingList<ASPCore_Final.Models.TinTuc>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\TinTucs\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(249, 107, true);
            WriteLiteral("\r\n<div class=\"outer-w3-agile mt-3\">\r\n    <h4 class=\"tittle-w3-agileits mb-4\">Danh sách nhân viên</h4>\r\n    ");
            EndContext();
            BeginContext(356, 354, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7dff91e74cce44c9a44226e49dad6793", async() => {
                BeginContext(395, 81, true);
                WriteLiteral("\r\n        <input name=\"searchString\" class=\"form-control\" placeholder=\"Search...\"");
                EndContext();
                BeginWriteAttribute("value", "\r\n               value=\"", 476, "\"", 533, 1);
#line 14 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\TinTucs\Index.cshtml"
WriteAttributeValue("", 500, Model.RouteValue["searchString"], 500, 33, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(534, 169, true);
                WriteLiteral(" />\r\n        <button type=\"submit\" class=\"btn btn-info\">\r\n            <span class=\"glyphicon glyphicon-search\" aria-hidden=\"true\"></span> Search\r\n        </button>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(710, 31, true);
            WriteLiteral("\r\n    <hr />\r\n    <p>\r\n        ");
            EndContext();
            BeginContext(741, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ebe792b5481b43448ce7248b038c2138", async() => {
                BeginContext(788, 7, true);
                WriteLiteral("Tạo mới");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(799, 148, true);
            WriteLiteral("\r\n    </p>\r\n\r\n\r\n\r\n    <table class=\"table table-striped\">\r\n        <thead>\r\n            <tr>\r\n                <th scope=\"col\">\r\n                    ");
            EndContext();
            BeginContext(948, 43, false);
#line 30 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\TinTucs\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.NoiDung));

#line default
#line hidden
            EndContext();
            BeginContext(991, 79, true);
            WriteLiteral("\r\n                </th>\r\n                <th scope=\"col\">\r\n                    ");
            EndContext();
            BeginContext(1071, 43, false);
#line 33 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\TinTucs\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.NgayTao));

#line default
#line hidden
            EndContext();
            BeginContext(1114, 79, true);
            WriteLiteral("\r\n                </th>\r\n                <th scope=\"col\">\r\n                    ");
            EndContext();
            BeginContext(1194, 45, false);
#line 36 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\TinTucs\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.TrangThai));

#line default
#line hidden
            EndContext();
            BeginContext(1239, 79, true);
            WriteLiteral("\r\n                </th>\r\n                <th scope=\"col\">\r\n                    ");
            EndContext();
            BeginContext(1319, 52, false);
#line 39 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\TinTucs\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.LoaiTtNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1371, 79, true);
            WriteLiteral("\r\n                </th>\r\n                <th scope=\"col\">\r\n                    ");
            EndContext();
            BeginContext(1451, 42, false);
#line 42 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\TinTucs\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.TieuDe));

#line default
#line hidden
            EndContext();
            BeginContext(1493, 79, true);
            WriteLiteral("\r\n                </th>\r\n                <th scope=\"col\">\r\n                    ");
            EndContext();
            BeginContext(1573, 50, false);
#line 45 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\TinTucs\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.MaNvNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1623, 106, true);
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 51 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\TinTucs\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(1786, 15, true);
            WriteLiteral("            <tr");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1801, "\"", 1837, 4);
            WriteAttributeValue("", 1811, "_delete(", 1811, 8, true);
#line 53 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\TinTucs\Index.cshtml"
WriteAttributeValue("", 1819, item.MaTt, 1819, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 1829, ",", 1829, 1, true);
            WriteAttributeValue(" ", 1830, "event)", 1831, 7, true);
            EndWriteAttribute();
            BeginContext(1838, 57, true);
            WriteLiteral(">\r\n                <td scope=\"row\">\r\n                    ");
            EndContext();
            BeginContext(1896, 42, false);
#line 55 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\TinTucs\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.NoiDung));

#line default
#line hidden
            EndContext();
            BeginContext(1938, 79, true);
            WriteLiteral("\r\n                </td>\r\n                <td scope=\"row\">\r\n                    ");
            EndContext();
            BeginContext(2018, 42, false);
#line 58 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\TinTucs\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.NgayTao));

#line default
#line hidden
            EndContext();
            BeginContext(2060, 79, true);
            WriteLiteral("\r\n                </td>\r\n                <td scope=\"row\">\r\n                    ");
            EndContext();
            BeginContext(2140, 44, false);
#line 61 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\TinTucs\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.TrangThai));

#line default
#line hidden
            EndContext();
            BeginContext(2184, 79, true);
            WriteLiteral("\r\n                </td>\r\n                <td scope=\"row\">\r\n                    ");
            EndContext();
            BeginContext(2264, 58, false);
#line 64 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\TinTucs\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.LoaiTtNavigation.LoaiTt));

#line default
#line hidden
            EndContext();
            BeginContext(2322, 79, true);
            WriteLiteral("\r\n                </td>\r\n                <td scope=\"row\">\r\n                    ");
            EndContext();
            BeginContext(2402, 41, false);
#line 67 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\TinTucs\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.TieuDe));

#line default
#line hidden
            EndContext();
            BeginContext(2443, 79, true);
            WriteLiteral("\r\n                </td>\r\n                <td scope=\"row\">\r\n                    ");
            EndContext();
            BeginContext(2523, 55, false);
#line 70 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\TinTucs\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.MaNvNavigation.Email));

#line default
#line hidden
            EndContext();
            BeginContext(2578, 79, true);
            WriteLiteral("\r\n                </td>\r\n                <td scope=\"row\">\r\n                    ");
            EndContext();
            BeginContext(2657, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6da4f8486c864b93bbaeda4bd72ea087", async() => {
                BeginContext(2728, 3, true);
                WriteLiteral("Sửa");
                EndContext();
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
#line 73 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\TinTucs\Index.cshtml"
                                           WriteLiteral(item.MaTt);

#line default
#line hidden
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
            EndContext();
            BeginContext(2735, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(2759, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91eec9c681f84b618447384ae8049782", async() => {
                BeginContext(2833, 12, true);
                WriteLiteral("Xem chi tiết");
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
#line 74 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\TinTucs\Index.cshtml"
                                              WriteLiteral(item.MaTt);

#line default
#line hidden
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
            EndContext();
            BeginContext(2849, 139, true);
            WriteLiteral(" |\r\n\r\n                    <button type=\"button\" class=\"btn btn-primary btn-delete\">Xóa</button>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 79 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\TinTucs\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(3003, 1115, true);
            WriteLiteral(@"        </tbody>
    </table>
    <script>
        function _delete(id, ev) {
            if (ev.target.className == 'btn btn-primary btn-delete') {
                console.log(ev.target);
                console.log(ev.currentTarget);
                var cf = confirm('Bạn có muốn xoá tin tức ID: ' + id + '?');
                if (cf) {
                    $(ev.currentTarget).fadeOut();
                    $.ajax({
                        url: '/api/TinTucs/' + id,
                        type: ""Delete"",
                        contentType: ""application/json; charset=utf-8"",
                        dataType: ""json"",
                        async: true,
                        success: function (result) {
                            alert(""Xoá thành công"");
                        },
                        error: function (errormessage) {
                            alert(errormessage.responseText);
                        }
                    });
                }
            }
    ");
            WriteLiteral("    }\r\n    </script>\r\n    <nav class=\"navbar-default justify-content-center\">\r\n\r\n\r\n        ");
            EndContext();
            BeginContext(4119, 135, false);
#line 110 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\TinTucs\Index.cshtml"
   Write(await this.Component.InvokeAsync("Pager", new { pagingList = this.Model, @searchString = @ViewBag.SearchString, @class = "page-item" }));

#line default
#line hidden
            EndContext();
            BeginContext(4254, 26, true);
            WriteLiteral("\r\n\r\n\r\n    </nav>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReflectionIT.Mvc.Paging.PagingList<ASPCore_Final.Models.TinTuc>> Html { get; private set; }
    }
}
#pragma warning restore 1591
