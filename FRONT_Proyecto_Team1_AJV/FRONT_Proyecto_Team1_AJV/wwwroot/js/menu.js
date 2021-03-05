// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
    //MUESTRA/OCULTA LA COLUMNA DE FILTROS
    $("#ico").click(function () {
        $("#colMenuFiltros").toggle();
    });

});

$(document).ready(function () {
    // MUESTRA/OCULTA EL NOMBRE DE LAS PESTAÑAS DEL SIDEBAR
        $("#btnHide").click(function () {
            $(".lblNames").slideToggle();
        });
});



