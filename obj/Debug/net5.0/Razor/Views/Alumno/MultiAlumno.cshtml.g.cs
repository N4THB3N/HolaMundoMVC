#pragma checksum "D:\BASIS\Temp\ncastaneda\Projects\HolaMundoMVC\Views\Alumno\MultiAlumno.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2a35f9148ed0a90de3a0662cff2181a665d857a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Alumno_MultiAlumno), @"mvc.1.0.view", @"/Views/Alumno/MultiAlumno.cshtml")]
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
#line 1 "D:\BASIS\Temp\ncastaneda\Projects\HolaMundoMVC\Views\_ViewImports.cshtml"
using HolaMundoMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\BASIS\Temp\ncastaneda\Projects\HolaMundoMVC\Views\_ViewImports.cshtml"
using HolaMundoMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2a35f9148ed0a90de3a0662cff2181a665d857a", @"/Views/Alumno/MultiAlumno.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd844b5729bef53cbee2b226a2f3054d035bc852", @"/Views/_ViewImports.cshtml")]
    public class Views_Alumno_MultiAlumno : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Alumno>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\BASIS\Temp\ncastaneda\Projects\HolaMundoMVC\Views\Alumno\MultiAlumno.cshtml"
  
    ViewData["Title"] = "Información Asignaturas";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 7 "D:\BASIS\Temp\ncastaneda\Projects\HolaMundoMVC\Views\Alumno\MultiAlumno.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

<strong>Desde la vista normal</strong>


<table class=""table table-dark table-hover"">
    <thead>
        <tr>
            <th scope=""col"">Nombre</th>
            <th scope=""col"">Id</th>            
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 20 "D:\BASIS\Temp\ncastaneda\Projects\HolaMundoMVC\Views\Alumno\MultiAlumno.cshtml"
             foreach (var alumno in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 23 "D:\BASIS\Temp\ncastaneda\Projects\HolaMundoMVC\Views\Alumno\MultiAlumno.cshtml"
                   Write(alumno.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 24 "D:\BASIS\Temp\ncastaneda\Projects\HolaMundoMVC\Views\Alumno\MultiAlumno.cshtml"
                   Write(alumno.UniqueId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 26 "D:\BASIS\Temp\ncastaneda\Projects\HolaMundoMVC\Views\Alumno\MultiAlumno.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Alumno>> Html { get; private set; }
    }
}
#pragma warning restore 1591