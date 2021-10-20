using AccidentesTransito.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace AccidentesTransito.App.Persistencia
{
    public class RepositorioTipoVehiculo : IRepositorioTipoVehiculo
    {
      private readonly AppContext _appContext;

        public RepositorioTipoVehiculo(AppContext appContext)
        {
            _appContext = appContext;
        }
        public IEnumerable<TipoVehiculo> GetAllTiposVehiculos(){
            return _appContext.TiposVehiculos;
        }
        public TipoVehiculo GetTipoVehiculo (int tipoVehiculoId){
            return _appContext.TiposVehiculos.FirstOrDefault(tv => tv.Id == tipoVehiculoId);
            
        }
    }
}