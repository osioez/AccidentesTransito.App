using System.Collections.Generic;
using AccidentesTransito.App.Dominio;

namespace AccidentesTransito.App.Persistencia
{
    public interface IRepositorioPeaton
    {
        IEnumerable<Peaton> GetAllPeatones();
        Peaton AddPeaton(Peaton peaton);
        Peaton UpdatePeaton (Peaton peaton);
        void DeletePeaton (int idPeaton);
        Peaton GetPeaton (int idPeaton);
    }
}