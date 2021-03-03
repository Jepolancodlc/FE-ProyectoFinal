// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


function getKendoCharts(loc) {
    /*
     * Función para printar varios gráficos por pantalla formatados dentro de divs.
     * También tiene los arrays con la data para los diversos charts. Llama a las funciones para cada chart.
     */

    $(loc).empty(); // eliminamos el contenido del containerScreen
    addDivs(loc); // insertamos los divs para los gráficos

    // DATA PARA LOS CHARTS
    let productividadAnual = [
        // AREA CHART
        {
            "departamento": "Ayuntamiento",
            "anno": "2015",
            "valor": 15.8
        },
        {
            "departamento": "Ayuntamiento",
            "anno": "2016",
            "valor": 29.6
        },
        {
            "departamento": "Ayuntamiento",
            "anno": "2017",
            "valor": 50.5
        },
        {
            "departamento": "Ayuntamiento",
            "anno": "2018",
            "valor": 74.6
        },
        {
            "departamento": "Ayuntamiento",
            "anno": "2019",
            "valor": 80.9
        },
        {
            "departamento": "Ayuntamiento",
            "anno": "2020",
            "valor": 75.4
        }
    ];

    let trabajadoresDepartamento = [
        // CHART PIE
        {    
            "departamento": "Dept. Cultura",
            "porcentaje": 12,
        },
        {
            "departamento": "Dept. Urbanismo",
            "porcentaje": 21,
        },
        {
            "departamento": "Dept. Medio Ambiente",
            "porcentaje": 6,
        },
        {
            "departamento": "Secretaría General",
            "porcentaje": 9,
        },
        {
            "departamento": "Dept. Hacienda",
            "porcentaje": 34,
        },
        {
            "departamento": "Dept. Fomento",
            "porcentaje": 18,
        },
    ];

    let superavitDepartamentoAnual = [
        // LINE CHART
        {
            "departamento": "Dept. Cultura",
            "porcentaje": [2.107, 3.254, -1.254, 6.254, 8.244, -4.801, -1.258, 0.254, 1.246, -3.54]
        },
        {
            "departamento": "Dept. Urbanismo",
            "porcentaje": [-1.258, 0.214, 0.254, 0.269, 1.254, -2.258, 4.258, 5.369, 1.254, -6.855]
        },
        {
            "departamento": "Dept. Medio Ambiente",
            "porcentaje": [-2.084, 1.231, -5.254, -9.584, 1.254, -1.658, 2.548, -3.254, -15.254, 4.254]
        },
        {
            "departamento": "Secretaría General",
            "porcentaje": [-0.254, -1.254, -1.958, -2.654, -3.254, -12.547, -9.547, -5.254, 0.254, 1.254]
        },
        {
            "departamento": "Dept. Hacienda",
            "porcentaje": [3.907, 7.943, 7.848, 9.284, 9.263, 9.801, 3.890, 8.238, 9.552, 6.855]
        },
        {
            "departamento": "Dept. Fomento",
            "porcentaje": [-1.269, -0.254, 0, 0.254, -0.256, 1.258, -3.365, 0.321, -0.111, 0.254]
        }
    ];

    let presupuestoDepartamentoAnual = [
        {
            "name": "Ayuntamiento",
            "value": 100000,
            "items": [
                {
                    "name": "Dept. Cultura",
                    "value": 2000,
                    "items": [
                        {
                            "name": "Nominas",
                            "value": 800
                        },
                        {
                            "name": "Material",
                            "value": 200
                        },
                        {
                            "name": "Actividades",
                            "value": 400
                        },
                        {
                            "name": "Mantenimiento",
                            "value": 200
                        },
                        {
                            "name": "Gastos Eléctricos",
                            "value": 300
                        },
                        {
                            "name": "Otros Gastos",
                            "value": 100
                        }
                    ]
                },
                {
                    "name": "Dept. Urbanismo",
                    "value": 3000,
                    "items": [
                        {
                            "name": "Nominas",
                            "value": 500
                        },
                        {
                            "name": "Material",
                            "value": 1100
                        },
                        {
                            "name": "Actividades",
                            "value": 200
                        },
                        {
                            "name": "Mantenimiento",
                            "value": 100
                        },
                        {
                            "name": "Gastos Eléctricos",
                            "value": 100
                        },
                        {
                            "name": "Otros Gastos",
                            "value": 0
                        }
                    ]
                },
                {
                    "name": "Dept. Medio Ambiente",
                    "value": 800,
                    "items": [
                        {
                            "name": "Nominas",
                            "value": 200
                        },
                        {
                            "name": "Material",
                            "value": 100
                        },
                        {
                            "name": "Actividades",
                            "value": 300
                        },
                        {
                            "name": "Mantenimiento",
                            "value": 100
                        },
                        {
                            "name": "Gastos Eléctricos",
                            "value": 100
                        },
                        {
                            "name": "Otros Gastos",
                            "value": 0
                        }
                    ]
                },
                {
                    "name": "Secretaría General",
                    "value": 500,
                    "items": [
                        {
                            "name": "Nominas",
                            "value": 400
                        },
                        {
                            "name": "Material",
                            "value": 0
                        },
                        {
                            "name": "Actividades",
                            "value": 0
                        },
                        {
                            "name": "Mantenimiento",
                            "value": 0
                        },
                        {
                            "name": "Gastos Eléctricos",
                            "value": 0
                        },
                        {
                            "name": "Otros Gastos",
                            "value": 100
                        }
                    ]
                },
                {
                    "name": "Dept. Hacienda",
                    "value": 3000,
                    "items": [
                        {
                            "name": "Nominas",
                            "value": 700
                        },
                        {
                            "name": "Material",
                            "value": 600
                        },
                        {
                            "name": "Actividades",
                            "value": 300
                        },
                        {
                            "name": "Mantenimiento",
                            "value": 200
                        },
                        {
                            "name": "Gastos Eléctricos",
                            "value": 400
                        },
                        {
                            "name": "Otros Gastos",
                            "value": 700
                        }
                    ]
                },
                {
                    "name": "Dept. Fomento",
                    "value": 700,
                    "items": [
                        {
                            "name": "Nominas",
                            "value": 300
                        },
                        {
                            "name": "Material",
                            "value": 100
                        },
                        {
                            "name": "Actividades",
                            "value": 100
                        },
                        {
                            "name": "Mantenimiento",
                            "value": 100
                        },
                        {
                            "name": "Gastos Eléctricos",
                            "value": 100
                        },
                        {
                            "name": "Otros Gastos",
                            "value": 0
                        }
                    ]
                },
            ]
        }
    ];

    let gastoDepartamentos = [
        {
            "gasto": "Nóminas",
            "euros": 8995
        },
        {
            "gasto": "Material",
            "euros": 2800
        },
        {
            "gasto": "Gasto Energético",
            "euros": 3500
        },
        {
            "gasto": "Mantenimiento",
            "euros": 3581
        },
        {
            "gasto": "Alimentacion",
            "euros": 1854
        },
        {
            "gasto": "Hucha",
            "euros": 550
        },
        {
            "gasto": "Otros Gastos",
            "euros": 1245
        }
    ];

    let horasTrabajadores = [{
        name: "Horas por Contrato",
        data: [120, 115, 123, 125, 120, 110, 50, 112, 123],
        markers: { type: "square" }
    }, {
        name: "Horas Extras",
        data: [2, 5, 8, 10, 2, 6, 8, 6, 3]
    }];

    // LLAMADA DE FUNCIONES A LOS CHARTS - pasamos por parámetro el id del div para printarlos.
    areaChart(productividadAnual, "#areaChart");
    pieChart(trabajadoresDepartamento, "#pieChart");
    lineChart(superavitDepartamentoAnual, "#lineChart");
    treeChart(presupuestoDepartamentoAnual, "#treeChart");
    radarChart(gastoDepartamentos, "#radarChart");
    columnChart(horasTrabajadores, "#columnChart");
   
    /////////////////////////// CHARTS CREADOS CON DATOS DE LA BASE DE DATOS //////////////////////////////////////////////////
    GetPoblacionChart(); // llamamos al get para volver a guardar la data actualizada
    let dataPoblacion = JSON.parse(localStorage.getItem("poblacion")); // la asignamos a una variable para trabajar con ella
    poblacionChart(dataPoblacion, "#poblacionChart");

    GetGeneroChart();
    let dataGenero = JSON.parse(localStorage.getItem("genero"));
    donutChart(dataGenero, "#donutChart");
}

function addDivs(loc) {

    $(loc).append("<div id='areaChart' class='graph'></div>" +
        "<div id='pieChart' class='graph'></div>"+
        "<div id='lineChart' class='graph'></div>"+
        "<div id='radarChart' class='graph'></div>"+
        "<div id='donutChart' class='graph'></div>"+
        "<div id='columnChart' class='graph'></div>"+
        "<div id='treeChart' class='graphGrande'></div>"+
        "<div id='poblacionChart' class='graphGrande'></div>"
    );
}


function areaChart(data, loc) {
    $(loc).kendoChart({
        dataSource: {
            data: data
        },
        title: {
            text: "Productividad Anual"
        },
        legend: {
            visible: false
        },
        seriesDefaults: {
            type: "area",
            labels: {
                visible: true,
                format: "{0}%",
                background: "transparent"
            }
        },
        series: [{
            field: "valor",
            categoryField: "anno",
            name: "departamento"
        }],
        valueAxis: {
            labels: {
                format: "{0}%"
            },
            line: {
                visible: true
            }
        },
        categoryAxis: {
            majorGridLines: {
                visible: true
            }
        },
        tooltip: {
            visible: true,
            format: "{0}%",
            template: "#= category # - #= value #%"
        }
    });
}

function pieChart(data, loc) {
    $(loc).kendoChart({
        title: {
            text: "% Trabajadores por Departamentos"
        },
        legend: {
            position: "top"
        },
        dataSource: {
            data: data
        },
        series: [{
            type: "pie",
            field: "porcentaje",
            categoryField: "departamento",
        }],
        seriesColors: ["#42a7ff", "#ff4e00", "#00ff03", "#666666", "#00ffd7", "#e8ff00"],
        tooltip: {
            visible: true,
            template: "${ category } - ${ value }%"
        }
    });
}

function lineChart(data, loc) {
    $(loc).kendoChart({
        dataSource: {
            data: data
        },
        title: {
            text: "Gastos por departamento respecto al presupuesto total anual"
        },
        legend: {
            position: "top"
        },
        seriesDefaults: {
            type: "line",
            style: "smooth",
            labels: {
                visible: false,
                format: "{0}%",
                background: "transparent"
            }
        },
        series: [{
            name: "Dept. Cultura",
            data: [2.107, 3.254, -1.254, 6.254, 8.244, -4.801, -1.258, 0.254, 1.246, -3.54],
            color: "#007bff"
        },
        {
            name: "Dept. Urbanismo",
            data: [-1.258, 0.214, 0.254, 0.269, 1.254, -2.258, 4.258, 5.369, 1.254, -6.855],
            color: "#dc3545"
        },
        {
            name: "Dept. Medio Ambiente",
            data: [-2.084, 1.231, -5.254, -9.584, 1.254, -1.658, 2.548, -3.254, -15.254, 4.254],
            color: "#28a745"
        },
        {
            name: "Secretaría General",
            data: [-0.254, -1.254, -1.958, -2.654, -3.254, -12.547, -9.547, -5.254, 0.254, 1.254],
            color: "#343a40"
        },
        {
            name: "Dept. Hacienda",
            data: [3.907, 7.943, 7.848, 9.284, 9.263, 9.801, 3.890, 8.238, 9.552, 6.855],
            color: "#20c997"
        },
        {
            name: "Dept. Fomento",
            data: [-1.269, -0.254, 0, 0.254, -0.256, 1.258, -3.365, 0.321, -0.111, 0.254],
            color: "#6610f2"
        }],
        valueAxis: {
            labels: {
                format: "{0}%"
            },
            line: {
                visible: false
            },
            axisCrossingValue: -20
        },
        categoryAxis: {
            categories: [2011, 2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019, 2020],
            majorGridLines: {
                visible: false
            },
            labels: {
                rotation: "auto"
            }
        },
        tooltip: {
            visible: true,
            format: "{0}%",
            template: "#= series.name #: #= value #"
        }
    });
}

function treeChart(data, loc) {
    $(loc).kendoTreeMap({
        dataSource: {
            data: data,
            schema: {
                model: {
                    children: "items"
                }
            },
        },
        valueField: "value",
        textField: "name",
        colors: [["#42a7ff", "#81c4ff"], ["#ff4e00", "#fdb697"], ["#00ff03", "#c2fdc2"], ["#666666", "#b5b5b5"], ["#00ffd7", "#affff3"], ["#e8ff00","#f6ff9a"]]
    });
}

function radarChart(data, loc) {
    $(loc).kendoChart({
        title: {
            text: "Gastos por área"
        },
        dataSource: {
            data: data
        },
        series: [{
            name: "Gastos",
            type: "radarLine",
            field: "euros",
            categoryField: "gasto",
            color: "#007bff"
        }],
        valueAxis: {
            visible: false
        },
        tooltip: {
            visible: true
        },
        legend: {
            visible: false
        }
    });
}

function donutChart(data, loc) {
    $(loc).kendoChart({
        title: {
            text: "Sexo de los Trabajadores"
        },
        legend: {
            position: "top"
        },
        dataSource: {
            data: data
        },
        seriesDefaults: {
            type: "donut",
            startAngle: 150
        },
        series: [{
            field: "Cantidad",
            categoryField: "Genero"
        }],
        seriesColors: ["#ffd34a", "#ff776e"],
        tooltip: {
            visible: true,
            template: "${ category } - Nº ${ value }"
        }
    });
}

function columnChart(data, loc) {
    $(loc).kendoChart({
        title: {
            text: "Horas Realizadas"
        },
        legend: {
            position: "bottom"
        },
        seriesDefaults: {
            type: "column",
            stack: true
        },
        series: data,
        valueAxis: {
            line: {
                visible: false
            }
        },
        seriesColors: ["#007bff", "#ffc107"],
        categoryAxis: {
            categories: ["Adriàn Moreno", "Sara Molina", "David Fernandez", "Joan Palomo", "Yolanda Garcia", "Anna Rojas", "Martín Garcia", "David Ferrer", "María Plana"],
            majorGridLines: {
                visible: false
            },
            labels: {
                visible: true,
                rotation: 310
            }
        },
        tooltip: {
            visible: true,
            format: "{0}"
        }
    });
}

function poblacionChart(data, loc) {
    $(loc).kendoChart({
        title: {
            text: "Población Trabajadores"
        },
        legend: {
            position: "top"
        },
        dataSource: {
            data: data
        },
        seriesDefaults: {
            type: "donut",
            startAngle: 150
        },
        series: [{
            field: "Coincidencias",
            categoryField: "D_Poblacion"
        }],
        tooltip: {
            visible: true,
            template: "${ category } - Nº ${ value }"
        }
    });
}


function GetPoblacionChart() {
    // Función para el GET de la API a Trabajadores/Poblacion. Guarda el json devuelto en una variable en memoria llamada 'poblacion'.
    $.ajax(
        {
            url: "https://localhost:44326/api/Trabajadores/Poblacion",
            method: 'GET',
            dataType: 'json',
            headers: {
                'Accept': 'application/json',
                'Authorization': localStorage.getItem('token') /* Recogemos el token guardado en memoria (se llama a guardar en index.cshtml) */
            },
            contentType: 'application/json',

            success: function (poblacion) {
                localStorage.setItem("poblacion", poblacion); /* guardamos el json en memoria */
            },
            error: function (error) {
                console.log(error);
            }
        }
    );
}

function GetGeneroChart() {
    // Función para el GET de la API a Trabajadores/Genero. Guarda el json devuelto en una variable en memoria llamada 'genero'.
    $.ajax(
        {
            url: "https://localhost:44326/api/Trabajadores/Genero",
            method: 'GET',
            dataType: 'json',
            headers: {
                'Accept': 'application/json',
                'Authorization': localStorage.getItem('token') /* Recogemos el token guardado en memoria (se llama a guardar en index.cshtml) */
            },
            contentType: 'application/json',

            success: function (genero) {
                localStorage.setItem("genero", genero); /* guardamos el json en memoria */
            },
            error: function (error) {
                console.log(error);
            }
        }
    );
}