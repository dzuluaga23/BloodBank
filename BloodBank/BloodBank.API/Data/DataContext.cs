using BloodBank.Shared.Entidades;
using Microsoft.EntityFrameworkCore;
using System.Drawing;

namespace BloodBank.API.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Cita> Citas { get; set; }
        public DbSet<Donacion> Donaciones { get; set; }
        public DbSet<Donante> Donantes { get; set; }
        public DbSet<Enfermero> Enfermeros { get; set; }
        public DbSet<Hospital> Hospitales { get; set; }
        public DbSet<Inventario> Inventarios { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
