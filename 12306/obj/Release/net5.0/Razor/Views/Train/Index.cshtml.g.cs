#pragma checksum "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5653d9d1d91b8b1c46c3b012d292c155d2f43c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Train_Index), @"mvc.1.0.view", @"/Views/Train/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5653d9d1d91b8b1c46c3b012d292c155d2f43c5", @"/Views/Train/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d958efeed3f68c64ceb229445b28e0a04d5f41d", @"/Views/_ViewImports.cshtml")]
    public class Views_Train_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReturnModels.Train_Index>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5653d9d1d91b8b1c46c3b012d292c155d2f43c54176", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>train</title>
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
            background: #6F9");
                WriteLiteral(@"BFF;
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
            display: none;
        }

        .current .img2 {
   ");
                WriteLiteral(@"         display: inline-block;
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

       ");
                WriteLiteral(@" .content {
            margin: 0px 230px;
        }

        .image {
            position: relative;
        }

            .image img {
                height: 645px;
                width: 1295px;
                overflow: hidden;
                position: absolute;
                left: 0px;
                top: 20px;
                opacity: 90%;
                border-radius: 15px;
                box-shadow: 8px 8px 5px rgb(0 0 0 / 60%);
            }

        .query {
            position: absolute;
            top: 45%;
            left: 30%;
            height: auto;
            width: 400px;
            box-shadow: -8px 8px 5px rgb(0 0 0 / 10%);
        }

        .query-hd {
            border-radius: 8px 8px 0 0;
            border-width: 1px;
            color: rgb(255, 255, 255);
            height: 30px;
            line-height: 30px;
            width: auto;
            padding-left: 10px;
            background-color: #6F9BFF;
        }

        .quer");
                WriteLiteral(@"y-bd {
            padding: 10px 0px;
            background-color: #eef1f8;
            opacity: 90%;
            border-top: none;
            border-radius: 0 0 8px 8px; /*边框圆角*/
            border: 1px solid #6F9BFF; /*边框*/
        }

            .query-bd ul {
                line-height: 40px;
                text-align: center;
            }

                .query-bd ul li {
                    float: left;
                    margin-left: 60px;
                    margin-right: 80px;
                }

        .btn {
            height: 28px;
            width: 80px;
            border: none;
            border-radius: 5px;
            background-color: rgb(255, 144, 71);
            color: #FFFFFF;
            font-size: 14px;
        }

            .btn:hover {
                background-color: rgba(255, 144, 71, 0.600);
                cursor: pointer;
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5653d9d1d91b8b1c46c3b012d292c155d2f43c510328", async() => {
                WriteLiteral(@"
    <div class=""nav"">
        <div class=""nav-hd"">
            铁路购票系统
        </div>
        <hr style=""margin-top: 45px;color:#fff"">
        <div class=""nav-bd"" id=""nav"">
            <ul>
                <li class=""current nav-item"">
                    <img class=""img1"" src=""/Train/images/系统首页1.png"">
                    <img class=""img2"" src=""/Train/images/系统首页2.png"">
                    <a href=""#"">系统首页</a>
                </li>
                <li class=""nav-item"">
                    <img class=""img1"" src=""/Train/images/订票中心1.png"">
                    <img class=""img2"" src=""/Train/images/订票中心2.png"">
                    <a href=""#"">订票中心</a>
                </li>
                <li class=""nav-item"">
                    <img class=""img1"" src=""/Train/images/个人信息1.png"">
                    <img class=""img2"" src=""/Train/images/个人信息2.png"">
                    <a href=""#"">个人信息</a>
                </li>
                <li class=""nav-item"">
                    <img class=""img1"" src=""/Tra");
                WriteLiteral(@"in/images/我的订单1.png"">
                    <img class=""img2"" src=""/Train/images/我的订单2.png"">
                    <a href=""#"">我的订单</a>
                </li>
                <li class=""nav-item"">
                    <img class=""img1"" src=""/Train/images/安全中心1.png"">
                    <img class=""img2"" src=""/Train/images/安全中心2.png"">
                    <a href=""#"">安全中心</a>
                </li>
            </ul>
        </div>
    </div>
    <div class=""logout"">
        <img src=""/Train/images/train.png"">
        <span>您好！</span>
");
#nullable restore
#line 251 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Index.cshtml"
          
            if (Model == null || Model.Myuser.UserPID == null)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <span href=\"/Login/Index\">请登录</span>\r\n");
#nullable restore
#line 255 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <span>");
#nullable restore
#line 258 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Index.cshtml"
                 Write(Model.Myuser.UserRName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                <a href=\"/Login//Index\">退出登录</a>\r\n");
#nullable restore
#line 260 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Index.cshtml"
            }
        

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    </div>
    <div class=""content"">
        <div class=""image"">
            <img src=""/Train/images/main.png"">
        </div>
        <div class=""query"" id=""sc"">
            <div class=""query-hd"">选择车票</div>
            <div class=""query-bd"">
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5653d9d1d91b8b1c46c3b012d292c155d2f43c513672", async() => {
                    WriteLiteral(@"
                    <ul>
                        <li>
                            <span>始&nbsp;发&nbsp;站：</span>
                            <input onclick=""in1()"" id=""start_station"" name=""start_station"">
                        </li>
                        <li>
                            <span>终&nbsp;点&nbsp;站：</span>
                            <input onclick=""in2()"" name=""end_station"" id=""end_station"">
                        </li>
                        <li>
                            <p name=""da"">
                                <span>出发日期：</span>
                                <select name=""date"" onchange=""ch()"">
                                </select>
                                <select name=""datem"" onchange=""chm()"">
                                </select>
                                <select name=""dated"">
                                </select>
                            </p>

                        </li>
                        <button class=""btn"" type=""submit");
                    WriteLiteral("\" style=\"width: 100px; border-width: 1px\" value=\"查询\">查询</button>\r\n                    </ul>\r\n                ");
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

            <div id=""xuanze"" style='display: none; position:absolute; border:1px solid rgb(121, 173, 245); top:40px; left: 330px;height:121px; width: 400px;overflow:hidden; overflow-y:auto; background-color: rgb(255, 255, 255);'></div>
        </div>
    </div>
    <script>
        var d = new Date();
        var year = d.getFullYear();
        var year2 = d.getFullYear() + 1;
        var month2 = d.getMonth() + 2;
        var month = d.getMonth() + 1;
        var daa = 0;
        var daiin = document.getElementsByTagName(""select"")[0];
        daiin.innerHTML += ""<option>"" + year + ""</option><option>"" + year2 + ""</option>"";

        var daiin2 = document.getElementsByTagName(""select"")[1];
        for (; month <= 12; month++) {
            daiin2.innerHTML += ""<option>"" + month + ""</option>"";
        }
        //daiin2.innerHTML+=""<option>""+month+""</option><option>""+month2+""</option>"";

        var daiin3 = document.getElementsByTagName(""select"")[2];
        var md =");
                WriteLiteral(@" new Array();
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
            daiin3.innerHTML += ""<option>"" + daa + ""</option>"";
        }

    </script>
    <script>
        function in1() {
            lis(1, document.getElementById('start_station').value);
            var be = document.getElementById('xuanze');
            be.style.top = '40px';
            if (document.getElementById('xuanze').style.display == ""none"")
                docu");
                WriteLiteral(@"ment.getElementById('xuanze').style.display = ""block"";
            else
                document.getElementById('xuanze').style.display = ""none"";
            document.getElementById('start_station').onfocus = function () {
                document.getElementById('xuanze').style.display = ""none"";
            }
        }
        function in2() {
            lis(2, document.getElementById('end_station').value);
            var be2 = document.getElementById('xuanze');
            be2.style.top = '85px';
            if (document.getElementById('xuanze').style.display == ""none"")
                document.getElementById('xuanze').style.display = ""block"";
            else
                document.getElementById('xuanze').style.display = ""none"";
            document.getElementById('end_station').onfocus = function () {
                document.getElementById('xuanze').style.display = ""none"";
            }
        }
        function cd(obj) {
            document.getElementById('start_station').value");
                WriteLiteral(@" = obj.innerHTML;
            document.getElementById('xuanze').style.display = ""none"";
        }
        function cd2(obj) {
            document.getElementById('end_station').value = obj.innerHTML;
            document.getElementById('xuanze').style.display = ""none"";
        }
    </script>
");
                WriteLiteral("        <script>\r\n            var a = new Array();\r\n        </script>\r\n");
#nullable restore
#line 376 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Index.cshtml"
        for (int i = 0; i < Model.Station.Count; i++)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <script>\r\n                a.push(\"");
#nullable restore
#line 379 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Index.cshtml"
                   Write(Model.Station[i].StationName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\");\r\n            </script>\r\n");
#nullable restore
#line 381 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Train\Index.cshtml"
        }
    

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

    <script>
        function lis(p, cha) {

            var a2 = new Array();
            var i2 = 0;
            var i3 = 0;
            var x = 0;
            var y = 0;
            var chu;
            if (p == 1)
                chu = ""cd(this)"";
            else
                chu = ""cd2(this)"";
            var before = document.getElementById('xuanze');
            for (i2 = 0; i2 < a.length; i2++) {
                x = 0 + i2 % 4 * 100;
                y = 0 + Math.floor(i2 / 4) * 25;
                if (i2 > a.length || i2 == a.length) {
                    //before.innerHTML += ""<button id='"" + i + ""' onclick='"" + chu +""' style='background-color: rgb(255, 255, 255); position:absolute; border-width:1px; top:""+y+""px; left: ""+x+""px; width: 50px'>&emsp;</button>"";

                    before.innerHTML += ""<button id='"" + i2 + ""' onclick='"" + chu + ""' style='background-color: #f0f2f6;position:absolute; border-width:1px; top:"" + y + ""px; left: "" + x + ""px; width: 90px;height:20px;");
                WriteLiteral(@"pxborder:none;cursor:pointer;'>&emsp;</button>"";
                    continue;
                }
                //before.innerHTML += ""<button id='"" + i + ""' onclick='"" + chu +""' style='background-color: rgb(255, 255, 255); position:absolute; border-width:1px; top:""+y+""px; left: ""+x+""px; width: 50px'>""+a2[i2]+""</button>"";

                before.innerHTML += ""<button id='"" + i2 + ""' onclick='"" + chu + ""' style='background-color: #f0f2f6;position:absolute; border-width:1px; top:"" + y + ""px;left: "" + x + ""px; width: 90px;height:20px;border:none;cursor:pointer;'>"" + a[i2] + ""</button>"";

            }
        }
    </script>
    <script type=""text/javascript"">
        let oMenu = my$('nav');
        let oUL = getFirstElementChild(oMenu);
        // 获取 id
        function my$(id) {
            return document.getElementById(id);
        }
        // 获取第一个元素
        function getFirstElementChild(element) {
            let node;
            let nodes = element.childNodes;
            let i = 0");
                WriteLiteral(@";
            //遍历返回元素节点，当元素节点为空时返回null
            while (node = nodes[i++]) {
                if (node.nodeType === 1) {
                    return node;
                }
            }
            return null;
        }
        // 添加注册事件
        for (let i = 0; i < oUL.children.length; i++) {
            let oLi = oUL.children[i];
            oLi.onclick = LiClick;
        }
        function LiClick() {
            for (let i = 0; i < oUL.children.length; i++) {
                let oLi = oUL.children[i];
                oLi.className = 'nav-item';
            }
            this.className = 'current';
            return false;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReturnModels.Train_Index> Html { get; private set; }
    }
}
#pragma warning restore 1591
