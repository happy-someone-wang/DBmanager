#pragma checksum "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Person\ticket.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be32457c4770635f6aab8036a3609c4517e05525"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Person_ticket), @"mvc.1.0.view", @"/Views/Person/ticket.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be32457c4770635f6aab8036a3609c4517e05525", @"/Views/Person/ticket.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d958efeed3f68c64ceb229445b28e0a04d5f41d", @"/Views/_ViewImports.cshtml")]
    public class Views_Person_ticket : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReturnModels.OrderList>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be32457c4770635f6aab8036a3609c4517e055253244", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <title>personal_ticket</title>\r\n    <link rel=\"stylesheet\" href=\"personal_ticket.css\" />\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be32457c4770635f6aab8036a3609c4517e055254344", async() => {
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
                <li class=""nav-item"">
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
                WriteLiteral(@"    <img class=""img1"" src=""/Person/image/我的订单1.png"">
                    <img class=""img2"" src=""/Person/image/我的订单2.png"">
                    <a href=""/Person/ticket"">我的订单</a>
                </li>
                <li class=""current nav-item"">
                    <img class=""img1"" src=""/Person/image/安全中心1.png"">
                    <img class=""img2"" src=""/Person/image/安全中心2.png"">
                    <a href=""/Person/account"">安全中心</a>
                </li>
            </ul>
        </div>
    </div>
    <div class=""logout"">
        <img src=""../image/train.png"">
        <span>您好！</span>
        <span>");
#nullable restore
#line 48 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Person\ticket.cshtml"
         Write(Model.Myuser.UserRName);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
        <a href=""#"">退出登录</a>
    </div>

    <div class=""content"">
        <!-- 车票信息右侧内容 -->
        <div class=""subway-order"">
            <div class=""panel-tab"">
                <!--上部导航栏-->
                <div class=""tab-hd"">
                    <ul class=""tab-hd-list"" id=""order_tab"">
                        <li id=""order_tab_1"" data-type=""0""> <a href=""javascript:;"" style=""background-color: #6f9aff22;"">未出行订单 </a> </li>
                        <li id=""order_tab_2"" data-type=""1""> <a href=""javascript:;"" style=""background-color: #6f9aff22;"">历史订单</a> </li>
                    </ul>
                </div>
                <div class=""tab-bd"">
                    <!-- 未出行订单 -->
                    <div class=""tab-item"" style=""display:block; min-height: 530px;"" id=""untrip"">
                        <!-- 未出行订单列表 -->
                        <div class=""order-panel order-panel-history"">
                            <!-- 订单-搜索表单 -->
                            <div class=""search-form-mini"">
                WriteLiteral(@"
                                <div class=""form-item"">
                                    <div class=""sel w160"">
                                        <div class=""sel-hd"">
                                            <div class=""sel-inner"" id=""chuxunType""> 按订票日期查询 </div>
                                            <i class=""icon icon-caret-down""></i>
                                        </div>
                                        <div class=""sel-bd select-old"">
                                            <ul class=""sel-list"" id=""wcx_seach_type"">
                                                <li id=""ifSelected"" class=""selected ifSelected""> 按订票日期查询 </li>
                                                <li>按乘车日期查询</li>
                                            </ul>
                                        </div>
                                    </div>
                                </div>
                                <div class=""form-item"">
                                    ");
                WriteLiteral("<div class=\"input-box input-data w160\">\r\n                                        <input type=\"text\" id=\"noTripFromDate\" class=\"input\"");
                BeginWriteAttribute("value", " value=\"", 4050, "\"", 4058, 0);
                EndWriteAttribute();
                WriteLiteral(@" aria-label=""请输入日期，例如2021杠01杠01"" autocomplete=""off"">
                                        <i class=""icon icon-date"" data-click=""noTripFromDate""></i>
                                    </div>
                                    <span class=""txt-lighter""> - </span>
                                    <div class=""input-box input-data w160"">
                                        <input type=""text"" id=""noTripToDate"" class=""input""");
                BeginWriteAttribute("value", " value=\"", 4498, "\"", 4506, 0);
                EndWriteAttribute();
                WriteLiteral(@" aria-label=""请输入日期，例如2021杠01杠01"" autocomplete=""off"">
                                        <i class=""icon icon-date"" data-click=""noTripToDate""></i>
                                    </div>
                                </div>
                                <div class=""form-item"">
                                    <div class=""input-box input-data w160"">
                                        <input type=""text"" class=""input"" id=""noTripName"" placeholder=""订单号/车次/姓名"" autocomplete=""off"">
                                        <i class=""icon icon-clear""></i>
                                    </div>
                                </div>
                                <div class=""form-item""> <a href=""javascript:;"" class=""btn w100"" id=""searchNoTrip"">查询</a> </div>
                            </div>
                            <div class=""order-filter"" style=""margin-top: 20px""> <a href=""javascript:;"" class=""active"">全部</a> <a href=""javascript:;"">可改签</a> <a href=""javascript:;"">可退票</a> </div>
   ");
                WriteLiteral(@"                         <!-- 订单-订单列表头部 -->
                            <table class=""order-panel-head title-text"" style=""display:table;"">
                                <colgroup>
                                    <col class=""col-train"">
                                    <col class=""col-passenger"">
                                    <col class=""col-seat"">
                                    <col class=""col-price"">
                                    <col class=""col-state"">
                                    <col>
                                </colgroup>
                                <tbody>
                                    <tr>
                                        <th>车次信息</th>
                                        <th style=""width: 200px"">旅客信息</th>
                                        <th>席位信息</th>
                                        <th>票价</th>
                                        <th>车票状态</th>
                                        <!-- <th>总金额</th> -->
   ");
                WriteLiteral("                                 </tr>\r\n                                </tbody>\r\n                            </table>\r\n                            <div id=\"not_travel\">\r\n");
#nullable restore
#line 126 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Person\ticket.cshtml"
                                  
                                    if (Model != null)
                                    {
                                        for(int i=0;i<Model.List.Count;i++)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                    <div class=""order-item"">
                                        <div class=""order-item-hd"">
                                            <div class=""order-hd-info""><span class=""txt-light"">订票时间：</span><span class=""dingqiaoDate"" data-date=""");
#nullable restore
#line 133 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Person\ticket.cshtml"
                                                                                                                                            Write(Model.List[i].OrderCreate);

#line default
#line hidden
#nullable disable
                WriteLiteral("\">");
#nullable restore
#line 133 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Person\ticket.cshtml"
                                                                                                                                                                        Write(Model.List[i].OrderCreate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></div>\r\n                                            <div class=\"order-hd-info\"><span class=\"txt-light\">订单号：</span>");
#nullable restore
#line 134 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Person\ticket.cshtml"
                                                                                                     Write(Model.List[i].OrderID);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</div>
                                        </div>
                                        <div class=""order-item-bd"">
                                            <table class=""order-item-table"" id=""query_order_form_ED43099486"">
                                                <colgroup>
                                                    <col class=""col-train"">
                                                    <col class=""col-passenger"">
                                                    <col class=""col-seat"">
                                                    <col class=""col-price"">
                                                    <col class=""col-state"">
                                                    <col>
                                                </colgroup>
                                                <tbody>
                                                    <tr class=""has-order-num "">
                                                        <td class=""td-left align-t");
                WriteLiteral(@"op"" rowspan=""1"">
                                                            <div class=""order-info-ticket"">
                                                                <!-- <div class=""order-num-one"">去程</div> -->
                                                                <div class=""txt-bold txt-lg"">");
#nullable restore
#line 151 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Person\ticket.cshtml"
                                                                                        Write(Model.Start_station[i]);

#line default
#line hidden
#nullable disable
                WriteLiteral("&nbsp;&gt;&nbsp;");
#nullable restore
#line 151 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Person\ticket.cshtml"
                                                                                                                               Write(Model.End_station[i]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 151 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Person\ticket.cshtml"
                                                                                                                                                     Write(Model.List[i].TrainID);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                                                                <div>");
#nullable restore
#line 152 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Person\ticket.cshtml"
                                                                Write(Model.List[i].LeavingTime);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" 开</div>
                                                            </div>
                                                        </td>
                                                        <td style=""width: 200px;"">
                                                            <div class=""passenger-operation"">
                                                                <div class=""passenger-check data-val"" data-sequence=""ED43099486"" data-value=""ED43099486,1,03,0011,2022-09-14 11:10"" data-tradeno=""NN1NNNJ0Z0Z1N0W1Z00N00  000Z0Z      00Z""> </div>
                                                                <div>");
#nullable restore
#line 158 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Person\ticket.cshtml"
                                                                Write(Model.List[i].Passenger.PassengerRName);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" </div>
                                                                <div> 中国居民身份证 </div>
                                                            </div>
                                                        </td>
                                                        <td>
                                                            <div>");
#nullable restore
#line 163 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Person\ticket.cshtml"
                                                            Write(Model.Seat_level[i]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                                                            <div>");
#nullable restore
#line 164 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Person\ticket.cshtml"
                                                            Write(Model.List[i].CarriageNo);

#line default
#line hidden
#nullable disable
                WriteLiteral(" 车 ");
#nullable restore
#line 164 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Person\ticket.cshtml"
                                                                                        Write(Model.List[i].SeatNo);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" 号</div>
                                                        </td>
                                                        <td style=""position: relative;"">
                                                            <div> 成人票 </div>
                                                            <div><span class=""txt-price"">");
#nullable restore
#line 168 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Person\ticket.cshtml"
                                                                                    Write(Model.List[i].OrderValue);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" 元</span></div>
                                                        </td>
                                                        <td>
                                                            <div class=""ticket-status-name"">
                                                                <div> 已支付 </div>
                                                            </div>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan=""6"" class=""order-operation"">
                                                            <div class=""btn-right"">
                                                                <div class=""alert alert-rebuy"">
                                                                    <div class=""alert-hd"">
                                                                        改签申请
        ");
                WriteLiteral(@"                                                                <span class=""alert-close"" onclick=""alert_rebuy()"">X</span>
                                                                    </div>
                                                                    <div class=""alert-bd"">
                                                                        <h2 class=""msg"">您确认要改签吗？</h2>
                                                                    </div>
                                                                    <div class=""choice"">
                                                                        <a href=""#"" onclick=""alert_rebuy()"" class=""tc_btn"">取消</a>
                                                                        <a");
                BeginWriteAttribute("href", " href=\"", 12286, "\"", 12337, 2);
                WriteAttributeValue("", 12293, "/Train/reBuy?Order_ID=", 12293, 22, true);
#nullable restore
#line 189 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Person\ticket.cshtml"
WriteAttributeValue("", 12315, Model.List[i].OrderID, 12315, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""tc_btn"" data-sequenceno=""ED43099486"" data-type=""N"" data-start-train-date-page=""2022-09-14 11:10"" style=""margin-left: 30px;"">确定</a>
                                                                    </div>
                                                                </div>
                                                                <a href=""#"" onclick=""alert_rebuy()"" class=""btn resignTrain"">改签</a>
                                                                <div class=""alert alert-cancel"">
                                                                    <div class=""alert-hd"">
                                                                        退票申请
                                                                        <span class=""alert-close"" onclick=""alert_cancel()"">X</span>
                                                                    </div>
                                                                    <div class=""alert-bd"">
                                   ");
                WriteLiteral(@"                                     <h2 class=""msg"">您确认要退票吗？</h2>
                                                                    </div>
                                                                    <div class=""choice"">
                                                                        <a href=""#"" onclick=""alert_cancel()"" class=""tc_btn"">取消</a>
                                                                        <a");
                BeginWriteAttribute("href", " href=\"", 13802, "\"", 13857, 2);
                WriteAttributeValue("", 13809, "/Person/t_cancel?Order_ID=", 13809, 26, true);
#nullable restore
#line 203 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Person\ticket.cshtml"
WriteAttributeValue("", 13835, Model.List[i].OrderID, 13835, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"tc_btn\" data-sequenceno=\"");
#nullable restore
#line 203 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Person\ticket.cshtml"
                                                                                                                                                              Write(Model.List[i].OrderID);

#line default
#line hidden
#nullable disable
                WriteLiteral(@""" data-type=""Y"" style=""margin-left: 30px;"">确定</a>
                                                                    </div>
                                                                </div>
                                                                <a href=""#"" onclick=""alert_cancel()"" class=""btn resignTrain"">退票</a>
                                                            </div>
                                                        </td>
                                                    </tr>
                                                </tbody>
                                            </table>
                                        </div>
                                    </div>
");
#nullable restore
#line 214 "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Person\ticket.cshtml"
                                        }

                                    }
                                

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            </div>
                            <div id=""J-Trip"" class=""pagination mt-lg""></div>
                        </div>
                    </div>
                    <!-- 历史订单 -->
                    <div class=""tab-item"" style=""display: none; min-height: 530px;"" id=""history"">
                        <!-- 历史订单列表 -->
                        <div class=""order-panel order-panel-history"">
                            <!-- 订单-搜索表单 -->
                            <div class=""search-form-mini"">
                                <div class=""form-item"">
                                    <div class=""sel-inner"">乘车日期</div>
                                </div>
                                <div class=""form-item"">
                                    <div class=""input-box input-data w160"">
                                        <input type=""text"" id=""historyFromDate"" class=""input""");
                BeginWriteAttribute("value", " value=\"", 15679, "\"", 15687, 0);
                EndWriteAttribute();
                WriteLiteral(@" aria-label=""请输入日期，例如2021杠01杠01"" autocomplete=""off"">
                                        <i class=""icon icon-date"" data-click=""historyFromDate""></i>
                                    </div>
                                    <span class=""txt-lighter""> - </span>
                                    <div class=""input-box input-data w160"">
                                        <input type=""text"" id=""historyToDate"" class=""input""");
                BeginWriteAttribute("value", " value=\"", 16129, "\"", 16137, 0);
                EndWriteAttribute();
                WriteLiteral(@" aria-label=""请输入日期，例如2021杠01杠01"" autocomplete=""off"">
                                        <i class=""icon icon-date"" data-click=""historyToDate""></i>
                                    </div>
                                </div>
                                <div class=""form-item"">
                                    <div class=""input-box input-data w160"">
                                        <input type=""text"" class=""input"" placeholder=""订单号/车次/姓名"" id=""historyName"" autocomplete=""off"">
                                        <i class=""icon icon-clear""></i>
                                    </div>
                                </div>
                                <div class=""form-item""> <a href=""javascript:;"" class=""btn w100"" id=""searchHistory"">查询</a> </div>
                            </div>

                            <!-- 历史订单-历史订单列表头部 -->
                            <table class=""order-panel-head title-text"" style=""display:table;"">
                                <colgroup>
 ");
                WriteLiteral(@"                                   <col class=""col-train"">
                                    <col class=""col-passenger"">
                                    <col class=""col-seat"">
                                    <col class=""col-price"">
                                    <col class=""col-state"">
                                    <col>
                                </colgroup>
                                <tbody>
                                    <tr>
                                        <th>车次信息</th>
                                        <th style=""width: 200px"">旅客信息</th>
                                        <th>席位信息</th>
                                        <th>票价</th>
                                        <th>车票状态</th>
                                        <!-- <th>总金额</th> -->
                                    </tr>
                                </tbody>
                            </table>
                            <div id=""history_travel"">
           ");
                WriteLiteral(@"                     <div class=""order-item"">
                                    <div class=""order-item-hd"">
                                        <div class=""order-hd-info""><span class=""txt-light"">订票日期：</span><span class=""dingqiaoDate"" data-date=""2022-08-31 21:23:25"">2022-08-31</span></div>
                                        <div class=""order-hd-info""><span class=""txt-light"">订单号：</span>ED43099485</div>
                                    </div>
                                    <div class=""order-item-bd"">
                                        <table class=""order-item-table"" id=""query_order_form_ED43099485"">
                                            <colgroup>
                                                <col class=""col-train"">
                                                <col class=""col-passenger"">
                                                <col class=""col-seat"">
                                                <col class=""col-price"">
                                      ");
                WriteLiteral(@"          <col class=""col-state"">
                                                <col>
                                            </colgroup>
                                            <tbody>
                                                <tr class=""has-order-num "">
                                                    <td class=""td-left align-top"" rowspan=""1"">
                                                        <div class=""order-info-ticket"">
                                                            <!-- <div class=""order-num-one"">去程</div> -->
                                                            <div class=""txt-bold txt-lg"">白银西&nbsp;&gt;&nbsp;长征 7515</div>
                                                            <div>2022-09-14&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 11:10 开</div>
                                                        </div>
                                                    </td>
                                                    <td style=""width: 200px;"">
   ");
                WriteLiteral(@"                                                     <div class=""passenger-operation"">
                                                            <div class=""passenger-check data-val"" data-sequence=""ED43099486"" data-value=""ED43099486,1,03,0011,2022-09-14 11:10"" data-tradeno=""NN1NNNJ0Z0Z1N0W1Z00N00  000Z0Z      00Z""> </div>
                                                            <div>白晶晶 </div>
                                                            <div> 中国居民身份证 </div>
                                                        </div>
                                                    </td>
                                                    <td>
                                                        <div>硬座</div>
                                                        <div>03车011号</div>
                                                    </td>
                                                    <td style=""position: relative;"">
                                                        <div> 成人");
                WriteLiteral(@"票 </div>
                                                        <div><span class=""txt-price"">6.5元</span></div>
                                                    </td>
                                                    <td>
                                                        <div class=""ticket-status-name"">
                                                            <div> 已支付 </div>
                                                        </div>
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                            </div>
                            <div id=""J-History"" class=""pagination mt-lg""></div>
                        </div>
                    </div>
                </div>
            </div>

            <!-- 暂无数据 -->
         ");
                WriteLiteral(@"   <div class=""panel-tab"" id=""noDataDom"" style=""display: none"">
                <div class=""tab-bd"">
                    <!-- 历史订单 -->
                    <div class=""tab-item"" style=""display: block; min-height: 530px;"">
                        <!-- 历史订单列表 -->
                        <div class=""order-panel order-panel-history"">
                            <div class=""order-empty"">
                                <div class=""empty-txt"">
                                    <p>您没有对应的订单内容哦～</p>
                                    <p> 您可以通过<a href=""JavaScript:;"" class=""txt-primary underline"">车票订购</a>功能，来制定出行计划。 </p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <script type=""text/javascript"" src=""personal_ticket.js""></script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReturnModels.OrderList> Html { get; private set; }
    }
}
#pragma warning restore 1591