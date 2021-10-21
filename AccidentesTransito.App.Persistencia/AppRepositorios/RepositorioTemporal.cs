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
        public List<AccidenteConductorVehiculo> accidenteConductorVehiculoImplicados;

        public RepositorioTemporal()
        {
            vehiculosImplicados = new List<Vehiculo>();
            conductoresImplicados = new List<Conductor>();
            peatonesImplicados = new List<Peaton>();
            accidenteConductorVehiculoImplicados = new List<AccidenteConductorVehiculo>();
        }
        public void AgregarVehiculo(Vehiculo vehiculo)
        {

            vehiculosImplicados.Add(vehiculo);
        }
        public List<Vehiculo> ObtenerVehiculos()
        {
            return vehiculosImplicados;
        }
        public void AgregarConductor(Conductor conductor)
        {

            conductoresImplicados.Add(conductor);
        }
        public List<Conductor> ObtenerConductores()
        {
            return conductoresImplicados;
        }
        public void AgregarPeaton(Peaton peaton)
        {

            peatonesImplicados.Add(peaton);
        }
        public List<Peaton> ObtenerPeatones()
        {
            return peatonesImplicados;
        }
        public void AgregarAccidenteConductorVehiculo(AccidenteConductorVehiculo accidenteConductorVehiculo)
        {
            accidenteConductorVehiculoImplicados.Add(accidenteConductorVehiculo);
        }
        public List<AccidenteConductorVehiculo> ObtenerAccidenteConductorVehiculo()
        {
            return accidenteConductorVehiculoImplicados;
        }
        public List<AccidenteConductorVehiculo> ActualizarAccidenteConductorVehiculo(Conductor nuevoConductorImplicado, string placaVehiculoAsociado)
        {
            var obj = accidenteConductorVehiculoImplicados.FirstOrDefault(acv => acv.Vehiculo.Placa == placaVehiculoAsociado);
            if (obj != null) obj.Conductor = nuevoConductorImplicado;
            return accidenteConductorVehiculoImplicados;
        }
        public void LimpiarRepositorioTemporal()
        {
            vehiculosImplicados = new List<Vehiculo>();
            conductoresImplicados = new List<Conductor>();
            peatonesImplicados = new List<Peaton>();
            accidenteConductorVehiculoImplicados = new List<AccidenteConductorVehiculo>();
        }
    }
    }