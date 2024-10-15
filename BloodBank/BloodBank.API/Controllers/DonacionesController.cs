using BloodBank.API.Data;
using BloodBank.Shared.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BloodBank.API.Controllers
{

    [ApiController]
    [Route("/api/donaciones")]
    public class DonacionesController : ControllerBase
    {
        private readonly DataContext _context;
        public DonacionesController(DataContext context)
        {
            _context = context;

        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {

            return Ok(await _context.Donaciones.ToListAsync());

        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {

            var donacion = await _context.Donaciones.FirstOrDefaultAsync(x => x.Id == id);
            if (donacion == null)
            {

                return NotFound();
            }
            else
            {
                return Ok(donacion);

            }
        }

        [HttpPost]

        public async Task<ActionResult> Post(Donacion donacion)
        {
            _context.Add(donacion);
            await _context.SaveChangesAsync();

            return Ok(donacion);
        }

        [HttpPut]

        public async Task<ActionResult> Put(Donacion donacion)
        {

            _context.Update(donacion);
            await _context.SaveChangesAsync();

            return Ok(donacion);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var FilasAfectadas = await _context.Donaciones
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
