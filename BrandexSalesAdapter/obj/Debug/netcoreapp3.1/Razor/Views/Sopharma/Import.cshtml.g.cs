#pragma checksum "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/NewName/BrandexSalesAdapter/BrandexSalesAdapter/Views/Sopharma/Import.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6c7285b7ca5fb14a5fd705449d48b16d6b02644"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sopharma_Import), @"mvc.1.0.view", @"/Views/Sopharma/Import.cshtml")]
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
#line 1 "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/NewName/BrandexSalesAdapter/BrandexSalesAdapter/Views/_ViewImports.cshtml"
using BrandexSalesAdapter.ExcelLogic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/NewName/BrandexSalesAdapter/BrandexSalesAdapter/Views/_ViewImports.cshtml"
using BrandexSalesAdapter.ExcelLogic.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6c7285b7ca5fb14a5fd705449d48b16d6b02644", @"/Views/Sopharma/Import.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33774425a315e5e2753252b7b5f7464894075238", @"/Views/_ViewImports.cshtml")]
    public class Views_Sopharma_Import : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BrandexSalesAdapter.ExcelLogic.Models.Sopharma.SopharmaOutputModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Sopharma ");
#nullable restore
#line 2 "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/NewName/BrandexSalesAdapter/BrandexSalesAdapter/Views/Sopharma/Import.cshtml"
        Write(Model.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral(" upload was successful!</h1>\n");
#nullable restore
#line 3 "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/NewName/BrandexSalesAdapter/BrandexSalesAdapter/Views/Sopharma/Import.cshtml"
 if (Model.Errors.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>The following errors occurred:</h2>\n    <ul>\n\n");
#nullable restore
#line 8 "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/NewName/BrandexSalesAdapter/BrandexSalesAdapter/Views/Sopharma/Import.cshtml"
         foreach (var error in Model.Errors)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>Error: In line ");
#nullable restore
#line 10 "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/NewName/BrandexSalesAdapter/BrandexSalesAdapter/Views/Sopharma/Import.cshtml"
                          Write(error.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral(" with value ");
#nullable restore
#line 10 "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/NewName/BrandexSalesAdapter/BrandexSalesAdapter/Views/Sopharma/Import.cshtml"
                                                Write(error.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 11 "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/NewName/BrandexSalesAdapter/BrandexSalesAdapter/Views/Sopharma/Import.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </ul>\n");
#nullable restore
#line 14 "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/NewName/BrandexSalesAdapter/BrandexSalesAdapter/Views/Sopharma/Import.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/NewName/BrandexSalesAdapter/BrandexSalesAdapter/Views/Sopharma/Import.cshtml"
Write(Html.Raw(@Model.Table));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BrandexSalesAdapter.ExcelLogic.Models.Sopharma.SopharmaOutputModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
