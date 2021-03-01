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

namespace API_Proyecto_Team1_AJV.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class TrabajadoresController : ControllerBase
    {
        private readonly TrabajadoresNetContext _context;
        // DTOs
        private static readonly Expression<Func<Trabajadores, PoblacionTrabajadoresDto>> AsPoblacionDto =
            x => new PoblacionTrabajadoresDto
            {
                D_Poblacion = x.IdP.DPoblacion,
                D_Provincia = x.IdProvinciaNavigation.DProvincia,
            };

        public TrabajadoresController(TrabajadoresNetContext context)
        {
            _context = context;
        }

        // GET: api/Trabajadores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Trabajadores>>> GetTrabajadores()
        {
            return await _context.Trabajadores.ToListAsync();
        }

        // GET: api/Trabajadores/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Trabajadores>> GetTrabajadores(string id)
        {
            var trabajadores = await _context.Trabajadores.FindAsync(id);

            if (trabajadores == null)
            {
                return NotFound();
            }

            return trabajadores;
        }

        /*
         *  DTOs
         * 
         */

        //GET api/Trabajadores/Poblacion
        // obtiene los nombres de las poblaciones de cada trabajador para los gráficos
        [HttpGet("Poblacion")]
        public IQueryable<PoblacionTrabajadoresDto> GetPoblacionTrabajadores()
        {
            // RETORNA POBLACION Y PROVINCIA
            return _context.Trabajadores.Select(AsPoblacionDto);
        }
    }
}
