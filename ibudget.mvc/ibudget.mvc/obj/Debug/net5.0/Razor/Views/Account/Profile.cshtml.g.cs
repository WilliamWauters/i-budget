#pragma checksum "C:\Users\willi\Desktop\WEB\Project\2_developement\IBudget\ibudget.mvc\ibudget.mvc\Views\Account\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f71678b1d80ab12e646f885574bf4433affbf3cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Profile), @"mvc.1.0.view", @"/Views/Account/Profile.cshtml")]
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
#line 1 "C:\Users\willi\Desktop\WEB\Project\2_developement\IBudget\ibudget.mvc\ibudget.mvc\Views\_ViewImports.cshtml"
using ibudget.mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\willi\Desktop\WEB\Project\2_developement\IBudget\ibudget.mvc\ibudget.mvc\Views\_ViewImports.cshtml"
using ibudget.mvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f71678b1d80ab12e646f885574bf4433affbf3cb", @"/Views/Account/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c40c84dae6b9ffd4aae1adb565df9d6c831ca76", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row"">
    <div class=""col-md-12"">
        <h3>Claims associated with current User</h3>
        <p>This page displays all the claims associated the the current User. This is useful when debugging to see which claims are being populated from the Auth0 ID Token.</p>

        <table class=""table"">
            <thead>
                <tr>
                    <th>
                        Claim
                    </th>
                    <th>
                        Value
                    </th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 18 "C:\Users\willi\Desktop\WEB\Project\2_developement\IBudget\ibudget.mvc\ibudget.mvc\Views\Account\Profile.cshtml"
                 foreach (var claim in User.Claims)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                        <td>");
#nullable restore
#line 21 "C:\Users\willi\Desktop\WEB\Project\2_developement\IBudget\ibudget.mvc\ibudget.mvc\Views\Account\Profile.cshtml"
                       Write(claim.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 22 "C:\Users\willi\Desktop\WEB\Project\2_developement\IBudget\ibudget.mvc\ibudget.mvc\Views\Account\Profile.cshtml"
                       Write(claim.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>\n");
#nullable restore
#line 24 "C:\Users\willi\Desktop\WEB\Project\2_developement\IBudget\ibudget.mvc\ibudget.mvc\Views\Account\Profile.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\n        </table>\n    </div>\n</div>");
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
