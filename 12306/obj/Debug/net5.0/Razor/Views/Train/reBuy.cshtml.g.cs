#pragma checksum "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\reBuy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb61d807749a1630dd76cdde86e1fe1aacf4afe9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Train_reBuy), @"mvc.1.0.view", @"/Views/Train/reBuy.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb61d807749a1630dd76cdde86e1fe1aacf4afe9", @"/Views/Train/reBuy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d958efeed3f68c64ceb229445b28e0a04d5f41d", @"/Views/_ViewImports.cshtml")]
    public class Views_Train_reBuy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReturnModels.Train_reBuy_Model>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Train/reBuy"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb61d807749a1630dd76cdde86e1fe1aacf4afe94184", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>buy</title>
    <style>
        * {
            margin: 0px;
            padding: 0px;
            font-family: ""Helvetica Neue"",Helvetica,Arial,""PingFang SC"",""Hiragino Sans GB"",""Heiti SC"",""Microsoft YaHei"",""WenQuanYi Micro Hei"",sans-serif;
        }

        a {
            text-decoration: none;
        }

        ul, li {
            list-style: none;
        }

        .nav {
            line-height: 40px;
            font-size: 20px;
            height: 40px;
            background-image: linear-gradient(#9198e5, #1678be);
            margin: 20px 0px;
            padding-left: 45px;
            letter-spacing: 1px;
            color: white;
        }

            .nav ul {
                width: 1190px;
                margin: auto;
                position: relative;
                height: 40px;
 ");
                WriteLiteral(@"           }

        .nav-item {
            display: block;
            height: 40px;
            line-height: 40px;
            text-align: center;
            color: #FFFFFF;
            font-size: 17px;
            float: left;
            width: 180px;
        }

            .nav-item:hover {
                background-color: #1678be;
            }

        .nav a {
            color: white;
        }

        .choice1 {
            border-radius: 5px;
            border: 1px solid #1678be;
            height: 50px;
            width: 1100px;
            background-color: #eef1f8;
            margin: auto;
            padding: 15px 25px;
        }

        .query {
            height: 30px;
            width: 80px;
            border: none;
            border-radius: 5px;
            background-color: darkorange;
            color: #FFFFFF;
            margin-left: 40px;
        }

            .query:hover {
                background-color: rgba(255, 140, 0, 0.");
                WriteLiteral(@"642);
                cursor: pointer;
            }

        .choice1 ul {
            line-height: 50px;
            text-align: center;
        }

            .choice1 ul li {
                float: left;
                margin-right: 80px;
            }

        .choice1 select {
            min-width: 55px;
        }

        .tickets-hd {
            margin: auto;
            margin-top: 10px;
            height: 20px;
            line-height: 16px;
            width: 1130px;
            color: white;
            padding: 10px;
            background-image: linear-gradient(#9198e5e1, #1678bee0);
            border: 1px solid #1678be;
            border-radius: 5px 5px 0px 0px;
            font-size: 16px;
        }

            .tickets-hd th {
                padding-left: 5px;
                text-align: center;
                width: 300px;
                color: whitesmoke;
            }

        .tickets-bd {
            width: 1150px;
            margin: au");
                WriteLiteral(@"to;
            border: 1px solid #1678be;
            border-top: none;
        }

        .tickets {
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

            .tickets td {
                padding-left: 5px;
                text-align: center;
                width: 300px;
            }
    </style>
    <script src=""jquery-3.5.1/jquery-3.5.1.min.js""></script>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb61d807749a1630dd76cdde86e1fe1aacf4afe99062", async() => {
                WriteLiteral(@"
    <div class=""nav"">
        <ul>
            <li class=""nav-item"">
                <a href=""/Train/Index"">铁路购票系统</a>
            </li>
            <li class=""nav-item"">
                <a href=""/Person/center"">个人中心</a>
            </li>
        </ul>
    </div>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb61d807749a1630dd76cdde86e1fe1aacf4afe99607", async() => {
                    WriteLiteral("\r\n        <input type=\"hidden\" name=\"Order_ID\" id=\"Order_ID\"");
                    BeginWriteAttribute("value", " value=\"", 4261, "\"", 4284, 1);
#nullable restore
#line 162 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\reBuy.cshtml"
WriteAttributeValue("", 4269, Model.Order_ID, 4269, 15, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\r\n        <div class=\"choice1\">\r\n            <ul>\r\n                <li>\r\n                    <span>始发站：</span>\r\n                    <input id=\"bef3\" name=\"start_station\"");
                    BeginWriteAttribute("value", " value=\"", 4455, "\"", 4483, 1);
#nullable restore
#line 167 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\reBuy.cshtml"
WriteAttributeValue("", 4463, Model.Start_station, 4463, 20, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" readonly=\"readonly\">\r\n                </li>\r\n                <li>\r\n                    <span>终点站：</span>\r\n                    <input name=\"end_station\" id=\"bef4\"");
                    BeginWriteAttribute("value", " value=\"", 4646, "\"", 4672, 1);
#nullable restore
#line 171 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\reBuy.cshtml"
WriteAttributeValue("", 4654, Model.End_station, 4654, 18, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" readonly=""readonly"">
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
                </tr>
            </tbody>
        </table>
    </div>
    <div class=""tickets-bd"" id=""chepiao"">
");
#nullable restore
#line 204 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\reBuy.cshtml"
          
            if (Model != null)
                for (int i = 0; i < Model.TrainTickets.Count; i++)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <a style=\"text-decoration:none;\"");
                BeginWriteAttribute("onclick", " onclick=\"", 5802, "\"", 6097, 15);
                WriteAttributeValue("", 5812, "location.href", 5812, 13, true);
                WriteAttributeValue(" ", 5825, "=", 5826, 2, true);
                WriteAttributeValue(" ", 5827, "(\'/Train/rePay?order_id=", 5828, 25, true);
#nullable restore
#line 208 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\reBuy.cshtml"
WriteAttributeValue("", 5852, Model.Order_ID, 5852, 15, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 5867, "&train_id=", 5867, 10, true);
#nullable restore
#line 208 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\reBuy.cshtml"
WriteAttributeValue("", 5877, Model.TrainTickets[i].TrainID, 5877, 30, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 5907, "&start_station=", 5907, 15, true);
#nullable restore
#line 208 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\reBuy.cshtml"
WriteAttributeValue("", 5922, Model.TrainTickets[i].StartStName, 5922, 34, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 5956, "&end_station=", 5956, 13, true);
#nullable restore
#line 208 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\reBuy.cshtml"
WriteAttributeValue("", 5969, Model.TrainTickets[i].EndStName, 5969, 32, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 6001, "&leaving_time=", 6001, 14, true);
#nullable restore
#line 208 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\reBuy.cshtml"
WriteAttributeValue("", 6015, Model.TrainTickets[i].LeavingTime, 6015, 34, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 6049, "&arrive_time=", 6049, 13, true);
#nullable restore
#line 208 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\reBuy.cshtml"
WriteAttributeValue("", 6062, Model.TrainTickets[i].ArriveTime, 6062, 33, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 6095, "\')", 6095, 2, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <table class=\"tickets\">\r\n                        <tr>\r\n                            <td>");
#nullable restore
#line 211 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\reBuy.cshtml"
                           Write(Model.TrainTickets[i].TrainID);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 212 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\reBuy.cshtml"
                           Write(Model.TrainTickets[i].StartStName);

#line default
#line hidden
#nullable disable
                WriteLiteral("--");
#nullable restore
#line 212 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\reBuy.cshtml"
                                                               Write(Model.TrainTickets[i].EndStName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 213 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\reBuy.cshtml"
                           Write(Model.TrainTickets[i].LeavingTime);

#line default
#line hidden
#nullable disable
                WriteLiteral("--");
#nullable restore
#line 213 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\reBuy.cshtml"
                                                               Write(Model.TrainTickets[i].LeavingTime);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 214 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\reBuy.cshtml"
                           Write(Model.TrainTickets[i].VIPAmount);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 215 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\reBuy.cshtml"
                           Write(Model.TrainTickets[i].EXAmount);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 216 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\reBuy.cshtml"
                           Write(Model.TrainTickets[i].FirstAmount);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 217 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\reBuy.cshtml"
                           Write(Model.TrainTickets[i].SecondAmount);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        </tr>\r\n                    </table>\r\n                </a>\r\n");
#nullable restore
#line 221 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\reBuy.cshtml"
                }
        

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    </div>
    <div id=""xuanze2"" style='display: none; position:absolute; border:1px solid rgb(121, 173, 245); top:120px; left: 245px;height:200px; width: 200px; overflow: scroll; background-color: rgb(255, 255, 255);'>

    </div>

    <script>

        var d = new Date();
        var year = d.getFullYear();
        var year2 = d.getFullYear() + 1;
        var month = d.getMonth() + 1;
        var daa = 0;
        var daiin = document.getElementsByTagName(""select"")[0];
        for (; year <= 2030; year++) {
            if (year == ");
#nullable restore
#line 237 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\reBuy.cshtml"
                   Write(Model.Leaving_time.Year);

#line default
#line hidden
#nullable disable
                WriteLiteral(@") {
                daiin.innerHTML += ""<option selected = \""selected\"">"" + year + ""</option>""
            }
            else {
                daiin.innerHTML += ""<option>"" + year + ""</option>"";
            }
        }

        var daiin2 = document.getElementsByTagName(""select"")[1];
        for (; month <= 12; month++) {
            if (month == ");
#nullable restore
#line 247 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\reBuy.cshtml"
                    Write(Model.Leaving_time.Month);

#line default
#line hidden
#nullable disable
                WriteLiteral(@") {
                daiin2.innerHTML += ""<option selected = \""selected\"">"" + month + ""</option>"";
            }
            else {
                daiin2.innerHTML += ""<option>"" + month + ""</option>"";
            }
        }

        var daiin3 = document.getElementsByTagName(""select"")[2];
        var md = new Array();
        var yearc = document.getElementsByName(""date"")[0].value;
        var mousc = document.getElementsByName(""datem"")[0].value;

        function ch() {
            yearc = document.getElementsByName(""date"")[0].value;
        }
        function chm() {
            yearc = document.getElementsByName(""datem"")[0].value;
        }
        if (yearc % 4 == 0)
            md = [31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31];
        else
            md = [31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31];
        var dj = 0;
        for (dj = 0; dj < md[mousc - 1]; dj++) {
            daa = dj + 1;
            if (daa == ");
#nullable restore
#line 273 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\reBuy.cshtml"
                  Write(Model.Leaving_time.Day);

#line default
#line hidden
#nullable disable
                WriteLiteral(@") {
                daiin3.innerHTML += ""<option selected = \""selected\"">"" + daa + ""</option>"";
            }
            else {
                daiin3.innerHTML += ""<option>"" + daa + ""</option>"";
            }
        }
    </script>
    <script>
        var shi = document.getElementsByName(""shi"")[0];
        var fen = document.getElementsByName(""fen"")[0];
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
            ");
                WriteLiteral(@"lis(1, document.getElementById('bef3').value);
            document.getElementById('xuanze2').style.left = '245px';
            if (document.getElementById('xuanze2').style.display == ""none"")
                document.getElementById('xuanze2').style.display = ""block"";
            else
                document.getElementById('xuanze2').style.display = ""none"";
        }
        function in2() {
            lis(2, document.getElementById('bef4').value);
            document.getElementById('xuanze2').style.left = '635px';
            if (document.getElementById('xuanze2').style.display == ""none"")
                document.getElementById('xuanze2').style.display = ""block"";
            else
                document.getElementById('xuanze2').style.display = ""none"";
        }
        var a = new Array();
        a = ["""", ""北京"", ""天津"", ""济南"", ""上海"", ""杭州"", ""台北"", ""福州"", ""南昌"", ""长沙"", ""广州"", ""昆明"", ""贵阳"", ""武汉"", ""南京"", ""郑州"", ""重庆"", ""成都"", ""西安"", ""兰州"", ""天津北""];

        function cd(obj) {
            document.getElementB");
                WriteLiteral(@"yId('bef3').value = obj.innerHTML;
            document.getElementById('xuanze2').style.display = ""none"";
        }
        function cd2(obj) {
            document.getElementById('bef4').value = obj.innerHTML;
            document.getElementById('xuanze2').style.display = ""none"";
        }
        function lis(p, cha) {

            var a2 = new Array();
            a2 = ["""", ""北京"", ""天津"", ""济南"", ""上海"", ""杭州"", ""台北"", ""福州"", ""南昌"", ""长沙"", ""广州"", ""昆明"", ""贵阳"", ""武汉"", ""南京"", ""郑州"", ""重庆"", ""成都"", ""西安"", ""兰州"", ""天津北""];
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
 ");
                WriteLiteral(@"           for (i2 = 0; i2 < a.length; i2++) {
                x = 0 + i2 % 4 * 50;
                y = 0 + Math.floor(i2 / 4) * 25;
                if (i2 > a2.length || i2 == a2.length) {
                    before.innerHTML += ""<button id='"" + i2 + ""' onclick='"" + chu + ""' style='background-color: rgb(255, 255, 255);position:absolute; border-width:1px; top:"" + y + ""px; left: "" + x + ""px; width: 50px'>&emsp;</button>"";
                    continue;
                }
                before.innerHTML += ""<button id='"" + i2 + ""' onclick='"" + chu + ""' style='background-color: rgb(255, 255, 255);position:absolute; border-width:1px; top:"" + y + ""px; left: "" + x + ""px; width: 50px'>"" + a2[i2] + ""</button>"";
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReturnModels.Train_reBuy_Model> Html { get; private set; }
    }
}
#pragma warning restore 1591
