#pragma checksum "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Visitas\EliminarVisitas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e8efec77fef00c3a8aee2f4eda16bcf9ff21cfd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MascotaFeliz.App.Frontend.Pages.Visitas.Pages_Visitas_EliminarVisitas), @"mvc.1.0.razor-page", @"/Pages/Visitas/EliminarVisitas.cshtml")]
namespace MascotaFeliz.App.Frontend.Pages.Visitas
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
#line 1 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\_ViewImports.cshtml"
using MascotaFeliz.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e8efec77fef00c3a8aee2f4eda16bcf9ff21cfd", @"/Pages/Visitas/EliminarVisitas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cf052204a3bb4119b871dc96742e016457a0b55", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Visitas_EliminarVisitas : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./ListaVisitas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<table class=\"table table-hover\">\r\n<thead>\r\n\r\n\r\n\r\n\r\n<th class=\"text-center\" colspan=\"2\">Detalles De la Visita Eliminada</th>\r\n</thead>\r\n  <tbody>\r\n    <tr>\r\n       <th>Id de la Visita</th>\r\n        <td>");
#nullable restore
#line 16 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Visitas\EliminarVisitas.cshtml"
       Write(Model.visitaPyP.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>   \r\n        <th>Fecha Visita</th>\r\n        <td>");
#nullable restore
#line 20 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Visitas\EliminarVisitas.cshtml"
       Write(Model.visitaPyP.FechaVisita);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n\r\n        <tr>   \r\n        <th>Temperatura</th>\r\n        <td>");
#nullable restore
#line 24 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Visitas\EliminarVisitas.cshtml"
       Write(Model.visitaPyP.Temperatura);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n        \r\n        <tr>\r\n          <th>Peso</th>\r\n        <td>");
#nullable restore
#line 28 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Visitas\EliminarVisitas.cshtml"
       Write(Model.visitaPyP.Peso);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n        \r\n        <tr>\r\n          <th>FrecuenciaRespiratoria</th>\r\n        <td>");
#nullable restore
#line 32 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Visitas\EliminarVisitas.cshtml"
       Write(Model.visitaPyP.FrecuenciaRespiratoria);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n        \r\n        <tr>\r\n          <th>FrecuenciaCardiaca</th>\r\n          <td>");
#nullable restore
#line 36 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Visitas\EliminarVisitas.cshtml"
         Write(Model.visitaPyP.FrecuenciaCardiaca);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n        \r\n        <tr>\r\n          <th>EstadoAnimo</th>\r\n          <td>");
#nullable restore
#line 40 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Visitas\EliminarVisitas.cshtml"
         Write(Model.visitaPyP.EstadoAnimo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n        \r\n   \r\n   <tr>\r\n          <th>Id Veterinario</th>\r\n          <td>");
#nullable restore
#line 45 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Visitas\EliminarVisitas.cshtml"
         Write(Model.visitaPyP.IdVeterinario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n\r\n          <tr>\r\n          <th>Recomendaciones</th>\r\n          <td>");
#nullable restore
#line 49 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Visitas\EliminarVisitas.cshtml"
         Write(Model.visitaPyP.Recomendaciones);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n  </tbody>\r\n</table>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e8efec77fef00c3a8aee2f4eda16bcf9ff21cfd6955", async() => {
                WriteLiteral("Listado De Todas las visitas");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MascotaFeliz.App.Frontend.Pages.EliminarVisitasModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFeliz.App.Frontend.Pages.EliminarVisitasModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFeliz.App.Frontend.Pages.EliminarVisitasModel>)PageContext?.ViewData;
        public MascotaFeliz.App.Frontend.Pages.EliminarVisitasModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
