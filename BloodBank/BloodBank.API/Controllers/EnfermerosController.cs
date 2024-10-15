using BloodBank.API.Data;
using BloodBank.Shared.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BloodBank.API.Controllers
{
    [ApiController]
    [Route("/api/enfermeros")]
    public class EnfermerosController : ControllerBase
    {
        private readonly DataContext _context;
        public EnfermerosController(DataContext context)
        {
            _context = context;

        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {

            return Ok(await _context.Enfermeros.ToListAsync());

        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {

            var enfermero = await _context.Enfermeros.FirstOrDefaultAsync(x => x.Id == id);
            if (enfermero == null)
            {

                return NotFound();
            }
            else
            {
                return Ok(enfermero);

            }
        }

        [HttpPost]

        public async Task<ActionResult> Post(Enfermero enfermero)
        {
            _context.Add(enfermero);
            await _context.SaveChangesAsync();

            return Ok(enfermero);
        }

        [HttpPut]

        public async Task<ActionResult> Put(Enfermero enfermero)
        {

            _context.Update(enfermero);
            await _context.SaveChangesAsync();

            return Ok(enfermero);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var FilasAfectadas = await _context.Enfermeros
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
