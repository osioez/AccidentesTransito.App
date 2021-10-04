using System.Collections.Generic;
using AccidentesTransito.App.Dominio;

namespace AccidentesTransito.App.Persistencia
{
    public interface IRepositorioAgente
    {
        IEnumerable<Agente> GetAllAgentes();
        Agente AddAgente(Agente agente);
        Agente UpdateAgente (Agente agente);
        void DeleteAgente (int idAgente);
        Agente GetAgente (int idAgente);
    }
}