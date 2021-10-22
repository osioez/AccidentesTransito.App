using System.Collections.Generic;
using AccidentesTransito.App.Dominio;
using System.Linq;
using System;

namespace AccidentesTransito.App.Persistencia
{
    public class RepositorioAccidenteConductorVehiculo : IRepositorioAccidenteConductorVehiculo
    {
        private readonly AppContext _appContext;

        public RepositorioAccidenteConductorVehiculo(AppContext appContext)
        {
            _appContext = appContext;
        }

        public List<AccidenteConductorVehiculo> GetAllAccidenteConductorVehiculo()
        {
            List<AccidenteConductorVehiculo> acvCompletos = new List<AccidenteConductorVehiculo>();
            IEnumerable<AccidenteConductorVehiculo> acvEncontrados = _appContext.AccidenteConductorVehiculo;
            foreach(var accidenteConductorVehiculo in acvEncontrados){
                var conductorEncontrado = _appContext.Conductores.Find(accidenteConductorVehiculo.ConductorId);
                var vehiculoEncontrado = _appContext.Vehiculos.Find(accidenteConductorVehiculo.VehiculoId);
                var accidenteEncontrado = _appContext.Accidentes.Find(accidenteConductorVehiculo.AccidenteId);
                AccidenteConductorVehiculo accidenteConductorVehiculoEncontrado = new AccidenteConductorVehiculo();
                accidenteConductorVehiculoEncontrado.Conductor = conductorEncontrado;
                accidenteConductorVehiculoEncontrado.Vehiculo = vehiculoEncontrado;
                accidenteConductorVehiculoEncontrado.Accidente = accidenteEncontrado;
                acvCompletos.Add(accidenteConductorVehiculoEncontrado);
            } 
            return acvCompletos;
        }


    }
}