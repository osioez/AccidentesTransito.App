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
            var AccidenteAdicionado = _appContext.Add(accidente);
            _appContext.SaveChanges();
            return AccidenteAdicionado.Entity;
        }

        public IEnumerable<Accidente> GetAllAccidentes()
        {
            return _appContext.Accidente;
        }

        public Accidente GetAccidente(int idAccidente)
        {
            return _appContext.Accidente.FirstOrDefault(a => a.Id == idAccidente);
        }

    }
}