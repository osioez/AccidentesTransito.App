using System.Collections.Generic;
using AccidentesTransito.App.Dominio;
using System.Linq;

namespace AccidentesTransito.App.Persistencia
{
    public class RepositorioPeaton : IRepositorioPeaton
    {
        private readonly AppContext _appContext;

        public RepositorioPeaton(AppContext appContext)
        {
            _appContext = appContext;
        }
        public Peaton AddPeaton(Peaton peaton)
        {
            var peatonAdicionado = _appContext.Add(peaton);
            _appContext.SaveChanges();
            return peatonAdicionado.Entity;
        }

        public void DeletePeaton(int idPeaton)
        {
            var peatonEncontrado = _appContext.Peatones.FirstOrDefault(p => p.Id == idPeaton);
            if(peatonEncontrado == null){
                return;
            }
            _appContext.Remove(peatonEncontrado);
            _appContext.SaveChanges();
        }

        public IEnumerable<Peaton> GetAllPeatones()
        {
            return _appContext.Peatones;
        }

        public Peaton GetPeaton(int documentoIdentidad)
        {
            return _appContext.Peatones.FirstOrDefault(p => p.DocumentoIdentidad == documentoIdentidad);
        }

        public Peaton UpdatePeaton(Peaton peaton)
        {
            var peatonEncontrado = _appContext.Peatones.FirstOrDefault(p => p.Id == peaton.Id);
            if(peatonEncontrado != null){
                peatonEncontrado.Nombres = peaton.Nombres;
                peatonEncontrado.Apellidos = peaton.Apellidos;
                peatonEncontrado.PresentaDiscapacidad = peaton.PresentaDiscapacidad;
                _appContext.SaveChanges();
            }
           return peatonEncontrado;
        }
    }
}