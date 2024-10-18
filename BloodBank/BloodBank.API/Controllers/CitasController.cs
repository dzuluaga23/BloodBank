using BloodBank.API.Data;
using BloodBank.Shared.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BloodBank.API.Controllers
{

    [ApiController]
    [Route("/api/citas")]
    public class CitasController : ControllerBase
    {
        private readonly DataContext _context;
        public CitasController(DataContext context)
        {
            _context = context;

        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {

            return Ok(await _context.Citas.ToListAsync());

        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {

            var cita = await _context.Citas.FirstOrDefaultAsync(x => x.Id == id);
            if (cita == null)
            {

                return NotFound();
            }
            else
            {
                return Ok(cita);

            }
        }

        [HttpPost]

        public async Task<ActionResult> Post(Cita cita)
        {
            _context.Add(cita);
            await _context.SaveChangesAsync();

            return Ok(cita);
        }

        [HttpPut]

        public async Task<ActionResult> Put(Cita cita)
        {

            _context.Update(cita);
            await _context.SaveChangesAsync();

            return Ok(cita);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var FilasAfectadas = await _context.Citas
                .Where(a => a.Id == id)
                .ExecuteDeleteAsync();

            if (FilasAfectadas == 0)
            {

                return NotFound();
            }
            else
            {
                return NoContent();
            }
        }
    }
}

