#pragma checksum "K:\Project\OHDProject\OHDProject\Views\Admin\ListRequests.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1384519bf82aa3cd357c4ffd8d2a6882cc9fb5be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ListRequests), @"mvc.1.0.view", @"/Views/Admin/ListRequests.cshtml")]
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
#line 1 "K:\Project\OHDProject\OHDProject\Views\_ViewImports.cshtml"
using OHDProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "K:\Project\OHDProject\OHDProject\Views\_ViewImports.cshtml"
using OHDProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1384519bf82aa3cd357c4ffd8d2a6882cc9fb5be", @"/Views/Admin/ListRequests.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97eefd7effff6d29cc829e6a7da25ab2004cfc00", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ListRequests : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OHDProject.Models.ViewModel1>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/sb-admin-2.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Pending", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Accepted", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Rejected", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Work-in-progress", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Need-more-info", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("max-width: 500px;padding-top:30px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "K:\Project\OHDProject\OHDProject\Views\Admin\ListRequests.cshtml"
   Layout = "_AdminLayout"; 

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1384519bf82aa3cd357c4ffd8d2a6882cc9fb5be7013", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1384519bf82aa3cd357c4ffd8d2a6882cc9fb5be7282", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<!-- Page Heading -->
<div class=""d-sm-flex align-items-center justify-content-between mb-4"">
    <h1 class=""h3 mb-0 text-gray-800"">List requests</h1>
</div>
<div class=""content"" style=""width: fit-content;margin-left: -15px;margin-top: -15px"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""card strpied-tabled-with-hover"">
                    <div class=""card-body table-responsive"">
                        <table class=""table table-hover table-striped table-fixed"" id=""table1"" cellpadding=""0"" style=""width:1500px;"">
                            <thead>
                                <th>Request ID</th>
                                <th>Subject</th>
                                <th>Description</th>
                                <th>Create Time</th>
                                <th>Requestor ID</th>
                                <th>Facility ID</th>
                                <th>Facility Name</th>
  ");
            WriteLiteral(@"                              <th>Assignee</th>
                                <th>End Time</th>
                                <th>Status</th>
                                <th>Remark</th>
                                <th>Details</th>
                            </thead>
                            <tbody>
");
#nullable restore
#line 32 "K:\Project\OHDProject\OHDProject\Views\Admin\ListRequests.cshtml"
                                 foreach (var item in Model) 
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 35 "K:\Project\OHDProject\OHDProject\Views\Admin\ListRequests.cshtml"
                                       Write(item._requests.RequestId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 36 "K:\Project\OHDProject\OHDProject\Views\Admin\ListRequests.cshtml"
                                       Write(item._requests.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 37 "K:\Project\OHDProject\OHDProject\Views\Admin\ListRequests.cshtml"
                                       Write(item._requests.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 38 "K:\Project\OHDProject\OHDProject\Views\Admin\ListRequests.cshtml"
                                       Write(item._requests.CreateTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 39 "K:\Project\OHDProject\OHDProject\Views\Admin\ListRequests.cshtml"
                                       Write(item._requests.requestorId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 40 "K:\Project\OHDProject\OHDProject\Views\Admin\ListRequests.cshtml"
                                       Write(item._requests.FacilityId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 41 "K:\Project\OHDProject\OHDProject\Views\Admin\ListRequests.cshtml"
                                       Write(item._facilities.FacilityName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 42 "K:\Project\OHDProject\OHDProject\Views\Admin\ListRequests.cshtml"
                                       Write(item._requests.Assignee);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 43 "K:\Project\OHDProject\OHDProject\Views\Admin\ListRequests.cshtml"
                                       Write(item._requests.EndTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 44 "K:\Project\OHDProject\OHDProject\Views\Admin\ListRequests.cshtml"
                                       Write(item._requests.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td style=\"min-width:100px;\">");
#nullable restore
#line 45 "K:\Project\OHDProject\OHDProject\Views\Admin\ListRequests.cshtml"
                                                                Write(item._requests.Remark);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                        <td id=""details"">
                                            <div class=""card-body table-responsive"" style=""position: relative;top:-28px; left:-24px; text-align:center"">
                                                <a type=""button""");
            BeginWriteAttribute("href", " href=\"", 2792, "\"", 2799, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-primary btn-block"" data-toggle=""modal"" data-target=""#myModal"" style=""width:80px; padding-left: 5px 5px; "">Details</a>

                                                <!-- Modal -->
                                                <div class=""container"">
                                                    <!-- The Modal -->
                                                    <div class=""modal"" id=""myModal"">
                                                        <div class=""modal-dialog"">
                                                            <div class=""modal-content"" style=""width:1000px;position: relative;top: 60px;left:-200px; padding: 20px 20px 50px -50px;"">
                                                                <h4>Request ID: ");
#nullable restore
#line 56 "K:\Project\OHDProject\OHDProject\Views\Admin\ListRequests.cshtml"
                                                                           Write(item._requests.RequestId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1384519bf82aa3cd357c4ffd8d2a6882cc9fb5be15857", async() => {
                WriteLiteral(@"
                                                                    <div class=""form-group"">
                                                                        <label for=""subject"" class=""control-label"" style=""margin-left: 50px;"">Subject: </label>
                                                                        <div class=""input-group"" style=""max-width: 400px;margin-left: 140px;"">
                                                                            ");
#nullable restore
#line 61 "K:\Project\OHDProject\OHDProject\Views\Admin\ListRequests.cshtml"
                                                                       Write(item._requests.Subject);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                                        </div>
                                                                    </div>

                                                                    <div class=""form-group"">
                                                                        <label for=""description"" class=""control-label"" style=""margin-left: 50px;"">Decription: </label>
                                                                        <div class=""input-group"" style=""max-width: 400px;margin-left: 140px;"">
                                                                            ");
#nullable restore
#line 68 "K:\Project\OHDProject\OHDProject\Views\Admin\ListRequests.cshtml"
                                                                       Write(item._requests.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                                        </div>
                                                                    </div>

                                                                    <div class=""form-group"">
                                                                        <label for=""requestorId"" class=""control-label"" style=""margin-left: 50px;"">Requestor ID: </label>
                                                                        <div class=""input-group"" style=""max-width: 400px;margin-left: 140px;"">
                                                                            ");
#nullable restore
#line 75 "K:\Project\OHDProject\OHDProject\Views\Admin\ListRequests.cshtml"
                                                                       Write(item._requests.requestorId);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                                        </div>
                                                                    </div>

                                                                    <div class=""form-group"">
                                                                        <label for=""requestorName"" class=""control-label"" style=""margin-left: 50px;"">Requestor ID: </label>
                                                                        <div class=""input-group"" style=""max-width: 400px;margin-left: 140px;"">
                                                                            //-----//
                                                                        </div>
                                                                    </div>

                                                                    <div class=""form-group"">
                                                                        <label for=""facilityId"" class=""control-labe");
                WriteLiteral(@"l"" style=""margin-left: 50px;"">Facility ID: </label>
                                                                        <div class=""input-group"" style=""max-width: 400px;margin-left: 140px;"">
                                                                            ");
#nullable restore
#line 89 "K:\Project\OHDProject\OHDProject\Views\Admin\ListRequests.cshtml"
                                                                       Write(item._requests.FacilityId);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                                        </div>
                                                                    </div>

                                                                    <div class=""form-group"">
                                                                        <label for=""facility"" class=""control-label"" style=""margin-left: 50px;"">Facility: </label>
                                                                        <div class=""input-group"" style=""max-width: 400px;margin-left: 140px;"">
                                                                            ");
#nullable restore
#line 96 "K:\Project\OHDProject\OHDProject\Views\Admin\ListRequests.cshtml"
                                                                       Write(item._facilities.FacilityName);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                                        </div>
                                                                    </div>

                                                                    <div class=""form-group"">
                                                                        <label for=""createtime"" class=""control-label"" style=""margin-left: 50px;"">Create Time: </label>
                                                                        <div class=""input-group"" style=""max-width: 400px;margin-left: 140px;"">
                                                                            ");
#nullable restore
#line 103 "K:\Project\OHDProject\OHDProject\Views\Admin\ListRequests.cshtml"
                                                                       Write(item._requests.CreateTime);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                                        </div>
                                                                    </div>

                                                                    <div class=""form-group"">
                                                                        <label for=""assignee"" class=""control-label"" style=""margin-left: 50px;"">Assignee: </label>
                                                                        <div class=""input-group"" style=""max-width: 400px;margin-left: 140px;"">
                                                                            ");
#nullable restore
#line 110 "K:\Project\OHDProject\OHDProject\Views\Admin\ListRequests.cshtml"
                                                                       Write(item._requests.Assignee);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                                        </div>
                                                                    </div>

                                                                    <div class=""form-group"">
                                                                        <label for=""endtime"" class=""control-label"" style=""margin-left: 50px;"">End Time: </label>
                                                                        <div class=""input-group"" style=""max-width: 400px;margin-left: 140px;"">
                                                                            ");
#nullable restore
#line 117 "K:\Project\OHDProject\OHDProject\Views\Admin\ListRequests.cshtml"
                                                                       Write(item._requests.EndTime);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                                        </div>
                                                                    </div>

                                                                    <div class=""form-group"" style=""position:relative; top: -645px;left:500px;font-size:16px;"">
                                                                        <label for=""endtime"" class=""control-label"">Current Status: </label>
                                                                        <div class=""input-group"">
                                                                            ");
#nullable restore
#line 124 "K:\Project\OHDProject\OHDProject\Views\Admin\ListRequests.cshtml"
                                                                       Write(item._requests.Status);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                                        </div>
                                                                    </div>

                                                                    <div class=""form-group"" style=""position:relative; top: -645px;left:500px;font-size:16px;"">
                                                                        <label for=""endtime"" class=""control-label"" >Change Status: </label>
                                                                        <select name=""status"" id=""status"" style=""padding:5px 5px 5px 5px"">
                                                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1384519bf82aa3cd357c4ffd8d2a6882cc9fb5be25796", async() => {
                    WriteLiteral("Pending");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1384519bf82aa3cd357c4ffd8d2a6882cc9fb5be27097", async() => {
                    WriteLiteral("Accepted");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1384519bf82aa3cd357c4ffd8d2a6882cc9fb5be28399", async() => {
                    WriteLiteral("Rejected");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1384519bf82aa3cd357c4ffd8d2a6882cc9fb5be29701", async() => {
                    WriteLiteral("Work-in-progress");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1384519bf82aa3cd357c4ffd8d2a6882cc9fb5be31011", async() => {
                    WriteLiteral("Need-more-info");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                                                        </select>
                                                                    </div>

                                                                    <div class=""form-group"" style=""position: relative; top: -645px; left: 500px; font-size: 16px;"">
                                                                        <label for=""endtime"" class=""control-label"">Remark: </label>
                                                                        <div class=""input-group"" style=""margin-top: 20px;"">
                                                                            <textarea class=""form-control"" style=""max-width:300px;"" name=""Remark"" id=""Remark""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 12191, "\"", 12227, 1);
#nullable restore
#line 142 "K:\Project\OHDProject\OHDProject\Views\Admin\ListRequests.cshtml"
WriteAttributeValue("", 12205, item._requests.Remark, 12205, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"></textarea>
                                                                        </div>
                                                                    </div>

                                                                    <div class=""input-group"" style=""position:relative; top:-152px;left:330px"">
                                                                        <div class=""submitbutton"">
                                                                            <a type=""button""");
                BeginWriteAttribute("href", " href=\"", 12736, "\"", 12743, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""btn btn-primary btn-block cancel-btn"">Cancel</a>
                                                                        </div>
                                                                    </div>
                                                                    <div class=""input-group"" style=""position:relative; top:-190px;left:410px"">
                                                                        <div class=""submitbutton"">
                                                                            <button type=""submit"" class=""btn btn-primary btn-block submit-btn"" onclick=""return confirm('Confirm to save the changes !!!')"">Save changes</button>
                                                                        </div>
                                                                    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
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
                                                </div>
</td>
                                    </tr>
");
#nullable restore
#line 163 "K:\Project\OHDProject\OHDProject\Views\Admin\ListRequests.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OHDProject.Models.ViewModel1>> Html { get; private set; }
    }
}
#pragma warning restore 1591
