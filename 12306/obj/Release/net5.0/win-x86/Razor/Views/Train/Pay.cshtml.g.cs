#pragma checksum "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Pay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e208ebfd72de4d3f752d4585a91523c228b7fcfb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Train_Pay), @"mvc.1.0.view", @"/Views/Train/Pay.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e208ebfd72de4d3f752d4585a91523c228b7fcfb", @"/Views/Train/Pay.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d958efeed3f68c64ceb229445b28e0a04d5f41d", @"/Views/_ViewImports.cshtml")]
    public class Views_Train_Pay : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReturnModels.Train_Pay_Model>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Train/Pay"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e208ebfd72de4d3f752d4585a91523c228b7fcfb4170", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>pay</title>
    <script src=""/Train/jquery-3.5.1/jquery-3.5.1.js""></script>
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
            float: left;
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
            font-family: '????????????';
            letter-spacing: 1px;
            text-align: center;
            margin: 25px 0px;
        }

        .nav-bd {
            margin-top: 50px;
        }

        .nav-");
                WriteLiteral(@"item {
            height: 40px;
            background: #6F9BFF;
            border-radius: 20px;
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
       ");
                WriteLiteral(@"     display: none;
        }

        .current .img2 {
            display: inline-block;
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
                height: 80px");
                WriteLiteral(@";
                line-height: 80px;
            }

        .content {
            margin: 30px 260px;
        }

        .tinfo {
            width: 500px;
            height: 194px;
            display: block;
            padding: 15px 15px;
            margin-left: 350px;
            text-align: center;
            background-image: url('/wwwroot/Train/images/??????bg.png');
            background-size: cover;
        }

        .s_sta, .e_sta {
            font-size: 20px;
            height: 140px;
            width: 80px;
        }

        .s_sta, .e_sta, .tinfo-middle {
            margin: 50px 21px;
            line-height: 50px;
            float: left;
            text-align: center;
        }

        .btn {
            position: absolute;
            bottom: 20px;
            left: 46%;
            height: 30px;
            width: 80px;
            border: none;
            border-radius: 5px;
            background-color: rgb(255, 144, 71);
            color:");
                WriteLiteral(@" #FFF;
            font-size: 14px;
        }

            .btn:hover {
                background-color: rgba(255, 140, 0, 0.642);
                cursor: pointer;
            }

        .pinfo-hd {
            margin: auto;
            margin-top: 10px;
            height: 20px;
            line-height: 16px;
            width: 1130px;
            padding: 10px;
            background-color: #E5E5E5;
            font-size: 16px;
        }

            .pinfo-hd th {
                padding-left: 30px;
                text-align: center;
                width: 300px;
                color: rgba(0, 0, 0, 0.600);
            }

            .pinfo-hd .choice {
                padding-left: 10px;
                width: 100px;
            }

        .pinfo-bd {
            width: 1150px;
            margin: auto;
        }

        .pinfo {
            position: relative;
            border-radius: 5px;
            min-height: 350px;
            width: 1185px;
           ");
                WriteLiteral(@" margin-top: 25px;
            padding: 15px 25px;
            box-shadow: 0px 2px 8px rgb(0 0 0 / 30%);
        }

        .info {
            height: 18px;
            line-height: 16px;
            width: 1150px;
            border: 1px solid #1678be;
            border-top: none;
            border-left: none;
            border-right: none;
            background-color: rgba(230, 230, 250, 0.436);
            margin: auto;
            padding: 10px;
            font-size: 14px;
        }
        .btn {
            position: absolute;
            bottom: 20px;
            left: 40%;
        }

        .btn1 {
            height: 30px;
            width: 90px;
            border: none;
            border-radius: 5px;
            background-color: rgba(128, 128, 128, 0.200);
            border: 1px solid #bababa;
            color: #333;
            font-size: 14px;
        }

            .btn1:hover {
                background-color: rgba(128, 128, 128, 0.600);
       ");
                WriteLiteral(@"         cursor: pointer;
            }

        .btn2 {
            height: 30px;
            width: 90px;
            border: none;
            border-radius: 5px;
            background-color: rgb(255, 144, 71);
            color: #FFF;
            font-size: 14px;
        }

            .btn2:hover {
                background-color: rgba(255, 140, 0, 0.642);
                cursor: pointer;
            }

        .pinfo td {
            padding-left: 5px;
            text-align: center;
            width: 300px;
        }

        .pinfo .choice {
            width: 100px;
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e208ebfd72de4d3f752d4585a91523c228b7fcfb12141", async() => {
                WriteLiteral(@"
    <div class=""nav"">
        <div class=""nav-hd"">
            ??????????????????
        </div>
        <hr style=""margin-top: 45px;color:#fff"">
        <div class=""nav-bd"" id=""nav"">
            <ul>
                <li class=""nav-item"">
                    <img class=""img1"" src=""/Person/image/????????????1.png"">
                    <img class=""img2"" src=""/Person/image/????????????2.png"">
                    <a href=""/Home/Index"">????????????</a>
                </li>
                <li class=""nav-item"">
                    <img class=""img1"" src=""/Person/image/????????????1.png"">
                    <img class=""img2"" src=""/Person/image/????????????2.png"">
                    <a href=""/Train/Index"">????????????</a>
                </li>
                <li class=""nav-item"">
                    <img class=""img1"" src=""/Person/image/????????????1.png"">
                    <img class=""img2"" src=""/Person/image/????????????2.png"">
                    <a href=""/Person/information"">????????????</a>
                </li>
                <li class=""nav-item"">
                ");
                WriteLiteral(@"    <img class=""img1"" src=""/Person/image/????????????1.png"">
                    <img class=""img2"" src=""/Person/image/????????????2.png"">
                    <a href=""/Person/ticket"">????????????</a>
                </li>
                <li class=""current nav-item"">
                    <img class=""img1"" src=""/Person/image/????????????1.png"">
                    <img class=""img2"" src=""/Person/image/????????????2.png"">
                    <a href=""/Person/account"">????????????</a>
                </li>
            </ul>
        </div>
    </div>
    <div class=""logout"">
        <img src=""/Train/images/train.png"">
        <span>?????????</span>
        <span>");
#nullable restore
#line 321 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Pay.cshtml"
         Write(Model.Myuser.UserRName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n        <a href=\"/Login/Index\">????????????</a>\r\n    </div>\r\n    <div class=\"content\">\r\n        <div class=\"tinfo\">\r\n            <div class=\"s_sta\" id=\"stta\">\r\n                <p style=\"color: #fb7403;\">");
#nullable restore
#line 327 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Pay.cshtml"
                                      Write(Model.Start_station);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                <p>");
#nullable restore
#line 328 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Pay.cshtml"
              Write(Model.TrainTicket.LeavingTime);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"tinfo-middle\" id=\"cc\">\r\n                <p style=\"color: #fb7403;\">");
#nullable restore
#line 331 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Pay.cshtml"
                                      Write(Model.Train_ID);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                <img style=""position: relative;top:-25px;opacity: 80%;"" src=""/Train/images/row.png"">
                <p style=""line-height: 10px"">&emsp;</p>
            </div>
            <div class=""e_sta"" id=""endd"">
                <p style=""color: #fb7403;"">");
#nullable restore
#line 336 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Pay.cshtml"
                                      Write(Model.End_station);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                <p>");
#nullable restore
#line 337 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Pay.cshtml"
              Write(Model.TrainTicket.ArriveTime);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
            </div>
        </div>

        <div class=""pinfo"">
            <div class=""pinfo-hd"">
                <table>
                    <tbody>
                        <tr>
                            <th class=""choice"">??????</th>
                            <th>?????????</th>
                            <th>????????????</th>
                            <th>??????</th>
                        </tr>
                    </tbody>
                </table>
            </div>
            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e208ebfd72de4d3f752d4585a91523c228b7fcfb16833", async() => {
                    WriteLiteral("\r\n                <div class=\"pinfo-bd\">\r\n                    <table class=\"info\">\r\n");
#nullable restore
#line 357 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Pay.cshtml"
                          
                            if (Model != null)
                            {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                <tr>\r\n                                    <td class=\"choice\"><input type=\"checkbox\" name=\"PID[0]\"");
                    BeginWriteAttribute("value", " value=\"", 10154, "\"", 10183, 1);
#nullable restore
#line 361 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Pay.cshtml"
WriteAttributeValue("", 10162, Model.Myuser.UserPID, 10162, 21, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral("></td>\r\n                                    <td name=\"name[0]\">");
#nullable restore
#line 362 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Pay.cshtml"
                                                  Write(Model.Myuser.UserRName);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                                    <td name=\"PID[0]\">");
#nullable restore
#line 363 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Pay.cshtml"
                                                 Write(Model.Myuser.UserPID);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                                    <td>\r\n                                        <input hidden=\"hidden\" name=\"train_id\"");
                    BeginWriteAttribute("value", " value=\"", 10479, "\"", 10502, 1);
#nullable restore
#line 365 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Pay.cshtml"
WriteAttributeValue("", 10487, Model.Train_ID, 10487, 15, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n                                        <input hidden=\"hidden\" name=\"start_station\"");
                    BeginWriteAttribute("value", " value=\"", 10591, "\"", 10619, 1);
#nullable restore
#line 366 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Pay.cshtml"
WriteAttributeValue("", 10599, Model.Start_station, 10599, 20, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n                                        <input hidden=\"hidden\" name=\"end_station\"");
                    BeginWriteAttribute("value", " value=\"", 10706, "\"", 10732, 1);
#nullable restore
#line 367 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Pay.cshtml"
WriteAttributeValue("", 10714, Model.End_station, 10714, 18, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n                                        <input hidden=\"hidden\" name=\"date\"");
                    BeginWriteAttribute("value", " value=\"", 10812, "\"", 10848, 1);
#nullable restore
#line 368 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Pay.cshtml"
WriteAttributeValue("", 10820, Model.TrainTicket.TrainDate, 10820, 28, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" />
                                        <p style=""margin: 3px;font-size:15px"">

                                            <label><input type=""radio"" name=""seat[0]"" value=""VIP"" onchange=""on2(this)"">?????????</label>
                                            <label><input type=""radio"" name=""seat[0]"" value=""EX"" onchange=""on2(this)"">?????????</label>
                                            <label><input type=""radio"" name=""seat[0]"" value=""first"" onchange=""on2(this)"">?????????</label>
                                            <label><input type=""radio"" name=""seat[0]"" value=""second"" onchange=""on2(this)"">?????????</label>
                                        </p>
                                    </td>
                                </tr>
");
#nullable restore
#line 378 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Pay.cshtml"
                            }

                            if (Model != null && Model.MyPassengers != null && Model.MyPassengers.Count > 0)
                            {
                                for (int i = 0; i < Model.MyPassengers.Count; i++)
                                {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                    <tr>\r\n                                        <td class=\"choice\"><input type=\"checkbox\"");
                    BeginWriteAttribute("value", " value=\"", 12012, "\"", 12055, 1);
#nullable restore
#line 385 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Pay.cshtml"
WriteAttributeValue("", 12020, Model.MyPassengers[i].PassengerPID, 12020, 35, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral("></td>\r\n                                        <td");
                    BeginWriteAttribute("name", " name=\"", 12107, "\"", 12126, 3);
                    WriteAttributeValue("", 12114, "name[", 12114, 5, true);
#nullable restore
#line 386 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Pay.cshtml"
WriteAttributeValue("", 12119, i+1, 12119, 6, false);

#line default
#line hidden
#nullable disable
                    WriteAttributeValue("", 12125, "]", 12125, 1, true);
                    EndWriteAttribute();
                    WriteLiteral(">");
#nullable restore
#line 386 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Pay.cshtml"
                                                           Write(Model.MyPassengers[i].PassengerRName);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                                        <td");
                    BeginWriteAttribute("name", " name=\"", 12215, "\"", 12233, 3);
                    WriteAttributeValue("", 12222, "PID[", 12222, 4, true);
#nullable restore
#line 387 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Pay.cshtml"
WriteAttributeValue("", 12226, i+1, 12226, 6, false);

#line default
#line hidden
#nullable disable
                    WriteAttributeValue("", 12232, "]", 12232, 1, true);
                    EndWriteAttribute();
                    WriteLiteral(">");
#nullable restore
#line 387 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Pay.cshtml"
                                                          Write(Model.MyPassengers[i].PassengerPID);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                                        <td>\r\n                                            <p style=\"margin: 3px;font-size:15px\">\r\n                                                <label><input type=\"radio\"");
                    BeginWriteAttribute("name", " name=\"", 12481, "\"", 12500, 3);
                    WriteAttributeValue("", 12488, "seat[", 12488, 5, true);
#nullable restore
#line 390 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Pay.cshtml"
WriteAttributeValue("", 12493, i+1, 12493, 6, false);

#line default
#line hidden
#nullable disable
                    WriteAttributeValue("", 12499, "]", 12499, 1, true);
                    EndWriteAttribute();
                    WriteLiteral(" value=\"VIP\" onchange=\"on2(this)\">?????????</label>\r\n                                                <label><input type=\"radio\"");
                    BeginWriteAttribute("name", " name=\"", 12622, "\"", 12641, 3);
                    WriteAttributeValue("", 12629, "seat[", 12629, 5, true);
#nullable restore
#line 391 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Pay.cshtml"
WriteAttributeValue("", 12634, i+1, 12634, 6, false);

#line default
#line hidden
#nullable disable
                    WriteAttributeValue("", 12640, "]", 12640, 1, true);
                    EndWriteAttribute();
                    WriteLiteral(" value=\"EX\" onchange=\"on2(this)\">?????????</label>\r\n                                                <label><input type=\"radio\"");
                    BeginWriteAttribute("name", " name=\"", 12762, "\"", 12781, 3);
                    WriteAttributeValue("", 12769, "seat[", 12769, 5, true);
#nullable restore
#line 392 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Pay.cshtml"
WriteAttributeValue("", 12774, i+1, 12774, 6, false);

#line default
#line hidden
#nullable disable
                    WriteAttributeValue("", 12780, "]", 12780, 1, true);
                    EndWriteAttribute();
                    WriteLiteral(" value=\"first\" onchange=\"on2(this)\">?????????</label>\r\n                                                <label><input type=\"radio\"");
                    BeginWriteAttribute("name", " name=\"", 12905, "\"", 12924, 3);
                    WriteAttributeValue("", 12912, "seat[", 12912, 5, true);
#nullable restore
#line 393 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Pay.cshtml"
WriteAttributeValue("", 12917, i+1, 12917, 6, false);

#line default
#line hidden
#nullable disable
                    WriteAttributeValue("", 12923, "]", 12923, 1, true);
                    EndWriteAttribute();
                    WriteLiteral(" value=\"second\" onchange=\"on2(this)\">?????????</label>\r\n                                            </p>\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 397 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Pay.cshtml"
                                }
                            }
                        

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"                    </table>
                </div>
                <div class=""btn"">
                    <button class=""btn1"" type=""button"" onclick=""javascript:jump()"">???????????????</button>
                    <button class=""btn2"" type=""submit"">??????</button>
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
        </div>
    </div>
    <script>
        function jump() {
            window.location.href = ""/Person/information"";
        }
    </script>
    <script>
        function on(e) {
            e.setAttribute(""value"", e.value);
        }
        function on2(e) {
            e.setAttribute(""checked"", e.checked);
        }
            //var num = 0;
            //function delet(obj) {
            //    var di = obj.name;
            //    document.getElementById(di).remove();
            //    num--;
            //}
            //function create() {
            //    num++;
            //    var inf = ""info["" + num.toString() + ""]"";
            //    var namme = ""seat["" + num.toString() + ""]"";
            //    document.getElementById('infos').innerHTML += ""<div class='pinfo-bd' id='"" + inf + ""'><p>????????????????????? <button class='btn' name = '"" + inf + ""' onclick = 'delet(this)' style = 'margin-left: 490px;'> ??????</button > <hr> </p> <p style='margin: 3px;'>???????????????<input id='"" + inf + "".idcard");
                WriteLiteral(@"' onchange='on(this)' name='idcard'></p><p style='margin: 3px;'>???&emsp;&emsp;??????<input id='"" + inf + "".name' onchange='on(this)' name='name'></p> <p style='margin: 3px;'>?????????????????????<label><input type='radio' name='"" + namme + ""' value='VIP' onchange='on2(this)'>?????????</label><label><input type='radio' name='"" + namme + ""' value='EX' onchange='on2(this)'>?????????</label><label><input type='radio' name='"" + namme + ""' value='first' onchange='on2(this)'>?????????</label> <label><input type='radio' name='"" + namme + ""' value='second' onchange='on2(this)'>?????????</label></p> </div>"";
            //}
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReturnModels.Train_Pay_Model> Html { get; private set; }
    }
}
#pragma warning restore 1591
