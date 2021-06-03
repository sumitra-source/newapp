#pragma checksum "C:\Users\shres\Source\Repos\sumitra-source\newapp\IntegratedLibrary\Views\Catalog\Hold.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fdb40cc1e7fb4b6580e7e4817b061ab91b07293e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalog_Hold), @"mvc.1.0.view", @"/Views/Catalog/Hold.cshtml")]
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
#line 1 "C:\Users\shres\Source\Repos\sumitra-source\newapp\IntegratedLibrary\Views\_ViewImports.cshtml"
using IntegratedLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\shres\Source\Repos\sumitra-source\newapp\IntegratedLibrary\Views\_ViewImports.cshtml"
using IntegratedLibrary.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdb40cc1e7fb4b6580e7e4817b061ab91b07293e", @"/Views/Catalog/Hold.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b8730e8fb42c8f11a0b781f2e217cd5d856e9f2", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalog_Hold : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IntegratedLibrary.Models.CheckoutModels.CheckoutModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""https://code.jquery.com/jquery=3.1.1.slim.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/tether/1.4.0/js/tether.min.js""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-alpha.6/js/bootstrap.min.js""></script>
");
            }
            );
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    <link href=\"https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css\"\r\n          rel=\"stylesheet\" type=\"text/css\" />\r\n");
            }
            );
            WriteLiteral(@"<div class=""container"">
    <div class=""card-header clearfix detailHeading"">
        <h2 class=""text-muted"">Place Hold on Library Item</h2>
    </div>
    <div class=""jumbotron"">
        <div class="" row"">
            <div class=""col-md-3"">
                <div>
                    <p id=""itemTitle"">");
#nullable restore
#line 19 "C:\Users\shres\Source\Repos\sumitra-source\newapp\IntegratedLibrary\Views\Catalog\Hold.cshtml"
                                 Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <img class=\"detailImage\"");
            BeginWriteAttribute("src", " src=\"", 892, "\"", 913, 1);
#nullable restore
#line 20 "C:\Users\shres\Source\Repos\sumitra-source\newapp\IntegratedLibrary\Views\Catalog\Hold.cshtml"
WriteAttributeValue("", 898, Model.ImageUrl, 898, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-9\">\r\n                <p>There are currently ");
#nullable restore
#line 24 "C:\Users\shres\Source\Repos\sumitra-source\newapp\IntegratedLibrary\Views\Catalog\Hold.cshtml"
                                  Write(Model.HoldCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" holds in the queue for this item.</p>\r\n");
#nullable restore
#line 25 "C:\Users\shres\Source\Repos\sumitra-source\newapp\IntegratedLibrary\Views\Catalog\Hold.cshtml"
                 using (Html.BeginForm("PlaceHold", "Catalog", FormMethod.Post))
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\shres\Source\Repos\sumitra-source\newapp\IntegratedLibrary\Views\Catalog\Hold.cshtml"
               Write(Html.HiddenFor(a => a.AssetId));

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div>\r\n                        Please insert a Library Card Id.\r\n                        ");
#nullable restore
#line 30 "C:\Users\shres\Source\Repos\sumitra-source\newapp\IntegratedLibrary\Views\Catalog\Hold.cshtml"
                   Write(Html.TextBoxFor(a => a.LibraryCardId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div>\r\n                        <button type=\"submit\" class=\"btn btn-info btn-lg\">Place hold</button>\r\n                    </div>\r\n");
#nullable restore
#line 35 "C:\Users\shres\Source\Repos\sumitra-source\newapp\IntegratedLibrary\Views\Catalog\Hold.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IntegratedLibrary.Models.CheckoutModels.CheckoutModel> Html { get; private set; }
    }
}
#pragma warning restore 1591