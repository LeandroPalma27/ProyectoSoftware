#pragma checksum "C:\Users\leand\Desktop\Programacion\Trabajo Cuarto Módulo\Trabajo Cuarto Módulo\ProyectoIngSoftware\Evaluacion4\Views\Producto\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4048518f73c99260b099aa2bc4920549a5bdc436"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Producto_Detail), @"mvc.1.0.view", @"/Views/Producto/Detail.cshtml")]
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
#line 1 "C:\Users\leand\Desktop\Programacion\Trabajo Cuarto Módulo\Trabajo Cuarto Módulo\ProyectoIngSoftware\Evaluacion4\Views\_ViewImports.cshtml"
using Evaluacion4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\leand\Desktop\Programacion\Trabajo Cuarto Módulo\Trabajo Cuarto Módulo\ProyectoIngSoftware\Evaluacion4\Views\_ViewImports.cshtml"
using Evaluacion4.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\leand\Desktop\Programacion\Trabajo Cuarto Módulo\Trabajo Cuarto Módulo\ProyectoIngSoftware\Evaluacion4\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4048518f73c99260b099aa2bc4920549a5bdc436", @"/Views/Producto/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88c1d96a9dc944aaa513ed3f52416566ead50c0a", @"/Views/_ViewImports.cshtml")]
    public class Views_Producto_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Evaluacion4.Models.Entidad.Producto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\leand\Desktop\Programacion\Trabajo Cuarto Módulo\Trabajo Cuarto Módulo\ProyectoIngSoftware\Evaluacion4\Views\Producto\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"text-center\">\r\n        <h1>Detalles</h1>\r\n    </div>\r\n    <div class=\"container\">\r\n        <div class=\"card-columns\">\r\n            <div class=\"card\">\r\n\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4048518f73c99260b099aa2bc4920549a5bdc4365247", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 331, "~/", 331, 2, true);
#nullable restore
#line 15 "C:\Users\leand\Desktop\Programacion\Trabajo Cuarto Módulo\Trabajo Cuarto Módulo\ProyectoIngSoftware\Evaluacion4\Views\Producto\Detail.cshtml"
AddHtmlAttributeValue("", 333, Html.DisplayFor(model => model.Imagen), 333, 39, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title\" style=\"width: 220px\">\r\n                        ");
#nullable restore
#line 18 "C:\Users\leand\Desktop\Programacion\Trabajo Cuarto Módulo\Trabajo Cuarto Módulo\ProyectoIngSoftware\Evaluacion4\Views\Producto\Detail.cshtml"
                   Write(Html.DisplayFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </h5>\r\n                    <p class=\"card-text\">\r\n                        <small class=\"text-muted\">\r\n                            <i class=\"fas fa-dollar-sign\" style=\"font-size: 1.5em\">");
#nullable restore
#line 22 "C:\Users\leand\Desktop\Programacion\Trabajo Cuarto Módulo\Trabajo Cuarto Módulo\ProyectoIngSoftware\Evaluacion4\Views\Producto\Detail.cshtml"
                                                                              Write(Html.DisplayFor(model => model.Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral(".00</i>\r\n                        </small>\r\n                    </p>\r\n                </div>\r\n\r\n            </div>\r\n            <div class=\"card\">\r\n                <div");
            BeginWriteAttribute("class", " class=\"", 959, "\"", 967, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"col-sm-12\">\r\n                        <strong>\r\n                            ");
#nullable restore
#line 32 "C:\Users\leand\Desktop\Programacion\Trabajo Cuarto Módulo\Trabajo Cuarto Módulo\ProyectoIngSoftware\Evaluacion4\Views\Producto\Detail.cshtml"
                       Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral(" :\r\n                        </strong>\r\n                        ");
#nullable restore
#line 34 "C:\Users\leand\Desktop\Programacion\Trabajo Cuarto Módulo\Trabajo Cuarto Módulo\ProyectoIngSoftware\Evaluacion4\Views\Producto\Detail.cshtml"
                   Write(Html.DisplayFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n\r\n                    <div class=\"col-sm-12\">\r\n                        <strong>\r\n                            ");
#nullable restore
#line 39 "C:\Users\leand\Desktop\Programacion\Trabajo Cuarto Módulo\Trabajo Cuarto Módulo\ProyectoIngSoftware\Evaluacion4\Views\Producto\Detail.cshtml"
                       Write(Html.DisplayNameFor(model => model.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral(" :\r\n                        </strong>\r\n                        ");
#nullable restore
#line 41 "C:\Users\leand\Desktop\Programacion\Trabajo Cuarto Módulo\Trabajo Cuarto Módulo\ProyectoIngSoftware\Evaluacion4\Views\Producto\Detail.cshtml"
                   Write(Html.DisplayFor(model => model.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n\r\n                    <div class=\"col-sm-12\">\r\n                        <strong>\r\n                            ");
#nullable restore
#line 46 "C:\Users\leand\Desktop\Programacion\Trabajo Cuarto Módulo\Trabajo Cuarto Módulo\ProyectoIngSoftware\Evaluacion4\Views\Producto\Detail.cshtml"
                       Write(Html.DisplayNameFor(model => model.Codigo));

#line default
#line hidden
#nullable disable
            WriteLiteral(":\r\n                        </strong>\r\n                        ");
#nullable restore
#line 48 "C:\Users\leand\Desktop\Programacion\Trabajo Cuarto Módulo\Trabajo Cuarto Módulo\ProyectoIngSoftware\Evaluacion4\Views\Producto\Detail.cshtml"
                   Write(Html.DisplayFor(model => model.Codigo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n\r\n                    <div class=\"col-sm-12\">\r\n                        <strong>\r\n                            ");
#nullable restore
#line 53 "C:\Users\leand\Desktop\Programacion\Trabajo Cuarto Módulo\Trabajo Cuarto Módulo\ProyectoIngSoftware\Evaluacion4\Views\Producto\Detail.cshtml"
                       Write(Html.DisplayNameFor(model => model.Stock));

#line default
#line hidden
#nullable disable
            WriteLiteral(" :\r\n                        </strong>\r\n                        ");
#nullable restore
#line 55 "C:\Users\leand\Desktop\Programacion\Trabajo Cuarto Módulo\Trabajo Cuarto Módulo\ProyectoIngSoftware\Evaluacion4\Views\Producto\Detail.cshtml"
                   Write(Html.DisplayFor(model => model.Stock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n\r\n                    <div class=\"col-sm-12\">\r\n                        <strong>\r\n                            ");
#nullable restore
#line 60 "C:\Users\leand\Desktop\Programacion\Trabajo Cuarto Módulo\Trabajo Cuarto Módulo\ProyectoIngSoftware\Evaluacion4\Views\Producto\Detail.cshtml"
                       Write(Html.DisplayNameFor(model => model.Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral(" :\r\n                        </strong>\r\n                        <i class=\"fas fa-dollar-sign\" style=\"font-size: 1em\"> ");
#nullable restore
#line 62 "C:\Users\leand\Desktop\Programacion\Trabajo Cuarto Módulo\Trabajo Cuarto Módulo\ProyectoIngSoftware\Evaluacion4\Views\Producto\Detail.cshtml"
                                                                         Write(Html.DisplayFor(model => model.Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral(".00</i>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n        <div>\r\n");
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4048518f73c99260b099aa2bc4920549a5bdc43612861", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>    \r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Evaluacion4.Models.Entidad.Producto> Html { get; private set; }
    }
}
#pragma warning restore 1591
