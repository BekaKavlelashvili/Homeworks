#pragma checksum "C:\Users\Beka\source\repos\Homework_13\exercise_2\Views\Home\BookingNotAllowed.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac9198c49e5741532e10e9ca4d72f384883ccf2e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_BookingNotAllowed), @"mvc.1.0.view", @"/Views/Home/BookingNotAllowed.cshtml")]
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
#line 1 "C:\Users\Beka\source\repos\Homework_13\exercise_2\Views\_ViewImports.cshtml"
using exercise_2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Beka\source\repos\Homework_13\exercise_2\Views\_ViewImports.cshtml"
using exercise_2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac9198c49e5741532e10e9ca4d72f384883ccf2e", @"/Views/Home/BookingNotAllowed.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"109c093e5aea8130b40b63c6637fd56d36ce320b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_BookingNotAllowed : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<exercise_2.Models.PersonClass>
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
#nullable restore
#line 2 "C:\Users\Beka\source\repos\Homework_13\exercise_2\Views\Home\BookingNotAllowed.cshtml"
  
    ViewData["Title"] = "Booking Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac9198c49e5741532e10e9ca4d72f384883ccf2e3519", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Index</title>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac9198c49e5741532e10e9ca4d72f384883ccf2e4578", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 13 "C:\Users\Beka\source\repos\Homework_13\exercise_2\Views\Home\BookingNotAllowed.cshtml"
     using (Html.BeginForm("Index", "Home", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <table cellpadding=\"0\" cellspacing=\"0\">\r\n            <tr>\r\n                <th colspan=\"2\" align=\"center\">Person Details</th>\r\n            </tr>\r\n            <tr>\r\n                <td>FirstName: </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 22 "C:\Users\Beka\source\repos\Homework_13\exercise_2\Views\Home\BookingNotAllowed.cshtml"
               Write(Html.TextBoxFor(m => m.FirstName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>LastName: </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 28 "C:\Users\Beka\source\repos\Homework_13\exercise_2\Views\Home\BookingNotAllowed.cshtml"
               Write(Html.TextBoxFor(m => m.LastName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>Movie: </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 34 "C:\Users\Beka\source\repos\Homework_13\exercise_2\Views\Home\BookingNotAllowed.cshtml"
               Write(Html.TextBoxFor(m => m.Movie));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n            </tr>           \r\n            <tr>\r\n                <td></td>\r\n                <td><input type=\"submit\" value=\"Submit\" /></td>\r\n            </tr>\r\n        </table>\r\n");
#nullable restore
#line 42 "C:\Users\Beka\source\repos\Homework_13\exercise_2\Views\Home\BookingNotAllowed.cshtml"
    }

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<exercise_2.Models.PersonClass> Html { get; private set; }
    }
}
#pragma warning restore 1591
