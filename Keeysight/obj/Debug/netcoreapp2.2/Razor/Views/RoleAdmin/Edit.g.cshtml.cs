#pragma checksum "C:\Users\User\source\repos\Keeysight\Keeysight\Views\RoleAdmin\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77608f73f3265187bff7e7d420eb83a9b92a3bc5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RoleAdmin_Edit), @"mvc.1.0.view", @"/Views/RoleAdmin/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/RoleAdmin/Edit.cshtml", typeof(AspNetCore.Views_RoleAdmin_Edit))]
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
#line 1 "C:\Users\User\source\repos\Keeysight\Keeysight\Views\_ViewImports.cshtml"
using Keeysight;

#line default
#line hidden
#line 2 "C:\Users\User\source\repos\Keeysight\Keeysight\Views\_ViewImports.cshtml"
using Keeysight.Models;

#line default
#line hidden
#line 3 "C:\Users\User\source\repos\Keeysight\Keeysight\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77608f73f3265187bff7e7d420eb83a9b92a3bc5", @"/Views/RoleAdmin/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8158c62552ecafe5b6f29a662769fcb23a5ebaf5", @"/Views/_ViewImports.cshtml")]
    public class Views_RoleAdmin_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleEditModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 69, true);
            WriteLiteral("<div class=\"bg-primary m-1 p-1 text-white\"><h4>Edit Role</h4></div>\r\n");
            EndContext();
            BeginContext(91, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "77608f73f3265187bff7e7d420eb83a9b92a3bc55438", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 3 "C:\Users\User\source\repos\Keeysight\Keeysight\Views\RoleAdmin\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(151, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(153, 1541, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "77608f73f3265187bff7e7d420eb83a9b92a3bc57135", async() => {
                BeginContext(191, 42, true);
                WriteLiteral("\r\n    <input type=\"hidden\" name=\"roleName\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 233, "\"", 257, 1);
#line 5 "C:\Users\User\source\repos\Keeysight\Keeysight\Views\RoleAdmin\Edit.cshtml"
WriteAttributeValue("", 241, Model.Role.Name, 241, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(258, 43, true);
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"roleId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 301, "\"", 323, 1);
#line 6 "C:\Users\User\source\repos\Keeysight\Keeysight\Views\RoleAdmin\Edit.cshtml"
WriteAttributeValue("", 309, Model.Role.Id, 309, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(324, 51, true);
                WriteLiteral(" />\r\n    <h6 class=\"bg-info p-1 text-white\">Add To ");
                EndContext();
                BeginContext(376, 15, false);
#line 7 "C:\Users\User\source\repos\Keeysight\Keeysight\Views\RoleAdmin\Edit.cshtml"
                                         Write(Model.Role.Name);

#line default
#line hidden
                EndContext();
                BeginContext(391, 58, true);
                WriteLiteral("</h6>\r\n    <table class=\"table table-bordered table-sm\">\r\n");
                EndContext();
#line 9 "C:\Users\User\source\repos\Keeysight\Keeysight\Views\RoleAdmin\Edit.cshtml"
         if (Model.NonMembers.Count() == 0)
        {

#line default
#line hidden
                BeginContext(505, 65, true);
                WriteLiteral("            <tr><td colspan=\"2\">All Users Are Members</td></tr>\r\n");
                EndContext();
#line 12 "C:\Users\User\source\repos\Keeysight\Keeysight\Views\RoleAdmin\Edit.cshtml"
        }
        else
        {
            

#line default
#line hidden
#line 15 "C:\Users\User\source\repos\Keeysight\Keeysight\Views\RoleAdmin\Edit.cshtml"
             foreach (AppUser user in Model.NonMembers)
            {

#line default
#line hidden
                BeginContext(678, 46, true);
                WriteLiteral("                <tr>\r\n                    <td>");
                EndContext();
                BeginContext(725, 13, false);
#line 18 "C:\Users\User\source\repos\Keeysight\Keeysight\Views\RoleAdmin\Edit.cshtml"
                   Write(user.UserName);

#line default
#line hidden
                EndContext();
                BeginContext(738, 95, true);
                WriteLiteral("</td>\r\n                    <td>\r\n                        <input type=\"checkbox\" name=\"IdsToAdd\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 833, "\"", 849, 1);
#line 20 "C:\Users\User\source\repos\Keeysight\Keeysight\Views\RoleAdmin\Edit.cshtml"
WriteAttributeValue("", 841, user.Id, 841, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(850, 53, true);
                WriteLiteral(">\r\n                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 23 "C:\Users\User\source\repos\Keeysight\Keeysight\Views\RoleAdmin\Edit.cshtml"
            }

#line default
#line hidden
#line 23 "C:\Users\User\source\repos\Keeysight\Keeysight\Views\RoleAdmin\Edit.cshtml"
             
        }

#line default
#line hidden
                BeginContext(929, 65, true);
                WriteLiteral("    </table>\r\n    <h6 class=\"bg-info p-1 text-white\">Remove From ");
                EndContext();
                BeginContext(995, 15, false);
#line 26 "C:\Users\User\source\repos\Keeysight\Keeysight\Views\RoleAdmin\Edit.cshtml"
                                              Write(Model.Role.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1010, 58, true);
                WriteLiteral("</h6>\r\n    <table class=\"table table-bordered table-sm\">\r\n");
                EndContext();
#line 28 "C:\Users\User\source\repos\Keeysight\Keeysight\Views\RoleAdmin\Edit.cshtml"
         if (Model.Members.Count() == 0)
        {

#line default
#line hidden
                BeginContext(1121, 64, true);
                WriteLiteral("            <tr><td colspan=\"2\">No Users Are Members</td></tr>\r\n");
                EndContext();
#line 31 "C:\Users\User\source\repos\Keeysight\Keeysight\Views\RoleAdmin\Edit.cshtml"
        }
        else
        {
            

#line default
#line hidden
#line 34 "C:\Users\User\source\repos\Keeysight\Keeysight\Views\RoleAdmin\Edit.cshtml"
             foreach (AppUser user in Model.Members)
            {

#line default
#line hidden
                BeginContext(1290, 46, true);
                WriteLiteral("                <tr>\r\n                    <td>");
                EndContext();
                BeginContext(1337, 13, false);
#line 37 "C:\Users\User\source\repos\Keeysight\Keeysight\Views\RoleAdmin\Edit.cshtml"
                   Write(user.UserName);

#line default
#line hidden
                EndContext();
                BeginContext(1350, 98, true);
                WriteLiteral("</td>\r\n                    <td>\r\n                        <input type=\"checkbox\" name=\"IdsToDelete\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1448, "\"", 1464, 1);
#line 39 "C:\Users\User\source\repos\Keeysight\Keeysight\Views\RoleAdmin\Edit.cshtml"
WriteAttributeValue("", 1456, user.Id, 1456, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1465, 53, true);
                WriteLiteral(">\r\n                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 42 "C:\Users\User\source\repos\Keeysight\Keeysight\Views\RoleAdmin\Edit.cshtml"
            }

#line default
#line hidden
#line 42 "C:\Users\User\source\repos\Keeysight\Keeysight\Views\RoleAdmin\Edit.cshtml"
             
        }

#line default
#line hidden
                BeginContext(1544, 83, true);
                WriteLiteral("    </table>\r\n    <button type=\"submit\" class=\"btn btn-primary\">Save</button>\r\n    ");
                EndContext();
                BeginContext(1627, 58, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "77608f73f3265187bff7e7d420eb83a9b92a3bc513882", async() => {
                    BeginContext(1675, 6, true);
                    WriteLiteral("Cancel");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1685, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1694, 2, true);
            WriteLiteral("\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleEditModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
