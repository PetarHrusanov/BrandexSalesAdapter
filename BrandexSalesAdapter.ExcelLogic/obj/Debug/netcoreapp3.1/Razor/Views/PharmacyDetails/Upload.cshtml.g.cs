#pragma checksum "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/BrandexSalesAdapter/Server/BrandexSalesAdapter/BrandexSalesAdapter.ExcelLogic/Views/PharmacyDetails/Upload.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfb55dd941833d49d295311bfe17f6a7a08dbad1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PharmacyDetails_Upload), @"mvc.1.0.view", @"/Views/PharmacyDetails/Upload.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfb55dd941833d49d295311bfe17f6a7a08dbad1", @"/Views/PharmacyDetails/Upload.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a65ee68a51ba3d804baa9fd8933a76bc4cca7e9", @"/Views/_ViewImports.cshtml")]
    public class Views_PharmacyDetails_Upload : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BrandexSalesAdapter.ExcelLogic.Models.Pharmacies.PharmacyOutputModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/BrandexSalesAdapter/Server/BrandexSalesAdapter/BrandexSalesAdapter.ExcelLogic/Views/PharmacyDetails/Upload.cshtml"
   ViewData["Title"] = "Details"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Uploaded Pharmacy Chains</h1>\n<div>\n    <hr />\n    <h2>Details</h2>\n    <dl class=\"row\">\n        <dt class=\"col-sm-2\">\n            Pharmacy Name\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 12 "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/BrandexSalesAdapter/Server/BrandexSalesAdapter/BrandexSalesAdapter.ExcelLogic/Views/PharmacyDetails/Upload.cshtml"
       Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            Class\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 18 "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/BrandexSalesAdapter/Server/BrandexSalesAdapter/BrandexSalesAdapter.ExcelLogic/Views/PharmacyDetails/Upload.cshtml"
       Write(Model.PharmacyClass);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            Company\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 24 "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/BrandexSalesAdapter/Server/BrandexSalesAdapter/BrandexSalesAdapter.ExcelLogic/Views/PharmacyDetails/Upload.cshtml"
       Write(Model.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            Company\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 30 "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/BrandexSalesAdapter/Server/BrandexSalesAdapter/BrandexSalesAdapter.ExcelLogic/Views/PharmacyDetails/Upload.cshtml"
       Write(Model.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            Pharmacy Chain Name\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 36 "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/BrandexSalesAdapter/Server/BrandexSalesAdapter/BrandexSalesAdapter.ExcelLogic/Views/PharmacyDetails/Upload.cshtml"
       Write(Model.PharmacyChainName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            Address\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 42 "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/BrandexSalesAdapter/Server/BrandexSalesAdapter/BrandexSalesAdapter.ExcelLogic/Views/PharmacyDetails/Upload.cshtml"
       Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            Region\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 48 "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/BrandexSalesAdapter/Server/BrandexSalesAdapter/BrandexSalesAdapter.ExcelLogic/Views/PharmacyDetails/Upload.cshtml"
       Write(Model.Region);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            Region\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 54 "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/BrandexSalesAdapter/Server/BrandexSalesAdapter/BrandexSalesAdapter.ExcelLogic/Views/PharmacyDetails/Upload.cshtml"
       Write(Model.Region);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            BrandexId\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 60 "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/BrandexSalesAdapter/Server/BrandexSalesAdapter/BrandexSalesAdapter.ExcelLogic/Views/PharmacyDetails/Upload.cshtml"
       Write(Model.BrandexId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            PharmnetId\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 66 "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/BrandexSalesAdapter/Server/BrandexSalesAdapter/BrandexSalesAdapter.ExcelLogic/Views/PharmacyDetails/Upload.cshtml"
       Write(Model.PharmnetId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            PhoenixId\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 72 "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/BrandexSalesAdapter/Server/BrandexSalesAdapter/BrandexSalesAdapter.ExcelLogic/Views/PharmacyDetails/Upload.cshtml"
       Write(Model.PhoenixId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            SopharmaId\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 78 "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/BrandexSalesAdapter/Server/BrandexSalesAdapter/BrandexSalesAdapter.ExcelLogic/Views/PharmacyDetails/Upload.cshtml"
       Write(Model.SopharmaId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            StingId\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 84 "/Users/Petar/Documents/Documents – Petar’s MacBook Pro/Programiranka/Firmata/BrandexSalesAdapter/Server/BrandexSalesAdapter/BrandexSalesAdapter.ExcelLogic/Views/PharmacyDetails/Upload.cshtml"
       Write(Model.StingId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n    </dl>\n    <div>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dfb55dd941833d49d295311bfe17f6a7a08dbad110495", async() => {
                WriteLiteral("Index");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BrandexSalesAdapter.ExcelLogic.Models.Pharmacies.PharmacyOutputModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
