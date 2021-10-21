using System.Collections.Generic;
using AccidentesTransito.App.Dominio;
using System.Linq;
using System;

namespace AccidentesTransito.App.Persistencia
{
    public class RepositorioAccidente : IRepositorioAccidente
    {
        private readonly AppContext _appContext;

        public RepositorioAccidente(AppContext appContext)
        {
            _appContext = appContext;
        }
        public Accidente AddAccidente(Accidente accidente)
        {
            List<Peaton> PeatonesImplicadosBD = new List<Peaton>();
            List<AccidenteConductorVehiculo> AccidenteConductorVehiculoBD = new List<AccidenteConductorVehiculo>();

            var agenteEncontrado = _appContext.Agentes.Find(accidente.Agente.Id);
                accidente.Agente = agenteEncontrado;
            var barrioEncontrado = _appContext.Barrios.Find(accidente.Barrio.Id);
                accidente.Barrio = barrioEncontrado;
            foreach(var peaton in accidente.Peatones){
                var peatonEncontrado = _appContext.Peatones.Find(peaton.Id);
                PeatonesImplicadosBD.Add(peatonEncontrado);
            }
            accidente.Peatones = PeatonesImplicadosBD;
            foreach(var accidenteConductorVehiculo in accidente.AccidenteConductorVehiculo){
                var conductorEncontrado = _appContext.Conductores.Find(accidenteConductorVehiculo.Conductor.Id);
                var vehiculoEncontrado = _appContext.Vehiculos.Find(accidenteConductorVehiculo.Vehiculo.Id);
                AccidenteConductorVehiculo accidenteConductorVehiculoEncontrado = new AccidenteConductorVehiculo();
                accidenteConductorVehiculoEncontrado.Conductor = conductorEncontrado;
                accidenteConductorVehiculoEncontrado.Vehiculo = vehiculoEncontrado;
                AccidenteConductorVehiculoBD.Add(accidenteConductorVehiculoEncontrado);
            }
            accidente.AccidenteConductorVehiculo = AccidenteConductorVehiculoBD;
            accidente.Fecha = DateTime.Now;
            var AccidenteAdicionado = _appContext.Add(accidente);
            _appContext.SaveChanges();
            return AccidenteAdicionado.Entity;
        }

        public IEnumerable<Accidente> GetAllAccidentes()
        {
            return _appContext.Accidentes;
        }

        public Accidente GetAccidente(int idAccidente)
        {
            return _appContext.Accidentes.FirstOrDefault(a => a.Id == idAccidente);
        }

    }
}