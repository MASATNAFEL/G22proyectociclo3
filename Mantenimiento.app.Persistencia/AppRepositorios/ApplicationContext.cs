using Microsoft.EntityFrameworkCore;
using Mantenimiento.app.Dominio;

namespace Mantenimiento.app.Persistencia
{
    public class ApplicationContext : DbContext
    {
        private const string connectionString = @"Data Source=localhost\sqlexpress;Initial Catalog=MantenimientoTic;Integrated Security=True;";
          public DbSet<Cliente> Clientes {get; set;}
	public DbSet<Servicio> Servicios{get; set;}
        public DbSet<Tecnico> Tecnicos {get; set;}
	public DbSet<Vehiculo> Vehiculos {get; set;}

    public ApplicationContext(){}

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
        :base(options)
    {
    }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
             {
                optionsBuilder.UseSqlServer(connectionString);
             }
    }
}