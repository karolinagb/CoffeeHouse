#pragma checksum "C:\projetos\CoffeeHouse\CoffeeHouse\Views\MaquinaCafes\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d587bb23635bd8b42f96e97995b0c95be63f2117"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MaquinaCafes_Create), @"mvc.1.0.view", @"/Views/MaquinaCafes/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/MaquinaCafes/Create.cshtml", typeof(AspNetCore.Views_MaquinaCafes_Create))]
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
#line 1 "C:\projetos\CoffeeHouse\CoffeeHouse\Views\_ViewImports.cshtml"
using CoffeeHouse;

#line default
#line hidden
#line 2 "C:\projetos\CoffeeHouse\CoffeeHouse\Views\_ViewImports.cshtml"
using CoffeeHouse.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d587bb23635bd8b42f96e97995b0c95be63f2117", @"/Views/MaquinaCafes/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0294fe7d5e9d617deee3c63d87515446de498248", @"/Views/_ViewImports.cshtml")]
    public class Views_MaquinaCafes_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoffeeHouse.Models.MaquinaCafe>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 165, true);
            WriteLiteral("\r\n<!--<div asp-validation-summary=\"All\" class=\"text-danger\"></div>-->\r\n<div class=\"alert alert-success\" role=\"alert\">\r\n    <h4 class=\"alert-heading\">Café escolhido: ");
            EndContext();
            BeginContext(205, 15, false);
#line 5 "C:\projetos\CoffeeHouse\CoffeeHouse\Views\MaquinaCafes\Create.cshtml"
                                         Write(Model.Descricao);

#line default
#line hidden
            EndContext();
            BeginContext(220, 32, true);
            WriteLiteral("</h4>\r\n    <p>Valor do item: R$ ");
            EndContext();
            BeginContext(253, 15, false);
#line 6 "C:\projetos\CoffeeHouse\CoffeeHouse\Views\MaquinaCafes\Create.cshtml"
                    Write(Model.ValorCafe);

#line default
#line hidden
            EndContext();
            BeginContext(268, 28, true);
            WriteLiteral("</p>\r\n    <p>Valor pago: R$ ");
            EndContext();
            BeginContext(297, 17, false);
#line 7 "C:\projetos\CoffeeHouse\CoffeeHouse\Views\MaquinaCafes\Create.cshtml"
                 Write(Model.ValorAceito);

#line default
#line hidden
            EndContext();
            BeginContext(314, 44, true);
            WriteLiteral(" </p>\r\n    <hr>\r\n    <p class=\"mb-0\">Troco: ");
            EndContext();
            BeginContext(359, 11, false);
#line 9 "C:\projetos\CoffeeHouse\CoffeeHouse\Views\MaquinaCafes\Create.cshtml"
                      Write(Model.Troco);

#line default
#line hidden
            EndContext();
            BeginContext(370, 16, true);
            WriteLiteral("</p>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(403, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 13 "C:\projetos\CoffeeHouse\CoffeeHouse\Views\MaquinaCafes\Create.cshtml"
       await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoffeeHouse.Models.MaquinaCafe> Html { get; private set; }
    }
}
#pragma warning restore 1591
