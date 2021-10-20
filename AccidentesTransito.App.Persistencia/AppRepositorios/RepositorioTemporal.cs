using AccidentesTransito.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace AccidentesTransito.App.Persistencia
{
    public class RepositorioTemporal : IRepositorioTemporal
    {
        public List<Vehiculo> vehiculosImplicados;
        public List<Conductor> conductoresImplicados;
        public List<Peaton> peatonesImplicados;

        public RepositorioTemporal(){
            vehiculosImplicados = new List<Vehiculo>();
            conductoresImplicados = new List<Conductor>();
            peatonesImplicados = new List<Peaton>();
        }
        public void AgregarVehiculo(Vehiculo vehiculo){

            vehiculosImplicados.Add(vehiculo);
        }
        public List<Vehiculo> ObtenerVehiculos(){
            return vehiculosImplicados;
        }
        public void AgregarConductor(Conductor conductor){

            conductoresImplicados.Add(conductor);
        }
        public List<Conductor> ObtenerConductores(){
            return conductoresImplicados;
        }
        public void AgregarPeaton(Peaton peaton){

            peatonesImplicados.Add(peaton);
        }
        public List<Peaton> ObtenerPeatones(){
            return peatonesImplicados;
        }
    }
}