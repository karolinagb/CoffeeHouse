#pragma checksum "C:\projetos\CoffeeHouse\CoffeeHouse\Views\MaquinaCafes\DefeitoLeitora.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a9ae220e6d17e059e10a8d3fc7788dedc21d454"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MaquinaCafes_DefeitoLeitora), @"mvc.1.0.view", @"/Views/MaquinaCafes/DefeitoLeitora.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/MaquinaCafes/DefeitoLeitora.cshtml", typeof(AspNetCore.Views_MaquinaCafes_DefeitoLeitora))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a9ae220e6d17e059e10a8d3fc7788dedc21d454", @"/Views/MaquinaCafes/DefeitoLeitora.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0294fe7d5e9d617deee3c63d87515446de498248", @"/Views/_ViewImports.cshtml")]
    public class Views_MaquinaCafes_DefeitoLeitora : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\projetos\CoffeeHouse\CoffeeHouse\Views\MaquinaCafes\DefeitoLeitora.cshtml"
  
    ViewData["Title"] = "Oops!";

#line default
#line hidden
            BeginContext(41, 6, true);
            WriteLiteral("\r\n<h3>");
            EndContext();
            BeginContext(48, 17, false);
#line 5 "C:\projetos\CoffeeHouse\CoffeeHouse\Views\MaquinaCafes\DefeitoLeitora.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(65, 60, true);
            WriteLiteral("</h3>\r\n\r\n<div class=\"alert alert-danger\" role=\"alert\">\r\n    ");
            EndContext();
            BeginContext(126, 12, false);
#line 8 "C:\projetos\CoffeeHouse\CoffeeHouse\Views\MaquinaCafes\DefeitoLeitora.cshtml"
Write(ViewBag.Erro);

#line default
#line hidden
            EndContext();
            BeginContext(138, 14, true);
            WriteLiteral("\r\n</div>\r\n\r\n\r\n");
            EndContext();
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