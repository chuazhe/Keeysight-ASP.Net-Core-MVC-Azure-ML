#pragma checksum "C:\Users\User\source\repos\Keeysight\Keeysight\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "730ec921c270874dd1ec6a0849f4c600bdc2b7e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"730ec921c270874dd1ec6a0849f4c600bdc2b7e0", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fd4dc91b1c9b4aedd157d8b90a69d2c513e484e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TestTable>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin:20px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\User\source\repos\Keeysight\Keeysight\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Home";
    ViewBag.Header = "Home Header";


#line default
#line hidden
            BeginContext(106, 956, true);
            WriteLiteral(@"

<div class=""row"">
    <div class=""card"" style=""width: 18rem;"">
        <div class=""card-header"">
            Announcement
        </div>
        <ul class=""list-group list-group-flush"">
            <li class=""list-group-item"">dadao</li>
            <li class=""list-group-item"">dsadad</li>
            <li class=""list-group-item"">Vdsadaos</li>
        </ul>
    </div>
</div>
<div class=""row"">
    <div class=""col-md-2 tiles"">Box 1</div>
    <div class=""col-md-2 tiles"">Title Test</div>
    <div class=""col-md-2 tiles"">Title Test</div>
    <div class=""col-md-2 tiles"">Title Test</div>
    <div class=""col-md-2 tiles"">Title Test</div>
    <div class=""col-md-2 tiles"">Title Test</div>
</div>
<!--
<div class=""row"">
    If user is null, identity is null
    if identity is null, isauthenticated is null
    if iauthenticated is null, set it to false
    In default, the statement won't execute if the if is false and vice versa

");
            EndContext();
#line 36 "C:\Users\User\source\repos\Keeysight\Keeysight\Views\Home\Index.cshtml"
 if (User?.Identity?.IsAuthenticated ?? false)
{

#line default
#line hidden
            BeginContext(1113, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(1117, 109, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "730ec921c270874dd1ec6a0849f4c600bdc2b7e05915", async() => {
                BeginContext(1216, 6, true);
                WriteLiteral("Logout");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1226, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 40 "C:\Users\User\source\repos\Keeysight\Keeysight\Views\Home\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1231, 759, true);
            WriteLiteral(@"</div>-->
<div class=""row"">
    <fieldset>
        <legend style=""font-family:Arial Black;color:blue"">Two Way DataBinding AngularJS IN MVC 4.5</legend>

        <div ng-app="""">
            My Full Name :
            <input type=""text"" ng-model=""MyTitle"" placeholder=""Enter Your Name Here...."">
            <hr />
            My Name Is 1st Time: <span style=""color:blue;background-color: Yellow;color: Blue;font-style: oblique;font-weight: bold"">{{MyTitle}}</span>
            <br />
            <br />
            My Name Is 2nd Time: <span style=""color:orangered;background-color:yellow;font-style: oblique;font-weight: bold"" ng-bind=""MyTitle""></span>
        </div>
    </fieldset>
</div>
<div class=""=row"" style=""margin:20px"">
    <div>
");
            EndContext();
#line 59 "C:\Users\User\source\repos\Keeysight\Keeysight\Views\Home\Index.cshtml"
         foreach (var a in Model)
        {

#line default
#line hidden
            BeginContext(2036, 42, true);
            WriteLiteral("            <ul>\r\n                <li>Id: ");
            EndContext();
            BeginContext(2079, 4, false);
#line 62 "C:\Users\User\source\repos\Keeysight\Keeysight\Views\Home\Index.cshtml"
                   Write(a.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2083, 47, true);
            WriteLiteral(" (From Server)</li>\r\n                <li>Name: ");
            EndContext();
            BeginContext(2131, 6, false);
#line 63 "C:\Users\User\source\repos\Keeysight\Keeysight\Views\Home\Index.cshtml"
                     Write(a.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2137, 40, true);
            WriteLiteral(" (From Server)</li>\r\n            </ul>\r\n");
            EndContext();
#line 65 "C:\Users\User\source\repos\Keeysight\Keeysight\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2188, 93, true);
            WriteLiteral("    </div>\r\n</div>\r\n<div class=\"=row\" style=\"margin:20px\">\r\n    <div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TestTable>> Html { get; private set; }
    }
}
#pragma warning restore 1591
