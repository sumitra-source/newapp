#pragma checksum "C:\Users\shres\Documents\newapp\netcore-main\newapp\FirstMVCApp\Views\Home\PersonalDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6e9fe88dc85fc7ea2174975b0f668b155af36f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PersonalDetails), @"mvc.1.0.view", @"/Views/Home/PersonalDetails.cshtml")]
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
#line 1 "C:\Users\shres\Documents\newapp\netcore-main\newapp\FirstMVCApp\Views\_ViewImports.cshtml"
using FirstMVCApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\shres\Documents\newapp\netcore-main\newapp\FirstMVCApp\Views\_ViewImports.cshtml"
using FirstMVCApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6e9fe88dc85fc7ea2174975b0f668b155af36f7", @"/Views/Home/PersonalDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d01f06844b421d4a2b9deae35724be7dbbdd2a3d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_PersonalDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PersonalDetail>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\shres\Documents\newapp\netcore-main\newapp\FirstMVCApp\Views\Home\PersonalDetails.cshtml"
  
    ViewData["Title"] = "PersonalDetail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Personal Detail</h1>\n<h2>Here is ");
#nullable restore
#line 7 "C:\Users\shres\Documents\newapp\netcore-main\newapp\FirstMVCApp\Views\Home\PersonalDetails.cshtml"
       Write(Html.DisplayFor(x => Model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\'s details</h2>\n\n<table border=\"1\" class=\"table table-bordered\">\n    <tr>\n        <th>Particular</th>\n        <th>Details</th>\n    </tr>\n\n    <tr>\n        <td>");
#nullable restore
#line 16 "C:\Users\shres\Documents\newapp\netcore-main\newapp\FirstMVCApp\Views\Home\PersonalDetails.cshtml"
       Write(Html.DisplayNameFor(x => x.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 17 "C:\Users\shres\Documents\newapp\netcore-main\newapp\FirstMVCApp\Views\Home\PersonalDetails.cshtml"
       Write(Html.DisplayFor(x => Model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    </tr>\n    <tr>\n        <td>");
#nullable restore
#line 20 "C:\Users\shres\Documents\newapp\netcore-main\newapp\FirstMVCApp\Views\Home\PersonalDetails.cshtml"
       Write(Html.DisplayNameFor(x => x.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 21 "C:\Users\shres\Documents\newapp\netcore-main\newapp\FirstMVCApp\Views\Home\PersonalDetails.cshtml"
       Write(Html.DisplayFor(x => Model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    </tr>\n    <tr>\n        <td>");
#nullable restore
#line 24 "C:\Users\shres\Documents\newapp\netcore-main\newapp\FirstMVCApp\Views\Home\PersonalDetails.cshtml"
       Write(Html.DisplayNameFor(x => x.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 25 "C:\Users\shres\Documents\newapp\netcore-main\newapp\FirstMVCApp\Views\Home\PersonalDetails.cshtml"
       Write(Html.DisplayFor(x => Model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    </tr>\n    <tr>\n        <td>");
#nullable restore
#line 28 "C:\Users\shres\Documents\newapp\netcore-main\newapp\FirstMVCApp\Views\Home\PersonalDetails.cshtml"
       Write(Html.DisplayNameFor(x => x.Occupation));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 29 "C:\Users\shres\Documents\newapp\netcore-main\newapp\FirstMVCApp\Views\Home\PersonalDetails.cshtml"
       Write(Html.DisplayFor(x => Model.Occupation));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    </tr>\n    <tr>\n        <td>");
#nullable restore
#line 32 "C:\Users\shres\Documents\newapp\netcore-main\newapp\FirstMVCApp\Views\Home\PersonalDetails.cshtml"
       Write(Html.DisplayNameFor(x => x.DOB));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 33 "C:\Users\shres\Documents\newapp\netcore-main\newapp\FirstMVCApp\Views\Home\PersonalDetails.cshtml"
       Write(Html.DisplayFor(x => Model.DOB));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    </tr>\n\n</table>\n\n");
#nullable restore
#line 38 "C:\Users\shres\Documents\newapp\netcore-main\newapp\FirstMVCApp\Views\Home\PersonalDetails.cshtml"
Write(Html.ActionLink("Back to Persons", "Persons", "Home", null, new { @class = "btn btn-secondary"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PersonalDetail> Html { get; private set; }
    }
}
#pragma warning restore 1591
