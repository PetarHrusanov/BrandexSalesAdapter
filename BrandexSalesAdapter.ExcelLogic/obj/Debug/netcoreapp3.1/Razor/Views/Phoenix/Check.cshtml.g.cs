#pragma checksum "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/NewName/BrandexSalesAdapter/BrandexSalesAdapter.ExcelLogic/Views/Phoenix/Check.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f21995e6378b1fada79eb04a4a363e934de3af47"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Phoenix_Check), @"mvc.1.0.view", @"/Views/Phoenix/Check.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f21995e6378b1fada79eb04a4a363e934de3af47", @"/Views/Phoenix/Check.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a65ee68a51ba3d804baa9fd8933a76bc4cca7e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Phoenix_Check : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BrandexSalesAdapter.ExcelLogic.Models.Phoenix.PhoenixOutputModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Phoenix ");
#nullable restore
#line 2 "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/NewName/BrandexSalesAdapter/BrandexSalesAdapter.ExcelLogic/Views/Phoenix/Check.cshtml"
       Write(Model.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n");
#nullable restore
#line 3 "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/NewName/BrandexSalesAdapter/BrandexSalesAdapter.ExcelLogic/Views/Phoenix/Check.cshtml"
 if (Model.Errors.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>The following errors occurred:</h2>\n    <ul>\n\n");
#nullable restore
#line 8 "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/NewName/BrandexSalesAdapter/BrandexSalesAdapter.ExcelLogic/Views/Phoenix/Check.cshtml"
         foreach (var error in Model.Errors)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>Error: In line ");
#nullable restore
#line 10 "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/NewName/BrandexSalesAdapter/BrandexSalesAdapter.ExcelLogic/Views/Phoenix/Check.cshtml"
                          Write(error.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral(" with value ");
#nullable restore
#line 10 "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/NewName/BrandexSalesAdapter/BrandexSalesAdapter.ExcelLogic/Views/Phoenix/Check.cshtml"
                                                Write(error.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 11 "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/NewName/BrandexSalesAdapter/BrandexSalesAdapter.ExcelLogic/Views/Phoenix/Check.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </ul>\n");
#nullable restore
#line 14 "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/NewName/BrandexSalesAdapter/BrandexSalesAdapter.ExcelLogic/Views/Phoenix/Check.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/NewName/BrandexSalesAdapter/BrandexSalesAdapter.ExcelLogic/Views/Phoenix/Check.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BrandexSalesAdapter.ExcelLogic.Models.Phoenix.PhoenixOutputModel> Html { get; private set; }
    }
}
#pragma warning restore 1591