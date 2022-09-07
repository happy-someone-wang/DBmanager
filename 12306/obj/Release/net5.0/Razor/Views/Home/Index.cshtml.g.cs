#pragma checksum "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5549c02913a39ddc7a2d28a8458f222366cb3e61"
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
#line 1 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\_ViewImports.cshtml"
using _12306;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\_ViewImports.cshtml"
using _12306.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5549c02913a39ddc7a2d28a8458f222366cb3e61", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d958efeed3f68c64ceb229445b28e0a04d5f41d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5549c02913a39ddc7a2d28a8458f222366cb3e613230", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">

    <title>Train Booking System</title>

    <!-- Vendor CSS Files -->
    <link href=""/assets/vendor/aos/aos.css"" rel=""stylesheet"">
    <link href=""/assets/vendor/bootstrap/css/bootstrap.min.css"" rel=""stylesheet"">
    <link href=""/assets/vendor/bootstrap-icons/bootstrap-icons.css"" rel=""stylesheet"">

    <!-- Template Main CSS File -->
    <link href=""/assets/css/style.css"" rel=""stylesheet"">

");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5549c02913a39ddc7a2d28a8458f222366cb3e614653", async() => {
                WriteLiteral(@"

    <!-- 头部导航栏 -->
    <header id=""header"" class=""fixed-top "">
        <div class=""container d-flex align-items-center"">

            <h1 class=""logo me-auto""></h1>
            <nav id=""navbar"" class=""navbar"">
                <ul>
                    <li><a class=""nav-link scrollto active"" href=""#hero"">主页</a></li>
                    <li><a class=""nav-link scrollto"" href=""#about"">关于我们</a></li>
                    <li><a class=""nav-link scrollto"" href=""#why-us"">常见问题</a></li>
                    <li><a class=""nav-link scrollto"" href=""#services"">服务列表</a></li>
                    <li><a class=""getstarted scrollto"" href=""/Login/Index"">登录</a></li>
                </ul>
                <i class=""bi bi-list mobile-nav-toggle""></i>
            </nav><!-- .navbar -->

        </div>
    </header><!-- End Header -->
    <!-- ======= Hero Section ======= -->
    <section id=""hero"" class=""d-flex align-items-center"">

        <div class=""container"">
            <div class=""row"">
                <");
                WriteLiteral(@"div class=""col-lg-6 d-flex flex-column justify-content-center pt-4 pt-lg-0 order-2 order-lg-1"" data-aos=""fade-up"" data-aos-delay=""200"">
                    <h1 class=""top-title"">火车站售票系统</h1>
                    <h2>Train Booking System</h2>
                    <div class=""d-flex justify-content-center justify-content-lg-start"">
                        <a href=""#about"" class=""btn-get-started scrollto"">Sign Up</a>
                        <a href=""#"" class=""glightbox btn-watch-video""><span>&nbsp;</span></a>
                    </div>
                </div>
                <div class=""col-lg-6 order-1 order-lg-2 hero-img"" data-aos=""zoom-in"" data-aos-delay=""200"">
                    <img src=""/assets/img/hero-img.png"" class=""img-fluid animated""");
                BeginWriteAttribute("alt", " alt=\"", 2280, "\"", 2286, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                </div>
            </div>
        </div>

    </section><!-- End Hero -->


    <div id=""home-page-less"">
        <div class=""advantage"">
            <div class=""base_bd container"" data-aos=""fade-up"" data-aos-delay=""200"">
                <div class=""advantage_bd fl"">
                    <i class=""i_adv icon1""></i>
                    <h4>安心服务</h4>
                </div>
                <div class=""advantage_bd fr"">
                    <i class=""i_adv icon3""></i>
                    <h4>退改无忧 </h4>
                </div>
                <div class=""advantage_bd fm"">
                    <i class=""i_adv icon2""></i>
                    <h4>放心价格</h4>
                </div>
            </div>
        </div>
    </div>

    <!-- ======= About Us Section ======= -->
    <section id=""about"" class=""about"">
        <div class=""container"" data-aos=""fade-up"">

            <div class=""section-title"">
                <h2>关于我们</h2>
            </div>

            <div class");
                WriteLiteral(@"=""row content"">
                <div class=""col-lg-12"">
                    <p>
                        “火车站售票系统”新媒体服务平台是中国铁路总公司在移动互联网上发布铁路资讯的权威渠道，是服务社会公众的新入口。各类新媒体渠道之间既能在新闻发布、公众服务等功能上相互补充，又可在传播模式、服务内容、受众群体上各有侧重，社会公众可以利用自己最习惯、最熟悉、最便捷的新媒体方式获得所需的信息服务。&nbsp;
                    </p>
                    <br />
                </div>
            </div>

        </div>
    </section><!-- End About Us Section -->
    <!-- ======= Why Us Section ======= -->
    <section id=""why-us"" class=""why-us section-bg"">
        <div class=""container-fluid"" data-aos=""fade-up"">

            <div class=""row"">

                <div class=""col-lg-7 d-flex flex-column justify-content-center align-items-stretch  order-2 order-lg-1"">

                    <div class=""content"">
                        <h3> <strong>常见问题</strong></h3>
                        <h3><strong>common problem</strong></h3>
                    </div>

                    <div class=""accordion-list"">
                        <ul>
            ");
                WriteLiteral(@"                <li>
                                <a data-bs-toggle=""collapse"" class=""collapse"" data-bs-target=""#accordion-list-1""><span>01</span> 车票有哪些种类？ <i class=""bx bx-chevron-down icon-show""></i><i class=""bx bx-chevron-up icon-close""></i></a>
                                <div id=""accordion-list-1"" class=""collapse show"" data-bs-parent="".accordion-list"">
                                    <p>
                                        目前，铁路部门发售有电子客票和纸质车票。
                                    </p>
                                    <p>
                                        （1）电子客票：铁路电子客票是以电子数据形式体现的铁路旅客运输合同的凭证。旅客可通过火车站售票系统、实施铁路电子客票车站的售票窗口、自动售票机和铁路客票销售代理点购买铁路指定范围内的铁路电子客票。
                                    </p>
                                    <p>
                                        （2）纸质车票：主要包括红色底纹的计算机软纸车票；浅蓝色底纹的计算机磁介质车票；列车移动补票机出具的车补票；代用票、区段票、客运运价杂费收据等。
                                    </p>
                                </div>
                            </li>

             ");
                WriteLiteral(@"               <li>
                                <a data-bs-toggle=""collapse"" data-bs-target=""#accordion-list-2"" class=""collapsed""><span>02</span> 去哪里可以购买车票？ <i class=""bx bx-chevron-down icon-show""></i><i class=""bx bx-chevron-up icon-close""></i></a>
                                <div id=""accordion-list-2"" class=""collapse"" data-bs-parent="".accordion-list"">
                                    <p>
                                        请到铁路运输企业或其销售代理人的售票处购买火车票。目前，铁路部门提供以下方式：
                                    </p>
                                    <p>
                                        （1）铁路售票窗口，指铁路车站售票处和铁路客票代售点。
                                    </p>
                                    <p>
                                        （2）铁路车站或指定场所设置的自动售票机。
                                    </p>
                                    <p>
                                        （3）火车站售票系统。
                                    </p>
                                    <p>
                   ");
                WriteLiteral(@"                     （4）电话订票。在已经开通电话订票业务的地区，旅客可以先通过电话预订车票，再按规定时间到指定地点支付。
                                    </p>
                                </div>
                            </li>

                            <li>
                                <a data-bs-toggle=""collapse"" data-bs-target=""#accordion-list-3"" class=""collapsed""><span>03</span> 车票有效期是如何规定的？ <i class=""bx bx-chevron-down icon-show""></i><i class=""bx bx-chevron-up icon-close""></i></a>
                                <div id=""accordion-list-3"" class=""collapse"" data-bs-parent="".accordion-list"">
                                    <p>
                                        旅客购票后，请按票面载明的乘车日期、车次乘车，中途上（下）车未乘区间失效。
                                    </p>
                                </div>
                            </li>

                        </ul>
                    </div>

                </div>

                <div class=""col-lg-5 align-items-stretch order-1 order-lg-2 img"" style='background-image: url(""/assets/img/w");
                WriteLiteral(@"hy-us.png"");' data-aos=""zoom-in"" data-aos-delay=""150"">&nbsp;</div>
            </div>

        </div>
    </section><!-- End Why Us Section -->
    <!-- ======= Cta Section ======= -->
    <section id=""cta"" class=""cta"">
        <div class=""container"" data-aos=""zoom-in"">

            <div class=""row"">
                <div class=""col-lg-9 text-center text-lg-start"">
                    <h3>隐私权政策</h3>
                    <p> 我们致力于维持您对我们的信任，恪守以下原则，保护您的个人信息：权责一致原则、目的明确原则、选择同意原则、最小必要原则、确保安全原则、主体参与原则、公开透明原则等。我们也将按业界成熟的安全标准，采取相应的安全保护措施来保护您的个人信息。我们在您使用火车站售票系统的过程中所收集到的个人信息将只用于本《隐私政策》中所规定的用途。&nbsp;</p>
                </div>
                <div class=""col-lg-3 cta-btn-container text-center"">
                    <a class=""cta-btn align-middle"" href=""#"">查看详情</a>
                </div>
            </div>

        </div>
    </section><!-- End Cta Section -->
    <!-- ======= Services Section ======= -->
    <section id=""services"" class=""services section-bg"">
        <div class=""container"" data-aos=""");
                WriteLiteral(@"fade-up"">

            <div class=""section-title"">
                <h2>服&nbsp;&nbsp;&nbsp;务</h2>
                <p>火车站售票系统是一个免费的购票网站，使用统一的购票业务规则，具有车票预订、改签、退票、订单查询、乘车人管理、个人资料修改、密码修改等功能。</p>
            </div>

            <div class=""row"">
                <div class=""col-xl-3 col-md-6 d-flex align-items-stretch"" data-aos=""zoom-in"" data-aos-delay=""100"">
                    <div class=""icon-box"">
                        <div class=""icon""><i class=""bx bxl-dribbble""></i></div>
                        <h4><a href=""/Train/Index"">车票预订</a></h4>
                        <p>您可以随时预订与查看未来十五天以内的车票。</p>
                    </div>
                </div>

                <div class=""col-xl-3 col-md-6 d-flex align-items-stretch mt-4 mt-md-0"" data-aos=""zoom-in"" data-aos-delay=""200"">
                    <div class=""icon-box"">
                        <div class=""icon""><i class=""bx bx-file""></i></div>
                        <h4><a href=""/Login/Index"">车票管理</a></h4>
                        <p>待付款车票、已购车票的信息查看、车票改");
                WriteLiteral(@"签与退订从这里进入。</p>
                    </div>
                </div>

                <div class=""col-xl-3 col-md-6 d-flex align-items-stretch mt-4 mt-xl-0"" data-aos=""zoom-in"" data-aos-delay=""300"">
                    <div class=""icon-box"">
                        <div class=""icon""><i class=""bx bx-tachometer""></i></div>
                        <h4><a href=""/Login/Index"">个人中心</a></h4>
                        <p>在此处您可以查看并更改个人信息。</p>
                    </div>
                </div>

                <div class=""col-xl-3 col-md-6 d-flex align-items-stretch mt-4 mt-xl-0"" data-aos=""zoom-in"" data-aos-delay=""400"">
                    <div class=""icon-box"">
                        <div class=""icon""><i class=""bx bx-layer""></i></div>
                        <h4><a href=""/Login/Index"">安全中心</a></h4>
                        <p>为了防止出现密码泄露的情况，我们提供密码更改服务，以保障您的财产与信息安全。</p>
                    </div>
                </div>

            </div>

        </div>
    </section><!-- End Services Section -->
    <!");
                WriteLiteral(@"-- ======= Footer ======= -->
    <footer id=""footer"">
        <div class=""container footer-bottom clearfix"">
            <div class=""copyright"">
                联系我们：18726169392
            </div>
        </div>
    </footer><!-- End Footer -->

    <div id=""preloader""></div>
    <a href=""#"" class=""back-to-top d-flex align-items-center justify-content-center""><i class=""bi bi-arrow-up-short""></i></a>

    <!-- Vendor JS Files -->
    <script src=""/assets/vendor/aos/aos.js""></script>
    <script src=""/assets/vendor/bootstrap/js/bootstrap.bundle.min.js""></script>

    <!-- Template Main JS File -->
    <script src=""/assets/js/main.js""></script>

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
            WriteLiteral("\r\n\r\n</html>");
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
