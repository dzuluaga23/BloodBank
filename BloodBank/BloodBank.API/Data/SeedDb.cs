using BloodBank.Shared.Entidades;

namespace BloodBank.API.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;
        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckInventarioAsync();
        }

        public async Task CheckInventarioAsync()
        {
            if (!_context.Inventarios.Any())
            {
                _context.Inventarios.Add(new Inventario { Tipo = "A+" });
                _context.Inventarios.Add(new Inventario { Tipo = "O+" });
                _context.Inventarios.Add(new Inventario { Tipo = "B+" });
                _context.Inventarios.Add(new Inventario { Tipo = "AB+" });
                _context.Inventarios.Add(new Inventario { Tipo = "A-" });
                _context.Inventarios.Add(new Inventario { Tipo = "O-" });
                _context.Inventarios.Add(new Inventario { Tipo = "B-" });
                _context.Inventarios.Add(new Inventario { Tipo = "AB-" });
            }
            await _context.SaveChangesAsync();
        }
    }
}
