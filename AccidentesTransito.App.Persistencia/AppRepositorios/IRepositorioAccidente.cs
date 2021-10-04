using System.Collections.Generic;
using AccidentesTransito.App.Dominio;

namespace AccidentesTransito.App.Persistencia
{
    public interface IRepositorioAccidente
    {
        IEnumerable<Accidente> GetAllAccidentes();
        Accidente AddAccidente(Accidente accidente);
        Accidente GetAccidente (int idAccidente);
    }
}