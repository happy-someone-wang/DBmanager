#pragma checksum "C:\Users\17594\source\repos\12306\DBmanager\12306\Views\Person\ticket.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2183c5b495a9d984a370502278b8174e3631f7b"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2183c5b495a9d984a370502278b8174e3631f7b", @"/Views/Person/ticket.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d958efeed3f68c64ceb229445b28e0a04d5f41d", @"/Views/_ViewImports.cshtml")]
    public class Views_Person_ticket : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2183c5b495a9d984a370502278b8174e3631f7b3229", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <title>personal_ticket</title>\r\n    <link rel=\"stylesheet\" href=\"/Person/personal_ticket.css\" />\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2183c5b495a9d984a370502278b8174e3631f7b4341", async() => {
                WriteLiteral(@"
    <br>
    <div class=""wrapper content"">
        <!-- 面包屑 -->
        <div class=""breadcrumb""> 当前位置： <a href=""/Person/center"">个人中心</a> <span class=""sep"">&gt;</span> <span class=""active"">订单中心</span> </div>
        <div class=""center-box"">
            <!-- 车票信息左侧 -->
            <!-- 车票信息左侧菜单 -->
            <ul class=""center-menu"" role=""menubar"">
                <li class=""menu-item"" id=""gerenzhongxin"" role=""menuitem"">
                    <h2 class=""menu-tit""> <a href=""/Person/center"">个人中心</a> </h2>
                </li>
                <li class=""menu-item"" role=""menuitem"">
                    <h2 class=""menu-tit active""> <a href=""/Person/ticket"">订单中心</a> </h2>
                </li>
                <li class=""menu-item"" role=""menuitem"">
                    <h2 class=""menu-tit""> <a href=""/Person/information"">个人信息</a> </h2>
                </li>
                <li class=""menu-item"" role=""menuitem"">
                    <h2 class=""menu-tit""> <a href=""/Person/account"">密码修改</a> </h2>
       ");
                WriteLiteral(@"         </li>
            </ul>
            <div class=""center-main"">
                <!-- 车票信息右侧内容 -->
                <div class=""subway-order"">
                    <div class=""panel-tab"">
                        <!--上部导航栏-->
                        <div class=""tab-hd"">
                            <ul class=""tab-hd-list"" id=""order_tab"">
                                <li id=""order_tab_1"" data-type=""0""> <a href=""javascript:;"">未出行订单 </a> </li>
                                <li id=""order_tab_2"" data-type=""1""> <a href=""javascript:;"">历史订单</a> </li>
                            </ul>
                        </div>
                        <div class=""tab-bd"">
                            <!-- 未出行订单 -->
                            <div class=""tab-item"" style=""display:block; min-height: 530px;"" id=""untrip"">
                                <!-- 未出行订单列表 -->
                                <div class=""order-panel order-panel-history"">
                                    <!-- 订单-搜索表单 -->
           ");
                WriteLiteral(@"                         <div class=""search-form-mini"">
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
                         ");
                WriteLiteral(@"                   </div>
                                        </div>
                                        <div class=""form-item"">
                                            <div class=""input-box input-data w160"">
                                                <input type=""text"" id=""noTripFromDate"" class=""input""");
                BeginWriteAttribute("value", " value=\"", 3577, "\"", 3585, 0);
                EndWriteAttribute();
                WriteLiteral(@" aria-label=""请输入日期，例如2021杠01杠01"" autocomplete=""off"">
                                                <i class=""icon icon-date"" data-click=""noTripFromDate""></i>
                                            </div>
                                            <span class=""txt-lighter""> - </span>
                                            <div class=""input-box input-data w160"">
                                                <input type=""text"" id=""noTripToDate"" class=""input""");
                BeginWriteAttribute("value", " value=\"", 4065, "\"", 4073, 0);
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
                                    <div class=""order-filter"" style=""margin-top: 20px""> <a href=""javascript:;""");
                WriteLiteral(@" class=""active"">全部</a> <a href=""javascript:;"">可改签</a> <a href=""javascript:;"">可退票</a> </div>
                                    <!-- 订单-订单列表头部 -->
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
                     ");
                WriteLiteral(@"                           <th>席位信息</th>
                                                <th>票价</th>
                                                <th>车票状态</th>
                                                <!-- <th>总金额</th> -->
                                            </tr>
                                        </tbody>
                                    </table>
                                    <div id=""not_travel"">
                                        <div class=""order-item"">
                                            <div class=""order-item-hd"">
                                                <div class=""order-hd-info""><span class=""txt-light"">订票日期：</span><span class=""dingqiaoDate"" data-date=""2022-08-31 21:23:25"">2022-08-31</span></div>
                                                <div class=""order-hd-info""><span class=""txt-light"">订单号：</span>ED43099486</div>
                                            </div>
                                            <div class=""order-item-");
                WriteLiteral(@"bd"">
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
                                                            <td class=""td-left align-top"" rowspan=""1"">
                                                     ");
                WriteLiteral(@"           <div class=""order-info-ticket"">
                                                                    <!-- <div class=""order-num-one"">去程</div> -->
                                                                    <div class=""txt-bold txt-lg"">白银西&nbsp;&gt;&nbsp;长征 7515</div>
                                                                    <div>2022-09-14&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 11:10 开</div>
                                                                </div>
                                                            </td>
                                                            <td style=""width: 200px;"">
                                                                <div class=""passenger-operation"">
                                                                    <div class=""passenger-check data-val"" data-sequence=""ED43099486"" data-value=""ED43099486,1,03,0011,2022-09-14 11:10"" data-tradeno=""NN1NNNJ0Z0Z1N0W1Z00N00  000Z0Z      00Z""> </div>
                          ");
                WriteLiteral(@"                                          <div>白晶晶 </div>
                                                                    <div> 中国居民身份证 </div>
                                                                </div>
                                                            </td>
                                                            <td>
                                                                <div>硬座</div>
                                                                <div>03车011号</div>
                                                            </td>
                                                            <td style=""position: relative;"">
                                                                <div> 成人票 </div>
                                                                <div><span class=""txt-price"">6.5元</span></div>
                                                            </td>
                                                            <td>
                   ");
                WriteLiteral(@"                                             <div class=""ticket-status-name"">
                                                                    <div> 已支付 </div>
                                                                </div>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td colspan=""6"" class=""order-operation""><div class=""btn-right""> <a href=""javascript:void(0)"" class=""btn resignTrain"" data-sequenceno=""ED43099486"" data-type=""N"" data-start-train-date-page=""2022-09-14 11:10"">改签</a> <a href=""javascript:void(0)"" class=""btn resignTrain"" data-sequenceno=""ED43099486"" data-type=""Y"" onclick=""ac()"">退票</a> </div></td>
                                                        </tr>
                                                    </tbody>
                                                </table>
        ");
                WriteLiteral(@"                                    </div>
                                        </div>
                                    </div>
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
                                            <div class=""input-box inp");
                WriteLiteral("ut-data w160\">\r\n                                                <input type=\"text\" id=\"historyFromDate\" class=\"input\"");
                BeginWriteAttribute("value", " value=\"", 12383, "\"", 12391, 0);
                EndWriteAttribute();
                WriteLiteral(@" aria-label=""请输入日期，例如2021杠01杠01"" autocomplete=""off"">
                                                <i class=""icon icon-date"" data-click=""historyFromDate""></i>
                                            </div>
                                            <span class=""txt-lighter""> - </span>
                                            <div class=""input-box input-data w160"">
                                                <input type=""text"" id=""historyToDate"" class=""input""");
                BeginWriteAttribute("value", " value=\"", 12873, "\"", 12881, 0);
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
                                    <table cl");
                WriteLiteral(@"ass=""order-panel-head title-text"" style=""display:table;"">
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
                            ");
                WriteLiteral(@"                    <!-- <th>总金额</th> -->
                                            </tr>
                                        </tbody>
                                    </table>
                                    <div id=""history_travel"">
                                        <div class=""order-item"">
                                            <div class=""order-item-hd"">
                                                <div class=""order-hd-info""><span class=""txt-light"">订票日期：</span><span class=""dingqiaoDate"" data-date=""2022-08-31 21:23:25"">2022-08-31</span></div>
                                                <div class=""order-hd-info""><span class=""txt-light"">订单号：</span>ED43099485</div>
                                            </div>
                                            <div class=""order-item-bd"">
                                                <table class=""order-item-table"" id=""query_order_form_ED43099485"">
                                                    <colgroup>
     ");
                WriteLiteral(@"                                                   <col class=""col-train"">
                                                        <col class=""col-passenger"">
                                                        <col class=""col-seat"">
                                                        <col class=""col-price"">
                                                        <col class=""col-state"">
                                                        <col>
                                                    </colgroup>
                                                    <tbody>
                                                        <tr class=""has-order-num "">
                                                            <td class=""td-left align-top"" rowspan=""1"">
                                                                <div class=""order-info-ticket"">
                                                                    <!-- <div class=""order-num-one"">去程</div> -->
                                ");
                WriteLiteral(@"                                    <div class=""txt-bold txt-lg"">白银西&nbsp;&gt;&nbsp;长征 7515</div>
                                                                    <div>2022-09-14&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 11:10 开</div>
                                                                </div>
                                                            </td>
                                                            <td style=""width: 200px;"">
                                                                <div class=""passenger-operation"">
                                                                    <div class=""passenger-check data-val"" data-sequence=""ED43099486"" data-value=""ED43099486,1,03,0011,2022-09-14 11:10"" data-tradeno=""NN1NNNJ0Z0Z1N0W1Z00N00  000Z0Z      00Z""> </div>
                                                                    <div>白晶晶 </div>
                                                                    <div> 中国居民身份证 </div>
                                         ");
                WriteLiteral(@"                       </div>
                                                            </td>
                                                            <td>
                                                                <div>硬座</div>
                                                                <div>03车011号</div>
                                                            </td>
                                                            <td style=""position: relative;"">
                                                                <div> 成人票 </div>
                                                                <div><span class=""txt-price"">6.5元</span></div>
                                                            </td>
                                                            <td>
                                                                <div class=""ticket-status-name"">
                                                                    <div> 已支付 </div>
                         ");
                WriteLiteral(@"                                       </div>
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
                    <div class=""panel-tab"" id=""noDataDom"" style=""display: none"">
                        <div class=""tab-bd"">
                            <!-- 历史订单 -->
                            <div class=""tab-item"" style=""display: block; min-height: 530px;"">
                                <!-- 历史订单列表 -->
      ");
                WriteLiteral(@"                          <div class=""order-panel order-panel-history"">
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
        </div>
    </div>
    <div class=""alert"">
        <div class=""alert-hd""> 退票申请 <span class=""alert-close"" onclick=""ac()"">X</span> </div>
        <div class=""alert-bd"">
            <h2 class=""msg-tit"">您确认要退票吗？</h2>
            <hr>
            <ul style=""color: #333;"">
                <li class=""msg"" style=""font-weight: bolder;""> 共计退款： <sp");
                WriteLiteral(@"an class=""price"">6.5元</span> </li>
                <hr>
                <li class=""msg""> 手续费用： <span class=""price"">0元</span> <span style=""font-size: 10px;color: rgba(0, 0, 0, 0.500);"">(距开车时间前7天（含）以上不收取退票费，其余按票价10%计)</span> </li>
                <li class=""msg""> 车票票价： <span class=""price"">6.5元</span> </li>
            </ul>
            <hr>
        </div>
        <div class=""choice""> <a href=""#"" onclick=""ac()"" class=""tc_btn"">取消</a> <a href=""tp_succ.html"" class=""tc_btn"" style=""margin-left: 30px;"">确定</a> </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
