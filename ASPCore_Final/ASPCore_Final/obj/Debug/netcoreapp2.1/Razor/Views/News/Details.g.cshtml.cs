#pragma checksum "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Views\News\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26390c820f8aa1dc8c0f1641646fb635c3736ba6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_News_Details), @"mvc.1.0.view", @"/Views/News/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/News/Details.cshtml", typeof(AspNetCore.Views_News_Details))]
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
#line 1 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Views\_ViewImports.cshtml"
using ASPCore_Final;

#line default
#line hidden
#line 2 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Views\_ViewImports.cshtml"
using ASPCore_Final.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26390c820f8aa1dc8c0f1641646fb635c3736ba6", @"/Views/News/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cae0022d08f620143d968fa9654a9b9c381b59a0", @"/Views/_ViewImports.cshtml")]
    public class Views_News_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ASPCore_Final.Models.TinTuc>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:230px;height:230px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Alternate Text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(36, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Views\News\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_frontEnd.cshtml";

#line default
#line hidden
            BeginContext(130, 103, true);
            WriteLiteral("\r\n<div class=\"content\">\r\n    <div class=\"content_top\">\r\n        <div class=\"heading\">\r\n            <h3>");
            EndContext();
            BeginContext(234, 12, false);
#line 11 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Views\News\Details.cshtml"
           Write(Model.TieuDe);

#line default
#line hidden
            EndContext();
            BeginContext(246, 113, true);
            WriteLiteral("</h3>\r\n        </div>\r\n\r\n        <div class=\"clear\"></div>\r\n    </div>\r\n    <div class=\"section-group\">\r\n        ");
            EndContext();
            BeginContext(360, 23, false);
#line 17 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Views\News\Details.cshtml"
   Write(Html.Raw(Model.NoiDung));

#line default
#line hidden
            EndContext();
            BeginContext(383, 42, true);
            WriteLiteral("\r\n   \r\n    </div>\r\n</div>\r\n<div>\r\n  \r\n    ");
            EndContext();
            BeginContext(425, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f552276a58ee4fd28f4b0c067d09e066", async() => {
                BeginContext(447, 6, true);
                WriteLiteral("Trở về");
                EndContext();
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
            EndContext();
            BeginContext(457, 257, true);
            WriteLiteral(@"
</div>

<div class=""single-related-products"">
    <div class=""container"">
        <h3 class=""animated wow slideInUp"" data-wow-delay="".5s"">Tin liên quan</h3>
        <div class=""new-collections-grids"">
            <div class=""new-collections-grid"">
");
            EndContext();
#line 31 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Views\News\Details.cshtml"
                  
                    ESHOPContext db = new ESHOPContext();
                    var listSP_related = db.TinTuc.Where(p => p.LoaiTt == Model.LoaiTt).Take(4).ToList();
                

#line default
#line hidden
            BeginContext(919, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 36 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Views\News\Details.cshtml"
                 foreach (var item in listSP_related)
                {
                    

#line default
#line hidden
            BeginContext(1017, 183, true);
            WriteLiteral("                <div class=\"container-fluid\">\r\n                    <div class=\"row align-content-center\">\r\n                        <div class=\"col-sm-3\">\r\n                            ");
            EndContext();
            BeginContext(1200, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bec56a55524a447f9362e6f6433f5c95", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1210, "~/HangHoa/", 1210, 10, true);
#line 42 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Views\News\Details.cshtml"
AddHtmlAttributeValue("", 1220, item.Hinh, 1220, 10, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
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
            BeginContext(1289, 138, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-sm-8 align-content-between\">\r\n                            <h3><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1427, "\"", 1458, 2);
            WriteAttributeValue("", 1434, "/News/Details/", 1434, 14, true);
#line 45 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Views\News\Details.cshtml"
WriteAttributeValue("", 1448, item.MaTt, 1448, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1459, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1461, 11, false);
#line 45 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Views\News\Details.cshtml"
                                                              Write(item.TieuDe);

#line default
#line hidden
            EndContext();
            BeginContext(1472, 54, true);
            WriteLiteral(" </a></h3>\r\n                            <h4>Posted on ");
            EndContext();
            BeginContext(1527, 12, false);
#line 46 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Views\News\Details.cshtml"
                                     Write(item.NgayTao);

#line default
#line hidden
            EndContext();
            BeginContext(1539, 36, true);
            WriteLiteral(" </h4>\r\n                            ");
            EndContext();
            BeginContext(1576, 11, false);
#line 47 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Views\News\Details.cshtml"
                       Write(item.LoaiTt);

#line default
#line hidden
            EndContext();
            BeginContext(1587, 86, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 51 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Views\News\Details.cshtml"
                }

#line default
#line hidden
            BeginContext(1692, 99, true);
            WriteLiteral("            </div>\r\n            <div class=\"clearfix\"> </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ASPCore_Final.Models.TinTuc> Html { get; private set; }
    }
}
#pragma warning restore 1591