#pragma checksum "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Admin\OrderQuery.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "edb2e1df0a50e47658b97251e5c5c4e8e190de71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_OrderQuery), @"mvc.1.0.view", @"/Views/Admin/OrderQuery.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edb2e1df0a50e47658b97251e5c5c4e8e190de71", @"/Views/Admin/OrderQuery.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d958efeed3f68c64ceb229445b28e0a04d5f41d", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_OrderQuery : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "OrderQuery", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Admin\OrderQuery.cshtml"
  
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";
    ViewData["Title"] = "订单查询";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "edb2e1df0a50e47658b97251e5c5c4e8e190de714387", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>用户查询</title>\r\n    <link rel=\"stylesheet\" href=\"/Admin/admin.css\">\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "edb2e1df0a50e47658b97251e5c5c4e8e190de715618", async() => {
                WriteLiteral(@"
    <div class=""nav"">
        <div class=""nav-hd"">
            铁路购票系统
        </div>
        <hr style=""margin-top: 45px;color:#fff"">
        <div class=""nav-bd"" id=""nav"">
            <ul>
                <li class=""current nav-item"">
                    <img class=""img1"" src=""/Admin/image/订单查询1.png"">
                    <img class=""img2"" src=""/Admin/image/订单查询2.png"">
                    <a href=""/Admin/OrderQuery"">订单查询</a>
                </li>
                <li class=""nav-item"">
                    <img class=""img1"" src=""/Admin/image/用户查询1.png"">
                    <img class=""img2"" src=""/Admin/image/用户查询2.png"">
                    <a href=""/Admin/UserQuery"">用户查询</a>
                </li>
                <li class=""nav-item"">
                    <img class=""img1"" src=""/Admin/image/车次查询1.png"">
                    <img class=""img2"" src=""/Admin/image/车次查询2.png"">
                    <a href=""/Admin/TrainQuery"">车次查询</a>
                </li>
            </ul>
        </div>
    </div>");
                WriteLiteral("\r\n    <div class=\"logout\">\r\n        <span>您好！</span>\r\n        <span style=\"color: #6F9BFF;\">管理员</span>\r\n    </div>\r\n\r\n    <div class=\"content\">\r\n        <div class=\"search\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "edb2e1df0a50e47658b97251e5c5c4e8e190de717189", async() => {
                    WriteLiteral("\r\n                <label for=\"order\">\r\n                    <h2 style=\"display: inline-block;\">订单编号：</h2>\r\n                </label>\r\n                        <input type=\"text\" id=\"OrderID\" name=\"OrderID\" placeholder=\" \">\r\n");
                    WriteLiteral("                <button style=\"margin-left: 800px;\" class=\"query\" type=\"submit\" id=\"submit_botton\">搜索</button>\r\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
        </div>
        <div class=""lists"">
            <div class=""lists-hd"">
                <table>
                    <tbody>
                        <tr>
                            <th>订单编号</th>
                            <th>乘坐人</th>
                            <th>起始站</th>
                            <th>终点站</th>
                            <th>车次号</th>
                            <th>订单价格</th>
                        </tr>
                    </tbody>
                </table>
            </div>
            <div class=""lists-bd"">
                <table class=""list"" id=""orderlist"">
");
#nullable restore
#line 73 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Admin\OrderQuery.cshtml"
                      
                        if (Model != null)

                            for (int i = 0; i < Model.List.Count; i++)
                            {


#line default
#line hidden
#nullable disable
                WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 80 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Admin\OrderQuery.cshtml"
                                   Write(Model.List[i].OrderID);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 81 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Admin\OrderQuery.cshtml"
                                   Write(Model.List[i].Passenger.PassengerRName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 82 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Admin\OrderQuery.cshtml"
                                   Write(Model.Start_station[i]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 83 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Admin\OrderQuery.cshtml"
                                   Write(Model.End_station[i]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 84 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Admin\OrderQuery.cshtml"
                                   Write(Model.List[i].TrainID);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 85 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Admin\OrderQuery.cshtml"
                                   Write(Model.List[i].OrderValue);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                </tr>\r\n");
#nullable restore
#line 87 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Admin\OrderQuery.cshtml"
                            }
                    

#line default
#line hidden
#nullable disable
                WriteLiteral("                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
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