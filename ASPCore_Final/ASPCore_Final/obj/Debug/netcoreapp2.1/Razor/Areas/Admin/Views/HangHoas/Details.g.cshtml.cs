#pragma checksum "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HangHoas\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ea3d60bbd5602e8717b384e3f7f0870dfd51bd1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_HangHoas_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/HangHoas/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/HangHoas/Details.cshtml", typeof(AspNetCore.Areas_Admin_Views_HangHoas_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ea3d60bbd5602e8717b384e3f7f0870dfd51bd1", @"/Areas/Admin/Views/HangHoas/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b88735fcb76687533fa848e18cb76dff3784b38", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_HangHoas_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ASPCore_Final.Models.HangHoa>
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
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HangHoas\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(141, 121, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>HangHoa</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(263, 41, false);
#line 15 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HangHoas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TenHh));

#line default
#line hidden
            EndContext();
            BeginContext(304, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(348, 37, false);
#line 18 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HangHoas\Details.cshtml"
       Write(Html.DisplayFor(model => model.TenHh));

#line default
#line hidden
            EndContext();
            BeginContext(385, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(429, 40, false);
#line 21 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HangHoas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Hinh));

#line default
#line hidden
            EndContext();
            BeginContext(469, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(513, 36, false);
#line 24 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HangHoas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Hinh));

#line default
#line hidden
            EndContext();
            BeginContext(549, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(593, 42, false);
#line 27 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HangHoas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DonGia));

#line default
#line hidden
            EndContext();
            BeginContext(635, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(679, 38, false);
#line 30 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HangHoas\Details.cshtml"
       Write(Html.DisplayFor(model => model.DonGia));

#line default
#line hidden
            EndContext();
            BeginContext(717, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(761, 43, false);
#line 33 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HangHoas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GiamGia));

#line default
#line hidden
            EndContext();
            BeginContext(804, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(848, 39, false);
#line 36 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HangHoas\Details.cshtml"
       Write(Html.DisplayFor(model => model.GiamGia));

#line default
#line hidden
            EndContext();
            BeginContext(887, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(931, 40, false);
#line 39 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HangHoas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MoTa));

#line default
#line hidden
            EndContext();
            BeginContext(971, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1015, 36, false);
#line 42 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HangHoas\Details.cshtml"
       Write(Html.DisplayFor(model => model.MoTa));

#line default
#line hidden
            EndContext();
            BeginContext(1051, 53, true);
            WriteLiteral("\r\n        </dd>\r\n        \r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1105, 52, false);
#line 46 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HangHoas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MaLoaiNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1157, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1201, 55, false);
#line 49 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HangHoas\Details.cshtml"
       Write(Html.DisplayFor(model => model.MaLoaiNavigation.MaLoai));

#line default
#line hidden
            EndContext();
            BeginContext(1256, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1300, 51, false);
#line 52 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HangHoas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MaNccNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1351, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1395, 53, false);
#line 55 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HangHoas\Details.cshtml"
       Write(Html.DisplayFor(model => model.MaNccNavigation.MaNcc));

#line default
#line hidden
            EndContext();
            BeginContext(1448, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1495, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7bfa112c4f9d4239bf4e7b0b33de9790", async() => {
                BeginContext(1543, 4, true);
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
#line 60 "C:\Users\home\Desktop\ASPNET\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\HangHoas\Details.cshtml"
                           WriteLiteral(Model.MaHh);

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
            BeginContext(1551, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1559, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f55d6c60db6a4b6cab49b854f2e52666", async() => {
                BeginContext(1581, 12, true);
                WriteLiteral("Back to List");
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
            BeginContext(1597, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ASPCore_Final.Models.HangHoa> Html { get; private set; }
    }
}
#pragma warning restore 1591