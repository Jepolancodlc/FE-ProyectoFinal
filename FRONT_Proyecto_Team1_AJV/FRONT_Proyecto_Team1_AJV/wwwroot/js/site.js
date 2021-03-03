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

function fecha() {
    // MUESTRA LA FECHA DEL PC
    let meses = new Array("Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre");
    let f = new Date();
    $("#fecha").html(`${f.getDate()} ${meses[f.getMonth()]} ${f.getFullYear()}`);
}
fecha();

function activarFiltros(loc) {
    // BOTÓN PARA ACTIVAR/DESACTIVAR LOS FILTROS DE LA TABLA
}