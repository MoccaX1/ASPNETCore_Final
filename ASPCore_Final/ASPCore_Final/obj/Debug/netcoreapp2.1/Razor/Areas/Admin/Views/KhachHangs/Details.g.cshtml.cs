#pragma checksum "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\KhachHangs\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "327385e7675ffc88861c0caa2ab49e60dd427067"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_KhachHangs_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/KhachHangs/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/KhachHangs/Details.cshtml", typeof(AspNetCore.Areas_Admin_Views_KhachHangs_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"327385e7675ffc88861c0caa2ab49e60dd427067", @"/Areas/Admin/Views/KhachHangs/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b88735fcb76687533fa848e18cb76dff3784b38", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_KhachHangs_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ASPCore_Final.Models.KhachHang>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\KhachHangs\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(143, 118, true);
            WriteLiteral("\r\n\r\n\r\n<div>\r\n    <h4>Danh sách khách hàng</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(262, 44, false);
#line 15 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\KhachHangs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TaiKhoan));

#line default
#line hidden
            EndContext();
            BeginContext(306, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(350, 40, false);
#line 18 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\KhachHangs\Details.cshtml"
       Write(Html.DisplayFor(model => model.TaiKhoan));

#line default
#line hidden
            EndContext();
            BeginContext(390, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(434, 43, false);
#line 21 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\KhachHangs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MatKhau));

#line default
#line hidden
            EndContext();
            BeginContext(477, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(521, 39, false);
#line 24 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\KhachHangs\Details.cshtml"
       Write(Html.DisplayFor(model => model.MatKhau));

#line default
#line hidden
            EndContext();
            BeginContext(560, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(604, 41, false);
#line 27 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\KhachHangs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HoTen));

#line default
#line hidden
            EndContext();
            BeginContext(645, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(689, 37, false);
#line 30 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\KhachHangs\Details.cshtml"
       Write(Html.DisplayFor(model => model.HoTen));

#line default
#line hidden
            EndContext();
            BeginContext(726, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(770, 44, false);
#line 33 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\KhachHangs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GioiTinh));

#line default
#line hidden
            EndContext();
            BeginContext(814, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(858, 40, false);
#line 36 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\KhachHangs\Details.cshtml"
       Write(Html.DisplayFor(model => model.GioiTinh));

#line default
#line hidden
            EndContext();
            BeginContext(898, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(942, 44, false);
#line 39 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\KhachHangs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NgaySinh));

#line default
#line hidden
            EndContext();
            BeginContext(986, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1030, 40, false);
#line 42 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\KhachHangs\Details.cshtml"
       Write(Html.DisplayFor(model => model.NgaySinh));

#line default
#line hidden
            EndContext();
            BeginContext(1070, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1114, 42, false);
#line 45 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\KhachHangs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DiaChi));

#line default
#line hidden
            EndContext();
            BeginContext(1156, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1200, 38, false);
#line 48 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\KhachHangs\Details.cshtml"
       Write(Html.DisplayFor(model => model.DiaChi));

#line default
#line hidden
            EndContext();
            BeginContext(1238, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1282, 45, false);
#line 51 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\KhachHangs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DienThoai));

#line default
#line hidden
            EndContext();
            BeginContext(1327, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1371, 41, false);
#line 54 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\KhachHangs\Details.cshtml"
       Write(Html.DisplayFor(model => model.DienThoai));

#line default
#line hidden
            EndContext();
            BeginContext(1412, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1456, 41, false);
#line 57 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\KhachHangs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1497, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1541, 37, false);
#line 60 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\KhachHangs\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1578, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1622, 40, false);
#line 63 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\KhachHangs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Hinh));

#line default
#line hidden
            EndContext();
            BeginContext(1662, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1706, 36, false);
#line 66 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\KhachHangs\Details.cshtml"
       Write(Html.DisplayFor(model => model.Hinh));

#line default
#line hidden
            EndContext();
            BeginContext(1742, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1786, 47, false);
#line 69 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\KhachHangs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TrangThaiHd));

#line default
#line hidden
            EndContext();
            BeginContext(1833, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1877, 43, false);
#line 72 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\KhachHangs\Details.cshtml"
       Write(Html.DisplayFor(model => model.TrangThaiHd));

#line default
#line hidden
            EndContext();
            BeginContext(1920, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1967, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61fb8f7666fb4bf89b97c04cc00dcc94", async() => {
                BeginContext(2015, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 77 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\KhachHangs\Details.cshtml"
                           WriteLiteral(Model.MaKh);

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
            BeginContext(2023, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2031, 33, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1edee1cbbbb4b70b84a61eed3deadda", async() => {
                BeginContext(2053, 7, true);
                WriteLiteral("Trở lại");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2064, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ASPCore_Final.Models.KhachHang> Html { get; private set; }
    }
}
#pragma warning restore 1591
