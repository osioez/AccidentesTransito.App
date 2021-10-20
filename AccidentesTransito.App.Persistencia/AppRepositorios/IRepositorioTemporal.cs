using AccidentesTransito.App.Dominio;
using System.Collections.Generic;

namespace AccidentesTransito.App.Persistencia
{
    public interface IRepositorioTemporal
    {
         void AgregarVehiculo(Vehiculo vehiculo);
         //void EliminarVehiculo(Vehiculo vehiculo);
         List<Vehiculo> ObtenerVehiculos();
        void AgregarConductor(Conductor conductor);
        //void EliminarConductor(Conductor conductor);
         List<Conductor> ObtenerConductores();
        void AgregarPeaton(Peaton peaton);
        //void EliminarPeaton(Peaton peaton);
         List<Peaton> ObtenerPeatones();
    }
}