#pragma checksum "C:\Users\victor.flores\source\repos\DesafioFramework\DesafioFramework\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2470a477f3e041fb36b441b250c4e134d9dc7253"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\victor.flores\source\repos\DesafioFramework\DesafioFramework\Views\_ViewImports.cshtml"
using DesafioFramework;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\victor.flores\source\repos\DesafioFramework\DesafioFramework\Views\_ViewImports.cshtml"
using DesafioFramework.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2470a477f3e041fb36b441b250c4e134d9dc7253", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1846333b2e82ce6385cc7d6aff00243c2bcc7572", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\victor.flores\source\repos\DesafioFramework\DesafioFramework\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row col-12"">
    <div class=""col-md-3 col-12 col-sm-6"">
        <div class=""card"">
            <div class=""card-body"">
                <p class=""card-text"">Crud Paises</p>
                <a href=""/pais"" class=""btn btn-primary"">Go somewhere</a>
            </div>
        </div>
    </div>
    <div class=""col-md-3 col-12 col-sm-6"">
        <div class=""card"">
            <div class=""card-body"">
                <p class=""card-text"">Crud Estados</p>
                <a href=""/estado"" class=""btn btn-primary"">Go somewhere</a>
            </div>
        </div>
    </div>
    <div class=""col-md-3 col-12 col-sm-6"">
        <div class=""card"">
            <div class=""card-body"">
                <p class=""card-text"">Crud Cidades</p>
                <a href=""/cidade"" class=""btn btn-primary"">Go somewhere</a>
            </div>
        </div>
    </div>
    <div class=""col-md-3 col-12 col-sm-6"">
        <div class=""card"">
            <div class=""card-body"">
                <p class=""");
            WriteLiteral("card-text\">Crud Pacientes</p>\r\n                <a href=\"/paciente\" class=\"btn btn-primary\">Go somewhere</a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
