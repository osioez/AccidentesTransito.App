using System.Collections.Generic;
using AccidentesTransito.App.Dominio;

namespace AccidentesTransito.App.Persistencia
{
    public interface IRepositorioAccidenteConductorVehiculo
    {
        List<AccidenteConductorVehiculo> GetAllAccidenteConductorVehiculo();

    }
}