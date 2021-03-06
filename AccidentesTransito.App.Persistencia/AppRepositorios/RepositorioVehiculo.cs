using System.Collections.Generic;
using AccidentesTransito.App.Dominio;
using System.Linq;

namespace AccidentesTransito.App.Persistencia
{
    public class RepositorioVehiculo : IRepositorioVehiculo
    {
        private readonly AppContext _appContext;

        public RepositorioVehiculo(AppContext appContext)
        {
            _appContext = appContext;
        }
        public Vehiculo AddVehiculo(Vehiculo vehiculo)
        {
            var TipoVehiculo = _appContext.TiposVehiculos.Find(vehiculo.TipoVehiculo.Id);
            vehiculo.TipoVehiculo = TipoVehiculo;
            var VehiculoAdicionado = _appContext.Add(vehiculo);
            _appContext.SaveChanges();
            return VehiculoAdicionado.Entity;
        }

        public void DeleteVehiculo(string placaVehiculo)
        {
            var VehiculoEncontrado = _appContext.Vehiculos.FirstOrDefault(v => v.Placa == placaVehiculo);
            if (VehiculoEncontrado == null)
            {
                return;
            }
            _appContext.Remove(VehiculoEncontrado);
            _appContext.SaveChanges();
        }

        public IEnumerable<Vehiculo> GetAllVehiculos()
        {
            return _appContext.Vehiculos;
        }

        public Vehiculo GetVehiculo(string placaVehiculo)
        {
            var VehiculoEncontrado = _appContext.Vehiculos.FirstOrDefault(v => v.Placa == placaVehiculo);
            if (VehiculoEncontrado != null){
                var TipoVehiculo = _appContext.TiposVehiculos.Find(VehiculoEncontrado.TipoVehiculoId);
                VehiculoEncontrado.TipoVehiculo = TipoVehiculo;
            }
            return VehiculoEncontrado;
        }

        public Vehiculo UpdateVehiculo(Vehiculo vehiculo)
        {
            var vehiculoEncontrado = _appContext.Vehiculos.FirstOrDefault(v => v.Id == vehiculo.Id);
            if (vehiculoEncontrado != null)
            {
                vehiculoEncontrado.CapacidadPasajeros = vehiculo.CapacidadPasajeros;
                vehiculoEncontrado.Marca = vehiculo.Marca;
                vehiculoEncontrado.Modelo = vehiculo.Modelo;
                vehiculoEncontrado.TipoVehiculo = vehiculo.TipoVehiculo;
                vehiculoEncontrado.Placa = vehiculo.Placa;
                _appContext.SaveChanges();
            }
            return vehiculoEncontrado;
        }
    }
}