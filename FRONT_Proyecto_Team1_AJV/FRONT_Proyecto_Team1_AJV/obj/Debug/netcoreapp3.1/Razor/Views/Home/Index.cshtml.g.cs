#pragma checksum "C:\Users\victo\source\repos\Jepolancodlc_05_03_2021_V1_COLGADA_WEB\FE-ProyectoFinal\FRONT_Proyecto_Team1_AJV\FRONT_Proyecto_Team1_AJV\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "770f1f91bc834fd4d056f425af1574de11ec9e17"
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
#line 1 "C:\Users\victo\source\repos\Jepolancodlc_05_03_2021_V1_COLGADA_WEB\FE-ProyectoFinal\FRONT_Proyecto_Team1_AJV\FRONT_Proyecto_Team1_AJV\Views\_ViewImports.cshtml"
using FRONT_Proyecto_Team1_AJV;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\victo\source\repos\Jepolancodlc_05_03_2021_V1_COLGADA_WEB\FE-ProyectoFinal\FRONT_Proyecto_Team1_AJV\FRONT_Proyecto_Team1_AJV\Views\_ViewImports.cshtml"
using FRONT_Proyecto_Team1_AJV.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"770f1f91bc834fd4d056f425af1574de11ec9e17", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"136f25379489c9d080b60bf49e5ac5dd586dcce7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/logo.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("70"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\victo\source\repos\Jepolancodlc_05_03_2021_V1_COLGADA_WEB\FE-ProyectoFinal\FRONT_Proyecto_Team1_AJV\FRONT_Proyecto_Team1_AJV\Views\Home\Index.cshtml"
   ViewData["Title"] = "Home Page"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<div hidden id=\"tokenAPI\">\r\n    <!-- Token para el CRUD de la API -->\r\n");
            DefineSection("Token", async() => {
                WriteLiteral("\r\n        <script>CallToken(\'token@token.com\', \'TokenPassword\');</script>\r\n    ");
            }
            );
            WriteLiteral("    <!-- FIN DE TOKEN -->\r\n</div>\r\n<!-- Main -->\r\n<!-- Sidebar -->\r\n<div class=\"col-sm-auto\" id=\"colSideBar\">\r\n    <div>\r\n        <div class=\"icon-bar\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "770f1f91bc834fd4d056f425af1574de11ec9e175158", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            <a href=""#"" class=""active"">
                <i class=""bi bi-person-fill""></i>
                <label class=""lblNames"" style=""display: none;"">Trabajadores</label>
            </a>
            <a href=""#"">
                <i class=""bi bi-tag""></i>
                <label class=""lblNames"" style=""display: none;"">Etiquetas</label>
            </a>
            <a href=""#a"">
                <i class=""bi bi-display""></i>
                <label class=""lblNames"" style=""display: none;"">Vistas</label>
            </a>
            <a href=""#b"">
                <i class=""bi bi-bag""></i>
                <label class=""lblNames"" style=""display: none;"">Trabajo</label>
            </a>
            <a href=""#c"">
                <i class=""bi bi-tag-fill""></i>
                <label class=""lblNames"" style=""display: none;"">CE</label>
            </a>
            <a href=""#"">
                <i class=""bi bi-diagram-3-fill""></i>
                <label class=""lblNames"" style=""display: none;"">Organigr");
            WriteLiteral(@"ama</label>
            </a>
            <a href=""#"">
                <i class=""bi bi-graph-up""></i>
                <label class=""lblNames"" style=""display: none;"">Estadísticas</label>
            </a>
            <button type=""button"" id=""btnHide"" > <i class=""fas fa-chevron-right""></i></button>

        </div>
    </div>
</div>
<div class=""col-sm col2"">
    <!-- Menu Horizontal -->
    <div class=""row"">
        <div class=""col colhor "">
            <button class=""btnNav""><i id=""ico"" class=""fas fa-bars""></i></button>
            <label> Trabajadores </label>
            <div id=""secbtn"">
                <button class=""btnDis"" disabled id=""fecha"">
                    <i class=""bi bi-calendar-event""></i>
                </button>
                <button class=""btnDis"" disabled>
                    <i class=""bi bi-diagram-3-fill""></i> Grupo Castilla (No
                    tocar)
                </button>
            </div>
        </div>
    </div>
    <div class=""row vh-100"">
     ");
            WriteLiteral(@"   <!-- Menu Filtros -->
        <div class=""col-2"" id=""colMenuFiltros"">
            <div class=""MenuFiltros"">
                <div class=""input-group rounded"">
                    <!-- INPUT de filtros -->
                    <input id=""buscador"" type=""search"" class=""form-control rounded"" placeholder=""Filtrar unidad organizativa"" aria-label=""Search""
                           aria-describedby=""search-addon"" />
                    <button id=""btnFilter"" type=""button"" class=""btn btn-primary"">
                        <i onclick=""activarFiltros('#containerScreen')"" class=""bi bi-funnel-fill""></i>
                    </button>
                </div>

                <!-- Casillas de las unidades organizativas -->
                <button class=""input-group rounded btnOrganizativa"">
                    <i fill=""#005ab7"" class=""bi bi-building btnMenu""></i>
                    <i class=""btnMenu"" onclick=""PrintarTabla('#containerScreen');"">Ayuntamiento</i>
                    <i onclick=""getKendoCharts(");
            WriteLiteral(@"'#containerScreen')"" class=""bi bi-graph-up btnMenuGraph""></i>
                </button>
                <div id=""grupoBoton"">
                    <button class=""input-group rounded btnOrganizativa"">
                        <i fill=""#005ab7"" class=""bi bi-inboxes btnMenu""></i>
                        <i class=""btnMenu"" onclick=""GetTablaID('#containerScreen', 'Alcalde');"">Alcalde</i>
                        <i onclick=""getKendoChartsID('#containerScreen', 'Alcalde')"" class=""bi bi-graph-up btnMenuGraph""></i>
                    </button>
                    <button class=""input-group rounded btnOrganizativa"">
                        <i fill=""#005ab7"" class=""bi bi-inboxes btnMenu""></i>
                        <i class=""btnMenu"" onclick=""GetTablaID('#containerScreen', 'Administratiu/iva');"">Administratiu/iva</i>
                        <i onclick=""getKendoChartsID('#containerScreen', 'Administratiu/iva')"" class=""bi bi-graph-up btnMenuGraph""></i>
                    </button>
                    <button");
            WriteLiteral(@" class=""input-group rounded btnOrganizativa"">
                        <i fill=""#005ab7"" class=""bi bi-inboxes btnMenu""></i>
                        <i class=""btnMenu"" onclick=""GetTablaID('#containerScreen', 'Regidor');"">Regidor</i>
                        <i onclick=""getKendoChartsID('#containerScreen', 'Regidor')"" class=""bi bi-graph-up btnMenuGraph""></i>
                    </button>
                    <button class=""input-group rounded btnOrganizativa"">
                        <i fill=""#005ab7"" class=""bi bi-inboxes btnMenu""></i>
                        <i class=""btnMenu"" onclick=""GetTablaID('#containerScreen', 'Assessor');"">Assessor</i>
                        <i onclick=""getKendoChartsID('#containerScreen', 'Assessor')"" class=""bi bi-graph-up btnMenuGraph""></i>
                    </button>
                    <button class=""input-group rounded btnOrganizativa"">
                        <i fill=""#005ab7"" class=""bi bi-inboxes btnMenu""></i>
                        <i class=""btnMenu"" onclick=""GetTab");
            WriteLiteral(@"laID('#containerScreen', 'Ajuntament');"">Grupo: Ayuntamiento</i>
                        <i onclick=""getKendoChartsID('#containerScreen', 'Ajuntament')"" class=""bi bi-graph-up btnMenuGraph""></i>
                    </button>
                    <button class=""input-group rounded btnOrganizativa"">
                        <i fill=""#005ab7"" class=""bi bi-inboxes btnMenu""></i>
                        <i class=""btnMenu"" onclick=""GetTablaID('#containerScreen', 'Àrea de territori, via pública i mobilitat');"">Àrea de territori, via pública i mobilitat</i>
                        <i onclick=""getKendoChartsID('#containerScreen', 'Àrea de territori, via pública i mobilitat')"" class=""bi bi-graph-up btnMenuGraph""></i>
                    </button>
                    <button class=""input-group rounded btnOrganizativa"">
                        <i fill=""#005ab7"" class=""bi bi-inboxes btnMenu""></i>
                        <i class=""btnMenu"" onclick=""GetTablaID('#containerScreen', 'Àrea de transparència i Bon Govern');");
            WriteLiteral(@""">Àrea de transparència i Bon Govern</i>
                        <i onclick=""getKendoChartsID('#containerScreen', 'Àrea de transparència i Bon Govern')"" class=""bi bi-graph-up btnMenuGraph""></i>
                    </button>
                    <button class=""input-group rounded btnOrganizativa"">
                        <i fill=""#005ab7"" class=""bi bi-inboxes btnMenu""></i>
                        <i class=""btnMenu"" onclick=""GetTablaID('#containerScreen', 'Area de benestar Social');"">Area de benestar Social</i>
                        <i onclick=""getKendoChartsID('#containerScreen', 'Area de benestar Social')"" class=""bi bi-graph-up btnMenuGraph""></i>
                    </button>
                    <button class=""input-group rounded btnOrganizativa"">
                        <i fill=""#005ab7"" class=""bi bi-inboxes btnMenu""></i>
                        <i class=""btnMenu"" onclick=""GetTablaID('#containerScreen', 'Àrea de cultura Educació i Lleure');"">Àrea de cultura Educació i Lleure</i>
                 ");
            WriteLiteral(@"       <i onclick=""getKendoChartsID('#containerScreen', 'Àrea de cultura Educació i Lleure')"" class=""bi bi-graph-up btnMenuGraph""></i>
                    </button>
                    <button class=""input-group rounded btnOrganizativa"">
                        <i fill=""#005ab7"" class=""bi bi-inboxes btnMenu""></i>
                        <i class=""btnMenu"" onclick=""GetTablaID('#containerScreen', 'Àrea de urbanisme i Habitatge');"">Àrea de urbanisme i Habitatge</i>
                        <i onclick=""getKendoChartsID('#containerScreen', 'Àrea de urbanisme i Habitatge')"" class=""bi bi-graph-up btnMenuGraph""></i>
                    </button>
                    <button class=""input-group rounded btnOrganizativa"">
                        <i fill=""#005ab7"" class=""bi bi-inboxes btnMenu""></i>
                        <i class=""btnMenu"" onclick=""GetTablaID('#containerScreen', 'Àrea de comerç, turisme i ocupació');"">Àrea de comerç, turisme i ocupació</i>
                        <i onclick=""getKendoChartsID('#co");
            WriteLiteral(@"ntainerScreen', 'Àrea de comerç, turisme i ocupació')"" class=""bi bi-graph-up btnMenuGraph""></i>
                    </button>
                    <button class=""input-group rounded btnOrganizativa"">
                        <i fill=""#005ab7"" class=""bi bi-inboxes btnMenu""></i>
                        <i class=""btnMenu"" onclick=""GetTablaID('#containerScreen', 'Administratiu/va');"">Administratiu/va</i>
                        <i onclick=""getKendoChartsID('#containerScreen', 'Administratiu/va')"" class=""bi bi-graph-up btnMenuGraph""></i>
                    </button>
                    <button class=""input-group rounded btnOrganizativa"">
                        <i fill=""#005ab7"" class=""bi bi-inboxes btnMenu""></i>
                        <i class=""btnMenu"" onclick=""GetTablaID('#containerScreen', 'Urbanisme, Patrimoni i Centre Històric');"">Urbanisme, Patrimoni i Centre Històric</i>
                        <i onclick=""getKendoChartsID('#containerScreen', 'Urbanisme, Patrimoni i Centre Històric')"" class=""bi b");
            WriteLiteral(@"i-graph-up btnMenuGraph""></i>
                    </button>
                    <button class=""input-group rounded btnOrganizativa"">
                        <i fill=""#005ab7"" class=""bi bi-inboxes btnMenu""></i>
                        <i class=""btnMenu"" onclick=""GetTablaID('#containerScreen', 'Sostenibilitat, Serveis Ambientals i Medi Natural');"">Sostenibilitat, Serveis Ambientals i Medi Natural</i>
                        <i onclick=""getKendoChartsID('#containerScreen', 'Sostenibilitat, Serveis Ambientals i Medi Natural')"" class=""bi bi-graph-up btnMenuGraph""></i>
                    </button>
                    <button class=""input-group rounded btnOrganizativa"">
                        <i fill=""#005ab7"" class=""bi bi-inboxes btnMenu""></i>
                        <i class=""btnMenu"" onclick=""GetTablaID('#containerScreen', 'Actuacions Públiques i Serveis');"">Actuacions Públiques i Serveis</i>
                        <i onclick=""getKendoChartsID('#containerScreen', 'Actuacions Públiques i Serveis')"" cl");
            WriteLiteral(@"ass=""bi bi-graph-up btnMenuGraph""></i>
                    </button>
                    <button class=""input-group rounded btnOrganizativa"">
                        <i fill=""#005ab7"" class=""bi bi-inboxes btnMenu""></i>
                        <i class=""btnMenu"" onclick=""GetTablaID('#containerScreen', 'Habitatge');"">Habitatge</i>
                        <i onclick=""getKendoChartsID('#containerScreen', 'Habitatge')"" class=""bi bi-graph-up btnMenuGraph""></i>
                    </button>
                    <button class=""input-group rounded btnOrganizativa"">
                        <i fill=""#005ab7"" class=""bi bi-inboxes btnMenu""></i>
                        <i class=""btnMenu"" onclick=""GetTablaID('#containerScreen', 'Via pública i Barris');"">Via pública i Barris</i>
                        <i onclick=""getKendoChartsID('#containerScreen', 'Via pública i Barris')"" class=""bi bi-graph-up btnMenuGraph""></i>
                    </button>
                    <button class=""input-group rounded btnOrganizativa");
            WriteLiteral(@""">
                        <i fill=""#005ab7"" class=""bi bi-inboxes btnMenu""></i>
                        <i class=""btnMenu"" onclick=""GetTablaID('#containerScreen', 'Mobilitat');"">Mobilitat</i>
                        <i onclick=""getKendoChartsID('#containerScreen', 'Mobilitat')"" class=""bi bi-graph-up btnMenuGraph""></i>
                    </button>
                    <button class=""input-group rounded btnOrganizativa"">
                        <i fill=""#005ab7"" class=""bi bi-inboxes btnMenu""></i>
                        <i class=""btnMenu"" onclick=""GetTablaID('#containerScreen', 'Seguretat Ciutadana i Protecció Civil');"">Seguretat Ciutadana i Protecció Civil</i>
                        <i onclick=""getKendoChartsID('#containerScreen', 'Seguretat Ciutadana i Protecció Civil')"" class=""bi bi-graph-up btnMenuGraph""></i>
                    </button>
                    <button class=""input-group rounded btnOrganizativa"">
                        <i fill=""#005ab7"" class=""bi bi-inboxes btnMenu""></i>
        ");
            WriteLiteral(@"                <i class=""btnMenu"" onclick=""GetTablaID('#containerScreen', 'Comerç i Turisme');"">Comerç i Turisme</i>
                        <i onclick=""getKendoChartsID('#containerScreen', 'Comerç i Turisme')"" class=""bi bi-graph-up btnMenuGraph""></i>
                    </button>
                    <button class=""input-group rounded btnOrganizativa"">
                        <i fill=""#005ab7"" class=""bi bi-inboxes btnMenu""></i>
                        <i class=""btnMenu"" onclick=""GetTablaID('#containerScreen', 'Cultura');"">Cultura</i>
                        <i onclick=""getKendoChartsID('#containerScreen', 'Cultura')"" class=""bi bi-graph-up btnMenuGraph""></i>
                    </button>
                    <button class=""input-group rounded btnOrganizativa"">
                        <i fill=""#005ab7"" class=""bi bi-inboxes btnMenu""></i>
                        <i class=""btnMenu"" onclick=""GetTablaID('#containerScreen', 'Ensenyament i Politica Lingüistica');"">Ensenyament i Politica Lingüistica</i>
    ");
            WriteLiteral(@"                    <i onclick=""getKendoChartsID('#containerScreen', 'Ensenyament i Politica Lingüistica')"" class=""bi bi-graph-up btnMenuGraph""></i>
                    </button>
                    <button class=""input-group rounded btnOrganizativa"">
                        <i fill=""#005ab7"" class=""bi bi-inboxes btnMenu""></i>
                        <i class=""btnMenu"" onclick=""GetTablaID('#containerScreen', 'Afers Socials');"">Afers Socials</i>
                        <i onclick=""getKendoChartsID('#containerScreen', 'Afers Socials')"" class=""bi bi-graph-up btnMenuGraph""></i>
                    </button>
                    <button class=""input-group rounded btnOrganizativa"">
                        <i fill=""#005ab7"" class=""bi bi-inboxes btnMenu""></i>
                        <i class=""btnMenu"" onclick=""GetTablaID('#containerScreen', 'Acció Comunitària, Participació i Igualtat');"">Acció Comunitària, Participació i Igualtat</i>
                        <i onclick=""getKendoChartsID('#containerScreen', 'A");
            WriteLiteral(@"cció Comunitària, Participació i Igualtat')"" class=""bi bi-graph-up btnMenuGraph""></i>
                    </button>
                    <button class=""input-group rounded btnOrganizativa"">
                        <i fill=""#005ab7"" class=""bi bi-inboxes btnMenu""></i>
                        <i class=""btnMenu"" onclick=""GetTablaID('#containerScreen', 'Acció Civica i Joventut');"">Acció Civica i Joventut</i>
                        <i onclick=""getKendoChartsID('#containerScreen', 'Acció Civica i Joventut')"" class=""bi bi-graph-up btnMenuGraph""></i>
                    </button>
                    <button class=""input-group rounded btnOrganizativa"">
                        <i fill=""#005ab7"" class=""bi bi-inboxes btnMenu""></i>
                        <i class=""btnMenu"" onclick=""GetTablaID('#containerScreen', 'Salut i Dependéncia');"">Salut i Dependéncia</i>
                        <i onclick=""getKendoChartsID('#containerScreen', 'Salut i Dependéncia')"" class=""bi bi-graph-up btnMenuGraph""></i>
               ");
            WriteLiteral(@"     </button>
                    <button class=""input-group rounded btnOrganizativa"">
                        <i fill=""#005ab7"" class=""bi bi-inboxes btnMenu""></i>
                        <i class=""btnMenu"" onclick=""GetTablaID('#containerScreen', 'Governació');"">Governació</i>
                        <i onclick=""getKendoChartsID('#containerScreen', 'Governació')"" class=""bi bi-graph-up btnMenuGraph""></i>
                    </button>
                    <button class=""input-group rounded btnOrganizativa"">
                        <i fill=""#005ab7"" class=""bi bi-inboxes btnMenu""></i>
                        <i class=""btnMenu"" onclick=""GetTablaID('#containerScreen', 'Hisenda, Finances i Contractació');"">Hisenda, Finances i Contractació</i>
                        <i onclick=""getKendoChartsID('#containerScreen', 'Hisenda, Finances i Contractació')"" class=""bi bi-graph-up btnMenuGraph""></i>
                    </button>
                    <button class=""input-group rounded btnOrganizativa"">
            ");
            WriteLiteral(@"            <i fill=""#005ab7"" class=""bi bi-inboxes btnMenu""></i>
                        <i class=""btnMenu"" onclick=""GetTablaID('#containerScreen', 'Transparéncia,Oficina d\'Atenció al Ciutadà i Tecnologia de la Informació');"">Transparéncia,Oficina d'Atenció al Ciutadà i Tecnologia de la Informació</i>
                        <i onclick=""getKendoChartsID('#containerScreen', 'Transparéncia,Oficina d\'Atenció al Ciutadà i Tecnologia de la Informació')"" class=""bi bi-graph-up btnMenuGraph""></i>
                    </button>
                    <button class=""input-group rounded btnOrganizativa"">
                        <i fill=""#005ab7"" class=""bi bi-inboxes btnMenu""></i>
                        <i class=""btnMenu"" onclick=""GetTablaID('#containerScreen', 'Secretari/a');"">Secretari/a</i>
                        <i onclick=""getKendoChartsID('#containerScreen', 'Secretari/a')"" class=""bi bi-graph-up btnMenuGraph""></i>
                    </button>
                    <button class=""input-group rounded btnOrgan");
            WriteLiteral(@"izativa"">
                        <i fill=""#005ab7"" class=""bi bi-inboxes btnMenu""></i>
                        <i class=""btnMenu"" onclick=""GetTablaID('#containerScreen', 'Interventor/a');"">Interventor/a</i>
                        <i onclick=""getKendoChartsID('#containerScreen', 'Interventor/a')"" class=""bi bi-graph-up btnMenuGraph""></i>
                    </button>
                    <button class=""input-group rounded btnOrganizativa"">
                        <i fill=""#005ab7"" class=""bi bi-inboxes btnMenu""></i>
                        <i class=""btnMenu"" onclick=""GetTablaID('#containerScreen', 'Tresorer/a');"">Tresorer/a</i>
                        <i onclick=""getKendoChartsID('#containerScreen', 'Tresorer/a')"" class=""bi bi-graph-up btnMenuGraph""></i>
                    </button>
                    <button class=""input-group rounded btnOrganizativa"">
                        <i fill=""#005ab7"" class=""bi bi-inboxes btnMenu""></i>
                        <i class=""btnMenu"" onclick=""GetTablaID('#conta");
            WriteLiteral(@"inerScreen', 'Àrea de serveis econòmics');"">Àrea de serveis econòmics</i>
                        <i onclick=""getKendoChartsID('#containerScreen', 'Àrea de serveis econòmics')"" class=""bi bi-graph-up btnMenuGraph""></i>
                    </button>
                    <button class=""input-group rounded btnOrganizativa"">
                        <i fill=""#005ab7"" class=""bi bi-inboxes btnMenu""></i>
                        <i class=""btnMenu"" onclick=""GetTablaID('#containerScreen', 'Treballador/a social');"">Treballador/a social</i>
                        <i onclick=""getKendoChartsID('#containerScreen', 'Treballador/a social')"" class=""bi bi-graph-up btnMenuGraph""></i>
                    </button>
                    <button class=""input-group rounded btnOrganizativa"">
                        <i fill=""#005ab7"" class=""bi bi-inboxes btnMenu""></i>
                        <i class=""btnMenu"" onclick=""GetTablaID('#containerScreen', 'Educador/a social');"">Educador/a social</i>
                        <i onclick");
            WriteLiteral(@"=""getKendoChartsID('#containerScreen', 'Educador/a social')"" class=""bi bi-graph-up btnMenuGraph""></i>
                    </button>
                    <button class=""input-group rounded btnOrganizativa"">
                        <i fill=""#005ab7"" class=""bi bi-inboxes btnMenu""></i>
                        <i class=""btnMenu"" onclick=""GetTablaID('#containerScreen', 'Responsable biblioteques');"">Responsable biblioteques</i>
                        <i onclick=""getKendoChartsID('#containerScreen', 'Responsable biblioteques')"" class=""bi bi-graph-up btnMenuGraph""></i>
                    </button>
                </div>

                <div id=""footerFiltros"">
                    <a href=""#home"">
                        <i class=""bi bi-question-diamond-fill""></i>
                    </a>
                    <a href=""#about"">
                        <i class=""bi bi-globe2""></i>
                    </a>
                </div>
            </div>
        </div>
        <!-- Tabla -->
        <div id=");
            WriteLiteral("\"containerScreen\" class=\"col-10 colb containerScreen vh-100\"></div>\r\n    </div>\r\n</div>");
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
