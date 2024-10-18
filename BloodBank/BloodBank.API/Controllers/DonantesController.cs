using BloodBank.API.Data;
using BloodBank.Shared.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BloodBank.API.Controllers
{
    [ApiController]
    [Route("/api/donantes")]
    public class DonantesController : ControllerBase
    {
        private readonly DataContext _context;
        public DonantesController(DataContext context)
        {
            _context = context;

        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {

            return Ok(await _context.Donantes.ToListAsync());

        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {

            var donante = await _context.Donantes.FirstOrDefaultAsync(x => x.Id == id);
            if (donante == null)
            {

                return NotFound();
            }
            else
            {
                return Ok(donante);

            }
        }

        [HttpPost]

        public async Task<ActionResult> Post(Donante donante)
        {
            _context.Add(donante);
            await _context.SaveChangesAsync();

            return Ok(donante);
        }

        [HttpPut]

        public async Task<ActionResult> Put(Donante donante)
        {

            _context.Update(donante);
            await _context.SaveChangesAsync();

            return Ok(donante);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var FilasAfectadas = await _context.Donantes
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
