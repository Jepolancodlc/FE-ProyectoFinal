// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

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