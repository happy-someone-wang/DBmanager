#pragma checksum "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Person\information.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98b8721011be4182a5c46b113abd7f06e90c5292"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Person_information), @"mvc.1.0.view", @"/Views/Person/information.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98b8721011be4182a5c46b113abd7f06e90c5292", @"/Views/Person/information.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d958efeed3f68c64ceb229445b28e0a04d5f41d", @"/Views/_ViewImports.cshtml")]
    public class Views_Person_information : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReturnModels.Person_Information>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Person/information"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Person/deletePassenger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Person/addPassenger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98b8721011be4182a5c46b113abd7f06e90c52924952", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <title>Title</title>\r\n    <link rel=\"stylesheet\" href=\"/Person/personal_information.css\" />\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98b8721011be4182a5c46b113abd7f06e90c52926055", async() => {
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
                <li class=""current nav-item"">
                    <img class=""img1"" src=""/Person/image/????????????1.png"">
                    <img class=""img2"" src=""/Person/image/????????????2.png"">
                    <a href=""/Person/information"">????????????</a>
                </li>
                <li class=""nav-item"">
        ");
                WriteLiteral(@"            <img class=""img1"" src=""/Person/image/????????????1.png"">
                    <img class=""img2"" src=""/Person/image/????????????2.png"">
                    <a href=""/Person/ticket"">????????????</a>
                </li>
                <li class=""nav-item"">
                    <img class=""img1"" src=""/Person/image/????????????1.png"">
                    <img class=""img2"" src=""/Person/image/????????????2.png"">
                    <a href=""/Person/account"">????????????</a>
                </li>
            </ul>
        </div>
    </div>
    <div class=""logout"">
        <img src=""/Person/image/train.png"">
        <span>?????????</span>
        <span>");
#nullable restore
#line 48 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Person\information.cshtml"
         Write(Model.Myuser.UserRName);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
        <a href=""/Login/Index"">????????????</a>
    </div>


    <div class=""box1"">
        <div class=""box1_1"">
            <div class=""box1_1_1"" id=""box1_1_1"">
                <div class=""text_1"">????????????</div>
            </div>
            <div class=""box1_1_2"" id=""box1_1_2"">
                <div class=""text_1""> ??????????????? </div>
            </div>
        </div>
        <div class=""box1_2"">
            <div class=""box1_2_1"">
                <div class=""box1_2_1_1"">
                    <!-- ???????????? -->
                    <div class=""panel-border"" style=""display: block"" id=""myInfo"">
                        <!-- ???????????? -->
                        <div class=""center-form-item"">
                            <!-- ???????????? -->
                            <div class=""center-tit"">
                                <div class=""tit-name"">????????????</div>
                            </div>
                            <br>
                            <!-- ?????? -->
                            <div class=""form-list form");
                WriteLiteral(@"-list-view"" id=""basic_info_view"">
                                <div class=""form-item"">
                                    <div class=""form-label""><span class=""required"">*</span>????????????</div>
                                    <div class=""form-bd"">
                                        <div class=""form-bd-txt"">");
#nullable restore
#line 79 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Person\information.cshtml"
                                                            Write(Model.Myuser.UserPID);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</div>
                                    </div>
                                </div>
                                <div class=""form-item"">
                                    <div class=""form-label""><span class=""required"">*</span>?????????</div>
                                    <div class=""form-bd"">
                                        <div class=""form-bd-txt"">");
#nullable restore
#line 85 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Person\information.cshtml"
                                                            Write(Model.Myuser.UserGender);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</div>
                                    </div>
                                </div>
                                <div class=""form-item"">
                                    <div class=""form-label""><span class=""required"">*</span>?????????</div>
                                    <div class=""form-bd"">
                                        <div class=""form-bd-txt"">");
#nullable restore
#line 91 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Person\information.cshtml"
                                                            Write(Model.Myuser.UserRName);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</div>
                                    </div>
                                </div>
                                <div class=""form-item"">
                                    <div class=""form-label""><span class=""required"">*</span>???????????????</div>
                                    <div class=""form-bd"">
                                        <div class=""form-bd-txt"">");
#nullable restore
#line 97 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Person\information.cshtml"
                                                            Write(Model.Myuser.UserPID);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</div>
                                    </div>
                                </div>
                            </div>
                            <div class=""line-dashed""></div>

                            <!-- ???????????? -->
                            <div class=""center-tit"">
                                <div class=""tit-name"">????????????</div>
                                <input id=""bt1"" class=""change-bt"" type=""button"" value=""????????????"">
                            </div>
                            <br>
                            <!-- ?????? -->
                            <div class=""form-list form-list-view"" id=""relation_way_view"" style=""display: block"">
                                <div class=""form-item"" style=""position:relative"">
                                    <div class=""form-label""><span name=""mobile_div_span"" class=""required"">*</span>????????????</div>
                                    <div class=""form-bd"">
                                        <div class=""form-bd-txt"">");
#nullable restore
#line 114 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Person\information.cshtml"
                                                            Write(Model.Myuser.UserPhone);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</div>
                                    </div>
                                </div>
                                <div class=""form-item"" style=""position:relative"">
                                    <div class=""form-label"">?????????</div>
                                    <div class=""form-bd""");
                BeginWriteAttribute("title", " title=\"", 5787, "\"", 5818, 1);
#nullable restore
#line 119 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Person\information.cshtml"
WriteAttributeValue("", 5795, Model.Myuser.UserEmail, 5795, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                        <div class=\"form-bd-txt\">");
#nullable restore
#line 120 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Person\information.cshtml"
                                                            Write(Model.Myuser.UserEmail);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</div>
                                    </div>
                                </div>
                                <div class=""form-item"">
                                    <div class=""form-label"">?????????</div>
                                    <div class=""form-bd"">
                                        <div class=""form-bd-txt showAddress""");
                BeginWriteAttribute("title", " title=\"", 6265, "\"", 6273, 0);
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 126 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Person\information.cshtml"
                                                                                 Write(Model.Myuser.UserAddr);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</div>
                                    </div>
                                </div>
                            </div>
                            <!-- ?????????????????? -->

                            <div class=""form-list form-list-view"" id=""relation_way_change"" style=""display: none"">
                                <div class=""form-item"" style=""position:relative"">
                                    <div class=""form-label"" hidden=""hidden"">????????????</div>
                                    <div class=""form-bd"">
                                        <input class=""input"" id=""mobileNo""");
                BeginWriteAttribute("value", " value=\"", 6891, "\"", 6922, 1);
#nullable restore
#line 136 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Person\information.cshtml"
WriteAttributeValue("", 6899, Model.Myuser.UserPhone, 6899, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("placeholder", " placeholder=\"", 6923, "\"", 6960, 1);
#nullable restore
#line 136 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Person\information.cshtml"
WriteAttributeValue("", 6937, Model.Myuser.UserPhone, 6937, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" hidden=\"hidden\">\r\n                                        <div class=\"form-tips\" id=\"phonePrompt\" style=\"display: none\">??????????????????????????????</div>\r\n                                    </div>\r\n                                </div>\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98b8721011be4182a5c46b113abd7f06e90c529216929", async() => {
                    WriteLiteral(@"
                                    <div class=""form-item"" style=""position:relative"">
                                        <div class=""form-label"">?????????</div>
                                        <div class=""form-bd"">
                                            <input class=""input"" name=""email"" id=""email"" placeholder=""???????????????"">
                                            <div class=""form-tips""  id=""emailPrompt"" style=""display: none"">?????????????????????????????????</div>
                                        </div>
                                    </div>
                                    <div class=""form-item"">
                                        <div class=""form-label"">?????????</div>
                                        <div class=""form-bd"">
                                            <input class=""input"" name=""address"" placeholder=""???????????????"">
                                        </div>
                                    </div>
                                    <div class=""form-item"">
              ");
                    WriteLiteral("                          <input id=\"bt2\" class=\"cancel-change\" type=\"button\" value=\"??????\">\r\n");
                    WriteLiteral("                                        <button class=\"confirm-change\" type=\"submit\">????????????</button>\r\n                                    </div>\r\n                                ");
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
                    </div>
                    <!-- ??????????????? -->
                    <div class=""panel-border"" style=""display: none"" id=""partnerInfo"">
                        <div class=""form-list"">
                            <!-- ???????????????????????? -->
                            <div class=""partner"" id=""self"">
                                <div class=""partner-top"">
                                    <div class=""partnerInfo"">
                                        <div class=""form-item"">
                                            <div class=""form-label""><span class=""required"">*</span>?????????</div>
                                            <div class=""form-bd"">
                                                <div class=""form-bd-txt"">");
#nullable restore
#line 174 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Person\information.cshtml"
                                                                    Write(Model.Myuser.UserRName);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</div>
                                            </div>
                                        </div>
                                        <div class=""form-item"">
                                            <div class=""form-label""><span class=""required"">*</span>???????????????</div>
                                            <div class=""form-bd"">
                                                <div class=""form-bd-txt"">");
#nullable restore
#line 180 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Person\information.cshtml"
                                                                    Write(Model.Myuser.UserPID);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</div>
                                            </div>
                                        </div>
                                    </div>
                                    <div>
                                    </div>
                                </div>
                                <div class=""line-dashed""></div>
                            </div>
                            <!-- ?????????????????????????????? -->
");
#nullable restore
#line 190 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Person\information.cshtml"
                              
                                if (Model != null && Model.Mypassenger!=null&& Model.Mypassenger.Count > 0)
                                {
                                    for (int i = 0; i < Model.Mypassenger.Count; i++)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98b8721011be4182a5c46b113abd7f06e90c529222801", async() => {
                    WriteLiteral("\r\n                                                            <div class=\"partner\"");
                    BeginWriteAttribute("id", " id=\"", 10883, "\"", 10902, 2);
                    WriteAttributeValue("", 10888, "partner-", 10888, 8, true);
#nullable restore
#line 196 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Person\information.cshtml"
WriteAttributeValue("", 10896, i+1, 10896, 6, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@">
                                                                <div class=""partner-top"">
                                                                    <div class=""partnerInfo"">
                                                                        <div class=""form-item"">
                                                                            <div class=""form-label""><span class=""required"">*</span>?????????</div>
                                                                            <div class=""form-bd"">
                                                                                <input hidden=""hidden"" name=""PassengerName""");
                    BeginWriteAttribute("value", " value=\"", 11553, "\"", 11597, 1);
#nullable restore
#line 202 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Person\information.cshtml"
WriteAttributeValue("", 11561, Model.Mypassenger[i].PassengerRName, 11561, 36, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral("/>\r\n                                                                                <div class=\"form-bd-txt\" >");
#nullable restore
#line 203 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Person\information.cshtml"
                                                                                                     Write(Model.Mypassenger[i].PassengerRName);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"</div>
                                                                            </div>
                                                                        </div>
                                                                        <div class=""form-item"">
                                                                            <div class=""form-label""><span class=""required"">*</span>???????????????</div>
                                                                            <div class=""form-bd"">
                                                                                <input hidden=""hidden"" name=""PassengerPID""");
                    BeginWriteAttribute("value", " value=\"", 12378, "\"", 12420, 1);
#nullable restore
#line 209 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Person\information.cshtml"
WriteAttributeValue("", 12386, Model.Mypassenger[i].PassengerPID, 12386, 34, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n                                                                                <div class=\"form-bd-txt\" >");
#nullable restore
#line 210 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Person\information.cshtml"
                                                                                                     Write(Model.Mypassenger[i].PassengerPID);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"</div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                    <div>
");
                    WriteLiteral("                                                                        <button");
                    BeginWriteAttribute("id", " id=\"", 13158, "\"", 13182, 2);
                    WriteAttributeValue("", 13163, "deletPartner-", 13163, 13, true);
#nullable restore
#line 216 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Person\information.cshtml"
WriteAttributeValue("", 13176, i+1, 13176, 6, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" class=""deletPartner"" type=""submit"">??? ???</button>
                                                                    </div>
                                                                </div>
                                                                <div class=""line-dashed""></div>
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
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("   \r\n");
#nullable restore
#line 222 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Person\information.cshtml"
                                    }
                                }
                            

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            <!--?????????????????????-->\r\n\r\n                        <div class=\"partner\" id=\"addPartnerInfo\" style=\"display: none\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98b8721011be4182a5c46b113abd7f06e90c529229834", async() => {
                    WriteLiteral(@"
                                <div class=""partner-top"">
                                    <div class=""partnerInfo"">
                                        <div class=""form-item"">
                                            <div class=""form-label""><span class=""required"">*</span>?????????</div>
                                            <div class=""form-bd"">
                                                <input class=""input"" name=""pName"" placeholder=""???????????????"">
                                            </div>
                                        </div>
                                        <div class=""form-item"">
                                            <div class=""form-label""><span class=""required"">*</span>???????????????</div>
                                            <div class=""form-bd"">
                                                <input class=""input"" name=""pID"" placeholder=""?????????????????????"">
                                            </div>
                                        </div>
      ");
                    WriteLiteral(@"                              </div>
                                </div>
                                <div class=""line-dashed""></div>
                                <div class=""form-item"">
                                    <input class=""cancel-change"" type=""button"" value=""??????"" onClick=""cancelAddPartener()"">
");
                    WriteLiteral("                                    <button class=\"confirm-change\" type=\"submit\">????????????</button>\r\n                                </div>\r\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </div>

                            <input id=""createPartner"" style=""display: block"" class=""addPartner"" type=""button"" value=""+???????????????"" onClick=""addPartener()"">
                            <div class=""blank""> </div>
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
            WriteLiteral("\r\n</html>\r\n<script type=\"text/javascript\" src=\"/Person/personal_information.js\"></script>\r\n");
#nullable restore
#line 268 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Person\information.cshtml"
  
    if (Model.Deal_message != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <script>\r\n            alert(\"");
#nullable restore
#line 272 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Person\information.cshtml"
              Write(Model.Deal_message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\");\r\n        </script>\r\n");
#nullable restore
#line 274 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Person\information.cshtml"
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReturnModels.Person_Information> Html { get; private set; }
    }
}
#pragma warning restore 1591
