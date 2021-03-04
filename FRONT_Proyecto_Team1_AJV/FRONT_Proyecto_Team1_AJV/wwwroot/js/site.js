// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
    // MUESTRA/OCULTA EL SIDEBAR
    $("#NavBtn1").click(function () {
        $("#colSideBar").toggle();
    });

});

$(document).ready(function () {
    // MUESTRA LA FECHA DEL PC
    let meses = new Array("Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre");
    let f = new Date();
    $("#fecha").html(`${f.getDate()} ${meses[f.getMonth()]} ${f.getFullYear()}`);
});

function activarFiltros(loc) {
    // BOTÓN PARA ACTIVAR/DESACTIVAR LOS FILTROS DE LA TABLA
}

$(document).ready(function () {
    // FILTRO INPUT
    $("#buscador").on("keyup", function () {
        var value = $(this).val().toLowerCase();
        $("#grupoBoton button").filter(function () {
            $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
        });
    });
});


$(document).ready(function () {
    // ORDENA DE MANERA ASCENDENTE LOS BOTONES DE LA COLUMNA DE FILTROS
    $("#grupoBoton button").sort(sort_ascending).appendTo('#grupoBoton');
    function sort_ascending(a, b) {
        return ($(b).text()) < ($(a).text()) ? 1 : -1;
    }
});