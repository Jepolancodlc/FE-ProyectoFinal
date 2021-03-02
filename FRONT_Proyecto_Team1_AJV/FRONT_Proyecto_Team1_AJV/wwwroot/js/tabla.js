// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


// Función para construir la tabla según las tuplas de Productos
function PrintarTabla(loc) {
    GetTabla(loc);
}

function GetTabla(loc) {
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

            success: function (dataTabla) {
                let gridDataSource = new kendo.data.DataSource({
                    data: dataTabla,
                    schema: {
                        model: {
                            fields: {
                                id_Trabajador: { type: "number" },
                                fotoUrl: { type: "string" },
                                nombre: { type: "string" },
                                email: { type: "string" },
                                empresa: { type: "string" },
                                telefono: { type: "string" },
                                grupo: { type: "string" },
                                cuerpo: { type: "string" },
                                categoria: { type: "string" },
                                tProvis: { type: "string" },
                                sitAdmin: { type: "string" },
                            }
                        }
                    },
                    pageSize: 10,
                    sort: {
                        field: "id",
                        dir: "asc"
                    }
                });
                $(loc).kendoGrid({
                    sortable: true, pageable: true,
                    dataSource: gridDataSource
                });
            },
            error: function (error) {
                console.log(error);
            }
        }
    );
}
