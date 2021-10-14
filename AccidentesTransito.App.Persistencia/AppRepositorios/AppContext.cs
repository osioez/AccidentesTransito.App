using Microsoft.EntityFrameworkCore;
using AccidentesTransito.App.Dominio;

namespace AccidentesTransito.App.Persistencia
{
    public class AppContext : DbContext{
        public DbSet<Accidente> Accidentes {get; set;}
        public DbSet<Agente> Agentes {get; set;}
        public DbSet<Barrio> Barrios {get; set;}
        public DbSet<Conductor> Conductores {get; set;}
        public DbSet<Peaton> Peatones {get; set;}
        public DbSet<TipoVehiculo> TiposVehiculos {get; set;}
        public DbSet<Vehiculo> Vehiculos {get; set;}
    
        public DbSet<AccidenteConductorVehiculo> AccidenteConductorVehiculo {get; set;}

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // LocalDB (It only works with Windows)
                //optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = AccidentesTransito_v1_Data");
                
                // Localhost server connection
                optionsBuilder.UseSqlServer("Server=localhost;Database=AccidentesTransitoData;User Id=sa;Password=gLfH%$%t");

            }
        }
    }
}