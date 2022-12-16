#pragma checksum "C:\Users\arwa\source\repos\Frameworks_Project\Views\Events\CreateEvent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47d9a3536ca756ab0aa189fcf5007ea01404aa5b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Events_CreateEvent), @"mvc.1.0.view", @"/Views/Events/CreateEvent.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47d9a3536ca756ab0aa189fcf5007ea01404aa5b", @"/Views/Events/CreateEvent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70053674d2b90feeec2989712c1437946f54ac1e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Events_CreateEvent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\arwa\source\repos\Frameworks_Project\Views\Events\CreateEvent.cshtml"
  
    ViewData["Title"] = "Create Event";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2 class=\"display-4\">Create an Event!!</h2>\r\n<div class=\"row\">\r\n    <div class=\"col-12 justify-content-center\">\r\n        <section id=\"CreateForm\">\r\n");
#nullable restore
#line 9 "C:\Users\arwa\source\repos\Frameworks_Project\Views\Events\CreateEvent.cshtml"
             using (Html.BeginForm("Create", "Events", FormMethod.Post, new { @class = "form-horizontal", role = "form" }))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <hr />\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 13 "C:\Users\arwa\source\repos\Frameworks_Project\Views\Events\CreateEvent.cshtml"
               Write(Html.Label("name", "Enter the event name: ", new { @class = "control-label lead" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <div class=\"col-md-10\">\r\n                        ");
#nullable restore
#line 15 "C:\Users\arwa\source\repos\Frameworks_Project\Views\Events\CreateEvent.cshtml"
                   Write(Html.TextBox("name", "", new { @class = "form-control form-control-lg" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 19 "C:\Users\arwa\source\repos\Frameworks_Project\Views\Events\CreateEvent.cshtml"
               Write(Html.Label("name", "Enter the event description: ", new { @class = "control-label lead" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <div class=\"col-md-10\">\r\n                        ");
#nullable restore
#line 21 "C:\Users\arwa\source\repos\Frameworks_Project\Views\Events\CreateEvent.cshtml"
                   Write(Html.TextBox("description", "", new { @class = "form-control form-control-lg" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                   \r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 26 "C:\Users\arwa\source\repos\Frameworks_Project\Views\Events\CreateEvent.cshtml"
               Write(Html.Label("name", "Enter the event staffForm: ", new { @class = "control-label lead" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <div class=\"col-md-10\">\r\n                        ");
#nullable restore
#line 28 "C:\Users\arwa\source\repos\Frameworks_Project\Views\Events\CreateEvent.cshtml"
                   Write(Html.TextBox("staffForm", "", new { @class = "form-control form-control-lg" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 32 "C:\Users\arwa\source\repos\Frameworks_Project\Views\Events\CreateEvent.cshtml"
               Write(Html.Label("name", "Enter the event participationForm: ", new { @class = "control-label lead" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <div class=\"col-md-10\">\r\n                        ");
#nullable restore
#line 34 "C:\Users\arwa\source\repos\Frameworks_Project\Views\Events\CreateEvent.cshtml"
                   Write(Html.TextBox("participationForm", "", new { @class = "form-control form-control-lg" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 38 "C:\Users\arwa\source\repos\Frameworks_Project\Views\Events\CreateEvent.cshtml"
               Write(Html.Label("name", "Enter the event Image: ", new { @class = "control-label lead" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <div class=\"col-md-10\">\r\n                        ");
#nullable restore
#line 40 "C:\Users\arwa\source\repos\Frameworks_Project\Views\Events\CreateEvent.cshtml"
                   Write(Html.TextBox("image", "", new { @class = "form-control form-control-lg" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 44 "C:\Users\arwa\source\repos\Frameworks_Project\Views\Events\CreateEvent.cshtml"
               Write(Html.Label("name", "Choose a club: ", new { @class = "control-label lead" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <div class=\"col-md-10\">\r\n                        ");
#nullable restore
#line 46 "C:\Users\arwa\source\repos\Frameworks_Project\Views\Events\CreateEvent.cshtml"
                   Write(Html.ListBox("club", ViewBag.club, new { @class = "form-control form-control-lg" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 50 "C:\Users\arwa\source\repos\Frameworks_Project\Views\Events\CreateEvent.cshtml"
               Write(Html.Label("name", "choose a category: ", new { @class = "control-label lead" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <div class=\"col-md-10\">\r\n                        ");
#nullable restore
#line 52 "C:\Users\arwa\source\repos\Frameworks_Project\Views\Events\CreateEvent.cshtml"
                   Write(Html.ListBox("category", ViewBag.category, new { @class = "form-control form-control-lg" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <p class=\"lead\">Date: </p>\r\n         \r\n                    <div class=\"col-md-10\">\r\n                        ");
#nullable restore
#line 59 "C:\Users\arwa\source\repos\Frameworks_Project\Views\Events\CreateEvent.cshtml"
                   Write(Html.Label("date", "Enter date : ", new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 60 "C:\Users\arwa\source\repos\Frameworks_Project\Views\Events\CreateEvent.cshtml"
                   Write(Html.TextBox("date", "", new { placeholder = "dd-MM-yyyy", @class = "form-control form-control-lg" }));

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
#line 68 "C:\Users\arwa\source\repos\Frameworks_Project\Views\Events\CreateEvent.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </section>\r\n    </div>\r\n</div>\r\n\r\n");
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
