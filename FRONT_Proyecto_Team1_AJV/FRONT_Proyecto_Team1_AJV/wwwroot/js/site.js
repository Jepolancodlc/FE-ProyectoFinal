// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function ocultarSidebar() {
    // OCULTA/MUESTRA EL SIDEBAR
    let x = document.getElementById("colSideBar");
    if (x.style.display === "none") {
        x.style.display = "block";
    } else {
        x.style.display = "none";
    }
}

function ocultarMenuFiltros() {
    // OCULTA/MUESTRA EL MENU DE FILTROS
    let x = document.getElementById("colMenuFiltros");
    if (x.style.display === "none") {
        x.style.display = "block";
    } else {
        x.style.display = "none";
    }
}



function ocultaSBnombres() {
    // OCULTA/MUESTRA LOS NOMBRES DEL SIDEBAR
    let elements = document.getElementsByClassName("lblNames");

    for (let i = 0; i < elements.length; i++) {

        if (elements[i].style.display == "inline") {
            elements[i].style.display = "none";
        }
        else {
            elements[i].style.display = "inline";
        }
    }

}

function fecha() {
    // MUESTRA LA FECHA DEL PC
    let meses = new Array("Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre");
    let f = new Date();
    $("#fecha").html(`${f.getDate()} ${meses[f.getMonth()]} ${f.getFullYear()}`);
}
fecha();

function activarFiltros(loc) {
    // BOTÓN PARA ACTIVAR/DESACTIVAR LOS FILTROS DE LA TABLA
    if ($(loc).kendoGrid.filterable == true) {
        $(loc).kendoGrid({
            navigatable: false,
            resizable: false,
            reorderable: false,
            groupable: false,
            filterable: false
        });
        $(loc).removeClass("k-widget");
    }
    else {
        $(loc).kendoGrid({
            navigatable: true,
            resizable: true,
            reorderable: true,
            groupable: true,
            filterable: true
        });
        $(loc).removeClass("k-widget");
    }
    $(loc).removeClass("k-widget");
}