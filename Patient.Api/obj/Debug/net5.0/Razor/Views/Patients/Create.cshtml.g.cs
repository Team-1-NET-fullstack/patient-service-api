#pragma checksum "C:\IMPACT2\patient-service-api\Patient.Api\Views\Patients\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88f40a007f97d47b65ae762dd568fbea3eee101e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patients_Create), @"mvc.1.0.view", @"/Views/Patients/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88f40a007f97d47b65ae762dd568fbea3eee101e", @"/Views/Patients/Create.cshtml")]
    public class Views_Patients_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Patient.Api.Models.Patient>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\IMPACT2\patient-service-api\Patient.Api\Views\Patients\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>Patient</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""PatientId"" class=""control-label""></label>
                <input asp-for=""PatientId"" class=""form-control"" />
                <span asp-validation-for=""PatientId"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Title"" class=""control-label""></label>
                <input asp-for=""Title"" class=""form-control"" />
                <span asp-validation-for=""Title"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""FirstName"" class=""control-label""></label>
                <input asp-for=""FirstName"" class=""form-control"" />
                <span asp-validation-for=""FirstName"" class=""text-danger""></span");
            WriteLiteral(@">
            </div>
            <div class=""form-group"">
                <label asp-for=""LastName"" class=""control-label""></label>
                <input asp-for=""LastName"" class=""form-control"" />
                <span asp-validation-for=""LastName"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Dob"" class=""control-label""></label>
                <input asp-for=""Dob"" class=""form-control"" />
                <span asp-validation-for=""Dob"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Gender"" class=""control-label""></label>
                <input asp-for=""Gender"" class=""form-control"" />
                <span asp-validation-for=""Gender"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Race"" class=""control-label""></label>
                <input asp-for=""Race"" class=""form-control"" />
           ");
            WriteLiteral(@"     <span asp-validation-for=""Race"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Languages"" class=""control-label""></label>
                <input asp-for=""Languages"" class=""form-control"" />
                <span asp-validation-for=""Languages"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Address"" class=""control-label""></label>
                <input asp-for=""Address"" class=""form-control"" />
                <span asp-validation-for=""Address"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""PinCode"" class=""control-label""></label>
                <input asp-for=""PinCode"" class=""form-control"" />
                <span asp-validation-for=""PinCode"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""CountryCode"" class=""control-lab");
            WriteLiteral(@"el""></label>
                <input asp-for=""CountryCode"" class=""form-control"" />
                <span asp-validation-for=""CountryCode"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""State"" class=""control-label""></label>
                <input asp-for=""State"" class=""form-control"" />
                <span asp-validation-for=""State"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""ContactNumber"" class=""control-label""></label>
                <input asp-for=""ContactNumber"" class=""form-control"" />
                <span asp-validation-for=""ContactNumber"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""EmergencyContact"" class=""control-label""></label>
                <input asp-for=""EmergencyContact"" class=""form-control"" />
                <span asp-validation-for=""EmergencyContact"" class=""text-dan");
            WriteLiteral(@"ger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""NomineeId"" class=""control-label""></label>
                <select asp-for=""NomineeId"" class =""form-control"" asp-items=""ViewBag.NomineeId""></select>
            </div>
            <div class=""form-group"">
                <label asp-for=""CreatedBy"" class=""control-label""></label>
                <select asp-for=""CreatedBy"" class =""form-control"" asp-items=""ViewBag.CreatedBy""></select>
            </div>
            <div class=""form-group"">
                <label asp-for=""CreatedDate"" class=""control-label""></label>
                <input asp-for=""CreatedDate"" class=""form-control"" />
                <span asp-validation-for=""CreatedDate"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""UpdatedBy"" class=""control-label""></label>
                <select asp-for=""UpdatedBy"" class =""form-control"" asp-items=""ViewBag.UpdatedBy""></select>
 ");
            WriteLiteral(@"           </div>
            <div class=""form-group"">
                <label asp-for=""UpdatedDate"" class=""control-label""></label>
                <input asp-for=""UpdatedDate"" class=""form-control"" />
                <span asp-validation-for=""UpdatedDate"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 119 "C:\IMPACT2\patient-service-api\Patient.Api\Views\Patients\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Patient.Api.Models.Patient> Html { get; private set; }
    }
}
#pragma warning restore 1591
