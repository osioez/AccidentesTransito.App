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
            var agenteEncontrado = _appContext.Agente.FirstOrDefault(a => a.IdAgente == idAgente);
            if(agenteEncontrado == null){
                return;
            }
            _appContext.Remove(agenteEncontrado);
            _appContext.SaveChanges();
        }

        public IEnumerable<Agente> GetAllAgentes()
        {
            return _appContext.Agente;
        }

        public Agente GetAgente(int idAgente)
        {
            return _appContext.Agente.FirstOrDefault(a => a.IdAgente == idAgente);
        }

        public Agente UpdateAgente(Agente agente)
        {
            var AgenteEncontrado = _appContext.Agente.FirstOrDefault(a => a.IdAgente == agente.IdAgente);
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