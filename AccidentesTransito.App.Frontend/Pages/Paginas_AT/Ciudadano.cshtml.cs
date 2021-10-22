using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AccidentesTransito.App.Dominio;
using AccidentesTransito.App.Persistencia;

namespace AccidentesTransito.App.Frontend.Pages
{
    
    public class CiudadanoModel : PageModel
    {

        private readonly IRepositorioAccidenteConductorVehiculo repositorioAccidenteConductorVehiculo;

        public List<AccidenteConductorVehiculo> AccidenteConductorVehiculoImplicados { set; get; }
        public List<Accidente> AccidentesConductor { set; get; }
        public List<Accidente> AccidentesPeaton  { set; get; }


         public CiudadanoModel()
        {
            this.repositorioAccidenteConductorVehiculo = new RepositorioAccidenteConductorVehiculo(new AccidentesTransito.App.Persistencia.AppContext());
        }
        public void OnGet(int documentoIdentidad)
        {
            //AccidenteConductorVehiculoImplicados = repositorioAccidenteConductorVehiculo.GetAllAccidenteConductorVehiculo();
        }
    }
}
