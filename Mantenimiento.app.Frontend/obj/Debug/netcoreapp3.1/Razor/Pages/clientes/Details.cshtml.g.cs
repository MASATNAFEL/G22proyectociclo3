#pragma checksum "C:\MantenimientoAutomotriz\G22proyectociclo3\Mantenimiento.app.Frontend\Pages\clientes\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a821e7357a0ee7738c55b81106801ade4a6c4151"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Mantenimiento.app.Frontend.Pages.clientes.Pages_clientes_Details), @"mvc.1.0.razor-page", @"/Pages/clientes/Details.cshtml")]
namespace Mantenimiento.app.Frontend.Pages.clientes
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
#line 1 "C:\MantenimientoAutomotriz\G22proyectociclo3\Mantenimiento.app.Frontend\Pages\_ViewImports.cshtml"
using Mantenimiento.app.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a821e7357a0ee7738c55b81106801ade4a6c4151", @"/Pages/clientes/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fea37a9db42b952b94ed245c060d2fc90a924ed4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_clientes_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "../linkspage/clientes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<h1>informacion del cliente</h1>\r\n<hr>\r\n<br><br>\r\n<a class=\"btn btn-info\"><i class=\"fa-solid fa-eye\"></i></a>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a821e7357a0ee7738c55b81106801ade4a6c41513804", async() => {
                WriteLiteral("<i class=\"fa-sharp fa-solid fa-person-walking-arrow-loop-left\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<br><br>\r\n<div>\r\n<h5>Cliente</h5>\r\n<br><br>\r\n<div class=\"row\">\r\n    <div class=\"col-md-2\">\r\n    <strong>");
#nullable restore
#line 16 "C:\MantenimientoAutomotriz\G22proyectociclo3\Mantenimiento.app.Frontend\Pages\clientes\Details.cshtml"
       Write(Html.DisplayNameFor(m=>m.Cliente.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</strong>\r\n    </div>\r\n    <div class=\"col-md-10\">\r\n    ");
#nullable restore
#line 19 "C:\MantenimientoAutomotriz\G22proyectociclo3\Mantenimiento.app.Frontend\Pages\clientes\Details.cshtml"
Write(Html.DisplayFor(m=>m.Cliente.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-2\">\r\n    <strong>");
#nullable restore
#line 22 "C:\MantenimientoAutomotriz\G22proyectociclo3\Mantenimiento.app.Frontend\Pages\clientes\Details.cshtml"
       Write(Html.DisplayNameFor(m=>m.Cliente.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</strong>\r\n    </div>\r\n    <div class=\"col-md-10\">\r\n    ");
#nullable restore
#line 25 "C:\MantenimientoAutomotriz\G22proyectociclo3\Mantenimiento.app.Frontend\Pages\clientes\Details.cshtml"
Write(Html.DisplayFor(m=>m.Cliente.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n        <div class=\"col-md-2\">\r\n    <strong>");
#nullable restore
#line 28 "C:\MantenimientoAutomotriz\G22proyectociclo3\Mantenimiento.app.Frontend\Pages\clientes\Details.cshtml"
       Write(Html.DisplayNameFor(m=>m.Cliente.Documento));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</strong>\r\n    </div>\r\n    <div class=\"col-md-10\">\r\n    ");
#nullable restore
#line 31 "C:\MantenimientoAutomotriz\G22proyectociclo3\Mantenimiento.app.Frontend\Pages\clientes\Details.cshtml"
Write(Html.DisplayFor(m=>m.Cliente.Documento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n        <div class=\"col-md-2\">\r\n    <strong>");
#nullable restore
#line 34 "C:\MantenimientoAutomotriz\G22proyectociclo3\Mantenimiento.app.Frontend\Pages\clientes\Details.cshtml"
       Write(Html.DisplayNameFor(m=>m.Cliente.placa));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</strong>\r\n    </div>\r\n    <div class=\"col-md-10\">\r\n    ");
#nullable restore
#line 37 "C:\MantenimientoAutomotriz\G22proyectociclo3\Mantenimiento.app.Frontend\Pages\clientes\Details.cshtml"
Write(Html.DisplayFor(m=>m.Cliente.placa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n        <div class=\"col-md-2\">\r\n    <strong>");
#nullable restore
#line 40 "C:\MantenimientoAutomotriz\G22proyectociclo3\Mantenimiento.app.Frontend\Pages\clientes\Details.cshtml"
       Write(Html.DisplayNameFor(m=>m.Cliente.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</strong>\r\n    </div>\r\n    <div class=\"col-md-10\">\r\n    ");
#nullable restore
#line 43 "C:\MantenimientoAutomotriz\G22proyectociclo3\Mantenimiento.app.Frontend\Pages\clientes\Details.cshtml"
Write(Html.DisplayFor(m=>m.Cliente.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n        <div class=\"col-md-2\">\r\n    <strong>");
#nullable restore
#line 46 "C:\MantenimientoAutomotriz\G22proyectociclo3\Mantenimiento.app.Frontend\Pages\clientes\Details.cshtml"
       Write(Html.DisplayNameFor(m=>m.Cliente.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</strong>\r\n    </div>\r\n    <div class=\"col-md-10\">\r\n    ");
#nullable restore
#line 49 "C:\MantenimientoAutomotriz\G22proyectociclo3\Mantenimiento.app.Frontend\Pages\clientes\Details.cshtml"
Write(Html.DisplayFor(m=>m.Cliente.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n        <div class=\"col-md-2\">\r\n    <strong>");
#nullable restore
#line 52 "C:\MantenimientoAutomotriz\G22proyectociclo3\Mantenimiento.app.Frontend\Pages\clientes\Details.cshtml"
       Write(Html.DisplayNameFor(m=>m.Cliente.correo));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</strong>\r\n    </div>\r\n    <div class=\"col-md-10\">\r\n    ");
#nullable restore
#line 55 "C:\MantenimientoAutomotriz\G22proyectociclo3\Mantenimiento.app.Frontend\Pages\clientes\Details.cshtml"
Write(Html.DisplayFor(m=>m.Cliente.correo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    </div>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyApp.Namespace.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.DetailsModel>)PageContext?.ViewData;
        public MyApp.Namespace.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
