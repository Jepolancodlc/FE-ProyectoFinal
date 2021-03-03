// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


// Función para construir la tabla según las tuplas de Productos
function PrintarTabla(loc) {
    $(loc).empty(); // eliminamos el contenido de containerScreen
    GetTabla(loc); // llamamos al get para printar la tabla
}

function GetTabla(loc) {
    $.ajax(
        {
            url: "https://localhost:44326/api/Trabajadores",
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
                                sitAdmin: { type: "string" }
                            }
                        }
                    },
                    pageSize: 12,
                    sort: {
                        field: "id_Trabajador",
                        dir: "asc"
                    }
                });

                $(loc).kendoGrid({
                    sortable: true,
                    pageable: true,
                    navigatable: false,
                    resizable: false,
                    reorderable: false,
                    groupable: false,
                    filterable: false,
                    columns: [
                        { field: "id_Trabajador", title: "ID", width: "80px"  },
                        { template: "<img src='#:fotoUrl#' style='width:80px;height:50px;border-radius: 20%;' />", title: "Img"},
                        { field: "nombre", title: "Nombre" },
                        { field: "email", title: "Email" },
                        { field: "empresa", title: "Empresa" },
                        { field: "telefono", title: "Teléfono" },
                        { field: "grupo", title: "Grupo", width: "120px" },
                        { field: "cuerpo", title: "Cuerpo" },
                        { field: "categoria", title: "Categoría" },
                        { field: "tProvis", title: "Tipo Contrato" },
                        { field: "sitAdmin", title: "Sitio Administrativo" }
                    ],
                    dataSource: gridDataSource
                });
                $(loc).removeClass("k-widget");
            },
            error: function (error) {
                console.log(error);
            }
        }
    );
}
