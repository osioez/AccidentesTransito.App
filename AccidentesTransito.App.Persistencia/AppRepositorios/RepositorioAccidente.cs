using System.Collections.Generic;
using AccidentesTransito.App.Dominio;
using System.Linq;

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

            var agenteEncontrado = _appContext.Agentes.Find(accidente.Agente.Id);
                peaton = peatonEncontrado;
            foreach(var peaton in accidente.Peatones){
                var peatonEncontrado = _appContext.Peatones.Find(peaton.Id);
                peaton = peatonEncontrado;
            }
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