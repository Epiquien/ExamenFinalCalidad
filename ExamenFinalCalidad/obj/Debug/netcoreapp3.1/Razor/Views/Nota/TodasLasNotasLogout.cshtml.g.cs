#pragma checksum "C:\Users\PCTUNNING\source\repos\ExamenFinalCalidad\ExamenFinalCalidad\Views\Nota\TodasLasNotasLogout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b2c07ebf641771e88bee48d45fd04401b6e8377"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Nota_TodasLasNotasLogout), @"mvc.1.0.view", @"/Views/Nota/TodasLasNotasLogout.cshtml")]
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
#line 1 "C:\Users\PCTUNNING\source\repos\ExamenFinalCalidad\ExamenFinalCalidad\Views\_ViewImports.cshtml"
using ExamenFinalCalidad;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PCTUNNING\source\repos\ExamenFinalCalidad\ExamenFinalCalidad\Views\_ViewImports.cshtml"
using ExamenFinalCalidad.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b2c07ebf641771e88bee48d45fd04401b6e8377", @"/Views/Nota/TodasLasNotasLogout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fb74bee75d70ff54049ad386919f0f926d6bd09", @"/Views/_ViewImports.cshtml")]
    public class Views_Nota_TodasLasNotasLogout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/TodosLosCursos.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9b2c07ebf641771e88bee48d45fd04401b6e83774212", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n<div class=\"search-container\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b2c07ebf641771e88bee48d45fd04401b6e83775364", async() => {
                WriteLiteral("\n        <input type=\"text\"");
                BeginWriteAttribute("style", " style=\"", 128, "\"", 136, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Buscar Curso\" name=\"busqueda\" autocomplete=\"off\">\n        <button type=\"submit\" class=\"btnBuscar\"><i class=\"fa fa-search\"></i></button>\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n\n\n<div style=\"text-align:center\">\n    <a href=\"/Nota/TodasLasNotasLogout\"><img width=\"700\" height=\"250\"");
            BeginWriteAttribute("src", " src=\"", 409, "\"", 415, 0);
            EndWriteAttribute();
            WriteLiteral(" /></a>\n</div>\n\n<div class=\"row\">\n    <div class=\"container\">\n        <div class=\"card-deck\">\n");
#nullable restore
#line 19 "C:\Users\PCTUNNING\source\repos\ExamenFinalCalidad\ExamenFinalCalidad\Views\Nota\TodasLasNotasLogout.cshtml"
             foreach (var item in @ViewBag.Notas)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-md-4\">\n    <div class=\"card text-white bg-secondary mb-3\" style=\"max-width: 18rem;\">\n        <img class=\"card-img-top zoom\"");
            BeginWriteAttribute("src", " src=\"", 713, "\"", 731, 1);
#nullable restore
#line 23 "C:\Users\PCTUNNING\source\repos\ExamenFinalCalidad\ExamenFinalCalidad\Views\Nota\TodasLasNotasLogout.cshtml"
WriteAttributeValue("", 719, item.Imagen, 719, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n        <div class=\"card-body\">\n            <a");
            BeginWriteAttribute("href", " href=\"", 782, "\"", 824, 2);
            WriteAttributeValue("", 789, "/Nota/DetalleNotaLogout?Id=", 789, 27, true);
#nullable restore
#line 25 "C:\Users\PCTUNNING\source\repos\ExamenFinalCalidad\ExamenFinalCalidad\Views\Nota\TodasLasNotasLogout.cshtml"
WriteAttributeValue("", 816, item.Id, 816, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><h4 class=\"card-title text-white text-center\">");
#nullable restore
#line 25 "C:\Users\PCTUNNING\source\repos\ExamenFinalCalidad\ExamenFinalCalidad\Views\Nota\TodasLasNotasLogout.cshtml"
                                                                                                   Write(item.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4></a>\n            <p>");
#nullable restore
#line 26 "C:\Users\PCTUNNING\source\repos\ExamenFinalCalidad\ExamenFinalCalidad\Views\Nota\TodasLasNotasLogout.cshtml"
          Write(ViewBag.Categorias[@item.Id]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            <a");
            BeginWriteAttribute("href", " href=\"", 957, "\"", 999, 2);
            WriteAttributeValue("", 964, "/Nota/DetalleNotaLogout?Id=", 964, 27, true);
#nullable restore
#line 27 "C:\Users\PCTUNNING\source\repos\ExamenFinalCalidad\ExamenFinalCalidad\Views\Nota\TodasLasNotasLogout.cshtml"
WriteAttributeValue("", 991, item.Id, 991, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info text-center btnLeerMas\">Leer m&aacute;s...</a>\n        </div>\n    </div>\n</div>            ");
#nullable restore
#line 30 "C:\Users\PCTUNNING\source\repos\ExamenFinalCalidad\ExamenFinalCalidad\Views\Nota\TodasLasNotasLogout.cshtml"
                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n    </div>\n</div>\n");
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