#pragma checksum "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhanViens\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8a44d56f6e4eced742fdbd855f992e4617d50be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_NhanViens_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/NhanViens/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/NhanViens/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_NhanViens_Index))]
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
#line 1 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\_ViewImports.cshtml"
using ASPCore_Final;

#line default
#line hidden
#line 2 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\_ViewImports.cshtml"
using ASPCore_Final.Models;

#line default
#line hidden
#line 2 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhanViens\Index.cshtml"
using ReflectionIT.Mvc.Paging;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8a44d56f6e4eced742fdbd855f992e4617d50be", @"/Areas/Admin/Views/NhanViens/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b88735fcb76687533fa848e18cb76dff3784b38", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_NhanViens_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReflectionIT.Mvc.Paging.PagingList<ASPCore_Final.Models.NhanVien>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhanViens\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(249, 113, true);
            WriteLiteral("\r\n\r\n\r\n\r\n<div class=\"outer-w3-agile mt-3\">\r\n    <h4 class=\"tittle-w3-agileits mb-4\">Danh sách nhân viên</h4>\r\n    ");
            EndContext();
            BeginContext(362, 354, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d15b7b80dcf447cdaa7390267cbae1ed", async() => {
                BeginContext(401, 81, true);
                WriteLiteral("\r\n        <input name=\"searchString\" class=\"form-control\" placeholder=\"Search...\"");
                EndContext();
                BeginWriteAttribute("value", "\r\n               value=\"", 482, "\"", 539, 1);
#line 16 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhanViens\Index.cshtml"
WriteAttributeValue("", 506, Model.RouteValue["searchString"], 506, 33, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(540, 169, true);
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
            BeginContext(716, 19, true);
            WriteLiteral("\r\n    <p>\r\n        ");
            EndContext();
            BeginContext(735, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "458d144a4e37468ca8660725af79eeae", async() => {
                BeginContext(782, 7, true);
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
            BeginContext(793, 148, true);
            WriteLiteral("\r\n    </p>\r\n\r\n\r\n\r\n    <table class=\"table table-striped\">\r\n        <thead>\r\n            <tr>\r\n                <th scope=\"col\">\r\n                    ");
            EndContext();
            BeginContext(942, 40, false);
#line 31 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhanViens\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.MaNv));

#line default
#line hidden
            EndContext();
            BeginContext(982, 79, true);
            WriteLiteral("\r\n                </th>\r\n                <th scope=\"col\">\r\n                    ");
            EndContext();
            BeginContext(1062, 41, false);
#line 34 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhanViens\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.HoTen));

#line default
#line hidden
            EndContext();
            BeginContext(1103, 79, true);
            WriteLiteral("\r\n                </th>\r\n                <th scope=\"col\">\r\n                    ");
            EndContext();
            BeginContext(1183, 41, false);
#line 37 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhanViens\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1224, 79, true);
            WriteLiteral("\r\n                </th>\r\n                <th scope=\"col\">\r\n                    ");
            EndContext();
            BeginContext(1304, 43, false);
#line 40 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhanViens\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.MatKhau));

#line default
#line hidden
            EndContext();
            BeginContext(1347, 79, true);
            WriteLiteral("\r\n                </th>\r\n                <th scope=\"col\">\r\n                    ");
            EndContext();
            BeginContext(1427, 47, false);
#line 43 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhanViens\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.TrangThaiHd));

#line default
#line hidden
            EndContext();
            BeginContext(1474, 79, true);
            WriteLiteral("\r\n                </th>\r\n                <th scope=\"col\">\r\n                    ");
            EndContext();
            BeginContext(1554, 50, false);
#line 46 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhanViens\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.MaPqNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1604, 106, true);
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 52 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhanViens\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(1767, 84, true);
            WriteLiteral("                <tr>\r\n                    <td scope=\"row\">\r\n                        ");
            EndContext();
            BeginContext(1852, 39, false);
#line 56 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhanViens\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.MaNv));

#line default
#line hidden
            EndContext();
            BeginContext(1891, 91, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td scope=\"row\">\r\n                        ");
            EndContext();
            BeginContext(1983, 40, false);
#line 59 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhanViens\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.HoTen));

#line default
#line hidden
            EndContext();
            BeginContext(2023, 91, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td scope=\"row\">\r\n                        ");
            EndContext();
            BeginContext(2115, 40, false);
#line 62 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhanViens\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(2155, 91, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td scope=\"row\">\r\n                        ");
            EndContext();
            BeginContext(2247, 42, false);
#line 65 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhanViens\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.MatKhau));

#line default
#line hidden
            EndContext();
            BeginContext(2289, 91, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td scope=\"row\">\r\n                        ");
            EndContext();
            BeginContext(2381, 46, false);
#line 68 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhanViens\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TrangThaiHd));

#line default
#line hidden
            EndContext();
            BeginContext(2427, 91, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td scope=\"row\">\r\n                        ");
            EndContext();
            BeginContext(2519, 54, false);
#line 71 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhanViens\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.MaPqNavigation.MaPq));

#line default
#line hidden
            EndContext();
            BeginContext(2573, 91, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td scope=\"row\">\r\n                        ");
            EndContext();
            BeginContext(2664, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66be6a1fc38f47b2a0f2443fe8edac13", async() => {
                BeginContext(2711, 4, true);
                WriteLiteral("Edit");
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
#line 74 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhanViens\Index.cshtml"
                                               WriteLiteral(item.MaNv);

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
            BeginContext(2719, 28, true);
            WriteLiteral(" |\r\n                        ");
            EndContext();
            BeginContext(2747, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe86c1b818dd4326a37a4878296e9dd3", async() => {
                BeginContext(2797, 7, true);
                WriteLiteral("Details");
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
#line 75 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhanViens\Index.cshtml"
                                                  WriteLiteral(item.MaNv);

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
            BeginContext(2808, 28, true);
            WriteLiteral(" |\r\n                        ");
            EndContext();
            BeginContext(2836, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a21ef88d9883480788d196055efba788", async() => {
                BeginContext(2885, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 76 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhanViens\Index.cshtml"
                                                 WriteLiteral(item.MaNv);

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
            BeginContext(2895, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 79 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhanViens\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(2962, 116, true);
            WriteLiteral("        </tbody>\r\n\r\n    </table>\r\n   \r\n    <nav class=\"navbar-default justify-content-center\"  >\r\n   \r\n\r\n           ");
            EndContext();
            BeginContext(3079, 135, false);
#line 87 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\NhanViens\Index.cshtml"
      Write(await this.Component.InvokeAsync("Pager", new { pagingList = this.Model, @searchString = @ViewBag.SearchString, @class = "page-item" }));

#line default
#line hidden
            EndContext();
            BeginContext(3214, 55, true);
            WriteLiteral("\r\n                   \r\n      \r\n    </nav>\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReflectionIT.Mvc.Paging.PagingList<ASPCore_Final.Models.NhanVien>> Html { get; private set; }
    }
}
#pragma warning restore 1591
