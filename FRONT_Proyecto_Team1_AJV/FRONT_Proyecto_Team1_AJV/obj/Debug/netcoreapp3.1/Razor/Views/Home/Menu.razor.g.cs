#pragma checksum "C:\Users\victo\source\repos\FE-ProyectoFinal-Development_ANTICBO\FRONT_Proyecto_Team1_AJV\FRONT_Proyecto_Team1_AJV\Views\Home\Menu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "386f23dbfa18b9e57ec8e128f1077572c8045876"
// <auto-generated/>
#pragma warning disable 1591
namespace FRONT_Proyecto_Team1_AJV.Views.Home
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    public partial class Menu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            DefineSection("Main", async() => {
                __builder.AddMarkupContent(0, "\n    \n    ");
                __builder.AddMarkupContent(1, "<div id=\"menus\" class=\"col col2\">\n        \n        <div id=\"menuHorizontal\" class=\"row\">\n            <div class=\"col colhor\">\n                <button class=\"btnNav\" onclick=\"myFunction2()\"><i id=\"ico\" class=\"fas fa-bars\"></i></button>\n                <label> Trabajadores </label>\n                <div id=\"secbtn\">\n                    <button class=\"btnDis\" disabled>\n                        <i class=\"bi bi-calendar-event\"></i> <div id=\"fecha\"></div>\n                    </button>\n                    <button class=\"btnDis\" disabled>\n                        <i class=\"bi bi-diagram-3-fill\"></i> Grupo Castilla (No\n                        tocar)\n                    </button>\n                </div>\n            </div>\n        </div>\n\n\n        <div id=\"menuVertical\" class=\"row h-100\">\n            \n            <div class=\"col-auto cola h-100\" id=\"cola\">\n                <ul>\n                    <li><button type=\"button\" class=\"btn btn-primary btn-lg\">Large button</button></li>\n                    <li><button type=\"button\" class=\"btn btn-primary btn-lg\">Large button</button></li>\n                    <li><button type=\"button\" class=\"btn btn-primary btn-lg\">Large button</button></li>\n                    <li><button type=\"button\" class=\"btn btn-primary btn-lg\">Large button</button></li>\n                    <li><button type=\"button\" class=\"btn btn-primary btn-lg\">Large button</button></li>\n                    <li><button type=\"button\" class=\"btn btn-primary btn-lg\">Large button</button></li>\n                    <li><button type=\"button\" class=\"btn btn-primary btn-lg\">Large button</button></li>\n                    <li><button type=\"button\" class=\"btn btn-primary btn-lg\">Large button</button></li>\n                </ul>\n            </div>\n            \n            <div id=\"containerContenido\" class=\"col colb\">.col-sm-8</div>\n        </div>\n    </div>\n");
            }
            );
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591