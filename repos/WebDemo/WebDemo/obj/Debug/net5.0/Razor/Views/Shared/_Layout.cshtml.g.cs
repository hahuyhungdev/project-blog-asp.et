#pragma checksum "D:\backup\GitHub\source\repos\WebDemo\WebDemo\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05695e92449ffb36fedccc24547008f28aba3166"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "D:\backup\GitHub\source\repos\WebDemo\WebDemo\Views\_ViewImports.cshtml"
using WebDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\backup\GitHub\source\repos\WebDemo\WebDemo\Views\_ViewImports.cshtml"
using WebDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05695e92449ffb36fedccc24547008f28aba3166", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e04abde5ba65d2c6a681f80a959e4ef1b4774d9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-flex search-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en-US\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05695e92449ffb36fedccc24547008f28aba31663879", async() => {
                WriteLiteral(@"
    <meta http-equiv=""Content-Type"" content=""text/html; charset=UTF-8"">
    <title>Katen - Minimal Blog & Magazine HTML Theme</title>
    <meta name=""description"" content=""Katen - Minimal Blog & Magazine HTML Theme"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, maximum-scale=1"">
    <link rel=""shortcut icon"" type=""image/x-icon"" href=""images/favicon.png"">

    <!-- STYLES -->
    <link rel=""stylesheet"" href=""css/bootstrap.min.css"" type=""text/css"" media=""all"">
    <link rel=""stylesheet"" href=""css/all.min.css"" type=""text/css"" media=""all"">
    <link rel=""stylesheet"" href=""css/slick.css"" type=""text/css"" media=""all"">
    <link rel=""stylesheet"" href=""css/simple-line-icons.css"" type=""text/css"" media=""all"">
    <link rel=""stylesheet"" href=""css/style.css"" type=""text/css"" media=""all"">

    <!--[if lt IE 9]>
      <script src=""https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js""></script>
      <script src=""https://oss.maxcdn.com/respond/1.4.2/respond.min.js""></script>
   ");
                WriteLiteral(" <![endif]-->\r\n\r\n");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05695e92449ffb36fedccc24547008f28aba31665988", async() => {
                WriteLiteral(@"

    <!-- preloader -->
    <div id=""preloader"">
        <div class=""book"">
            <div class=""inner"">
                <div class=""left""></div>
                <div class=""middle""></div>
                <div class=""right""></div>
            </div>
            <ul>
                <li></li>
                <li></li>
                <li></li>
                <li></li>
                <li></li>
                <li></li>
                <li></li>
                <li></li>
                <li></li>
                <li></li>
                <li></li>
                <li></li>
                <li></li>
                <li></li>
                <li></li>
                <li></li>
                <li></li>
                <li></li>
            </ul>
        </div>
    </div>

    <!-- site wrapper -->
    <div class=""site-wrapper"">

        <div class=""main-overlay""></div>

        <!-- header -->
        <header class=""header-default"">
            <nav class=""navbar navba");
                WriteLiteral(@"r-expand-lg"">
                <div class=""container-xl"">
                    <!-- site logo -->
                    <a class=""navbar-brand"" href=""index.html""><img src=""images/logo.svg"" alt=""logo"" /></a>

                    <div class=""collapse navbar-collapse"">
                        <!-- menus -->
                        <ul class=""navbar-nav mr-auto"">
                            <li class=""nav-item active"">
                                <a class=""nav-link"" href=""/"">Home</a>
                            </li>
                             <li class=""nav-item dropdown"">
                                <a class=""nav-link dropdown-toggle"" href=""#"">Page</a>
                                ");
#nullable restore
#line 77 "D:\backup\GitHub\source\repos\WebDemo\WebDemo\Views\Shared\_Layout.cshtml"
                           Write(await Component.InvokeAsync("Nav"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link"" href=""/lien-he.html"">Liên hệ</a>
                            </li>
                        </ul>
                    </div>

                    <!-- header right section -->
                    <div class=""header-right"">
                        <!-- social icons -->
                        ");
#nullable restore
#line 88 "D:\backup\GitHub\source\repos\WebDemo\WebDemo\Views\Shared\_Layout.cshtml"
                   Write(await Component.InvokeAsync("Social"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                        <div class=""header-buttons"">
                            <button class=""search icon-button"">
                                <i class=""icon-magnifier""></i>
                            </button>
                            <button class=""burger-menu icon-button"">
                                <span class=""burger-icon""></span>
                            </button>
                        </div>
                    </div>
                </div>
            </nav>
        </header>

    ");
#nullable restore
#line 103 "D:\backup\GitHub\source\repos\WebDemo\WebDemo\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

        <!-- footer -->
        <footer>
            <div class=""container-xl"">
                <div class=""footer-inner"">
                    <div class=""row d-flex align-items-center gy-4"">
                        <!-- copyright text -->
                        <div class=""col-md-4"">
                            <span class=""copyright"">© 2021 Katen. Template by ThemeGer.</span>
                        </div>

                        <!-- social icons -->
                        <div class=""col-md-4 text-center"">
                            <ul class=""social-icons list-unstyled list-inline mb-0"">
                                <li class=""list-inline-item""><a href=""#""><i class=""fab fa-facebook-f""></i></a></li>
                                <li class=""list-inline-item""><a href=""#""><i class=""fab fa-twitter""></i></a></li>
                                <li class=""list-inline-item""><a href=""#""><i class=""fab fa-instagram""></i></a></li>
                                <li class=""list-inline-i");
                WriteLiteral(@"tem""><a href=""#""><i class=""fab fa-pinterest""></i></a></li>
                                <li class=""list-inline-item""><a href=""#""><i class=""fab fa-medium""></i></a></li>
                                <li class=""list-inline-item""><a href=""#""><i class=""fab fa-youtube""></i></a></li>
                            </ul>
                        </div>

                        <!-- go to top button -->
                        <div class=""col-md-4"">
                            <a href=""#"" id=""return-to-top"" class=""float-md-end""><i class=""icon-arrow-up""></i>Back to Top</a>
                        </div>
                    </div>
                </div>
            </div>
        </footer>

    </div><!-- end site wrapper -->
    <!-- search popup area -->
    <div class=""search-popup"">
        <!-- close button -->
        <button type=""button"" class=""btn-close"" aria-label=""Close""></button>
        <!-- content -->
        <div class=""search-content"">
            <div class=""text-center"">
     ");
                WriteLiteral("           <h3 class=\"mb-4 mt-0\">Press ESC to close</h3>\r\n            </div>\r\n            <!-- form -->\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05695e92449ffb36fedccc24547008f28aba316612097", async() => {
                    WriteLiteral("\r\n                <input class=\"form-control me-2\" type=\"search\" placeholder=\"Search and press enter ...\" aria-label=\"Search\">\r\n                <button class=\"btn btn-default btn-lg\" type=\"submit\"><i class=\"icon-magnifier\"></i></button>\r\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
        </div>
    </div>

    <!-- canvas menu -->
    <div class=""canvas-menu d-flex align-items-end flex-column"">
        <!-- close button -->
        <button type=""button"" class=""btn-close"" aria-label=""Close""></button>

        <!-- logo -->
        <div class=""logo"">
            <img src=""images/logo.svg"" alt=""Katen"" />
        </div>

        <!-- menu -->
        <nav>
            <ul class=""vertical-menu"">
                <li class=""active"">
                    <a href=""/"">Home</a>
                </li>
                <li>
                    <a href=""#"">Pages</a>
                    ");
#nullable restore
#line 172 "D:\backup\GitHub\source\repos\WebDemo\WebDemo\Views\Shared\_Layout.cshtml"
               Write(await Component.InvokeAsync("NavMobi"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </li>\r\n                <li><a href=\"/lien-he.html\">Liên hệ</a></li>\r\n            </ul>\r\n        </nav>\r\n\r\n        <!-- social icons -->\r\n        ");
#nullable restore
#line 179 "D:\backup\GitHub\source\repos\WebDemo\WebDemo\Views\Shared\_Layout.cshtml"
   Write(await Component.InvokeAsync("Social"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    </div>

    <!-- JAVA SCRIPTS -->
    <script src=""js/jquery.min.js""></script>
    <script src=""js/popper.min.js""></script>
    <script src=""js/bootstrap.min.js""></script>
    <script src=""js/slick.min.js""></script>
    <script src=""js/jquery.sticky-sidebar.min.js""></script>
    <script src=""js/custom.js""></script>

");
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
            WriteLiteral("\r\n</html>");
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
