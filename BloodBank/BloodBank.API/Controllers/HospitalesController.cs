using BloodBank.API.Data;
using BloodBank.Shared.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BloodBank.API.Controllers
{
    [ApiController]
    [Route("/api/hospitales")]
    public class HospitalesController : ControllerBase
    {
        private readonly DataContext _context;
        public HospitalesController(DataContext context)
        {
            _context = context;

        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {

            return Ok(await _context.Hospitales.ToListAsync());

        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {

            var hospital = await _context.Hospitales.FirstOrDefaultAsync(x => x.Id == id);
            if (hospital == null)
            {

                return NotFound();
            }
            else
            {
                return Ok(hospital);

            }
        }

        [HttpPost]

        public async Task<ActionResult> Post(Hospital hospital)
        {
            _context.Add(hospital);
            await _context.SaveChangesAsync();

            return Ok(hospital);
        }

        [HttpPut]

        public async Task<ActionResult> Put(Hospital hospital)
        {

            _context.Update(hospital);
            await _context.SaveChangesAsync();

            return Ok(hospital);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var FilasAfectadas = await _context.Hospitales
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
