#pragma checksum "C:\IMPACT2\patient-service-api\Patient.Api\Views\Patients\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3963a4bfee073ba2d73de01a932ea21dc1a1ea8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patients_Index), @"mvc.1.0.view", @"/Views/Patients/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3963a4bfee073ba2d73de01a932ea21dc1a1ea8", @"/Views/Patients/Index.cshtml")]
    public class Views_Patients_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Patient.Api.Models.Patient>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\IMPACT2\patient-service-api\Patient.Api\Views\Patients\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\IMPACT2\patient-service-api\Patient.Api\Views\Patients\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\IMPACT2\patient-service-api\Patient.Api\Views\Patients\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\IMPACT2\patient-service-api\Patient.Api\Views\Patients\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\IMPACT2\patient-service-api\Patient.Api\Views\Patients\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Dob));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\IMPACT2\patient-service-api\Patient.Api\Views\Patients\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\IMPACT2\patient-service-api\Patient.Api\Views\Patients\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Race));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\IMPACT2\patient-service-api\Patient.Api\Views\Patients\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Languages));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "C:\IMPACT2\patient-service-api\Patient.Api\Views\Patients\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 40 "C:\IMPACT2\patient-service-api\Patient.Api\Views\Patients\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PinCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 43 "C:\IMPACT2\patient-service-api\Patient.Api\Views\Patients\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CountryCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 46 "C:\IMPACT2\patient-service-api\Patient.Api\Views\Patients\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 49 "C:\IMPACT2\patient-service-api\Patient.Api\Views\Patients\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ContactNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 52 "C:\IMPACT2\patient-service-api\Patient.Api\Views\Patients\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EmergencyContact));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 55 "C:\IMPACT2\patient-service-api\Patient.Api\Views\Patients\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 58 "C:\IMPACT2\patient-service-api\Patient.Api\Views\Patients\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UpdatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 61 "C:\IMPACT2\patient-service-api\Patient.Api\Views\Patients\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CreatedByNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 64 "C:\IMPACT2\patient-service-api\Patient.Api\Views\Patients\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nominee));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 67 "C:\IMPACT2\patient-service-api\Patient.Api\Views\Patients\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UpdatedByNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 73 "C:\IMPACT2\patient-service-api\Patient.Api\Views\Patients\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 76 "C:\IMPACT2\patient-service-api\Patient.Api\Views\Patients\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 79 "C:\IMPACT2\patient-service-api\Patient.Api\Views\Patients\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 82 "C:\IMPACT2\patient-service-api\Patient.Api\Views\Patients\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 85 "C:\IMPACT2\patient-service-api\Patient.Api\Views\Patients\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Dob));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 88 "C:\IMPACT2\patient-service-api\Patient.Api\Views\Patients\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 91 "C:\IMPACT2\patient-service-api\Patient.Api\Views\Patients\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Race));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 94 "C:\IMPACT2\patient-service-api\Patient.Api\Views\Patients\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Languages));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 97 "C:\IMPACT2\patient-service-api\Patient.Api\Views\Patients\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 100 "C:\IMPACT2\patient-service-api\Patient.Api\Views\Patients\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PinCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 103 "C:\IMPACT2\patient-service-api\Patient.Api\Views\Patients\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CountryCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 106 "C:\IMPACT2\patient-service-api\Patient.Api\Views\Patients\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 109 "C:\IMPACT2\patient-service-api\Patient.Api\Views\Patients\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ContactNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 112 "C:\IMPACT2\patient-service-api\Patient.Api\Views\Patients\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EmergencyContact));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 115 "C:\IMPACT2\patient-service-api\Patient.Api\Views\Patients\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 118 "C:\IMPACT2\patient-service-api\Patient.Api\Views\Patients\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.UpdatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 121 "C:\IMPACT2\patient-service-api\Patient.Api\Views\Patients\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CreatedByNavigation.EmailId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 124 "C:\IMPACT2\patient-service-api\Patient.Api\Views\Patients\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nominee.EmailId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 127 "C:\IMPACT2\patient-service-api\Patient.Api\Views\Patients\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.UpdatedByNavigation.EmailId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 4038, "\"", 4068, 1);
#nullable restore
#line 130 "C:\IMPACT2\patient-service-api\Patient.Api\Views\Patients\Index.cshtml"
WriteAttributeValue("", 4053, item.PatientId, 4053, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 4121, "\"", 4151, 1);
#nullable restore
#line 131 "C:\IMPACT2\patient-service-api\Patient.Api\Views\Patients\Index.cshtml"
WriteAttributeValue("", 4136, item.PatientId, 4136, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 4206, "\"", 4236, 1);
#nullable restore
#line 132 "C:\IMPACT2\patient-service-api\Patient.Api\Views\Patients\Index.cshtml"
WriteAttributeValue("", 4221, item.PatientId, 4221, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 135 "C:\IMPACT2\patient-service-api\Patient.Api\Views\Patients\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Patient.Api.Models.Patient>> Html { get; private set; }
    }
}
#pragma warning restore 1591