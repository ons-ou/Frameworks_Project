#pragma checksum "C:\Users\onsou\Desktop\FrameworksProject\Views\Clubs\Club.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4743705d08612e2ff05ec7f9a139aa7b45095a49"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clubs_Club), @"mvc.1.0.view", @"/Views/Clubs/Club.cshtml")]
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
#line 1 "C:\Users\onsou\Desktop\FrameworksProject\Views\_ViewImports.cshtml"
using FrameworksProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\onsou\Desktop\FrameworksProject\Views\_ViewImports.cshtml"
using FrameworksProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4743705d08612e2ff05ec7f9a139aa7b45095a49", @"/Views/Clubs/Club.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70053674d2b90feeec2989712c1437946f54ac1e", @"/Views/_ViewImports.cshtml")]
    public class Views_Clubs_Club : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Club>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Clubs", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Events", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Event", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\onsou\Desktop\FrameworksProject\Views\Clubs\Club.cshtml"
  
    ViewData["Title"] = "Clubs";
    string alt_image = "https://i1.wp.com/insatpress.tn/wp-content/uploads/2020/04/44104159_2181495298587811_5543566004648411136_o.jpg?resize=1000%2C600&ssl=1";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-8\">\r\n        <h1 class=\"monospace\">\r\n            ");
#nullable restore
#line 11 "C:\Users\onsou\Desktop\FrameworksProject\Views\Clubs\Club.cshtml"
       Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h1>\r\n        <p class=\"subtitle\">\r\n            <h3 class=\"lead\">ID: </h3> ");
#nullable restore
#line 14 "C:\Users\onsou\Desktop\FrameworksProject\Views\Clubs\Club.cshtml"
                                  Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </p>
        <div class=""row"">
                <div class=""col-7 mb-5"" style=""width: 18rem;"">
                    <h3 class=""lead"">Description: </h3>
                    <div class=""card-body h-auto"" style=""height: 20rem;"">
                        <p class=""card-text"">");
#nullable restore
#line 20 "C:\Users\onsou\Desktop\FrameworksProject\Views\Clubs\Club.cshtml"
                                        Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                       \r\n                    </div>\r\n                    <h3 class=\"lead\">Website:</h3>\r\n                    <div class=\"card-body h-auto\" style=\"height: 20rem;\">\r\n                        <a");
            BeginWriteAttribute("href", " href=", 928, "", 948, 1);
#nullable restore
#line 25 "C:\Users\onsou\Desktop\FrameworksProject\Views\Clubs\Club.cshtml"
WriteAttributeValue("", 934, Model.Website, 934, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 25 "C:\Users\onsou\Desktop\FrameworksProject\Views\Clubs\Club.cshtml"
                                           Write(Model.Website ?? "Rien à afficher");

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        \r\n                    </div>\r\n                    <h3 class=\"lead\">Creation Year: </h3>\r\n                    <div class=\"card-body h-auto\" style=\"height: 20rem;\">\r\n                        <p class=\"card-text\">");
#nullable restore
#line 30 "C:\Users\onsou\Desktop\FrameworksProject\Views\Clubs\Club.cshtml"
                                         Write(Model.CreationYear.ToString() ?? "Rien à afficher" );

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n\r\n                </div>\r\n        </div>\r\n\r\n        <h3 class=\"my-2\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4743705d08612e2ff05ec7f9a139aa7b45095a497915", async() => {
                WriteLiteral("\r\n                <button type=\"button\" class=\"btn btn-danger btn-lg\">Edit</button>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 37 "C:\Users\onsou\Desktop\FrameworksProject\Views\Clubs\Club.cshtml"
                                                                        WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 1596, "\"", 1626, 2);
            WriteAttributeValue("", 1603, "/Clubs/delete/", 1603, 14, true);
#nullable restore
#line 40 "C:\Users\onsou\Desktop\FrameworksProject\Views\Clubs\Club.cshtml"
WriteAttributeValue("", 1617, Model.Id, 1617, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <button type=\"button\" class=\"btn btn-danger btn-lg\">Delete</button>\r\n            </a>\r\n        </h3>\r\n    </div>\r\n    <div class=\"col-4\">\r\n        <img");
            BeginWriteAttribute("src", " src=", 1797, "", 1828, 1);
#nullable restore
#line 46 "C:\Users\onsou\Desktop\FrameworksProject\Views\Clubs\Club.cshtml"
WriteAttributeValue("", 1802, Model.Logo ?? alt_image, 1802, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Image\" style=\"height:250px; width:400px;\"/>\r\n    </div>\r\n</div>\r\n\r\n<h3 class=\"display-4\">\r\n\r\n    Members\r\n</h3>\r\n<div class=\"row\">\r\n    <div class=\"d-flex justify-content-around flex-wrap\">\r\n");
#nullable restore
#line 56 "C:\Users\onsou\Desktop\FrameworksProject\Views\Clubs\Club.cshtml"
                
                  foreach(Member m in Model.Members){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card mb-5\" style=\"width: 18rem;\">\r\n                <div class=\"card-body h-auto\" style=\"height: 20rem;\">\r\n                    <h5 class=\"card-title\">");
#nullable restore
#line 60 "C:\Users\onsou\Desktop\FrameworksProject\Views\Clubs\Club.cshtml"
                                      Write(m.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <p class=\"card-text\">");
#nullable restore
#line 61 "C:\Users\onsou\Desktop\FrameworksProject\Views\Clubs\Club.cshtml"
                                    Write(m.Role);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 64 "C:\Users\onsou\Desktop\FrameworksProject\Views\Clubs\Club.cshtml"
              }
              

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n\r\n    </div>\r\n</div>\r\n\r\n<h3 class=\"display-4\">\r\n                Events\r\n</h3>\r\n\r\n<div class=\"row\">\r\n    <div class=\"d-flex justify-content-around flex-wrap\">\r\n");
#nullable restore
#line 77 "C:\Users\onsou\Desktop\FrameworksProject\Views\Clubs\Club.cshtml"
          
            foreach(Event e in Model.Events){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card mb-5\" style=\"width: 18rem;\">\r\n                <img class=\"card-img-top\" style=\"height: 20rem; width:100%;\"");
            BeginWriteAttribute("src", " src=", 2774, "", 2791, 1);
#nullable restore
#line 80 "C:\Users\onsou\Desktop\FrameworksProject\Views\Clubs\Club.cshtml"
WriteAttributeValue("", 2779, alt_image, 2779, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"event image\">\r\n                <div class=\"card-body h-auto\" style=\"height: 20rem;\">\r\n                    <h5 class=\"card-title\">");
#nullable restore
#line 82 "C:\Users\onsou\Desktop\FrameworksProject\Views\Clubs\Club.cshtml"
                                      Write(e.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <p class=\"card-text\">Happening the ");
#nullable restore
#line 83 "C:\Users\onsou\Desktop\FrameworksProject\Views\Clubs\Club.cshtml"
                                                   Write(e.Date.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4743705d08612e2ff05ec7f9a139aa7b45095a4914660", async() => {
                WriteLiteral("See Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 84 "C:\Users\onsou\Desktop\FrameworksProject\Views\Clubs\Club.cshtml"
                                                                                WriteLiteral(e.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 88 "C:\Users\onsou\Desktop\FrameworksProject\Views\Clubs\Club.cshtml"
        }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n   \r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Club> Html { get; private set; }
    }
}
#pragma warning restore 1591
