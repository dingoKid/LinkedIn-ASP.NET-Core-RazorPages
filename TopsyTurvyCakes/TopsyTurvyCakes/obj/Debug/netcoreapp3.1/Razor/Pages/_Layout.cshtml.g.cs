#pragma checksum "D:\Github\RazorPages\LinkedIn\TopsyTurvyCakes\TopsyTurvyCakes\Pages\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "401a85694b1e3389535ad9ae3527099117ae64ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TopsyTurvyCakes.Pages.Pages__Layout), @"mvc.1.0.view", @"/Pages/_Layout.cshtml")]
namespace TopsyTurvyCakes.Pages
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
#line 1 "D:\Github\RazorPages\LinkedIn\TopsyTurvyCakes\TopsyTurvyCakes\Pages\_ViewImports.cshtml"
using TopsyTurvyCakes.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"401a85694b1e3389535ad9ae3527099117ae64ce", @"/Pages/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a67ae31d14dee6e89b004882d2aa04936af702d", @"/Pages/_ViewImports.cshtml")]
    public class Pages__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\n<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "401a85694b1e3389535ad9ae3527099117ae64ce4511", async() => {
                WriteLiteral("\n    <title>Topsy Turvy Cake Design</title>\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "401a85694b1e3389535ad9ae3527099117ae64ce4815", async() => {
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
                WriteLiteral(@"
    <script src=""https://ajax.aspnetcdn.com/ajax/jquery/jquery-2.2.0.min.js""></script>
    <script src=""https://ajax.aspnetcdn.com/ajax/jquery.validate/1.16.0/jquery.validate.min.js""></script>
    <script src=""https://ajax.aspnetcdn.com/ajax/jquery.validation.unobtrusive/3.2.6/jquery.validate.unobtrusive.min.js""></script>
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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "401a85694b1e3389535ad9ae3527099117ae64ce7023", async() => {
                WriteLiteral(@"

    <header class=""container site-header"">
        <div class=""row"">
            <h1 class=""main-logo""><a href=""/"">Topsy Turvy Cake Design</a></h1>
        </div>
        <div class=""row"">
            <nav class=""navbar"">
                <ul class=""nav nav-pills"">
                    <li><a href=""/About"">About</a></li>
                    <li><a href=""/Blog"">Blog</a></li>
                    <li><a class=""active"" href=""/"">Recipes</a></li>
                    <li><a href=""/Portfolio"">Portfolio</a></li>
                    <li><a href=""/Contact"">Contact</a></li>
                </ul>
                <ul class=""nav nav-pills"">
                    <li>
");
#nullable restore
#line 27 "D:\Github\RazorPages\LinkedIn\TopsyTurvyCakes\TopsyTurvyCakes\Pages\_Layout.cshtml"
                         if (!User.Identity.IsAuthenticated)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <a href=\"/Account/Login\">Login</a> \n");
#nullable restore
#line 30 "D:\Github\RazorPages\LinkedIn\TopsyTurvyCakes\TopsyTurvyCakes\Pages\_Layout.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "401a85694b1e3389535ad9ae3527099117ae64ce8626", async() => {
                    WriteLiteral("\n                                <div class=\"input-group\">\n                                    <span>");
#nullable restore
#line 35 "D:\Github\RazorPages\LinkedIn\TopsyTurvyCakes\TopsyTurvyCakes\Pages\_Layout.cshtml"
                                     Write(User.Identity.IsAuthenticated);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</span>\n                                    <button type=\"submit\" class=\"btn btn-link\">Logout</button>\n                                </div>\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#nullable restore
#line 39 "D:\Github\RazorPages\LinkedIn\TopsyTurvyCakes\TopsyTurvyCakes\Pages\_Layout.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </li>\n                </ul>\n            </nav>\n        </div>\n        <div class=\"row\">\n");
#nullable restore
#line 45 "D:\Github\RazorPages\LinkedIn\TopsyTurvyCakes\TopsyTurvyCakes\Pages\_Layout.cshtml"
             if (IsSectionDefined("Title"))
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "D:\Github\RazorPages\LinkedIn\TopsyTurvyCakes\TopsyTurvyCakes\Pages\_Layout.cshtml"
           Write(RenderSection("Title", false));

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "D:\Github\RazorPages\LinkedIn\TopsyTurvyCakes\TopsyTurvyCakes\Pages\_Layout.cshtml"
                                              
            } else
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <h1>");
#nullable restore
#line 50 "D:\Github\RazorPages\LinkedIn\TopsyTurvyCakes\TopsyTurvyCakes\Pages\_Layout.cshtml"
               Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n");
#nullable restore
#line 51 "D:\Github\RazorPages\LinkedIn\TopsyTurvyCakes\TopsyTurvyCakes\Pages\_Layout.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        </div>\n    </header>\n\n    <div class=\"container\">\n        ");
#nullable restore
#line 57 "D:\Github\RazorPages\LinkedIn\TopsyTurvyCakes\TopsyTurvyCakes\Pages\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    </div>\n\n    <footer>\n        <div class=\"text-center\">\n            <span class=\"text-muted\">Last Rendered: ");
#nullable restore
#line 62 "D:\Github\RazorPages\LinkedIn\TopsyTurvyCakes\TopsyTurvyCakes\Pages\_Layout.cshtml"
                                               Write(DateTime.Now);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </span>\n        </div>\n    </footer>\n");
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
            WriteLiteral("\n</html>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IRecipesService RecipesService { get; private set; }
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
