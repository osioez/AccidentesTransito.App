using System.Collections.Generic;
using AccidentesTransito.App.Dominio;

namespace AccidentesTransito.App.Persistencia
{
    public interface IRepositorioVehiculo
    {
        IEnumerable<Vehiculo> GetAllVehiculos();
        Vehiculo AddVehiculo(Vehiculo vehiculo);
        Vehiculo UpdateVehiculo (Vehiculo vehiculo);
        void DeleteVehiculo (string placaVehiculo);
        Vehiculo GetVehiculo (string placaVehiculo);
    }
}