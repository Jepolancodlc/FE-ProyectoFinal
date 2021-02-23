using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API_Proyecto_Team1_AJV.Models;
using Microsoft.AspNetCore.Authorization;

namespace API_Proyecto_Team1_AJV.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class TrabajadoresController : ControllerBase
    {
        private readonly TrabajadoresNetContext _context;

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

        //// PUT: api/Trabajadores/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for
        //// more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutTrabajadores(string id, Trabajadores trabajadores)
        //{
        //    if (id != trabajadores.IdEmpresa)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(trabajadores).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!TrabajadoresExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/Trabajadores
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for
        //// more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        //[HttpPost]
        //public async Task<ActionResult<Trabajadores>> PostTrabajadores(Trabajadores trabajadores)
        //{
        //    _context.Trabajadores.Add(trabajadores);
        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateException)
        //    {
        //        if (TrabajadoresExists(trabajadores.IdEmpresa))
        //        {
        //            return Conflict();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return CreatedAtAction("GetTrabajadores", new { id = trabajadores.IdEmpresa }, trabajadores);
        //}

        //// DELETE: api/Trabajadores/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<Trabajadores>> DeleteTrabajadores(string id)
        //{
        //    var trabajadores = await _context.Trabajadores.FindAsync(id);
        //    if (trabajadores == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Trabajadores.Remove(trabajadores);
        //    await _context.SaveChangesAsync();

        //    return trabajadores;
        //}

        //private bool TrabajadoresExists(string id)
        //{
        //    return _context.Trabajadores.Any(e => e.IdEmpresa == id);
        //}
    }
}
