// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


// Función para construir la tabla según las tuplas de Productos
function PrintarTabla() {
    GetTabla();
    var tabla = localStorage.getItem("dataTable");

}

function GetTabla() {
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

                var gridDataSource = new kendo.data.DataSource({
                    data: data,
                    schema: {
                        model: {
                            fields: {
                                id: { type: "number" },
                                grupo: { type: "string" },
                                nombre: { type: "string" },
                                apellido1: { type: "string" },
                                apellido2: { type: "string" },
                                cpostal: { type: "string" },
                                cuerpo: { type: "string" },
                                domicilio: { type: "string" },
                                eCivil: { type: "string" },
                                email: { type: "string" },
                                esFamiliaNumerosa: { type: "string" },
                                escalera: { type: "string" },
                                fAlta: { type: "date" },
                                fBaja: { type: "date" },
                                fNac: { type: "date" },
                                gcrowver: { type: "date" },
                                horasAnual: { type: "number" },
                                hstSitAdmv: { type: "string" },
                                idCategoria: { type: "string" },
                                idEmpresa: { type: "string" },
                                idHstSitAdmv: { type: "number" },
                                idNivel: { type: "number" },
                                idOrganig: { type: "string" },
                                idPais: { type: "string" },
                                idPaisNac: { type: "string" },
                                idPoblacion: { type: "string" },
                                idPoblacionNac: { type: "string" },
                                idProvincia: { type: "string" },
                                idProvinciaNac: { type: "string" },
                                idPuesto: { type: "string" },
                                idTSitAdmv: { type: "string" },
                                idTrabajador: { type: "string" },
                                minusv: { type: "string" },
                                nif: { type: "string" },
                                nivOrgId: { type: "number" },
                                num: { type: "string" },
                                pJornadaCto: { type: "number" },
                                pJornadaTrab: { type: "number" },
                                pOcupacion: { type: "number" },
                                pReducJornada: { type: "number" },
                                piso: { type: "string" },
                                puerta: { type: "string" },
                                residente: { type: "string" },
                                sexo: { type: "string" },
                                siglas: { type: "string" },
                                sitAdmv: { type: "string" },
                                tProvis: { type: "string" },
                                telefEmerg: { type: "string" },
                                telefono1: { type: "string" },
                                telefono2: { type: "string" }
                            }
                        }
                    },
                    pageSize: 10,
                    sort: {
                        field: "id",
                        dir: "asc"
                    }
                });
                $("#TablaSuperCheta").kendoGrid({
                    sortable: true, pageable: true,
                    columns: [
                        { field: "id" },
                        { field: "nombre" },
                        { field: "apellido1" },
                        { field: "apellido2" },
                        { field: "telefono1" }
                    ], dataSource: gridDataSource
                });
            },
            error: function (error) {
                console.log(error);
            }
        }
    );
}
