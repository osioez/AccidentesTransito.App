using System.Collections.Generic;
using AccidentesTransito.App.Dominio;

namespace AccidentesTransito.App.Persistencia
{
    public interface IRepositorioConductor
    {
        IEnumerable<Conductor> GetAllConductores();
        Conductor AddConductor(Conductor conductor);
        Conductor UpdateConductor (Conductor conductor);
        void DeleteConductor (int documentoIdentidad);
        Conductor GetConductor (int documentoIdentidad);
    }
}