#pragma checksum "C:\Users\victor.flores\source\repos\DesafioFramework\DesafioFramework\Views\Estado\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0c6b9c18544d4268ef788f1c308e98099f4a4c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Estado_Index), @"mvc.1.0.view", @"/Views/Estado/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0c6b9c18544d4268ef788f1c308e98099f4a4c3", @"/Views/Estado/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1846333b2e82ce6385cc7d6aff00243c2bcc7572", @"/Views/_ViewImports.cshtml")]
    public class Views_Estado_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DesafioFramework.Models.Dto.EstadoViewDto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\victor.flores\source\repos\DesafioFramework\DesafioFramework\Views\Estado\Index.cshtml"
  
    ViewData["Title"] = "Lista de Estados";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<div class=""row col-12"">
    <div class=""col-12"">
        <a class=""btn btn-primary mb-2"" href=""/estado/create"">Novo Estado</a>
    </div>
    <table class=""table"">
        <thead>
            <tr>
                <th scope=""col"">Id Cidade</th>
                <th scope=""col"">Cidade</th>
                <th scope=""col"">Estado</th>
                <th scope=""col"">Ação</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 24 "C:\Users\victor.flores\source\repos\DesafioFramework\DesafioFramework\Views\Estado\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <th scope=\"row\">");
#nullable restore
#line 27 "C:\Users\victor.flores\source\repos\DesafioFramework\DesafioFramework\Views\Estado\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.idEstado));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <td>  ");
#nullable restore
#line 28 "C:\Users\victor.flores\source\repos\DesafioFramework\DesafioFramework\Views\Estado\Index.cshtml"
                     Write(Html.DisplayFor(modelItem => item.descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>  ");
#nullable restore
#line 29 "C:\Users\victor.flores\source\repos\DesafioFramework\DesafioFramework\Views\Estado\Index.cshtml"
                     Write(Html.DisplayFor(modelItem => item.fkidPais));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1055, "\"", 1084, 2);
            WriteAttributeValue("", 1062, "/estado/", 1062, 8, true);
#nullable restore
#line 31 "C:\Users\victor.flores\source\repos\DesafioFramework\DesafioFramework\Views\Estado\Index.cshtml"
WriteAttributeValue("", 1070, item.idEstado, 1070, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\"><i class=\"fa fa-eye\"></i></a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1167, "\"", 1201, 2);
            WriteAttributeValue("", 1174, "/estado/edit/", 1174, 13, true);
#nullable restore
#line 32 "C:\Users\victor.flores\source\repos\DesafioFramework\DesafioFramework\Views\Estado\Index.cshtml"
WriteAttributeValue("", 1187, item.idEstado, 1187, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\"><i class=\"fa fa-edit\"></i></a>\r\n                        <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1304, "\"", 1340, 3);
            WriteAttributeValue("", 1314, "deleteItem(", 1314, 11, true);
#nullable restore
#line 33 "C:\Users\victor.flores\source\repos\DesafioFramework\DesafioFramework\Views\Estado\Index.cshtml"
WriteAttributeValue("", 1325, item.idEstado, 1325, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1339, ")", 1339, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\"><i class=\"fa fa-trash-alt\"></i></button>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 36 "C:\Users\victor.flores\source\repos\DesafioFramework\DesafioFramework\Views\Estado\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>
</div>

<script>
    function deleteItem(item) {
        fetch('/estado/delete/' + item, {
            method: 'DELETE',
        })
            .then(res => res.text()) // or res.json()
            .then(window.location.reload())
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DesafioFramework.Models.Dto.EstadoViewDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
