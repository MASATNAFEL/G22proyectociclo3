using Microsoft.EntityFrameworkCore;
using Mantenimiento.app.Dominio;

namespace Mantenimiento.app.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Cliente> Clientes{get;set;}
        public DbSet<Tecnico> Tecnicos{get;set;}
        public DbSet<Vehiculo> Vehiculos{get;set;}

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
             {
                if(!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseSqlServer("Data Source =(localdb)\\MSSQLLocalDB; Initial Catalog = MantenimientoData");
                }
             }
    }
}