using System.Collections.Generic;
using AccidentesTransito.App.Dominio;
using System.Linq;

namespace AccidentesTransito.App.Persistencia
{
    public class RepositorioAgente : IRepositorioAgente
    {
        private readonly AppContext _appContext;

        public RepositorioAgente(AppContext appContext)
        {
            _appContext = appContext;
        }
        public Agente AddAgente(Agente agente)
        {
            var AgenteAdicionado = _appContext.Add(agente);
            _appContext.SaveChanges();
            return AgenteAdicionado.Entity;
        }

        public void DeleteAgente(int idAgente)
        {
            var agenteEncontrado = _appContext.Agentes.FirstOrDefault(a => a.IdAgente == idAgente);
            if(agenteEncontrado == null){
                return;
            }
            _appContext.Remove(agenteEncontrado);
            _appContext.SaveChanges();
        }

        public IEnumerable<Agente> GetAllAgentes()
        {
            return _appContext.Agentes;
        }

        public Agente GetAgente(int documentoIdentidad)
        {
            return _appContext.Agentes.FirstOrDefault(a => a.DocumentoIdentidad == documentoIdentidad);
        }

        public Agente UpdateAgente(Agente agente)
        {
            var AgenteEncontrado = _appContext.Agentes.FirstOrDefault(a => a.IdAgente == agente.IdAgente);
            if(AgenteEncontrado != null){
                AgenteEncontrado.Nombres = agente.Nombres;
                AgenteEncontrado.Apellidos = agente.Apellidos;
                AgenteEncontrado.FechaRegistro = agente.FechaRegistro;
                AgenteEncontrado.IdAgente = agente.IdAgente;
                _appContext.SaveChanges();
            }
           return AgenteEncontrado;
        }
    }
}