using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarcenariaApi.Data;
using MarcenariaApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MarcenariaApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AgendaController : ControllerBase
    {
        private readonly MarcenariaDbContext _context;

        public AgendaController(MarcenariaDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("listar")]
        public async Task<ActionResult<IEnumerable<Agenda>>> GetAgendas()
        {
            return await _context.Agendas.ToListAsync();
        }

        [HttpGet()]
        [Route("buscar/{id}")]
        public async Task<ActionResult<Agenda>> GetAgenda(int id)
        {
            var agenda = await _context.Agendas.FindAsync(id);

            if (agenda == null)
            {
                return NotFound();
            }

            return agenda;
        }

        [HttpPost]
        [Route("cadastrar")]
        public async Task<ActionResult<Agenda>> CreateAgenda(Agenda agenda)
        {
            _context.Agendas.Add(agenda);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetAgenda), new { id = agenda.Id }, agenda);
        }

        [HttpPut("{id}")]
        [Route("atualizar")]
        public async Task<IActionResult> UpdateAgenda(int id, Agenda agenda)
        {
            if (id != agenda.Id)
            {
                return BadRequest();
            }

            _context.Entry(agenda).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AgendaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        [Route("deletar")]
        public async Task<IActionResult> DeleteAgenda(int id)
        {
            var agenda = await _context.Agendas.FindAsync(id);

            if (agenda == null)
            {
                return NotFound();
            }

            _context.Agendas.Remove(agenda);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AgendaExists(int id)
        {
            return _context.Agendas.Any(a => a.Id == id);
        }
    }

}
