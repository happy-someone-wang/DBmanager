#pragma checksum "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Person\center.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01d21fab7fb480aeac13d91edcfbfa03736f1f92"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Person_center), @"mvc.1.0.view", @"/Views/Person/center.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01d21fab7fb480aeac13d91edcfbfa03736f1f92", @"/Views/Person/center.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d958efeed3f68c64ceb229445b28e0a04d5f41d", @"/Views/_ViewImports.cshtml")]
    public class Views_Person_center : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("<!doctype html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01d21fab7fb480aeac13d91edcfbfa03736f1f923229", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <title>personal</title>\r\n    <link rel=\"stylesheet\" href=\"/Person/personal_center.css\" />\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01d21fab7fb480aeac13d91edcfbfa03736f1f924334", async() => {
                WriteLiteral(@"
    <br>
    <div class=""wrapper content"">
        <!-- 面包屑 -->
        <div class=""breadcrumb"">
            当前位置：<a href=""/Person/center"">个人中心</a>
        </div>
        <!-- 个人中心 -->
        <div class=""center-box"">
            <!-- 个人中心左侧 -->
            <!-- 个人中心左侧菜单 -->
            <ul class=""center-menu"" role=""menubar"">
                <li class=""menu-item"" id=""gerenzhongxin"" role=""menuitem"">
                    <h2 class=""menu-tit active"">
                        <a href=""/Person/center;"">个人中心</a>
                    </h2>
                </li>
                <li class=""menu-item"" role=""menuitem"">
                    <h2 class=""menu-tit"">
                        <a href=""/Person/ticket"">订单中心</a>
                    </h2>
                </li>
                <li class=""menu-item"" role=""menuitem"">
                    <h2 class=""menu-tit"">
                        <a href=""/Person/information"">个人信息</a>
                    </h2>
                </li>
            </ul>

      ");
                WriteLiteral(@"      <!-- 个人中心右侧 -->
            <div class=""center-main"" style=""min-height: 310px"">
                <div class=""center-welcome""
                     id=""js-minHeight""
                     style=""min-height: 310px"">
                    <div class=""welcome_data"">
                        <div class=""welcome-con"">
                            <p>
                                欢迎您登录中国铁路客户服务中心网站。
                                <br>
                                <span style=""color: red;"">如果您的密码在其他网站也使用，建议您修改本网站密码。</span>
                                <br>
                                <span style=""color: red;"">为配合做好新冠疫情常态化防控工作，同时便于乘车人及时接收列车运行变更信息，购票时需登记每名乘车旅客中国大陆手机号码，请您提前填报并通知乘车人协助完成手机号码核验。对于未成年人、老年人等重点旅客以及无手机的旅客，可提供监护人或能及时联系的亲友手机号码。铁路部门将依法保护旅客个人信息安全。</span>
                                如果您要更改个人信息，请
                                <a id=""link_for_reSendEmail"" href=""/Person/information"" class=""txt-primary underline"">查看个人信息</a>。
                                <br>
                        ");
                WriteLiteral(@"        如果您需要订购车票，请您点击
                                <a id=""link_for_ticket"" class=""txt-primary underline"" href=""/Train/Index"">车票订购</a>。
                            </p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

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
            WriteLiteral("\r\n</html>\r\n");
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
