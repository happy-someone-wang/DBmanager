#pragma checksum "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Buy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6262640e506e3fbdad8cee2e3d86e658a0a7e509"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Train_Buy), @"mvc.1.0.view", @"/Views/Train/Buy.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6262640e506e3fbdad8cee2e3d86e658a0a7e509", @"/Views/Train/Buy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d958efeed3f68c64ceb229445b28e0a04d5f41d", @"/Views/_ViewImports.cshtml")]
    public class Views_Train_Buy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReturnModels.Train_Buy_Model>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Train/Buy"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6262640e506e3fbdad8cee2e3d86e658a0a7e5094170", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>buy</title>
    <style>
        * {
            margin: 0;
            padding: 0;
        }

        ul {
            list-style: none;
        }

        a {
            text-decoration: none;
        }

        .nav {
            width: 160px;
            background-color: #6F9BFF;
            padding: 20px 30px;
            position: fixed;
            top: 0px;
            bottom: 0px;
        }

        .nav-hd {
            color: white;
            font-size: 24px;
            font-weight: 600;
            font-family: '微软雅黑';
            letter-spacing: 1px;
            text-align: center;
            margin: 25px 0px;
        }

        .nav-bd {
            margin-top: 50px;
        }

        .nav-item {
            height: 40px;
            background: #6F9BFF;
            border-rad");
                WriteLiteral(@"ius: 20px;
            margin: 30px 0px;
            color: #fff;
            text-align: center;
        }

        .current {
            height: 40px;
            background: #fff;
            border-radius: 20px;
            margin: 30px 0px;
            color: #fff;
            text-align: center;
        }

        .nav-item a {
            height: 40px;
            line-height: 40px;
            color: #fff;
            vertical-align: middle;
        }

        .current a {
            height: 40px;
            line-height: 40px;
            color: rgb(42, 130, 228);
            vertical-align: middle;
        }

        img {
            vertical-align: middle;
            margin-right: 10px;
        }

        .nav-item .img1 {
            display: inline-block;
        }

        .nav-item .img2 {
            display: none;
        }

        .current .img1 {
            display: none;
        }

        .current .img2 {
            display: inline-blo");
                WriteLiteral(@"ck;
        }

        .logout {
            height: 80px;
            text-align: right;
            vertical-align: middle;
            box-shadow: 3px 3px 3px rgb(0 0 0 / 10%);
            font-size: 16px;
        }

            .logout img {
                height: 50px;
                width: 1090px;
                opacity: 40%;
                position: absolute;
                top: 30px;
                left: 250px;
            }

            .logout a {
                vertical-align: middle;
                height: 80px;
                line-height: 80px;
                margin: 0px 20px;
                color: #6F9BFF;
            }

                .logout a:hover {
                    color: rgb(42, 130, 228)
                }

            .logout span {
                vertical-align: middle;
                color: rgba(128, 128, 128, 0.859);
                height: 80px;
                line-height: 80px;
            }

        .content {
            mar");
                WriteLiteral(@"gin: 30px 260px;
        }

        .choice1 {
            border-radius: 5px;
            height: 60px;
            width: 1185px;
            margin: auto;
            padding: 15px 25px;
            box-shadow: 0px 2px 8px rgb(0 0 0 / 20%);
        }

        .query {
            height: 30px;
            width: 80px;
            border: none;
            border-radius: 5px;
            background-color: darkorange;
            color: #FFFFFF;
            margin-left: 20px;
            position: relative;
            top: 25%;
        }

            .query:hover {
                background-color: rgba(255, 140, 0, 0.642);
                cursor: pointer;
            }

        .choice1 ul {
            line-height: 60px;
            text-align: center;
        }

            .choice1 ul li {
                margin-left: 30px;
                float: left;
                margin-right: 80px;
            }

        .choice1 select {
            min-width: 55px;
     ");
                WriteLiteral(@"   }

        .tickets-hd {
            margin: auto;
            margin-top: 10px;
            height: 20px;
            line-height: 16px;
            width: 1130px;
            padding: 10px;
            background-color: #E5E5E5;
            font-size: 16px;
        }

            .tickets-hd th {
                padding-left: 5px;
                text-align: center;
                width: 260px;
                color: rgba(0, 0, 0, 0.600);
            }

        .tickets-bd {
            width: 1150px;
            margin: auto;
        }

        .tickets {
            border-radius: 5px;
            min-height: 460px;
            width: 1185px;
            margin-top: 25px;
            padding: 15px 25px;
            box-shadow: 0px 2px 8px rgb(0 0 0 / 30%);
        }

        .ticket {
            height: 18px;
            line-height: 16px;
            width: 1150px;
            border: 1px solid #1678be;
            border-top: none;
            border-left: no");
                WriteLiteral(@"ne;
            border-right: none;
            background-color: rgba(230, 230, 250, 0.436);
            margin: auto;
            padding: 10px;
            font-size: 14px;
        }

        .tickets td {
            padding-left: 5px;
            text-align: center;
            width: 260px;
        }

        .one {
            width: 50px;
        }

            .one .operate {
                display: none;
            }

            .one:hover > .first ~ .operate {
                display: block;
            }
    </style>
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6262640e506e3fbdad8cee2e3d86e658a0a7e50911007", async() => {
                WriteLiteral(@"
    <div class=""nav"">
        <div class=""nav-hd"">
            铁路购票系统
        </div>
        <hr style=""margin-top: 45px;color:#fff"">
        <div class=""nav-bd"" id=""nav"">
            <ul>
                <li class=""nav-item"">
                    <img class=""img1"" src=""/Person/image/系统首页1.png"">
                    <img class=""img2"" src=""/Person/image/系统首页2.png"">
                    <a href=""/Home/Index"">系统首页</a>
                </li>
                <li class=""current nav-item"">
                    <img class=""img1"" src=""/Person/image/订票中心1.png"">
                    <img class=""img2"" src=""/Person/image/订票中心2.png"">
                    <a href=""/Train/Index"">订票中心</a>
                </li>
                <li class=""nav-item"">
                    <img class=""img1"" src=""/Person/image/个人信息1.png"">
                    <img class=""img2"" src=""/Person/image/个人信息2.png"">
                    <a href=""/Person/information"">个人信息</a>
                </li>
                <li class=""nav-item"">
        ");
                WriteLiteral(@"            <img class=""img1"" src=""/Person/image/我的订单1.png"">
                    <img class=""img2"" src=""/Person/image/我的订单2.png"">
                    <a href=""/Person/ticket"">我的订单</a>
                </li>
                <li class=""nav-item"">
                    <img class=""img1"" src=""/Person/image/安全中心1.png"">
                    <img class=""img2"" src=""/Person/image/安全中心2.png"">
                    <a href=""/Person/account"">安全中心</a>
                </li>
            </ul>
        </div>
    </div>
    <div class=""logout"">
        <img src=""/Train/images/train.png"">
        <span>您好！</span>
        <span>");
#nullable restore
#line 284 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Buy.cshtml"
         Write(Model.Myuser.UserRName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n        <a href=\"#\">退出登录</a>\r\n    </div>\r\n\r\n    <div class=\"content\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6262640e506e3fbdad8cee2e3d86e658a0a7e50913356", async() => {
                    WriteLiteral("\r\n            <div class=\"choice1\">\r\n                <ul>\r\n                    <li>\r\n                        <span>始发站：</span>\r\n                        <input onclick=\"in1()\" id=\"bef3\" name=\"start_station\"");
                    BeginWriteAttribute("value", " value=\"", 7784, "\"", 7812, 1);
#nullable restore
#line 294 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Buy.cshtml"
WriteAttributeValue("", 7792, Model.Start_station, 7792, 20, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\r\n                    </li>\r\n                    <li>\r\n                        <span>终点站：</span>\r\n                        <input onclick=\"in2()\" name=\"end_station\" id=\"bef4\"");
                    BeginWriteAttribute("value", " value=\"", 7987, "\"", 8013, 1);
#nullable restore
#line 298 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Buy.cshtml"
WriteAttributeValue("", 7995, Model.End_station, 7995, 18, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@">
                    </li>
                    <li>
                        <span>出发日期：</span>
                        <select name=""date"" onchange=""ch()"">
                        </select>
                        <select name=""datem"" onchange=""chm()"">
                        </select>
                        <select name=""dated"">
                        </select>
                    </li>
                </ul>
                <button class=""query"" type=""submit"">查询</button>
            </div>
        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
        <div class=""tickets"">
            <div class=""tickets-hd"">
                <table>
                    <tbody>
                        <tr>
                            <th>车次</th>
                            <th>出发-到达站</th>
                            <th>出发-到达时间</th>
                            <th>商务座</th>
                            <th>头等座</th>
                            <th>一等座</th>
                            <th>二等座</th>
                            <th>购买车票</th>
                        </tr>
                    </tbody>
                </table>
            </div>
            <script>
                function _display(obj) { document.getElementsByName(""thdi"")[obj.value].style.display = ""block""; };
                function _disappear(obj) { document.getElementsByName(""thdi"")[obj.value].style.display = ""none""; };
                function jump(obj) { location.href = obj.value; }
            </script>
            <div class=""tickets-bd"" id=""chepiao"">
");
#nullable restore
#line 336 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Buy.cshtml"
                  
                    if (Model != null)
                        for (int i = 0; i < Model.TrainTickets.Count; i++)
                        {


#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div style=\"text-decoration:none;\">\r\n                        <table class=\"ticket\">\r\n                            <tr>\r\n                                <td style=\"text-align:center\">");
#nullable restore
#line 344 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Buy.cshtml"
                                                         Write(Model.TrainTickets[i].TrainID);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td style=\"text-align:center\"><button name=\"throu\" style=\"background-color:rgb(0, 0, 0, 0);border:none\" type=\"button\" onmouseover=\"_display(this)\" onmouseout=\"_disappear(this)\"");
                BeginWriteAttribute("value", " value=\"", 10154, "\"", 10164, 1);
#nullable restore
#line 345 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Buy.cshtml"
WriteAttributeValue("", 10162, i, 10162, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 345 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Buy.cshtml"
                                                                                                                                                                                                                       Write(Model.TrainTickets[i].StartStName);

#line default
#line hidden
#nullable disable
                WriteLiteral("-");
#nullable restore
#line 345 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Buy.cshtml"
                                                                                                                                                                                                                                                          Write(Model.TrainTickets[i].EndStName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button></td>\r\n                                <td style=\"text-align:center\">");
#nullable restore
#line 346 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Buy.cshtml"
                                                         Write(Model.TrainTickets[i].LeavingTime);

#line default
#line hidden
#nullable disable
                WriteLiteral("--");
#nullable restore
#line 346 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Buy.cshtml"
                                                                                             Write(Model.TrainTickets[i].ArriveTime);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td style=\"text-align:center\">");
#nullable restore
#line 347 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Buy.cshtml"
                                                         Write(Model.TrainTickets[i].VIPAmount);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td style=\"text-align:center\">");
#nullable restore
#line 348 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Buy.cshtml"
                                                         Write(Model.TrainTickets[i].EXAmount);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td style=\"text-align:center\">");
#nullable restore
#line 349 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Buy.cshtml"
                                                         Write(Model.TrainTickets[i].FirstAmount);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td style=\"text-align:center\">");
#nullable restore
#line 350 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Buy.cshtml"
                                                         Write(Model.TrainTickets[i].SecondAmount);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td style=\"text-align:center\"><button onclick=\"jump(this)\"");
                BeginWriteAttribute("value", " value=\'", 10885, "\'", 11075, 8);
                WriteAttributeValue("", 10893, "/Train/Pay?date=", 10893, 16, true);
#nullable restore
#line 351 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Buy.cshtml"
WriteAttributeValue("", 10909, Model.TrainTickets[i].TrainDate, 10909, 32, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 10941, "&train_id=", 10941, 10, true);
#nullable restore
#line 351 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Buy.cshtml"
WriteAttributeValue("", 10951, Model.TrainTickets[i].TrainID, 10951, 30, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 10981, "&start_station=", 10981, 15, true);
#nullable restore
#line 351 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Buy.cshtml"
WriteAttributeValue("", 10996, Model.TrainTickets[i].StartStName, 10996, 34, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 11030, "&end_station=", 11030, 13, true);
#nullable restore
#line 351 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Buy.cshtml"
WriteAttributeValue("", 11043, Model.TrainTickets[i].EndStName, 11043, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"width: 100px; height: 30px; background-color: #6F9BFF; color: white\">预订</button></td>\r\n                            </tr>\r\n                        </table>\r\n                    </div>\r\n                    <div");
                BeginWriteAttribute("id", " id=\"", 11292, "\"", 11305, 3);
                WriteAttributeValue("", 11297, "thdi[", 11297, 5, true);
#nullable restore
#line 355 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Buy.cshtml"
WriteAttributeValue("", 11302, i, 11302, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 11304, "]", 11304, 1, true);
                EndWriteAttribute();
                WriteLiteral(" name=\"thdi\"");
                BeginWriteAttribute("style", " style=\"", 11318, "\"", 11459, 8);
                WriteAttributeValue("", 11326, "background-color:", 11326, 17, true);
                WriteAttributeValue(" ", 11343, "rgba(230,", 11344, 10, true);
                WriteAttributeValue(" ", 11353, "230,", 11354, 5, true);
                WriteAttributeValue(" ", 11358, "250,", 11359, 5, true);
                WriteAttributeValue(" ", 11363, "1);position:absolute;top:(345+", 11364, 31, true);
#nullable restore
#line 355 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Buy.cshtml"
WriteAttributeValue("", 11394, i, 11394, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 11396, "*40)px;left:410px;line-height:16px;font-size:", 11396, 45, true);
                WriteAttributeValue(" ", 11441, "14px;display:none", 11442, 18, true);
                EndWriteAttribute();
                WriteLiteral(@">
                        <ul id=""GetThrough"" name=""through"" style=""width:400px;opacity:100%;border:solid 1px #1678be;"">

                            <li>
                                <button style=""border:none;background-color: rgba(230, 230, 250, 1);;width:100px;text-align:center;float:left;"">途经站</button>
                                <button style=""border:none;background-color: rgba(230, 230, 250, 1);;width:100px;text-align:center;float:left"">到站时</button>
                                <button style=""border:none;background-color: rgba(230, 230, 250, 1);;width:100px;text-align:center;float:left"">离站时</button>
                                <button style=""border:none;background-color: rgba(230, 230, 250, 1);;width:100px;text-align:center;float:left"">停留时间</button>
                            </li>
                        </ul>
                    </div>
");
#nullable restore
#line 366 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Buy.cshtml"


                            for (int j = 0; j < Model.TrainTickets[i].Parkstations.Count; j++)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <script>\r\n                                         var co = \"color:black;\";\r\n                                         document.getElementsByName(\"through\")[");
#nullable restore
#line 372 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Buy.cshtml"
                                                                          Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("].innerHTML += \"<li class=\'operate\'  ><button style=\'\" + co + \"border:none;background-color: aliceblue;width:100px;text-align:center;float:left\'>");
#nullable restore
#line 372 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Buy.cshtml"
                                                                                                                                                                                                                             Write(Model.TrainTickets[i].Parkstations[j].StationNo);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button><button style=\'\" + co + \"border:none;background-color: aliceblue;width:100px;text-align:center;float:left\'>");
#nullable restore
#line 372 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Buy.cshtml"
                                                                                                                                                                                                                                                                                                                                                                                                 Write(Model.TrainTickets[i].Parkstations[j].ArriveTime);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button><button style=\'\" + co + \"border:none;background-color: aliceblue;width:100px;text-align:center;float:left\'>");
#nullable restore
#line 372 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Buy.cshtml"
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      Write(Model.TrainTickets[i].Parkstations[j].LeavingTime);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button><button style=\'\" + co +\"border:none;background-color: aliceblue;width:100px;text-align:center;float:left\'>");
#nullable restore
#line 372 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Buy.cshtml"
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           Write(Model.TrainTickets[i].Parkstations[j].ParkingTime);

#line default
#line hidden
#nullable disable
                WriteLiteral(" 分</button></li >\"\r\n                    </script>\r\n");
#nullable restore
#line 374 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Buy.cshtml"
                            }

                        }
                

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            </div>
            <div style=""height:300px;width:300px"">
            </div>

        </div>
        <div id=""xuanze2"" style='display: none; position: absolute; border: 1px solid rgb(121, 173, 245); top: 165px; height: 121px; width: 400px; overflow: hidden; overflow-y: auto; background-color: rgb(255, 255, 255);'>
        </div>
    </div>
    <script>
        var d = new Date();
        var year = d.getFullYear();
        var year2 = d.getFullYear() + 1;
        var month = d.getMonth() + 1;
        var today = d.getDate();
        var md = new Array();
        if (yearc % 4 == 0)
            md = [31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31];
        else
            md = [31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31];
        var daa = 0;
        var daiin = document.getElementsByTagName(""select"")[0];
        var mouseoption = 1;
        var dateoption = 1;
        var nextdate = 1;
        var nextyear = 1;
        var nextmonth = month + 1;
        if (today + 7");
                WriteLiteral(@" > md[month - 1]) {
            mouseoption = 2;
            dateoption = 2;
            nextdate = 6 - md[month - 1] + today;
        }
        if (mouseoption == 2 && mouse == 11) {
            nextyear = 2;
            nextmonth = 0;
        }
        if (nextyear == 1) {
            daiin.innerHTML += ""<option>"" + year + ""</option>"";
        }
        else {
            daiin.innerHTML += ""<option>"" + year + ""</option>"";
            daiin.innerHTML += ""<option>"" + year + 1 + ""</option>"";
        }

        var daiin2 = document.getElementsByTagName(""select"")[1];
        if (mouseoption == 1) {
            daiin2.innerHTML += ""<option>"" + month + ""</option>"";
        }
        else {
            daiin2.innerHTML += ""<option>"" + month + ""</option>"";
            daiin2.innerHTML += ""<option>"" + nextmonth + ""</option>"";
        }


        var daiin3 = document.getElementsByTagName(""select"")[2];
        var yearc = document.getElementsByName(""date"")[0].value;
        var mousc = d");
                WriteLiteral(@"ocument.getElementsByName(""datem"")[0].value;



        function ch() {
            yearc = document.getElementsByName(""date"")[0].value;
        }
        function chm() {
            yearc = document.getElementsByName(""datem"")[0].value;
        }
        var dj = 0;
        if (mouseoption == 1) {
            for (dj = today; dj < today + 7; dj++) {
                daa = dj;
                daiin3.innerHTML += ""<option>"" + daa + ""</option>"";
            }
        }
        else if (mousc - 1 == month) {
            for (dj = today; dj < md[month]; dj++) {
                daa = dj;
                daiin3.innerHTML += ""<option>"" + daa + ""</option>"";
            }

        }
        else {
            for (dj = 0; dj < nextdate; dj++) {
                daa = dj + 1;
                daiin3.innerHTML += ""<option>"" + daa + ""</option>"";
            }
        }
    </script>

    <script>
        var shi = document.getElementsByName(""shi"")[0];
        var fen = document.getElementsB");
                WriteLiteral(@"yName(""fen"")[0];
        for (var i1 = 0; i1 < 24; i1++) {
            shi.innerHTML += ""<option>"" + i1 + ""</option>"";
        }
        for (var i3 = 0; i3 < 60; i3++) {
            fen.innerHTML += ""<option>"" + i3 + ""</option>"";
        }
        var shi2 = document.getElementsByName(""shi2"")[0];
        var fen2 = document.getElementsByName(""fen2"")[0];
        for (var i1 = 23; i1 > -1; i1--) {
            shi2.innerHTML += ""<option>"" + i1 + ""</option>"";
        }
        for (var i3 = 59; i3 > -1; i3--) {
            fen2.innerHTML += ""<option>"" + i3 + ""</option>"";
        }
    </script>
    <script>
        function in1() {
            lis(1, document.getElementById('bef3').value);
            document.getElementById('xuanze2').style.left = '365px';
            if (document.getElementById('xuanze2').style.display == ""none"")
                document.getElementById('xuanze2').style.display = ""block"";
            else
                document.getElementById('xuanze2').style.display = ");
                WriteLiteral(@"""none"";
        }
        function in2() {
            lis(2, document.getElementById('bef4').value);
            document.getElementById('xuanze2').style.left = '710px';
            if (document.getElementById('xuanze2').style.display == ""none"")
                document.getElementById('xuanze2').style.display = ""block"";
            else
                document.getElementById('xuanze2').style.display = ""none"";
        }
    </script>
");
                WriteLiteral("        <script>\r\n            var a = new Array();\r\n        </script>\r\n");
#nullable restore
#line 505 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Buy.cshtml"
        for (int i = 0; i < Model.Station.Count; i++)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <script>\r\n                a.push(\"");
#nullable restore
#line 508 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Buy.cshtml"
                   Write(Model.Station[i].StationName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\");\r\n        </script>\r\n");
#nullable restore
#line 510 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Buy.cshtml"
        }
    

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

    <script>
        function cd(obj) {
            document.getElementById('bef3').value = obj.innerHTML;
            document.getElementById('xuanze2').style.display = ""none"";
        }
        function cd2(obj) {
            document.getElementById('bef4').value = obj.innerHTML;
            document.getElementById('xuanze2').style.display = ""none"";
        }
        function lis(p, cha) {

            var a2 = new Array();
            var i2 = 0;
            var i3 = 0;
            var x = 0;
            var y = 0;
            var chu;
            for (i2 = 0, i3 = 0; i2 < a.length; i2++) {
                if (a[i2].includes(cha) || cha == null) {
                    a2[i3] = a[i2];
                    i3++;
                }
            }
            if (p == 1)
                chu = ""cd(this)"";
            else
                chu = ""cd2(this)"";
            var before = document.getElementById('xuanze2');
            for (i2 = 0; i2 < a.length; i2++) {
                x =");
                WriteLiteral(@" 0 + i2 % 4 * 100;
                y = 0 + Math.floor(i2 / 4) * 25;
                if (i2 > a.length || i2 == a.length) {
                    before.innerHTML += ""<button id='"" + i2 + ""' onclick='"" + chu + ""' style='background-color: #f0f2f6;position:absolute; border-width:1px; top:"" + y + ""px; left: "" + x + ""px; width: 90px;height:20px;pxborder: none;cursor:none;overflow: hidden;'>&emsp;</button>"";
                    continue;
                }
                before.innerHTML += ""<button id='"" + i2 + ""' onclick='"" + chu + ""' style='background-color: #f0f2f6;position:absolute; border-width:1px; top:"" + y + ""px; left: "" + x + ""px; width: 90px;height:20px;border:none;cursor:pointer;'>"" + a[i2] + ""</button>"";
            }
        }
    </script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReturnModels.Train_Buy_Model> Html { get; private set; }
    }
}
#pragma warning restore 1591