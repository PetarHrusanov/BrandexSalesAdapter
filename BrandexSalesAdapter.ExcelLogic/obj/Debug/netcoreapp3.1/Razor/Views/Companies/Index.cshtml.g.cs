#pragma checksum "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/BrandexSalesAdapter/Server/BrandexSalesAdapter/BrandexSalesAdapter.ExcelLogic/Views/Companies/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3a777cea2f91ce8e96c75ffffee77c065f5faa8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Companies_Index), @"mvc.1.0.view", @"/Views/Companies/Index.cshtml")]
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
#line 1 "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/BrandexSalesAdapter/Server/BrandexSalesAdapter/BrandexSalesAdapter.ExcelLogic/Views/_ViewImports.cshtml"
using BrandexSalesAdapter.ExcelLogic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/BrandexSalesAdapter/Server/BrandexSalesAdapter/BrandexSalesAdapter.ExcelLogic/Views/_ViewImports.cshtml"
using BrandexSalesAdapter.ExcelLogic.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/BrandexSalesAdapter/Server/BrandexSalesAdapter/BrandexSalesAdapter.ExcelLogic/Views/_ViewImports.cshtml"
using BrandexSalesAdapter.ExcelLogic.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3a777cea2f91ce8e96c75ffffee77c065f5faa8", @"/Views/Companies/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a65ee68a51ba3d804baa9fd8933a76bc4cca7e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Companies_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/BrandexSalesAdapter/Server/BrandexSalesAdapter/BrandexSalesAdapter.ExcelLogic/Views/Companies/Index.cshtml"
 using (Html.BeginForm("Import", "Companies", FormMethod.Post, new { enctype = "multipart/form-data" }))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/BrandexSalesAdapter/Server/BrandexSalesAdapter/BrandexSalesAdapter.ExcelLogic/Views/Companies/Index.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">\n        <h4>Companies Bulk Import</h4>\n        <hr />\n        ");
#nullable restore
#line 8 "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/BrandexSalesAdapter/Server/BrandexSalesAdapter/BrandexSalesAdapter.ExcelLogic/Views/Companies/Index.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        <div class=""form-group"">
            <div class=""col-md-10"">
                <input type=""file"" name=""ImageFile"" required />
            </div>
        </div>
        <div class=""form-group"">
            <div class=""col-md-offset-2 col-md-10"">
                <input type=""submit"" value=""Import"" class=""btn btn-primary"" />
            </div>
        </div>
    </div>
");
#nullable restore
#line 20 "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/BrandexSalesAdapter/Server/BrandexSalesAdapter/BrandexSalesAdapter.ExcelLogic/Views/Companies/Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<hr />\n\n");
#nullable restore
#line 24 "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/BrandexSalesAdapter/Server/BrandexSalesAdapter/BrandexSalesAdapter.ExcelLogic/Views/Companies/Index.cshtml"
 using (Html.BeginForm("Upload", "Companies", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"form-horizontal\">\n    <h4>Company Manual Import</h4>\n    ");
#nullable restore
#line 29 "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/BrandexSalesAdapter/Server/BrandexSalesAdapter/BrandexSalesAdapter.ExcelLogic/Views/Companies/Index.cshtml"
Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""form-group"">
        <div class=""form-group"">
            <label name=""companyName"" class=""control-label"">Company Name</label>
            <input name=""companyName"" class=""form-control"" />
        </div>
    </div>
    <div class=""form-group"">
        <div class=""form-group"">
            <label name=""vat"" class=""control-label"">VAT</label>
            <input name=""vat"" class=""form-control"" />
        </div>
    </div>
    <div class=""form-group"">
        <div class=""form-group"">
            <label name=""ownerName"" class=""control-label"">Owner</label>
            <input name=""ownerName"" class=""form-control"" />
        </div>
    </div>
    <div class=""form-group"">
        <div class=""col-md-offset-2 col-md-10"">
            <input type=""submit"" value=""Upload"" class=""btn btn-primary"" />
        </div>
    </div>
</div>
");
#nullable restore
#line 54 "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/BrandexSalesAdapter/Server/BrandexSalesAdapter/BrandexSalesAdapter.ExcelLogic/Views/Companies/Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
