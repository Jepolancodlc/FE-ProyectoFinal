// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function myFunction() {
    let x = document.getElementById("col1");
    if (x.style.display === "none") {
        x.style.display = "block";
    } else {
        x.style.display = "none";
    }
}

function myFunction2() {
    let x = document.getElementById("cola");
    if (x.style.display === "none") {
        x.style.display = "block";
    } else {
        x.style.display = "none";
    }
}


function hideSideBar() {
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
    let meses = new Array("Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre");
    let f = new Date();
    $("#fecha").html(`${f.getDate()} ${meses[f.getMonth()]} ${f.getFullYear()}`);
}
fecha();