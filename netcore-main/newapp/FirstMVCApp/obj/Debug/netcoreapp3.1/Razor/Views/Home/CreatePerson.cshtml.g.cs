#pragma checksum "C:\Users\shres\Documents\newapp\netcore-main\newapp\FirstMVCApp\Views\Home\CreatePerson.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ffeb58d80341084c37fdc49a5851efcc3c33c11"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CreatePerson), @"mvc.1.0.view", @"/Views/Home/CreatePerson.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ffeb58d80341084c37fdc49a5851efcc3c33c11", @"/Views/Home/CreatePerson.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d01f06844b421d4a2b9deae35724be7dbbdd2a3d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CreatePerson : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PersonalDetail>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "C:\Users\shres\Documents\newapp\netcore-main\newapp\FirstMVCApp\Views\Home\CreatePerson.cshtml"
   ViewData["Title"] = "CreatePerson"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>CreatePerson</h1>\n\n\n\n");
#nullable restore
#line 9 "C:\Users\shres\Documents\newapp\netcore-main\newapp\FirstMVCApp\Views\Home\CreatePerson.cshtml"
   ViewData["Title"] = "PersonalDetail"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Please enter the details for new person below.</h2>\n\n");
#nullable restore
#line 13 "C:\Users\shres\Documents\newapp\netcore-main\newapp\FirstMVCApp\Views\Home\CreatePerson.cshtml"
Write(Html.ActionLink("Back to Persons", "Persons", "Home", null, new { @class = "btn btn-secondary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
#nullable restore
#line 15 "C:\Users\shres\Documents\newapp\netcore-main\newapp\FirstMVCApp\Views\Home\CreatePerson.cshtml"
 using (Html.BeginForm("CreatePerson", "Home", FormMethod.Post, new { enctype ="multipart/form-data"}))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\shres\Documents\newapp\netcore-main\newapp\FirstMVCApp\Views\Home\CreatePerson.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\shres\Documents\newapp\netcore-main\newapp\FirstMVCApp\Views\Home\CreatePerson.cshtml"
Write(Html.HiddenFor(x => Model.PersonalDetailId));

#line default
#line hidden
#nullable disable
            WriteLiteral("<table border=\"1\" class=\"table table-bordered\">\n");
#nullable restore
#line 20 "C:\Users\shres\Documents\newapp\netcore-main\newapp\FirstMVCApp\Views\Home\CreatePerson.cshtml"
     if (Model.ErrorMsg != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 23 "C:\Users\shres\Documents\newapp\netcore-main\newapp\FirstMVCApp\Views\Home\CreatePerson.cshtml"
           Write(Html.DisplayNameFor(x => x.ErrorMsg));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 24 "C:\Users\shres\Documents\newapp\netcore-main\newapp\FirstMVCApp\Views\Home\CreatePerson.cshtml"
           Write(Html.TextBoxFor(x => Model.ErrorMsg));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n");
#nullable restore
#line 26 "C:\Users\shres\Documents\newapp\netcore-main\newapp\FirstMVCApp\Views\Home\CreatePerson.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n    <tr>\n        <th>Particular</th>\n        <th>Details</th>\n        <th></th>\n    </tr>\n\n\n    <tr>\n        <td>");
#nullable restore
#line 37 "C:\Users\shres\Documents\newapp\netcore-main\newapp\FirstMVCApp\Views\Home\CreatePerson.cshtml"
       Write(Html.DisplayNameFor(x => x.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 38 "C:\Users\shres\Documents\newapp\netcore-main\newapp\FirstMVCApp\Views\Home\CreatePerson.cshtml"
       Write(Html.TextBoxFor(x => Model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 39 "C:\Users\shres\Documents\newapp\netcore-main\newapp\FirstMVCApp\Views\Home\CreatePerson.cshtml"
       Write(Html.ValidationMessageFor(x => Model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    </tr>\n    <tr>\n        <td>");
#nullable restore
#line 42 "C:\Users\shres\Documents\newapp\netcore-main\newapp\FirstMVCApp\Views\Home\CreatePerson.cshtml"
       Write(Html.DisplayNameFor(x => x.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 43 "C:\Users\shres\Documents\newapp\netcore-main\newapp\FirstMVCApp\Views\Home\CreatePerson.cshtml"
       Write(Html.TextBoxFor(x => Model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 44 "C:\Users\shres\Documents\newapp\netcore-main\newapp\FirstMVCApp\Views\Home\CreatePerson.cshtml"
       Write(Html.ValidationMessageFor(x => Model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    </tr>\n    <tr>\n        <td>");
#nullable restore
#line 47 "C:\Users\shres\Documents\newapp\netcore-main\newapp\FirstMVCApp\Views\Home\CreatePerson.cshtml"
       Write(Html.DisplayNameFor(x => x.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 48 "C:\Users\shres\Documents\newapp\netcore-main\newapp\FirstMVCApp\Views\Home\CreatePerson.cshtml"
       Write(Html.TextBoxFor(x => Model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 49 "C:\Users\shres\Documents\newapp\netcore-main\newapp\FirstMVCApp\Views\Home\CreatePerson.cshtml"
       Write(Html.ValidationMessageFor(x => Model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    </tr>\n    <tr>\n        <td>");
#nullable restore
#line 52 "C:\Users\shres\Documents\newapp\netcore-main\newapp\FirstMVCApp\Views\Home\CreatePerson.cshtml"
       Write(Html.DisplayNameFor(x => x.Occupation));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 53 "C:\Users\shres\Documents\newapp\netcore-main\newapp\FirstMVCApp\Views\Home\CreatePerson.cshtml"
       Write(Html.TextBoxFor(x => Model.Occupation));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 54 "C:\Users\shres\Documents\newapp\netcore-main\newapp\FirstMVCApp\Views\Home\CreatePerson.cshtml"
       Write(Html.ValidationMessageFor(x => Model.Occupation));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    </tr>\n    <tr>\n        <td>");
#nullable restore
#line 57 "C:\Users\shres\Documents\newapp\netcore-main\newapp\FirstMVCApp\Views\Home\CreatePerson.cshtml"
       Write(Html.LabelFor(x => x.ImageLocation));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td> <input type=\"file\" name=\"profile-image\" multiple accept=\" image/*\" /> </td>\n\n    </tr>\n\n</table>\n");
            WriteLiteral("    <button type=\"submit\" class=\"btn btn-primary btn-block\">Add</button>\n");
#nullable restore
#line 65 "C:\Users\shres\Documents\newapp\netcore-main\newapp\FirstMVCApp\Views\Home\CreatePerson.cshtml"
}

#line default
#line hidden
#nullable disable
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
