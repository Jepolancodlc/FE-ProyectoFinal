// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


// Función para construir la tabla según las tuplas de Productos
function PrintarTabla(loc) {
    $(loc).empty(); // eliminamos el contenido de containerScreen
    GetTabla(loc); // llamamos al get para printar la tabla
}

function GetTabla(loc) {
    // FUNCIÓN GET PARA BUSCAR TODOS LOS DATOS DE LA BD EN FORMATO JSON Y PRINTARLOS EN UNA TABLA EN LA LOCALIZACIÓN PASADA POR PARÁMETRO
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
                                niv_Org: {type: "string"},
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
                    navigatable: true,
                    resizable: true,
                    reorderable: true,
                    groupable: true,
                    filterable: {
                        messages: {
                            info: "Muestra items cuyo valor:",
                            isTrue: "es verdadero",
                            isFalse: "es falso",
                            filter: "Filtra",
                            clear: "Borra",
                            and: "Y",
                            or: "Ó",
                            selectValue: "-Selecciona valor-",
                            operator: "Operador",
                            value: "Valor",
                            cancel: "Cancelar"
                        }
                    },
                    columns: [
                        { field: "id_Trabajador", title: "ID", width: "90px"  },
                        { template: "<img src='#:fotoUrl#' style='width:45px;height:50px;border-radius: 20%;' />", title: "Img", width: "90px"},
                        { field: "nombre", title: "Nombre" },
                        { field: "email", title: "Email" },
                        { field: "empresa", title: "Empresa" },
                        { field: "niv_Org", title: "Nivel Organizativo" },
                        { field: "telefono", title: "Teléfono" },
                        { field: "cuerpo", title: "Cuerpo", width: "180px"},
                        { field: "categoria", title: "Categoría" },
                        { template: "<label style='background-color:grey;color:white;width:40px;height:30px;border-radius: 100%;text-align: center;font-weight: bold;' > #:tProvis#</label>", field: "tProvis", title: "Tipo Contrato" },
                        { template: "<label style='background-color:green;color:white;width:40px;height:30px;border-radius: 100%;text-align: center;font-weight: bold;' > #:sitAdmin#</label>", field: "sitAdmin", title: "Sitio Administrativo" },
                        { template: "<label style='background-color:darkred;color:white;width:40px;height:30px;border-radius: 100%;text-align: center;font-weight: bold;' > #:sitAdmin#</label>", field: "grupo", title: "Grupo", width: "120px" }
                    ],
                    dataSource: gridDataSource
                });
            },
            error: function (error) {
                console.log(error);
            }
        }
    );
}



function GetTablaID(loc, niv_org) {
    // FUNCIÓN GET PARA BUSCAR POR ID LOS DATOS DE LA BD EN FORMATO JSON Y PRINTARLOS EN UNA TABLA EN LA LOCALIZACIÓN PASADA POR PARÁMETRO
    $.ajax(
        {
            url: "https://localhost:44304/api/Trabajadores/" + encodeURIComponent(niv_org),
            method: 'GET',
            dataType: 'json',
            headers: {
                'Accept': 'application/json',
                'Authorization': localStorage.getItem('token')
            },
            contentType: 'application/json',

            success: function (dataTabla) {
                $(loc).empty();
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
                                niv_Org: { type: "string" },
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
                    navigatable: true,
                    resizable: true,
                    reorderable: true,
                    groupable: true,
                    filterable: {
                        messages: {
                            info: "Muestra items cuyo valor:",
                            isTrue: "es verdadero",
                            isFalse: "es falso",
                            filter: "Filtra",
                            clear: "Borra",
                            and: "Y",
                            or: "Ó",
                            selectValue: "-Selecciona valor-",
                            operator: "Operador",
                            value: "Valor",
                            cancel: "Cancelar"
                        }
                    },
                    columns: [
                        { field: "id_Trabajador", title: "ID", width: "90px" },
                        { template: "<img src='#:fotoUrl#' style='width:45px;height:50px;border-radius: 20%;' />", title: "Img", width: "90px" },
                        { field: "nombre", title: "Nombre" },
                        { field: "email", title: "Email" },
                        { field: "empresa", title: "Empresa" },
                        { field: "niv_Org", title: "Nivel Organizativo" },
                        { field: "telefono", title: "Teléfono" },
                        { field: "cuerpo", title: "Cuerpo", width: "180x"},
                        { field: "categoria", title: "Categoría" },
                        { template: "<label style='background-color:grey;color:white;width:40px;height:30px;border-radius: 100%;text-align: center;font-weight: bold;' > #:tProvis#</label>", field: "tProvis", title: "Tipo Contrato" },
                        { template: "<label style='background-color:green;color:white;width:40px;height:30px;border-radius: 100%;text-align: center;font-weight: bold;' > #:sitAdmin#</label>", field: "sitAdmin", title: "Sitio Administrativo" },
                        { template: "<label style='background-color:darkred;color:white;width:40px;height:30px;border-radius: 100%;text-align: center;font-weight: bold;' > #:sitAdmin#</label>", field: "grupo", title: "Grupo", width: "120px" }
                    ],
                    dataSource: gridDataSource
                });
            },
            error: function (error) {
                console.log(error);
            }
        }
    );
}
