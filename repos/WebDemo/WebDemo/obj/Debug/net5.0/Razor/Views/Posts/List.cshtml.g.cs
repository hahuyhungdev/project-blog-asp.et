#pragma checksum "D:\backup\GitHub\source\repos\WebDemo\WebDemo\Views\Posts\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2bd55015c97ba19e26bdb7bd85373caafc79597"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Posts_List), @"mvc.1.0.view", @"/Views/Posts/List.cshtml")]
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
#nullable restore
#line 1 "D:\backup\GitHub\source\repos\WebDemo\WebDemo\Views\Posts\List.cshtml"
using PagedList.Core.Mvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2bd55015c97ba19e26bdb7bd85373caafc79597", @"/Views/Posts/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e04abde5ba65d2c6a681f80a959e4ef1b4774d9", @"/Views/_ViewImports.cshtml")]
    public class Views_Posts_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedList.Core.IPagedList<WebDemo.Models.Post>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("pager-container"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Posts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::PagedList.Core.Mvc.PagerTagHelper __PagedList_Core_Mvc_PagerTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\backup\GitHub\source\repos\WebDemo\WebDemo\Views\Posts\List.cshtml"
  
    Category category = ViewBag.DanhMuc;
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""page-header"">
    <div class=""container-xl"">
        <div class=""text-center"">
            <h1 class=""mt-0 mb-2"">Lifestyle</h1>
            <nav aria-label=""breadcrumb"">
                <ol class=""breadcrumb justify-content-center mb-0"">
                    <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
                    <li class=""breadcrumb-item active"" aria-current=""page"">Lifestyle</li>
                </ol>
            </nav>
        </div>
    </div>
</section>

<!-- section main content -->
<section class=""main-content"">
    <div class=""container-xl"">

        <div class=""row gy-4"">

            <div class=""col-lg-8"">

                <div class=""row gy-4"">
");
#nullable restore
#line 33 "D:\backup\GitHub\source\repos\WebDemo\WebDemo\Views\Posts\List.cshtml"
                     if (Model != null && Model.Count() > 0)
                    {
                        foreach (var item in Model)
                        {

                            string url = $"/{item.Alias}.html";

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-sm-6\">\r\n                                <div class=\"post post-grid rounded bordered\">\r\n                                    <div class=\"thumb top-rounded\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 1410, "\"", 1433, 2);
            WriteAttributeValue("", 1417, "/", 1417, 1, true);
#nullable restore
#line 42 "D:\backup\GitHub\source\repos\WebDemo\WebDemo\Views\Posts\List.cshtml"
WriteAttributeValue("", 1418, item.Cat.Alias, 1418, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"category-badge position-absolute\">");
#nullable restore
#line 42 "D:\backup\GitHub\source\repos\WebDemo\WebDemo\Views\Posts\List.cshtml"
                                                                                                       Write(item.Cat.CatName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                        <span class=\"post-format\">\r\n                                            <i class=\"icon-picture\"></i>\r\n                                        </span>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 1732, "\"", 1743, 1);
#nullable restore
#line 46 "D:\backup\GitHub\source\repos\WebDemo\WebDemo\Views\Posts\List.cshtml"
WriteAttributeValue("", 1739, url, 1739, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <div class=\"inner\">\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d2bd55015c97ba19e26bdb7bd85373caafc795977841", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1870, "~/images/posts/", 1870, 15, true);
#nullable restore
#line 48 "D:\backup\GitHub\source\repos\WebDemo\WebDemo\Views\Posts\List.cshtml"
AddHtmlAttributeValue("", 1885, item.Thumb, 1885, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 48 "D:\backup\GitHub\source\repos\WebDemo\WebDemo\Views\Posts\List.cshtml"
AddHtmlAttributeValue("", 1903, item.Title, 1903, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                            </div>
                                        </a>
                                    </div>
                                    <div class=""details"">
                                        <ul class=""meta list-inline mb-0"">
                                            <li class=""list-inline-item""><a href=""#""><img src=""images/other/author-sm.png"" class=""author""");
            BeginWriteAttribute("alt", " alt=\"", 2334, "\"", 2351, 1);
#nullable restore
#line 54 "D:\backup\GitHub\source\repos\WebDemo\WebDemo\Views\Posts\List.cshtml"
WriteAttributeValue("", 2340, item.Title, 2340, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />");
#nullable restore
#line 54 "D:\backup\GitHub\source\repos\WebDemo\WebDemo\Views\Posts\List.cshtml"
                                                                                                                                                         Write(item.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                                            <li class=\"list-inline-item\">");
#nullable restore
#line 55 "D:\backup\GitHub\source\repos\WebDemo\WebDemo\Views\Posts\List.cshtml"
                                                                    Write(item.CreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                        </ul>\r\n                                        <h5 class=\"post-title mb-3 mt-3\"><a");
            BeginWriteAttribute("href", " href=\"", 2596, "\"", 2607, 1);
#nullable restore
#line 57 "D:\backup\GitHub\source\repos\WebDemo\WebDemo\Views\Posts\List.cshtml"
WriteAttributeValue("", 2603, url, 2603, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 57 "D:\backup\GitHub\source\repos\WebDemo\WebDemo\Views\Posts\List.cshtml"
                                                                                   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h5>\r\n                                        <p class=\"excerpt mb-0\">");
#nullable restore
#line 58 "D:\backup\GitHub\source\repos\WebDemo\WebDemo\Views\Posts\List.cshtml"
                                                           Write(item.Scontent);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                    </div>
                                    <div class=""post-bottom clearfix d-flex align-items-center"">
                                        <div class=""social-share me-auto"">
                                            <button class=""toggle-button icon-share""></button>
                                            <ul class=""icons list-unstyled list-inline mb-0"">
                                                <li class=""list-inline-item""><a href=""#""><i class=""fab fa-facebook-f""></i></a></li>
                                                <li class=""list-inline-item""><a href=""#""><i class=""fab fa-twitter""></i></a></li>
                                                <li class=""list-inline-item""><a href=""#""><i class=""fab fa-linkedin-in""></i></a></li>
                                                <li class=""list-inline-item""><a href=""#""><i class=""fab fa-pinterest""></i></a></li>
                                                <li class=""list-inline-item""><a ");
            WriteLiteral(@"href=""#""><i class=""fab fa-telegram-plane""></i></a></li>
                                                <li class=""list-inline-item""><a href=""#""><i class=""far fa-envelope""></i></a></li>
                                            </ul>
                                        </div>
                                        <div class=""more-button float-end"">
                                            <a");
            BeginWriteAttribute("href", " href=\"", 4143, "\"", 4154, 1);
#nullable restore
#line 73 "D:\backup\GitHub\source\repos\WebDemo\WebDemo\Views\Posts\List.cshtml"
WriteAttributeValue("", 4150, url, 4150, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><span class=\"icon-options\"></span></a>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 78 "D:\backup\GitHub\source\repos\WebDemo\WebDemo\Views\Posts\List.cshtml"

                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                </div>\r\n\r\n                <div aria-label=\"Page navigation example\">\r\n                    <ul class=\"pagination\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("pager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d2bd55015c97ba19e26bdb7bd85373caafc7959714861", async() => {
            }
            );
            __PagedList_Core_Mvc_PagerTagHelper = CreateTagHelper<global::PagedList.Core.Mvc.PagerTagHelper>();
            __tagHelperExecutionContext.Add(__PagedList_Core_Mvc_PagerTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 88 "D:\backup\GitHub\source\repos\WebDemo\WebDemo\Views\Posts\List.cshtml"
__PagedList_Core_Mvc_PagerTagHelper.Options = PagedListRenderOptions.Bootstrap4PageNumbersOnly;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("options", __PagedList_Core_Mvc_PagerTagHelper.Options, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 88 "D:\backup\GitHub\source\repos\WebDemo\WebDemo\Views\Posts\List.cshtml"
__PagedList_Core_Mvc_PagerTagHelper.List = Model;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("list", __PagedList_Core_Mvc_PagerTagHelper.List, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__PagedList_Core_Mvc_PagerTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Alias", "PagedList.Core.Mvc.PagerTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 88 "D:\backup\GitHub\source\repos\WebDemo\WebDemo\Views\Posts\List.cshtml"
                                                                                                                                      WriteLiteral(category.Alias);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __PagedList_Core_Mvc_PagerTagHelper.RouteValues["Alias"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Alias", __PagedList_Core_Mvc_PagerTagHelper.RouteValues["Alias"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __PagedList_Core_Mvc_PagerTagHelper.AspArea = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __PagedList_Core_Mvc_PagerTagHelper.AspController = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __PagedList_Core_Mvc_PagerTagHelper.AspAction = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                    </ul>
                </div>

            </div>
            <div class=""col-lg-4"">

                <!-- sidebar -->
                <div class=""sidebar"">
                    <!-- widget about -->
                    <div class=""widget rounded"">
                        <div class=""widget-about data-bg-image text-center"" data-bg-image=""images/map-bg.png"">
                            <img src=""images/logo.svg"" alt=""logo"" class=""mb-4"" />
                            <p class=""mb-4"">Hello, We’re content writer who is fascinated by content fashion, celebrity and lifestyle. We helps clients bring the right content to the right people.</p>
                            <ul class=""social-icons list-unstyled list-inline mb-0"">
                                <li class=""list-inline-item""><a href=""#""><i class=""fab fa-facebook-f""></i></a></li>
                                <li class=""list-inline-item""><a href=""#""><i class=""fab fa-twitter""></i></a></li>
                             ");
            WriteLiteral(@"   <li class=""list-inline-item""><a href=""#""><i class=""fab fa-instagram""></i></a></li>
                                <li class=""list-inline-item""><a href=""#""><i class=""fab fa-pinterest""></i></a></li>
                                <li class=""list-inline-item""><a href=""#""><i class=""fab fa-medium""></i></a></li>
                                <li class=""list-inline-item""><a href=""#""><i class=""fab fa-youtube""></i></a></li>
                            </ul>
                        </div>
                    </div>

                    <!-- widget popular posts -->

                    ");
#nullable restore
#line 116 "D:\backup\GitHub\source\repos\WebDemo\WebDemo\Views\Posts\List.cshtml"
               Write(await Component.InvokeAsync("Popular"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"



                    <!-- widget categories -->
                    <div class=""widget rounded"">
                        <div class=""widget-header text-center"">
                            <h3 class=""widget-title"">Explore Topics</h3>
                            <img src=""images/wave.svg"" class=""wave"" alt=""wave"" />
                        </div>
                        ");
#nullable restore
#line 126 "D:\backup\GitHub\source\repos\WebDemo\WebDemo\Views\Posts\List.cshtml"
                   Write(await Component.InvokeAsync("Categories"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>

                    <!-- widget post carousel -->
                    <div class=""widget rounded"">
                        <div class=""widget-header text-center"">
                            <h3 class=""widget-title"">Celebration</h3>
                            <img src=""images/wave.svg"" class=""wave"" alt=""wave"" />
                        </div>
                        <div class=""widget-content"">
                            <div class=""post-carousel-widget"">
                                <!-- post -->
                                <div class=""post post-carousel"">
                                    <div class=""thumb rounded"">
                                        <a href=""#"" class=""category-badge position-absolute"">How to</a>
                                        <a href=""#"">
                                            <div class=""inner"">
                                                <img src=""images/widgets/widget-carousel-1.jpg"" alt=""post-title"" />
   ");
            WriteLiteral(@"                                         </div>
                                        </a>
                                    </div>
                                    <h5 class=""post-title mb-0 mt-4""><a href=""#"">5 Easy Ways You Can Turn Future Into Success</a></h5>
                                    <ul class=""meta list-inline mt-2 mb-0"">
                                        <li class=""list-inline-item""><a href=""#"">Katen Doe</a></li>
                                        <li class=""list-inline-item"">29 March 2021</li>
                                    </ul>
                                </div>
                                <!-- post -->
                                <div class=""post post-carousel"">
                                    <div class=""thumb rounded"">
                                        <a href=""#"" class=""category-badge position-absolute"">Trending</a>
                                        <a href=""#"">
                                            <div class=""inne");
            WriteLiteral(@"r"">
                                                <img src=""images/widgets/widget-carousel-2.jpg"" alt=""post-title"" />
                                            </div>
                                        </a>
                                    </div>
                                    <h5 class=""post-title mb-0 mt-4""><a href=""#"">Master The Art Of Nature With These 7 Tips</a></h5>
                                    <ul class=""meta list-inline mt-2 mb-0"">
                                        <li class=""list-inline-item""><a href=""#"">Katen Doe</a></li>
                                        <li class=""list-inline-item"">29 March 2021</li>
                                    </ul>
                                </div>
                                <!-- post -->
                                <div class=""post post-carousel"">
                                    <div class=""thumb rounded"">
                                        <a href=""#"" class=""category-badge position-absolute"">How t");
            WriteLiteral(@"o</a>
                                        <a href=""#"">
                                            <div class=""inner"">
                                                <img src=""images/widgets/widget-carousel-1.jpg"" alt=""post-title"" />
                                            </div>
                                        </a>
                                    </div>
                                    <h5 class=""post-title mb-0 mt-4""><a href=""#"">5 Easy Ways You Can Turn Future Into Success</a></h5>
                                    <ul class=""meta list-inline mt-2 mb-0"">
                                        <li class=""list-inline-item""><a href=""#"">Katen Doe</a></li>
                                        <li class=""list-inline-item"">29 March 2021</li>
                                    </ul>
                                </div>
                            </div>
                            <!-- carousel arrows -->
                            <div class=""slick-arrows-bot"">
   ");
            WriteLiteral(@"                             <button type=""button"" data-role=""none"" class=""carousel-botNav-prev slick-custom-buttons"" aria-label=""Previous""><i class=""icon-arrow-left""></i></button>
                                <button type=""button"" data-role=""none"" class=""carousel-botNav-next slick-custom-buttons"" aria-label=""Next""><i class=""icon-arrow-right""></i></button>
                            </div>
                        </div>
                    </div>

                    <!-- widget advertisement -->
                    <div class=""widget no-container rounded text-md-center"">
                        <span class=""ads-title"">- Sponsored Ad -</span>
                        <a href=""#"" class=""widget-ads"">
                            <img src=""images/ads/ad-360.png"" alt=""Advertisement"" />
                        </a>
                    </div>

                    <!-- widget tags -->
                    <div class=""widget rounded"">
                        <div class=""widget-header text-center"">
 ");
            WriteLiteral(@"                           <h3 class=""widget-title"">Tag Clouds</h3>
                            <img src=""images/wave.svg"" class=""wave"" alt=""wave"" />
                        </div>
                        <div class=""widget-content"">
                            <a href=""#"" class=""tag"">#Trending</a>
                            <a href=""#"" class=""tag"">#Video</a>
                            <a href=""#"" class=""tag"">#Featured</a>
                            <a href=""#"" class=""tag"">#Gallery</a>
                            <a href=""#"" class=""tag"">#Celebrities</a>
                        </div>
                    </div>
                </div>

            </div>

        </div>

    </div>
</section>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedList.Core.IPagedList<WebDemo.Models.Post>> Html { get; private set; }
    }
}
#pragma warning restore 1591