#pragma checksum "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "693064a7356ed1a0219bb788e0e498b74c61c5e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__Layout), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Areas_Admin_Views_Shared__Layout))]
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
#line 1 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\_ViewImports.cshtml"
using ASPCore_Final;

#line default
#line hidden
#line 2 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\_ViewImports.cshtml"
using ASPCore_Final.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"693064a7356ed1a0219bb788e0e498b74c61c5e6", @"/Areas/Admin/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b88735fcb76687533fa848e18cb76dff3784b38", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("media", new global::Microsoft.AspNetCore.Html.HtmlString("all"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/css/style4.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/css/fontawesome-all.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline mx-auto search-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/js/jquery-2.2.3.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\Shared\_Layout.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(29, 213, true);
            WriteLiteral("\r\n<!--\r\nAuthor: W3layouts\r\nAuthor URL: http://w3layouts.com\r\nLicense: Creative Commons Attribution 3.0 Unported\r\nLicense URL: http://creativecommons.org/licenses/by/3.0/\r\n-->\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            EndContext();
            BeginContext(242, 1567, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70d8ebb9e6fd4629a84c41945e70b4e4", async() => {
                BeginContext(248, 811, true);
                WriteLiteral(@"
    <title>Modernize an Admin Panel Category Bootstrap Responsive Web Template | Blank page :: w3layouts</title>
    <!-- Meta Tags -->
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <meta charset=""utf-8"">
    <meta name=""keywords"" content=""Modernize Responsive web template, Bootstrap Web Templates, Flat Web Templates, Android Compatible web template,
Smartphone Compatible web template, free webdesigns for Nokia, Samsung, LG, Sony Ericsson, Motorola web design"" />
    <script>
        addEventListener(""load"", function () {
            setTimeout(hideURLbar, 0);
        }, false);

        function hideURLbar() {
            window.scrollTo(0, 1);
        }
    </script>
    <!-- //Meta Tags -->
    <!-- Style-sheets -->
    <!-- Bootstrap Css -->
    ");
                EndContext();
                BeginContext(1059, 86, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a2145ad2f7dc4c1a908d5fde51975f67", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1145, 59, true);
                WriteLiteral("\r\n    <!-- Bootstrap Css -->\r\n    <!-- Common Css -->\r\n    ");
                EndContext();
                BeginContext(1204, 82, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "63ef26b911444f81a0e6e8bde511b2cb", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1286, 55, true);
                WriteLiteral("\r\n    <!--// Common Css -->\r\n    <!-- Nav Css -->\r\n    ");
                EndContext();
                BeginContext(1341, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4bcb54a11abc451f8bb3cf6edc709bc1", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1394, 60, true);
                WriteLiteral("\r\n    <!--// Nav Css -->\r\n    <!-- Fontawesome Css -->\r\n    ");
                EndContext();
                BeginContext(1454, 62, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "fe095244b7ac413799881b1760285be2", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1516, 286, true);
                WriteLiteral(@"
    <!--// Fontawesome Css -->
    <!--// Style-sheets -->
    <!--web-fonts-->
    <link href=""//fonts.googleapis.com/css?family=Poiret+One"" rel=""stylesheet"">
    <link href=""//fonts.googleapis.com/css?family=Open+Sans:300,400,600,700"" rel=""stylesheet"">
    <!--//web-fonts-->
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1809, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(1813, 15309, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbef828a77284f69b0189e28a1d90fa3", async() => {
                BeginContext(1819, 5127, true);
                WriteLiteral(@"
    <div class=""wrapper"">
        <!-- Sidebar Holder -->
        <nav id=""sidebar"">
            <div class=""sidebar-header"">
                <h1>
                    <a href=""index.html"">Modernize</a>
                </h1>
                <span>M</span>
            </div>
            <div class=""profile-bg""></div>
            <ul class=""list-unstyled components"">
                <li>
                    <a href=""index.html"">
                        <i class=""fas fa-th-large""></i>
                        Dashboard
                    </a>
                </li>
                <li>
                    <a href=""#homeSubmenu"" data-toggle=""collapse"" aria-expanded=""false"">
                        <i class=""fas fa-laptop""></i>
                        Components
                        <i class=""fas fa-angle-down fa-pull-right""></i>
                    </a>
                    <ul class=""collapse list-unstyled"" id=""homeSubmenu"">
                        <li>
                            <a h");
                WriteLiteral(@"ref=""cards.html"">Cards</a>
                        </li>
                        <li>
                            <a href=""carousels.html"">Carousels</a>
                        </li>
                        <li>
                            <a href=""forms.html"">Forms</a>
                        </li>
                        <li>
                            <a href=""modals.html"">Modals</a>
                        </li>
                        <li>
                            <a href=""tables.html"">Tables</a>
                        </li>
                    </ul>
                </li>
                <li>
                    <a href=""charts.html"">
                        <i class=""fas fa-chart-pie""></i>
                        Charts
                    </a>
                </li>
                <li>
                    <a href=""grids.html"">
                        <i class=""fas fa-th""></i>
                        Grid Layouts
                    </a>
                </li>
           ");
                WriteLiteral(@"     <li class=""active"">
                    <a href=""#pageSubmenu1"" data-toggle=""collapse"" aria-expanded=""false"">
                        <i class=""far fa-file""></i>
                        Pages
                        <i class=""fas fa-angle-down fa-pull-right""></i>
                    </a>
                    <ul class=""collapse list-unstyled"" id=""pageSubmenu1"">
                        <li>
                            <a href=""404.html"">404</a>
                        </li>
                        <li>
                            <a href=""500.html"">500</a>
                        </li>
                        <li>
                            <a href=""blank.html"">Blank</a>
                        </li>
                    </ul>
                </li>
                <li>
                    <a href=""mailbox.html"">
                        <i class=""far fa-envelope""></i>
                        Mailbox
                        <span class=""badge badge-secondary float-md-right bg-danger"">5 ");
                WriteLiteral(@"New</span>
                    </a>
                </li>
                <li>
                    <a href=""widgets.html"">
                        <i class=""far fa-window-restore""></i>
                        Widgets
                    </a>
                </li>
                <li>
                    <a href=""pricing.html"">
                        <i class=""fas fa-table""></i>
                        Pricing Tables
                    </a>
                </li>
                <li>
                    <a href=""#pageSubmenu3"" data-toggle=""collapse"" aria-expanded=""false"">
                        <i class=""fas fa-users""></i>
                        User
                        <i class=""fas fa-angle-down fa-pull-right""></i>
                    </a>
                    <ul class=""collapse list-unstyled"" id=""pageSubmenu3"">
                        <li>
                            <a href=""login.html"">Login</a>
                        </li>
                        <li>
                   ");
                WriteLiteral(@"         <a href=""register.html"">Register</a>
                        </li>
                        <li>
                            <a href=""forgot.html"">Forgot password</a>
                        </li>
                    </ul>
                </li>
                <li>
                    <a href=""maps.html"">
                        <i class=""far fa-map""></i>
                        Maps
                    </a>
                </li>
            </ul>
        </nav>

        <!-- Page Content Holder -->
        <div id=""content"">
            <!-- top-bar -->
            <nav class=""navbar navbar-default mb-xl-5 mb-4"">
                <div class=""container-fluid"">

                    <div class=""navbar-header"">
                        <button type=""button"" id=""sidebarCollapse"" class=""btn btn-info navbar-btn"">
                            <i class=""fas fa-bars""></i>
                        </button>
                    </div>
                    <!-- Search-from -->
             ");
                WriteLiteral("       ");
                EndContext();
                BeginContext(6946, 327, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7b33d66b64b44909687a76009fce4c5", async() => {
                    BeginContext(7017, 249, true);
                    WriteLiteral("\r\n                        <input class=\"form-control mr-sm-2\" type=\"search\" placeholder=\"Search\" aria-label=\"Search\" required=\"\">\r\n                        <button class=\"btn btn-style my-2 my-sm-0\" type=\"submit\">Search</button>\r\n                    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7273, 8701, true);
                WriteLiteral(@"
                    <!--// Search-from -->
                    <ul class=""top-icons-agileits-w3layouts float-right"">
                        <li class=""nav-item dropdown"">
                            <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbarDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true""
                               aria-expanded=""false"">
                                <i class=""far fa-bell""></i>
                                <span class=""badge"">4</span>
                            </a>
                            <div class=""dropdown-menu top-grid-scroll drop-1"">
                                <h3 class=""sub-title-w3-agileits"">User notifications</h3>
                                <a href=""#"" class=""dropdown-item mt-3"">
                                    <div class=""notif-img-agileinfo"">
                                        <img src=""images/clone.jpg"" class=""img-fluid"" alt=""Responsive image"">
                                    </div>
             ");
                WriteLiteral(@"                       <div class=""notif-content-wthree"">
                                        <p class=""paragraph-agileits-w3layouts py-2"">
                                            <span class=""text-diff"">John Doe</span> Curabitur non nulla sit amet nisl tempus convallis quis ac lectus.
                                        </p>
                                        <h6>4 mins ago</h6>
                                    </div>
                                </a>
                                <a href=""#"" class=""dropdown-item mt-3"">
                                    <div class=""notif-img-agileinfo"">
                                        <img src=""images/clone.jpg"" class=""img-fluid"" alt=""Responsive image"">
                                    </div>
                                    <div class=""notif-content-wthree"">
                                        <p class=""paragraph-agileits-w3layouts py-2"">
                                            <span class=""text-diff"">Diana</span");
                WriteLiteral(@"> Curabitur non nulla sit amet nisl tempus convallis quis ac lectus.
                                        </p>
                                        <h6>6 mins ago</h6>
                                    </div>
                                </a>
                                <a href=""#"" class=""dropdown-item mt-3"">
                                    <div class=""notif-img-agileinfo"">
                                        <img src=""images/clone.jpg"" class=""img-fluid"" alt=""Responsive image"">
                                    </div>
                                    <div class=""notif-content-wthree"">
                                        <p class=""paragraph-agileits-w3layouts py-2"">
                                            <span class=""text-diff"">Steffie</span> Curabitur non nulla sit amet nisl tempus convallis quis ac lectus.
                                        </p>
                                        <h6>12 mins ago</h6>
                                    </div>
    ");
                WriteLiteral(@"                            </a>
                                <a href=""#"" class=""dropdown-item mt-3"">
                                    <div class=""notif-img-agileinfo"">
                                        <img src=""images/clone.jpg"" class=""img-fluid"" alt=""Responsive image"">
                                    </div>
                                    <div class=""notif-content-wthree"">
                                        <p class=""paragraph-agileits-w3layouts py-2"">
                                            <span class=""text-diff"">Jack</span> Curabitur non nulla sit amet nisl tempus convallis quis ac lectus.
                                        </p>
                                        <h6>1 days ago</h6>
                                    </div>
                                </a>
                                <div class=""dropdown-divider""></div>
                                <a class=""dropdown-item"" href=""#"">view all notifications</a>
                            </d");
                WriteLiteral(@"iv>
                        </li>
                        <li class=""nav-item dropdown mx-3"">
                            <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbarDropdown1"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true""
                               aria-expanded=""false"">
                                <i class=""fas fa-spinner""></i>
                            </a>
                            <div class=""dropdown-menu top-grid-scroll drop-2"">
                                <h3 class=""sub-title-w3-agileits"">Shortcuts</h3>
                                <a href=""#"" class=""dropdown-item mt-3"">
                                    <h4>
                                        <i class=""fas fa-chart-pie mr-3""></i>Sed feugiat
                                    </h4>
                                </a>
                                <a href=""#"" class=""dropdown-item mt-3"">
                                    <h4>
                                        <i class=""fab fa-c");
                WriteLiteral(@"onnectdevelop mr-3""></i>Aliquam sed
                                    </h4>
                                </a>
                                <a href=""#"" class=""dropdown-item mt-3"">
                                    <h4>
                                        <i class=""fas fa-tasks mr-3""></i>Lorem ipsum
                                    </h4>
                                </a>
                                <a href=""#"" class=""dropdown-item mt-3"">
                                    <h4>
                                        <i class=""fab fa-superpowers mr-3""></i>Cras rutrum
                                    </h4>
                                </a>
                            </div>
                        </li>
                        <li class=""nav-item dropdown"">
                            <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbarDropdown2"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true""
                               aria-expanded=""false"">
     ");
                WriteLiteral(@"                           <i class=""far fa-user""></i>
                            </a>
                            <div class=""dropdown-menu drop-3"">
                                <div class=""profile d-flex mr-o"">
                                    <div class=""profile-l align-self-center"">
                                        <img src=""images/profile.jpg"" class=""img-fluid mb-3"" alt=""Responsive image"">
                                    </div>
                                    <div class=""profile-r align-self-center"">
                                        <h3 class=""sub-title-w3-agileits"">Will Smith</h3>
                                        <a href=""mailto:info@example.com"">info@example.com</a>
                                    </div>
                                </div>
                                <a href=""#"" class=""dropdown-item mt-3"">
                                    <h4>
                                        <i class=""far fa-user mr-3""></i>My Profile
             ");
                WriteLiteral(@"                       </h4>
                                </a>
                                <a href=""#"" class=""dropdown-item mt-3"">
                                    <h4>
                                        <i class=""fas fa-link mr-3""></i>Activity
                                    </h4>
                                </a>
                                <a href=""#"" class=""dropdown-item mt-3"">
                                    <h4>
                                        <i class=""far fa-envelope mr-3""></i>Messages
                                    </h4>
                                </a>
                                <a href=""#"" class=""dropdown-item mt-3"">
                                    <h4>
                                        <i class=""far fa-question-circle mr-3""></i>Faq
                                    </h4>
                                </a>
                                <a href=""#"" class=""dropdown-item mt-3"">
                                    <h4");
                WriteLiteral(@">
                                        <i class=""far fa-thumbs-up mr-3""></i>Support
                                    </h4>
                                </a>
                                <div class=""dropdown-divider""></div>
                                <a class=""dropdown-item"" href=""login.html"">Logout</a>
                            </div>
                        </li>
                    </ul>
                </div>
            </nav>
            <!--// top-bar -->
            ");
                EndContext();
                BeginContext(15975, 12, false);
#line 321 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(15987, 71, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n\r\n    <!-- Required common Js -->\r\n    ");
                EndContext();
                BeginContext(16058, 54, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3854c0c8e2804f308a9a298b9f16180d", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(16112, 1003, true);
                WriteLiteral(@"
    
    <!-- //Required common Js -->
    <!-- Sidebar-nav Js -->
    <script>
        $(document).ready(function () {
            $('#sidebarCollapse').on('click', function () {
                $('#sidebar').toggleClass('active');
            });
        });
    </script>
    <!--// Sidebar-nav Js -->
    <!-- dropdown nav -->
    <script>
        $(document).ready(function () {
            $("".dropdown"").hover(
                function () {
                    $('.dropdown-menu', this).stop(true, true).slideDown(""fast"");
                    $(this).toggleClass('open');
                },
                function () {
                    $('.dropdown-menu', this).stop(true, true).slideUp(""fast"");
                    $(this).toggleClass('open');
                }
            );
        });
    </script>
    <!-- //dropdown nav -->
    <!-- Js for bootstrap working-->
    <script src=""js/bootstrap.min.js""></script>
    <!-- //Js for bootstrap working -->

");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(17122, 13, true);
            WriteLiteral("\r\n\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
