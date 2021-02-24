// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


// Función para construir la tabla según las tuplas de Productos
function ActualizarTabla() {
    $.ajax(
        {
            url: "https://localhost:44304/api/Trabajadores",
            method: 'GET',
            dataType: 'json',
            headers: {
                'Accept': 'application/json',
                'Authorization': localStorage.getItem('token')
            },
            contentType: 'application/json',

            success: function (data) {
                var tabla = [];                          
                $.each(
                    data, function (key, value) {
                        tabla.push(
                            "<tr>" +
                            "<td>" + value.apellido1 +
                            "</td>" +
                            "</tr>"
                        )
                    }
                )
                $("#TablaSuperCheta").append(tabla);
            },
            error: function (error) {
                console.log(error);
            }
        }
    );
}