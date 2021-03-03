using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API_Proyecto_Team1_AJV.Models;
using Microsoft.AspNetCore.Authorization;
using API_Proyecto_Team1_AJV.DTOs;
using System.Linq.Expressions;
using Newtonsoft.Json;

namespace API_Proyecto_Team1_AJV.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class TrabajadoresController : ControllerBase
    {
        private readonly TrabajadoresNetContext _context;
        /*
         * DTOs
         */
        private static readonly Expression<Func<Trabajadores, PoblacionTrabajadoresDto>> AsPoblacionDto =
            // DTO PARA EL GRÁFICO DE POBLACIÓN
            p => new PoblacionTrabajadoresDto
            {
                D_Poblacion = p.IdP.DPoblacion
            };
        private static readonly Expression<Func<Trabajadores, GeneroTrabajadoresDto>> AsGeneroDto =
            // DTO PARA EL GRÁFICO DE GÉNERO
            g => new GeneroTrabajadoresDto
            {
                Genero = g.Sexo
            };
        private static readonly Expression<Func<Trabajadores, TablaTrabajadoresDto>> AsTablaDto =
            // DTO PARA LA TABLA DEL FRONT
            t => new TablaTrabajadoresDto
            {
                Id_Trabajador = t.Id,
                FotoUrl = "../img/"+t.Id+".jpg",
                Nombre = t.Nombre + " " + t.Apellido1 + " " + t.Apellido2,
                Email = t.Email,
                Empresa = t.NivOrg.Organig.Empresas.DEmpresa,
                Telefono = t.Telefono1 + " " + t.Telefono2,
                Grupo = t.Grupo,
                Cuerpo = t.CuerpoNavigation.Descrip,
                Categoria = t.IdCategoriaNavigation.Descrip,
                TProvis = t.TProvis,
                SitAdmin = t.SitAdmv
            };

        public TrabajadoresController(TrabajadoresNetContext context)
        {
            _context = context;
        }

        /*
         *  DTOs
         * 
         */

        // GET: api/Trabajadores
        // GET TRABAJADORES PERSONALIZADO CON DTO PARA QUE NOS MUESTRE SÓLO LAS COLUMNAS DESEADAS
        [HttpGet]
        public IQueryable<TablaTrabajadoresDto> GetTablaTrabajadores()
        {
            return _context.Trabajadores.Select(AsTablaDto);
        }

        //GET api/Trabajadores/Poblacion
        // obtiene los nombres de las poblaciones de cada trabajador y el número de repeticiones para los gráficos
        [HttpGet("Poblacion")]
        public string GetPoblacionTrabajadores()
        {
            // RETORNA POBLACION Y CANTIDAD POR POBLACION
            
            //guardamos el json con las poblaciones para comprobaciones
            var pob = _context.Trabajadores.Select(AsPoblacionDto);
            // creamos una lista vacia para ir añadiendo las poblaciones con porcentajes
            // esta lista la serializaremos en formato json para el output del POST
            List<PoblacionTrabajadoresDto> pob_cont = new List<PoblacionTrabajadoresDto>();

            int coincidencia; // variable para guardar las coincidencias
            List<string> lista_revisadas = new List<string> { }; // variable para guardar los pueblos revisados, sólo se revisarán una vez

            foreach(var x in pob) // recorremos la lista de trabajadores
            {
                coincidencia = 0;
                if (!lista_revisadas.Contains(x.D_Poblacion)) //por cada registro, si no hemos revisado el nombre ya
                {
                    foreach (var y in pob) // revisamos el json completo para buscar coincidencias
                    {
                        if (x.D_Poblacion == y.D_Poblacion) // si la población coincide
                        {
                            coincidencia = coincidencia + 1; // guardamos la cantidad de veces que coincide(mínimo 1 por cada registro(consigo mismo))
                        }
                    }
                }

                // creamos el nuevo objeto y le asignamos los valores resueltos
                PoblacionTrabajadoresDto pueblo = new PoblacionTrabajadoresDto();
                pueblo.D_Poblacion = x.D_Poblacion;
                pueblo.Coincidencias = coincidencia;

                // guardamos el objeto en una lista
                pob_cont.Add(pueblo);
                // guardamos el nombre del pueblo para no volver a revisarlo
                lista_revisadas.Add(x.D_Poblacion);
            }

            // convertimos la lista en formato json para devolverla
            var output = JsonConvert.SerializeObject(pob_cont, Formatting.Indented);
            return output;
        }


        //GET api/Trabajadores/Genero
        // obtiene la cantidad de hombres y mujeres de trabajadores para la gráfica
        [HttpGet("Genero")]
        public string GetGeneroTrabajadores()
        {
            // RETORNA GENERO Y CANTIDAD POR GENERO

            //guardamos el json con las poblaciones para comprobaciones
            var gen = _context.Trabajadores.Select(AsGeneroDto);
            // creamos una lista vacia para ir añadiendo los generos
            // esta lista la serializaremos en formato json para el output del POST
            List<GeneroTrabajadoresDto> gen_cont = new List<GeneroTrabajadoresDto>();

            int con_M = 0; // variable para guardar las coincidencias
            int con_F = 0;

            foreach (var x in gen) // recorremos la lista de trabajadores
            {
                if(x.Genero == "M")
                {
                    con_M = con_M + 1;
                }
                else
                {
                    con_F = con_F + 1;
                }
            }

            // creamos el nuevo objeto y le asignamos los valores resueltos
            GeneroTrabajadoresDto genero_M = new GeneroTrabajadoresDto();
            genero_M.Genero = "Masculino";
            genero_M.Cantidad = con_M;

            GeneroTrabajadoresDto genero_F = new GeneroTrabajadoresDto();
            genero_F.Genero = "Femenino";
            genero_F.Cantidad = con_F;

            // guardamos el objeto en una lista
            gen_cont.Add(genero_M);
            gen_cont.Add(genero_F);

            // convertimos la lista en formato json para devolverla
            var output = JsonConvert.SerializeObject(gen_cont, Formatting.Indented);
            return output;
        }
    }
}
