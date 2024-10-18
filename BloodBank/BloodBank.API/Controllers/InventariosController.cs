using BloodBank.API.Data;
using BloodBank.Shared.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BloodBank.API.Controllers
{
    [ApiController]
    [Route("/api/inventarios")]
    public class InventariosController : ControllerBase
    {
        private readonly DataContext _context;
        public InventariosController(DataContext context)
        {
            _context = context;

        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {

            return Ok(await _context.Inventarios.ToListAsync());

        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {

            var inventario = await _context.Inventarios.FirstOrDefaultAsync(x => x.Id == id);
            if (inventario == null)
            {

                return NotFound();
            }
            else
            {
                return Ok(inventario);

            }
        }

        [HttpPost]

        public async Task<ActionResult> Post(Inventario inventario)
        {
            _context.Add(inventario);
            await _context.SaveChangesAsync();

            return Ok(inventario);
        }

        [HttpPut]

        public async Task<ActionResult> Put(Inventario inventario)
        {

            _context.Update(inventario);
            await _context.SaveChangesAsync();

            return Ok(inventario);
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
