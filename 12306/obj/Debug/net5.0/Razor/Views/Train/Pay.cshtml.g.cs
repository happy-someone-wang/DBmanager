#pragma checksum "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Pay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "feba55f4b52ef4a85c473deed4807b95d14426c4"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"feba55f4b52ef4a85c473deed4807b95d14426c4", @"/Views/Train/Pay.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d958efeed3f68c64ceb229445b28e0a04d5f41d", @"/Views/_ViewImports.cshtml")]
    public class Views_Train_Pay : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReturnModels.Train_Pay_Model>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Pay", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "feba55f4b52ef4a85c473deed4807b95d14426c44117", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>pay</title>\r\n    <script src=\"jquery-3.5.1/jquery-3.5.1.min.js\"></script>\r\n");
#nullable restore
#line 10 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Pay.cshtml"
      
        if (Model == null)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <script>\r\n                window.history.go(-1);\r\n            </script>\r\n");
#nullable restore
#line 16 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Pay.cshtml"
        }
    

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "feba55f4b52ef4a85c473deed4807b95d14426c45891", async() => {
                WriteLiteral(@"
    <div style=""height: 180px;width: 900px; color: rgb(0, 0, 0);background-color: white;"">
        <div id=""stta"" style=""text-align: center;position:absolute; left: 50px; top: 70px; border-radius: 20px;font-size: 20px;height: 160px;width: 200px; background-color: rgb(147, 147, 245);"">
            <p>起始站</p>
");
#nullable restore
#line 24 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Pay.cshtml"
              
                if (Model != null)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <p>");
#nullable restore
#line 27 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Pay.cshtml"
                  Write(Model.Start_station);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                    <p>");
#nullable restore
#line 28 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Pay.cshtml"
                  Write(Model.Leaving_time.Hour);

#line default
#line hidden
#nullable disable
                WriteLiteral(":");
#nullable restore
#line 28 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Pay.cshtml"
                                           Write(Model.Leaving_time.Minute);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 29 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Pay.cshtml"
                }
            

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n        <div id=\"endd\" style=\"text-align: center;position:absolute; left: 540px; top: 70px; border-radius: 20px;font-size: 20px;height: 160px;width: 200px; background-color: rgb(147, 147, 245);\">\r\n            <p>终点站</p>\r\n");
#nullable restore
#line 35 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Pay.cshtml"
              
                if (Model != null)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <p>");
#nullable restore
#line 38 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Pay.cshtml"
                  Write(Model.End_station);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                    <p>");
#nullable restore
#line 39 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Pay.cshtml"
                  Write(Model.Arrive_time.Hour);

#line default
#line hidden
#nullable disable
                WriteLiteral(":");
#nullable restore
#line 39 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Pay.cshtml"
                                          Write(Model.Arrive_time.Minute);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 40 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Pay.cshtml"
                }
            

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n    </div>\r\n\r\n    <div id=\"cc\" style=\"position:absolute;top:85px;left:350px\">\r\n");
#nullable restore
#line 46 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Pay.cshtml"
          
            if (Model != null)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <p>");
#nullable restore
#line 49 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Pay.cshtml"
              Write(Model.Train_ID);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                <img src=\"/Train/images/row.jpg\" style=\"position:absolute;top: 45px; left: -50px\">\r\n                <p>");
#nullable restore
#line 51 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Pay.cshtml"
              Write(Model.Leaving_time.Month);

#line default
#line hidden
#nullable disable
                WriteLiteral(" 月 ");
#nullable restore
#line 51 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Pay.cshtml"
                                          Write(Model.Leaving_time.Day);

#line default
#line hidden
#nullable disable
                WriteLiteral(" 日</p>\r\n");
#nullable restore
#line 52 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Pay.cshtml"
            }
        

#line default
#line hidden
#nullable disable
                WriteLiteral("        <p style=\"line-height: 10px\">&emsp;</p>\r\n    </div>\r\n    <div></div>\r\n    <div></div>\r\n    <div></div>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "feba55f4b52ef4a85c473deed4807b95d14426c410877", async() => {
                    WriteLiteral(@"
        <div id=""infos"" style=""border-radius: 20px; border: 1px solid rgb(97, 130, 240); width: 700px; background-color: aliceblue"">
            <button type=""button"" onclick=""create()"" style=""border: 1px solid rgb(97, 130, 240); border-radius: 20px;position:relative; right: 0px"">添加乘车人</button>
");
#nullable restore
#line 62 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Pay.cshtml"
              
                if (Model != null)
                {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                    <input type=\"hidden\" id=\"train_ID\" name=\"train_ID\"");
                    BeginWriteAttribute("value", " value=\"", 2506, "\"", 2529, 1);
#nullable restore
#line 65 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Pay.cshtml"
WriteAttributeValue("", 2514, Model.Train_ID, 2514, 15, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n                    <input type=\"hidden\" id=\"start_station\" name=\"start_station\"");
                    BeginWriteAttribute("value", " value=\"", 2615, "\"", 2643, 1);
#nullable restore
#line 66 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Pay.cshtml"
WriteAttributeValue("", 2623, Model.Start_station, 2623, 20, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n                    <input type=\"hidden\" id=\"end_station\" name=\"end_station\"");
                    BeginWriteAttribute("value", " value=\"", 2725, "\"", 2751, 1);
#nullable restore
#line 67 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Pay.cshtml"
WriteAttributeValue("", 2733, Model.End_station, 2733, 18, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n                    <input type=\"hidden\" id=\"leaving_month\" name=\"leaving_month\"");
                    BeginWriteAttribute("value", " value=\"", 2837, "\"", 2870, 1);
#nullable restore
#line 68 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Pay.cshtml"
WriteAttributeValue("", 2845, Model.Leaving_time.Month, 2845, 25, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n                    <input type=\"hidden\" id=\"leaving_day\" name=\"leaving_day\"");
                    BeginWriteAttribute("value", " value=\"", 2952, "\"", 2983, 1);
#nullable restore
#line 69 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Pay.cshtml"
WriteAttributeValue("", 2960, Model.Leaving_time.Day, 2960, 23, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n");
#nullable restore
#line 70 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Pay.cshtml"
                }
            

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
            <div id=""info[0]"" style=""border-radius: 20px;height: 180px;width: 700px; color: rgb(0, 0, 0);background-color: lightgoldenrodyellow;border: 1px solid rgb(97, 130, 240);"">

                <p>
                    &emsp;&emsp;填写乘车人信息&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;<button name=""info[0]"" style=""border-radius: 20px; border: 1px solid rgb(97, 130, 240); background-color:aliceblue"" onclick=""delet(this)"">删除</button>
                </p>
                <p>&emsp;&emsp;身份证号：<input id=""info[0].idcard"" onchange=""on(this)"" name=""idcard""></p>
                <p>&emsp;&emsp;姓名：<input id=""info[0].name"" onchange=""on(this)"" name=""name""> </p>&emsp;&emsp;选择座位类型：
                <input type=""radio"" name=""seat[0]"" value=""VIP"" onchange=""on2(this)"">商务座
                <input type=""radio"" name=""seat[0]"" value=""EX"" onchange=""on2(this)"">特等座
                <inp");
                    WriteLiteral(@"ut type=""radio"" name=""seat[0]"" value=""first"" onchange=""on2(this)"">一等座
                <input type=""radio"" name=""seat[0]"" value=""second"" onchange=""on2(this)"">二等座
            </div>

        </div>
        <div style=""height: 20px""></div>
        <div style=""border-radius: 20px;height: 180px;width: 700px;background-color: aliceblue;"">
            <p>&emsp;</p>
            <p>&emsp;&emsp;请选择支付方式：</p>
            &emsp;&emsp;<input type=""radio"" name=""payway"" value=""Wechat"">微信支付
            <input type=""radio"" name=""payway"" value=""Alipay"">支付宝支付
            <p>&emsp;</p>
            <p>&emsp;&emsp;<button type=""submit"">订票</button></p>
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
    <script>
        function on(e) {
            e.setAttribute(""value"", e.value);
        }
        function on2(e) {
            e.setAttribute(""checked"", e.checked);
        }
        var num = 0;
        function delet(obj) {
            var di = obj.name;
            document.getElementById(di).remove();
            num--;
        }
        function create() {
            num++;
            var inf = ""info["" + num.toString() + ""]"";
            var nameidcar = ""idcard"";
            var namenamme = ""name"";
            var namme = ""seat["" + num.toString() + ""]"";
            document.getElementById('infos').innerHTML += ""<div id='"" + inf + ""' style='border-radius: 20px; height: 180px; width: 700px; color: rgb(0, 0, 0); background-color: lightgoldenrodyellow; border: 1px solid rgb(97, 130, 240); >'"" +
                ""<p>&emsp;&emsp;填写乘车人信息&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp");
                WriteLiteral(@";&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;<button name="" + inf + "" style='border-radius: 20px; border: 1px solid rgb(97, 130, 240); background-color: aliceblue' onclick='delet(this)'>删除</button></p><p>&emsp;&emsp; 身份证号：<input id="" + inf + ""."" + nameidcar + "" onchange='on(this)' name='"" + nameidcar + ""'></p><p>&emsp;&emsp;姓名：<input name='"" + namenamme + ""' id='"" + inf + ""."" + namenamme + ""' onchange='on(this)'></p>&emsp;&emsp;选择座位类型：<input onchange='on2(this)' type='radio' name='"" + namme + ""' value='VIP'>商务座<input onchange='on2(this)' type='radio' name='"" + namme + ""' value='EX'>特等座<input onchange='on2(this)' type='radio' name='"" + namme + ""' value='first'>一等座<input onchange='on2(this)' type='radio' name='"" + namme + ""' value='second'>二等座</div>"";
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReturnModels.Train_Pay_Model> Html { get; private set; }
    }
}
#pragma warning restore 1591
