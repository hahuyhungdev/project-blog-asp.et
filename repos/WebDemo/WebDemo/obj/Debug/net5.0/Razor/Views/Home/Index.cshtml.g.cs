#pragma checksum "D:\backup\GitHub\source\repos\WebDemo\WebDemo\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd13e8f0826d34a7322fee2dbc7c1ab8bd071941"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd13e8f0826d34a7322fee2dbc7c1ab8bd071941", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e04abde5ba65d2c6a681f80a959e4ef1b4774d9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebDemo.ModelsView.HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\backup\GitHub\source\repos\WebDemo\WebDemo\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section id=\"hero\">\r\n\r\n    <div class=\"container-xl\">\r\n\r\n        <div class=\"row gy-4\">\r\n");
#nullable restore
#line 11 "D:\backup\GitHub\source\repos\WebDemo\WebDemo\Views\Home\Index.cshtml"
             if (Model.Featured != null)
            {
                string url = $"/{Model.Featured.Alias}.html";

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-8\">\r\n\r\n\r\n                    <!-- featured post large -->\r\n                    <div class=\"post featured-post-lg\">\r\n                        <div class=\"details clearfix\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 534, "\"", 563, 2);
            WriteAttributeValue("", 541, "/", 541, 1, true);
#nullable restore
#line 20 "D:\backup\GitHub\source\repos\WebDemo\WebDemo\Views\Home\Index.cshtml"
WriteAttributeValue("", 542, Model.Featured.Alias, 542, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"category-badge\">");
#nullable restore
#line 20 "D:\backup\GitHub\source\repos\WebDemo\WebDemo\Views\Home\Index.cshtml"
                                                                               Write(Model.Featured.Cat.CatName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            <h2 class=\"post-title\"><a");
            BeginWriteAttribute("href", " href=\"", 674, "\"", 686, 2);
#nullable restore
#line 21 "D:\backup\GitHub\source\repos\WebDemo\WebDemo\Views\Home\Index.cshtml"
WriteAttributeValue("", 681, url, 681, 4, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 685, "", 686, 1, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 21 "D:\backup\GitHub\source\repos\WebDemo\WebDemo\Views\Home\Index.cshtml"
                                                              Write(Model.Featured.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h2>\r\n                            <ul class=\"meta list-inline mb-0\">\r\n                                <li class=\"list-inline-item\"><a href=\"#\">");
#nullable restore
#line 23 "D:\backup\GitHub\source\repos\WebDemo\WebDemo\Views\Home\Index.cshtml"
                                                                    Write(Model.Featured.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
            WriteLiteral("                            </ul>\r\n                        </div>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1178, "\"", 1189, 1);
#nullable restore
#line 28 "D:\backup\GitHub\source\repos\WebDemo\WebDemo\Views\Home\Index.cshtml"
WriteAttributeValue("", 1185, url, 1185, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            <div class=""thumb rounded"">
                                <div class=""inner data-bg-image"" data-bg-image=""/images/posts/from-home-hiu-qu-hn-bao-gi-ht-cng-hp-probook-400-series-g8.jpg""></div>
                            </div>
                        </a>
                    </div>

                </div>
");
#nullable restore
#line 36 "D:\backup\GitHub\source\repos\WebDemo\WebDemo\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            <div class=""col-lg-4"">

                <!-- post tabs -->
                <div class=""post-tabs rounded bordered"">
                    <!-- tab navs -->
                    <ul class=""nav nav-tabs nav-pills nav-fill"" id=""postsTab"" role=""tablist"">
                        <li class=""nav-item"" role=""presentation""><button aria-controls=""popular"" aria-selected=""true"" class=""nav-link active"" data-bs-target=""#popular"" data-bs-toggle=""tab"" id=""popular-tab"" role=""tab"" type=""button"">Popular</button></li>
                        <li class=""nav-item"" role=""presentation""><button aria-controls=""recent"" aria-selected=""false"" class=""nav-link"" data-bs-target=""#recent"" data-bs-toggle=""tab"" id=""recent-tab"" role=""tab"" type=""button"">Recent</button></li>
                    </ul>
                    <!-- tab contents -->
                    <div class=""tab-content"" id=""postsTabContent"">
                        <!-- loader -->
                        <div class=""lds-dual-ring""></div>
                    ");
            WriteLiteral("    <!-- popular posts -->\r\n                        <div aria-labelledby=\"popular-tab\" class=\"tab-pane fade show active\" id=\"popular\" role=\"tabpanel\">\r\n                            <!-- post -->\r\n");
#nullable restore
#line 54 "D:\backup\GitHub\source\repos\WebDemo\WebDemo\Views\Home\Index.cshtml"
                             if (Model.Populars != null)
                            {
                                foreach (var item in Model.Populars)
                                {
                                    string url = $"/{item.Alias}.html";

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <!-- post -->\r\n                                    <div class=\"post post-list-sm circle\">\r\n                                        <div class=\"thumb circle\">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 3278, "\"", 3289, 1);
#nullable restore
#line 62 "D:\backup\GitHub\source\repos\WebDemo\WebDemo\Views\Home\Index.cshtml"
WriteAttributeValue("", 3285, url, 3285, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                <div class=\"inner\">\r\n                                                    <img src=\"images/posts/tabs-1.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 3448, "\"", 3465, 1);
#nullable restore
#line 64 "D:\backup\GitHub\source\repos\WebDemo\WebDemo\Views\Home\Index.cshtml"
WriteAttributeValue("", 3454, item.Title, 3454, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                                                </div>
                                            </a>
                                        </div>
                                        <div class=""details clearfix"">
                                            <h6 class=""post-title my-0""><a");
            BeginWriteAttribute("href", " href=\"", 3771, "\"", 3782, 1);
#nullable restore
#line 69 "D:\backup\GitHub\source\repos\WebDemo\WebDemo\Views\Home\Index.cshtml"
WriteAttributeValue("", 3778, url, 3778, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 69 "D:\backup\GitHub\source\repos\WebDemo\WebDemo\Views\Home\Index.cshtml"
                                                                                  Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h6>\r\n                                            <ul class=\"meta list-inline mt-1 mb-0\">\r\n");
            WriteLiteral("                                            </ul>\r\n                                        </div>\r\n                                    </div>\r\n");
#nullable restore
#line 76 "D:\backup\GitHub\source\repos\WebDemo\WebDemo\Views\Home\Index.cshtml"
                                }
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <!--recent post-->\r\n                        <div aria-labelledby=\"recent-tab\" class=\"tab-pane\" id=\"recent\" role=\"tabpanel\">\r\n");
#nullable restore
#line 82 "D:\backup\GitHub\source\repos\WebDemo\WebDemo\Views\Home\Index.cshtml"
                             if (Model.Recents != null)
                            {
                                foreach (var item in Model.Recents)
                                {
                                    string url = $"/{item.Alias}.html";

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <!-- post -->\r\n                                    <div class=\"post post-list-sm circle\">\r\n                                        <div class=\"thumb circle\">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 5016, "\"", 5027, 1);
#nullable restore
#line 90 "D:\backup\GitHub\source\repos\WebDemo\WebDemo\Views\Home\Index.cshtml"
WriteAttributeValue("", 5023, url, 5023, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                <div class=\"inner\">\r\n                                                    <img src=\"images/posts/tabs-2.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 5186, "\"", 5203, 1);
#nullable restore
#line 92 "D:\backup\GitHub\source\repos\WebDemo\WebDemo\Views\Home\Index.cshtml"
WriteAttributeValue("", 5192, item.Title, 5192, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                                                </div>
                                            </a>
                                        </div>
                                        <div class=""details clearfix"">
                                            <h6 class=""post-title my-0""><a");
            BeginWriteAttribute("href", " href=\"", 5509, "\"", 5520, 1);
#nullable restore
#line 97 "D:\backup\GitHub\source\repos\WebDemo\WebDemo\Views\Home\Index.cshtml"
WriteAttributeValue("", 5516, url, 5516, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 97 "D:\backup\GitHub\source\repos\WebDemo\WebDemo\Views\Home\Index.cshtml"
                                                                                  Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h6>\r\n                                            <ul class=\"meta list-inline mt-1 mb-0\">\r\n");
            WriteLiteral("                                            </ul>\r\n                                        </div>\r\n                                    </div>\r\n");
#nullable restore
#line 104 "D:\backup\GitHub\source\repos\WebDemo\WebDemo\Views\Home\Index.cshtml"
                                }
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
            </div>
        </div>

    </div>
</section>
<section class=""main-content"">
    <div class=""container-xl"">

        <div class=""row gy-4"">

            <div class=""col-lg-8"">

                <!-- section header -->
                <div class=""section-header"">
                    <h3 class=""section-title"">Editor’s Pick</h3>
                    <img src=""images/wave.svg"" class=""wave"" alt=""wave"" />
                </div>

                <div class=""padding-30 rounded bordered"">
                    <div class=""row gy-5"">
                        <div class=""col-sm-6"">
                            <!-- post -->
                            <div class=""post"">
                                <div class=""thumb rounded"">
                                    <a href=""#"" class=""category-badge position-absolute"">Lifestyle</a>
                                    <span class=""post-format"">
             ");
            WriteLiteral(@"                           <i class=""icon-picture""></i>
                                    </span>
                                    <a href=""#"">
                                        <div class=""inner"">
                                            <img src=""images/posts/editor-lg.jpg"" alt=""post-title"" />
                                        </div>
                                    </a>
                                </div>
                                <ul class=""meta list-inline mt-4 mb-0"">
                                    <li class=""list-inline-item""><a href=""#""><img src=""images/other/author-sm.png"" class=""author"" alt=""author"" />Katen Doe</a></li>
                                    <li class=""list-inline-item"">29 March 2021</li>
                                </ul>
                                <h5 class=""post-title mb-3 mt-3""><a href=""#"">15 Unheard Ways To Achieve Greater Walker</a></h5>
                                <p class=""excerpt mb-0"">A wonderful serenity has taken ");
            WriteLiteral(@"possession of my entire soul, like these sweet mornings of spring which I enjoy</p>
                            </div>
                        </div>
                        <div class=""col-sm-6"">
                            <!-- post -->
                            <div class=""post post-list-sm square"">
                                <div class=""thumb rounded"">
                                    <a href=""#"">
                                        <div class=""inner"">
                                            <img src=""images/posts/editor-sm-1.jpg"" alt=""post-title"" />
                                        </div>
                                    </a>
                                </div>
                                <div class=""details clearfix"">
                                    <h6 class=""post-title my-0""><a href=""#"">3 Easy Ways To Make Your iPhone Faster</a></h6>
                                    <ul class=""meta list-inline mt-1 mb-0"">
                                       ");
            WriteLiteral(@" <li class=""list-inline-item"">29 March 2021</li>
                                    </ul>
                                </div>
                            </div>
                            <!-- post -->
                            <div class=""post post-list-sm square"">
                                <div class=""thumb rounded"">
                                    <a href=""#"">
                                        <div class=""inner"">
                                            <img src=""images/posts/editor-sm-2.jpg"" alt=""post-title"" />
                                        </div>
                                    </a>
                                </div>
                                <div class=""details clearfix"">
                                    <h6 class=""post-title my-0""><a href=""#"">An Incredibly Easy Method That Works For All</a></h6>
                                    <ul class=""meta list-inline mt-1 mb-0"">
                                        <li class=""list-inline-it");
            WriteLiteral(@"em"">29 March 2021</li>
                                    </ul>
                                </div>
                            </div>

                            <!-- post -->
                            <div class=""post post-list-sm square"">
                                <div class=""thumb rounded"">
                                    <a href=""#"">
                                        <div class=""inner"">
                                            <img src=""images/posts/editor-sm-3.jpg"" alt=""post-title"" />
                                        </div>
                                    </a>
                                </div>
                                <div class=""details clearfix"">
                                    <h6 class=""post-title my-0""><a href=""b#"">10 Ways To Immediately Start Selling Furniture</a></h6>
                                    <ul class=""meta list-inline mt-1 mb-0"">
                                        <li class=""list-inline-item"">29 March 2021</li");
            WriteLiteral(@">
                                    </ul>
                                </div>
                            </div>
                            <!-- post -->
                            <div class=""post post-list-sm square"">
                                <div class=""thumb rounded"">
                                    <a href=""#"">
                                        <div class=""inner"">
                                            <img src=""images/posts/editor-sm-4.jpg"" alt=""post-title"" />
                                        </div>
                                    </a>
                                </div>
                                <div class=""details clearfix"">
                                    <h6 class=""post-title my-0""><a href=""#"">15 Unheard Ways To Achieve Greater Walker</a></h6>
                                    <ul class=""meta list-inline mt-1 mb-0"">
                                        <li class=""list-inline-item"">29 March 2021</li>
                          ");
            WriteLiteral(@"          </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <div class=""spacer"" data-height=""50""></div>

                <!-- horizontal ads -->
                <div class=""ads-horizontal text-md-center"">
                    <span class=""ads-title"">- Sponsored Ad -</span>
                    <a href=""#"">
                        <img src=""images/ads/ad-750.png"" alt=""Advertisement"" />
                    </a>
                </div>

                <div class=""spacer"" data-height=""50""></div>

                <!-- section header -->
                <div class=""section-header"">
                    <h3 class=""section-title"">Trending</h3>
                    <img src=""images/wave.svg"" class=""wave"" alt=""wave"" />
                </div>

                <div class=""padding-30 rounded bordered"">
                    <div class=""row gy-5"">
                        <div ");
            WriteLiteral(@"class=""col-sm-6"">
                            <!-- post large -->
                            <div class=""post"">
                                <div class=""thumb rounded"">
                                    <a href=""#"" class=""category-badge position-absolute"">Culture</a>
                                    <span class=""post-format"">
                                        <i class=""icon-picture""></i>
                                    </span>
                                    <a href=""#"">
                                        <div class=""inner"">
                                            <img src=""images/posts/trending-lg-1.jpg"" alt=""post-title"" />
                                        </div>
                                    </a>
                                </div>
                                <ul class=""meta list-inline mt-4 mb-0"">
                                    <li class=""list-inline-item""><a href=""#""><img src=""images/other/author-sm.png"" class=""author"" alt=""author"" />");
            WriteLiteral(@"Katen Doe</a></li>
                                    <li class=""list-inline-item"">29 March 2021</li>
                                </ul>
                                <h5 class=""post-title mb-3 mt-3""><a href=""#"">Facts About Business That Will Help You Success</a></h5>
                                <p class=""excerpt mb-0"">A wonderful serenity has taken possession of my entire soul, like these sweet mornings of spring which I enjoy</p>
                            </div>
                            <!-- post -->
                            <div class=""post post-list-sm square before-seperator"">
                                <div class=""thumb rounded"">
                                    <a href=""#"">
                                        <div class=""inner"">
                                            <img src=""images/posts/trending-sm-1.jpg"" alt=""post-title"" />
                                        </div>
                                    </a>
                                </div>
");
            WriteLiteral(@"                                <div class=""details clearfix"">
                                    <h6 class=""post-title my-0""><a href=""#"">3 Easy Ways To Make Your iPhone Faster</a></h6>
                                    <ul class=""meta list-inline mt-1 mb-0"">
                                        <li class=""list-inline-item"">29 March 2021</li>
                                    </ul>
                                </div>
                            </div>
                            <!-- post -->
                            <div class=""post post-list-sm square before-seperator"">
                                <div class=""thumb rounded"">
                                    <a href=""#"">
                                        <div class=""inner"">
                                            <img src=""images/posts/trending-sm-2.jpg"" alt=""post-title"" />
                                        </div>
                                    </a>
                                </div>
             ");
            WriteLiteral(@"                   <div class=""details clearfix"">
                                    <h6 class=""post-title my-0""><a href=""#"">An Incredibly Easy Method That Works For All</a></h6>
                                    <ul class=""meta list-inline mt-1 mb-0"">
                                        <li class=""list-inline-item"">29 March 2021</li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                       
                    </div>
                </div>

                <div class=""spacer"" data-height=""50""></div>

                <!-- section header -->
               

                <!-- section header -->
                <div class=""section-header"">
                    <h3 class=""section-title"">Latest Posts</h3>
                    <img src=""images/wave.svg"" class=""wave"" alt=""wave"" />
                </div>

                <div class=""padding-30 rounded bordered"">

         ");
            WriteLiteral("           <div class=\"row\">\r\n");
#nullable restore
#line 314 "D:\backup\GitHub\source\repos\WebDemo\WebDemo\Views\Home\Index.cshtml"
                         if (Model.LatestPosts != null && Model.LatestPosts.Count > 0)
                        {
                            foreach (var item in Model.LatestPosts)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""col-md-12 col-sm-6"">
                                    <!-- post -->
                                    <div class=""post post-list clearfix"">
                                        <div class=""thumb rounded"">
                                            <span class=""post-format-sm"">
                                                <i class=""icon-picture""></i>
                                            </span>
                                            <a href=""#"">
                                                <div class=""inner"">
                                                    <img src=""images/posts/latest-sm-1.jpg"" alt=""post-title"" />
                                                </div>
                                            </a>
                                        </div>
                                        <div class=""details"">
                                            <ul class=""meta list-inline mb-3"">
                    ");
            WriteLiteral(@"                            <li class=""list-inline-item""><a href=""#""><img src=""images/other/author-sm.png"" class=""author"" alt=""author"" />Katen Doe</a></li>
                                                <li class=""list-inline-item""><a href=""#"">Trending</a></li>
                                                <li class=""list-inline-item"">29 March 2021</li>
                                            </ul>
                                            <h5 class=""post-title""><a href=""#"">The Next 60 Things To Immediately Do About Building</a></h5>
                                            <p class=""excerpt mb-0"">A wonderful serenity has taken possession of my entire soul, like these sweet mornings</p>
                                            <div class=""post-bottom clearfix d-flex align-items-center"">
                                                <div class=""social-share me-auto"">
                                                    <button class=""toggle-button icon-share""></button>
                ");
            WriteLiteral(@"                                    <ul class=""icons list-unstyled list-inline mb-0"">
                                                        <li class=""list-inline-item""><a href=""#""><i class=""fab fa-facebook-f""></i></a></li>
                                                        <li class=""list-inline-item""><a href=""#""><i class=""fab fa-twitter""></i></a></li>
                                                        <li class=""list-inline-item""><a href=""#""><i class=""fab fa-linkedin-in""></i></a></li>
                                                        <li class=""list-inline-item""><a href=""#""><i class=""fab fa-pinterest""></i></a></li>
                                                        <li class=""list-inline-item""><a href=""#""><i class=""fab fa-telegram-plane""></i></a></li>
                                                        <li class=""list-inline-item""><a href=""#""><i class=""far fa-envelope""></i></a></li>
                                                    </ul>
                                 ");
            WriteLiteral(@"               </div>
                                                <div class=""more-button float-end"">
                                                    <a href=""#""><span class=""icon-options""></span></a>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
");
#nullable restore
#line 358 "D:\backup\GitHub\source\repos\WebDemo\WebDemo\Views\Home\Index.cshtml"

                            }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                    <!-- load more button -->
                    <div class=""text-center"">
                        <button class=""btn btn-simple"">Load More</button>
                    </div>

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
                                <li class=""list-inline-item""><");
            WriteLiteral(@"a href=""#""><i class=""fab fa-facebook-f""></i></a></li>
                                <li class=""list-inline-item""><a href=""#""><i class=""fab fa-twitter""></i></a></li>
                                <li class=""list-inline-item""><a href=""#""><i class=""fab fa-instagram""></i></a></li>
                                <li class=""list-inline-item""><a href=""#""><i class=""fab fa-pinterest""></i></a></li>
                                <li class=""list-inline-item""><a href=""#""><i class=""fab fa-medium""></i></a></li>
                                <li class=""list-inline-item""><a href=""#""><i class=""fab fa-youtube""></i></a></li>
                            </ul>
                        </div>
                    </div>

                    <!-- widget popular posts -->

                    ");
#nullable restore
#line 393 "D:\backup\GitHub\source\repos\WebDemo\WebDemo\Views\Home\Index.cshtml"
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
#line 403 "D:\backup\GitHub\source\repos\WebDemo\WebDemo\Views\Home\Index.cshtml"
                   Write(await Component.InvokeAsync("Categories"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
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
                            <h3 class=""widget-title"">Tag Clouds</h3>
                            <img src=""images/wave.svg"" class=""wave"" alt=""wave"" />
                        </div>
                        <div class=""widget-content"">
                            <a href=""#"" class=""tag"">#Trending</a>
                            <a href=""#"" class=""tag"">#Video</a>
                            <a href=""#"" ");
            WriteLiteral(@"class=""tag"">#Featured</a>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebDemo.ModelsView.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
