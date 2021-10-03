using System;
using AccidentesTransito.App.Dominio;
using AccidentesTransito.App.Persistencia;

namespace AccidentesTransito.App.Consola
{
    class Program
    {
        private static IRepositorioPeaton _repositorioPeaton = new RepositorioPeaton(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //AddPeaton();
            BuscarPeaton(1);
        }

        private static void AddPeaton()
        {
            var peaton = new Peaton
            {
                DocumentoIdentidad = 1033333333,
                Nombres = "Sergio",
                Apellidos = "Perez",
                PresentaDiscapacidad = false
            };

            _repositorioPeaton.AddPeaton(peaton);
        }

        private static void BuscarPeaton(int idPeaton)
        {
            var peaton = _repositorioPeaton.GetPeaton(idPeaton);
            Console.WriteLine(peaton.Nombres + " " + peaton.Apellidos);
        }

    }
    
}
