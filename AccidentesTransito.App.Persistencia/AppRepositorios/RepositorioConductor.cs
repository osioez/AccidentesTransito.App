using System.Collections.Generic;
using AccidentesTransito.App.Dominio;
using System.Linq;

namespace AccidentesTransito.App.Persistencia
{
    public class RepositorioConductor : IRepositorioConductor
    {
        private readonly AppContext _appContext;

        public RepositorioConductor(AppContext appContext)
        {
            _appContext = appContext;
        }
        public Conductor AddConductor(Conductor conductor)
        {
            var ConductorAdicionado = _appContext.Add(conductor);
            _appContext.SaveChanges();
            return ConductorAdicionado.Entity;
        }

        public void DeleteConductor(int documentoIdentidad)
        {
            var conductorEncontrado = _appContext.Conductor.FirstOrDefault(c => c.DocumentoIdentidad == documentoIdentidad);
            if(conductorEncontrado == null){
                return;
            }
            _appContext.Remove(conductorEncontrado);
            _appContext.SaveChanges();
        }

        public IEnumerable<Conductor> GetAllConductores()
        {
            return _appContext.Conductor;
        }

        public Conductor GetConductor(int documentoIdentidad)
        {
            return _appContext.Conductor.FirstOrDefault(c => c.DocumentoIdentidad == documentoIdentidad);
        }

        public Conductor UpdateConductor(Conductor conductor)
        {
            var ConductorEncontrado = _appContext.Conductor.FirstOrDefault(c => c.DocumentoIdentidad == conductor.DocumentoIdentidad);
            if(ConductorEncontrado != null){
                ConductorEncontrado.Nombres = conductor.Nombres;
                ConductorEncontrado.Apellidos = conductor.Apellidos;
                ConductorEncontrado.TipoLicencia = conductor.TipoLicencia;
                _appContext.SaveChanges();
            }
           return ConductorEncontrado;
        }
    }
}