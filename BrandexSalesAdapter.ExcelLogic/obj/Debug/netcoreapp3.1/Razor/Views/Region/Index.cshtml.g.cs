#pragma checksum "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/BrandexSalesAdapter/Server/BrandexSalesAdapter/BrandexSalesAdapter.ExcelLogic/Views/Region/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e8f91e846c739a09389b159b6c099c292341470"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Region_Index), @"mvc.1.0.view", @"/Views/Region/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e8f91e846c739a09389b159b6c099c292341470", @"/Views/Region/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a65ee68a51ba3d804baa9fd8933a76bc4cca7e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Region_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/BrandexSalesAdapter/Server/BrandexSalesAdapter/BrandexSalesAdapter.ExcelLogic/Views/Region/Index.cshtml"
 using (Html.BeginForm("Import", "Region", FormMethod.Post, new { enctype = "multipart/form-data" }))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/BrandexSalesAdapter/Server/BrandexSalesAdapter/BrandexSalesAdapter.ExcelLogic/Views/Region/Index.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">\n        <h4>Regions Bulk Import</h4>\n        <hr />\n        ");
#nullable restore
#line 8 "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/BrandexSalesAdapter/Server/BrandexSalesAdapter/BrandexSalesAdapter.ExcelLogic/Views/Region/Index.cshtml"
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
#line 20 "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/BrandexSalesAdapter/Server/BrandexSalesAdapter/BrandexSalesAdapter.ExcelLogic/Views/Region/Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<hr />\n\n");
#nullable restore
#line 24 "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/BrandexSalesAdapter/Server/BrandexSalesAdapter/BrandexSalesAdapter.ExcelLogic/Views/Region/Index.cshtml"
 using (Html.BeginForm("Upload", "Region", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"form-horizontal\">\n    <h4>Region Manual Import</h4>\n    ");
#nullable restore
#line 28 "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/BrandexSalesAdapter/Server/BrandexSalesAdapter/BrandexSalesAdapter.ExcelLogic/Views/Region/Index.cshtml"
Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""form-group"">
        <div class=""form-group"">
            <label name=""regionName"" class=""control-label"">Region Name</label>
            <input name=""regionName"" class=""form-control"" />
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
#line 41 "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/BrandexSalesAdapter/Server/BrandexSalesAdapter/BrandexSalesAdapter.ExcelLogic/Views/Region/Index.cshtml"
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
