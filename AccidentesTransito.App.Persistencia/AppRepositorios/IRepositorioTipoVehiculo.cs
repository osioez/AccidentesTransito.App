using System.Collections.Generic;
using AccidentesTransito.App.Dominio;

namespace AccidentesTransito.App.Persistencia
{
    public interface IRepositorioTipoVehiculo
    {
        IEnumerable<TipoVehiculo> GetAllTiposVehiculos();
        TipoVehiculo GetTipoVehiculo (int tipoVehiculoId);
    }
}