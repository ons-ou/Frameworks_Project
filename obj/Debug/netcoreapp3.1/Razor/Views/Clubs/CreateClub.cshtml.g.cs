#pragma checksum "C:\Users\arwa\source\repos\Frameworks_Project\Views\Clubs\CreateClub.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b64b16d091e3f9cab5ebc60dc50820a57878790"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clubs_CreateClub), @"mvc.1.0.view", @"/Views/Clubs/CreateClub.cshtml")]
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
#line 1 "C:\Users\arwa\source\repos\Frameworks_Project\Views\_ViewImports.cshtml"
using FrameworksProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\arwa\source\repos\Frameworks_Project\Views\_ViewImports.cshtml"
using FrameworksProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b64b16d091e3f9cab5ebc60dc50820a57878790", @"/Views/Clubs/CreateClub.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70053674d2b90feeec2989712c1437946f54ac1e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Clubs_CreateClub : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\arwa\source\repos\Frameworks_Project\Views\Clubs\CreateClub.cshtml"
  
    ViewData["Title"] = "Create Club";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2 class=\"display-4\">Create a Club!!</h2>\r\n<div class=\"row\">\r\n    <div class=\"col-12 justify-content-center\">\r\n        <section id=\"CreateForm\">\r\n");
#nullable restore
#line 9 "C:\Users\arwa\source\repos\Frameworks_Project\Views\Clubs\CreateClub.cshtml"
             using (Html.BeginForm("Create", "Clubs", FormMethod.Post, new { @class = "form-horizontal", role = "form" }))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <hr />\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 13 "C:\Users\arwa\source\repos\Frameworks_Project\Views\Clubs\CreateClub.cshtml"
               Write(Html.Label("name", "Enter the club name: ", new { @class = "control-label lead" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <div class=\"col-md-10\">\r\n                        ");
#nullable restore
#line 15 "C:\Users\arwa\source\repos\Frameworks_Project\Views\Clubs\CreateClub.cshtml"
                   Write(Html.TextBox("name", "", new { @class = "form-control form-control-lg" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 19 "C:\Users\arwa\source\repos\Frameworks_Project\Views\Clubs\CreateClub.cshtml"
               Write(Html.Label("name", "Enter the club description: ", new { @class = "control-label lead" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <div class=\"col-md-10\">\r\n                        ");
#nullable restore
#line 21 "C:\Users\arwa\source\repos\Frameworks_Project\Views\Clubs\CreateClub.cshtml"
                   Write(Html.TextBox("description", "", new { @class = "form-control form-control-lg" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 26 "C:\Users\arwa\source\repos\Frameworks_Project\Views\Clubs\CreateClub.cshtml"
               Write(Html.Label("name", "Enter the club website: ", new { @class = "control-label lead" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <div class=\"col-md-10\">\r\n                        ");
#nullable restore
#line 28 "C:\Users\arwa\source\repos\Frameworks_Project\Views\Clubs\CreateClub.cshtml"
                   Write(Html.TextBox("website", "", new { @class = "form-control form-control-lg" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 32 "C:\Users\arwa\source\repos\Frameworks_Project\Views\Clubs\CreateClub.cshtml"
               Write(Html.Label("name", "Enter the club creation year: ", new { @class = "control-label lead" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <div class=\"col-md-10\">\r\n                        ");
#nullable restore
#line 34 "C:\Users\arwa\source\repos\Frameworks_Project\Views\Clubs\CreateClub.cshtml"
                   Write(Html.TextBox("creationYear", "", new { @class = "form-control form-control-lg",@type= "number"  }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 38 "C:\Users\arwa\source\repos\Frameworks_Project\Views\Clubs\CreateClub.cshtml"
               Write(Html.Label("name", "Enter the club Logo: ", new { @class = "control-label lead" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <div class=\"col-md-10\">\r\n                        ");
#nullable restore
#line 40 "C:\Users\arwa\source\repos\Frameworks_Project\Views\Clubs\CreateClub.cshtml"
                   Write(Html.TextBox("logo", "", new { @class = "form-control form-control-lg" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
                <div class=""form-group"">
                    <div class=""col-md-offset-2 col-md-10"">
                        <input type=""submit"" value=""Create"" class=""btn btn-danger btn-lg"" />
                    </div>
                </div>
");
#nullable restore
#line 48 "C:\Users\arwa\source\repos\Frameworks_Project\Views\Clubs\CreateClub.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </section>\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591