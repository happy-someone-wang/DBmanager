#pragma checksum "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Pay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ea1e5b2144207dde9339cc8919cde5013db08f3"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ea1e5b2144207dde9339cc8919cde5013db08f3", @"/Views/Train/Pay.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d958efeed3f68c64ceb229445b28e0a04d5f41d", @"/Views/_ViewImports.cshtml")]
    public class Views_Train_Pay : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Train/jquery-3.5.1/jquery-3.5.1.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Train/images/row.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("position:absolute;top: 50px; left: -50px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ea1e5b2144207dde9339cc8919cde5013db08f34497", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>pay</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ea1e5b2144207dde9339cc8919cde5013db08f34964", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ea1e5b2144207dde9339cc8919cde5013db08f36767", async() => {
                WriteLiteral(@"
    <div style=""height: 180px;width: 900px; color: rgb(0, 0, 0);background-color: white;"">
        <div id=""stta"" style=""text-align: center;position:absolute; left: 50px; top: 70px; border-radius: 20px;font-size: 20px;height: 160px;width: 200px; background-color: rgb(147, 147, 245);"">
            <p>起始站</p>
        </div>
        <div id=""endd"" style=""text-align: center;position:absolute; left: 540px; top: 70px; border-radius: 20px;font-size: 20px;height: 160px;width: 200px; background-color: rgb(147, 147, 245);"">
            <p>终点站</p>
        </div>
    </div>

    <div id=""cc"" style=""position:absolute;top:85px;left:350px"">
        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7ea1e5b2144207dde9339cc8919cde5013db08f37690", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
        <p style=""line-height: 10px"">&emsp;</p>
    </div>
    <div id=""info"" style=""border-radius: 20px;height: 180px;width: 700px; color: rgb(0, 0, 0);background-color: white;border: 1px solid rgb(97, 130, 240);"">
        <p>&emsp;&emsp;填写乘车人信息</p>
        <p>&emsp;&emsp;身份证号：<input id=""idcar""></p>
        <p>&emsp;&emsp;姓名：<input id=""namme""></p>
        &emsp;&emsp;选择座位类型：<input type=""radio"" name=""lei"" value=""fir"">商务座
        <input type=""radio"" name=""lei"" value=""yi"">一等座
        <input type=""radio"" name=""lei"" value=""er"">二等座
        <input type=""radio"" name=""lei"">一等卧
        <input type=""radio"" name=""lei"">二等卧
    </div>
    <div style=""height: 20px""></div>
    <div style=""border-radius: 20px;height: 180px;width: 700px;background-color: aliceblue;"">
        <p>&emsp;</p>
        <p>&emsp;&emsp;请选择支付方式：</p>
        &emsp;&emsp;<input type=""radio"" name=""zf"">微信支付
        <input type=""radio"" name=""zf"">支付宝支付
        <p>&emsp;</p>
        <p>&emsp;&emsp;<button onclick=""pg()"">订票</button></p>
");
                WriteLiteral(@"    </div>
    <script>
        function pg() {
            var str = document.getElementsByName(""lei"");
            var obja = str.length;
            var choose = 0;
            for (choose = 0; choose < obja; choose++) {
                if (str[choose].checked == true)
                    break;
            }

            var staf = decodeURI(window.location.href).split('?')[1].split('=')[0];
            var endf = decodeURI(window.location.href).split('?')[1].split('=')[1];
            var stf = decodeURI(window.location.href).split('?')[1].split('=')[2];
            var enf = decodeURI(window.location.href).split('?')[1].split('=')[3];
            var cccf = decodeURI(window.location.href).split('?')[1].split('=')[4];
            var daaf = decodeURI(window.location.href).split('?')[1].split('=')[5];
            $.ajax({
                type: ""post"",
                url: ""Paym"",
                dataType:'json',
                data: { ""staf"": staf, ""endf"": endf, ""stf"": stf, ""enf"": en");
                WriteLiteral(@"f, ""cccf"": cccf, ""daaf"": daaf,  ""idcar"": document.getElementById(""idcar"").value, ""namme"": document.getElementById(""namme"").value, ""zuo"": document.getElementsByName(""lei"")[choose].value },
                success: function (result) {
                    if (result == true)
                        alert(""订票成功"");
                    else
                        alert(""无票"");

                },
                error: function () {
                    alert(""订票失败"");
                }
            })
            //alert(""订票成功"");
        }
    </script>
    <script>
        var sta = decodeURI(window.location.href).split('?')[1].split('=')[0];
        var end = decodeURI(window.location.href).split('?')[1].split('=')[1];
        var st = decodeURI(window.location.href).split('?')[1].split('=')[2];
        var en = decodeURI(window.location.href).split('?')[1].split('=')[3];
        var ccc = decodeURI(window.location.href).split('?')[1].split('=')[4];
        var daa = decodeURI(window.location.h");
                WriteLiteral(@"ref).split('?')[1].split('=')[5];
        document.getElementById('stta').innerHTML += ""<p>"" + sta + ""</p>"";
        document.getElementById('stta').innerHTML += ""<p>"" + st + ""</p>"";
        document.getElementById('endd').innerHTML += ""<p>"" + end + ""</p>"";
        document.getElementById('endd').innerHTML += ""<p>"" + en + ""</p>"";
        document.getElementById('cc').innerHTML += ""<p>"" + daa + ""</p>"";
        document.getElementById('cc').innerHTML += ""<p>"" + ccc + ""</p>"";
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
