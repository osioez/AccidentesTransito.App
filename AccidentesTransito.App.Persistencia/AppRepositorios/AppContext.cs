using Microsoft.EntityFrameworkCore;
using AccidentesTransito.App.Dominio;

namespace AccidentesTransito.App.Persistencia
{
    public class AppContext : DbContext{
        public DbSet<Accidente> Accidente {get; set;}
        public DbSet<Agente> Agente {get; set;}
        public DbSet<Barrio> Barrio {get; set;}
        public DbSet<Conductor> Conductor {get; set;}
        public DbSet<Peaton> Peaton {get; set;}
        public DbSet<TipoVehiculo> TipoVehiculo {get; set;}
        public DbSet<Vehiculo> Vehiculo {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // LocalDB (It only works with Windows)
                // optionsBuilder.UseSqlServer("Data Source = localhost\\MSSQLLocalDB; Initial Catalog = AccidentesTransitoData");
                
                // Localhost server connection
                optionsBuilder.UseSqlServer("Server=localhost;Database=AccidentesTransitoData;User Id=sa;Password=gLfH%$%t");

            }
        }
    }
}