#pragma checksum "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/NewName/BrandexSalesAdapter/BrandexSalesAdapter.ExcelLogic/Views/Phoenix/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17629298bbdf832bf3ff8a1829e492ea54663299"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Phoenix_Index), @"mvc.1.0.view", @"/Views/Phoenix/Index.cshtml")]
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
#line 1 "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/NewName/BrandexSalesAdapter/BrandexSalesAdapter.ExcelLogic/Views/_ViewImports.cshtml"
using BrandexSalesAdapter.ExcelLogic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/NewName/BrandexSalesAdapter/BrandexSalesAdapter.ExcelLogic/Views/_ViewImports.cshtml"
using BrandexSalesAdapter.ExcelLogic.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/NewName/BrandexSalesAdapter/BrandexSalesAdapter.ExcelLogic/Views/_ViewImports.cshtml"
using BrandexSalesAdapter.ExcelLogic.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17629298bbdf832bf3ff8a1829e492ea54663299", @"/Views/Phoenix/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a65ee68a51ba3d804baa9fd8933a76bc4cca7e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Phoenix_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BrandexSalesAdapter.ExcelLogic.Models.Phoenix.PhoenixInputModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/NewName/BrandexSalesAdapter/BrandexSalesAdapter.ExcelLogic/Views/Phoenix/Index.cshtml"
 using (Html.BeginForm("Check", "Phoenix", FormMethod.Post, new { enctype = "multipart/form-data" }))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/NewName/BrandexSalesAdapter/BrandexSalesAdapter.ExcelLogic/Views/Phoenix/Index.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Check your Input For Error Befor Submitting</h1>\n    <div class=\"form-horizontal\">\n        <hr />\n        ");
#nullable restore
#line 8 "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/NewName/BrandexSalesAdapter/BrandexSalesAdapter.ExcelLogic/Views/Phoenix/Index.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        <h2>Check</h2>
        <div class=""form-group"">
            <div class=""col-md-10"">
                <input type=""file"" name=""ImageFile"" required />
            </div>
        </div>
        <div class=""form-group"">
            <div class=""col-md-offset-2 col-md-10"">
                <input type=""submit"" value=""Check"" class=""btn btn-primary"" />
            </div>
        </div>
    </div>
");
#nullable restore
#line 21 "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/NewName/BrandexSalesAdapter/BrandexSalesAdapter.ExcelLogic/Views/Phoenix/Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 23 "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/NewName/BrandexSalesAdapter/BrandexSalesAdapter.ExcelLogic/Views/Phoenix/Index.cshtml"
 using (Html.BeginForm("Import", "Phoenix", FormMethod.Post, new { enctype = "multipart/form-data" }))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/NewName/BrandexSalesAdapter/BrandexSalesAdapter.ExcelLogic/Views/Phoenix/Index.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">\n        <h4>Phoenix Input Form</h4>\n        <hr />\n        ");
#nullable restore
#line 30 "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/NewName/BrandexSalesAdapter/BrandexSalesAdapter.ExcelLogic/Views/Phoenix/Index.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n        <div class=\"form-group\">\n            ");
#nullable restore
#line 33 "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/NewName/BrandexSalesAdapter/BrandexSalesAdapter.ExcelLogic/Views/Phoenix/Index.cshtml"
       Write(Html.LabelFor(model => model.Date, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <div class=\"col-md-10\">\n                ");
#nullable restore
#line 35 "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/NewName/BrandexSalesAdapter/BrandexSalesAdapter.ExcelLogic/Views/Phoenix/Index.cshtml"
           Write(Html.EditorFor(model => model.Date, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 36 "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/NewName/BrandexSalesAdapter/BrandexSalesAdapter.ExcelLogic/Views/Phoenix/Index.cshtml"
           Write(Html.ValidationMessageFor(model => model.Date, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>

        <div class=""form-group"">
            <div class=""col-md-10"">
                <input type=""file"" name=""ImageFile"" required />
            </div>
        </div>
        <div class=""form-group"">
            <div class=""col-md-offset-2 col-md-10"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </div>
    </div>
");
#nullable restore
#line 51 "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/NewName/BrandexSalesAdapter/BrandexSalesAdapter.ExcelLogic/Views/Phoenix/Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 53 "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/NewName/BrandexSalesAdapter/BrandexSalesAdapter.ExcelLogic/Views/Phoenix/Index.cshtml"
 using (Html.BeginForm("Upload", "Phoenix", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">\n        <hr />\n        ");
#nullable restore
#line 57 "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/NewName/BrandexSalesAdapter/BrandexSalesAdapter.ExcelLogic/Views/Phoenix/Index.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        <h2>Upload Individually</h2>
        <div class=""form-group"">
            <div class=""form-group"">
                <label name=""pharmacyId"" class=""control-label"">Phoenix Pharmacy Id</label>
                <input name=""pharmacyId"" class=""form-control"" />
");
            WriteLiteral(@"            </div>
        </div>
        <div class=""form-group"">
            <div class=""form-group"">
                <label name=""productId"" class=""control-label"">Phoenix Product Id</label>
                <input name=""productId"" class=""form-control"" />
");
            WriteLiteral("            </div>\n        </div>\n        <div class=\"form-group\">\n            <div class=\"form-group\">\n                <label name=\"date\" class=\"control-label\">Date</label>\n                <input name=\"date\" class=\"form-control\" />\n");
            WriteLiteral("            </div>\n        </div>\n        <div class=\"form-group\">\n            <div class=\"form-group\">\n                <label name=\"count\" class=\"control-label\">Count</label>\n                <input name=\"count\" class=\"form-control\" />\n");
            WriteLiteral("            </div>\n        </div>\n        <div class=\"form-group\">\n            <div class=\"col-md-offset-2 col-md-10\">\n                <input type=\"submit\" value=\"Create\" class=\"btn btn-primary\" />\n            </div>\n        </div>\n    </div>\n");
#nullable restore
#line 93 "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/NewName/BrandexSalesAdapter/BrandexSalesAdapter.ExcelLogic/Views/Phoenix/Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BrandexSalesAdapter.ExcelLogic.Models.Phoenix.PhoenixInputModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
