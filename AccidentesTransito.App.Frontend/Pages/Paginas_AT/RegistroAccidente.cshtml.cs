using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AccidentesTransito.App.Dominio;
using AccidentesTransito.App.Persistencia;

namespace AccidentesTransito.App.Frontend.Pages
{
    public class RegistroAccidenteModel : PageModel
    {
        private readonly IRepositorioVehiculo repositorioVehiculo;
        private readonly IRepositorioPeaton repositorioPeaton;
        private readonly IRepositorioConductor repositorioConductor;
        private readonly IRepositorioAccidente repositorioAccidente;
        private readonly IRepositorioTipoVehiculo repositorioTipoVehiculo;
        private readonly IRepositorioAgente repositorioAgente;
        private readonly IRepositorioTemporal repositorioTemporal;

        [BindProperty]
        public Vehiculo Vehiculo { get; set; }
        [BindProperty]
        public TipoVehiculo TipoVehiculo { get; set; }
        [BindProperty]
        public Accidente Accidente { get; set; }
        [BindProperty]
        public Conductor Conductor { get; set; }
        [BindProperty]
        public Peaton Peaton { get; set; }
        [BindProperty]
        public Agente Agente { get; set; }

        public IEnumerable<Vehiculo> Vehiculos { set; get; }

        public List<Vehiculo> VehiculosImplicados { set; get; }
        public List<Conductor> ConductoresImplicados { set; get; }
        public List<Peaton> PeatonesImplicados { set; get; }
        public List<AccidenteConductorVehiculo> AccidenteConductorVehiculoImplicados { set; get; }
        public RegistroAccidenteModel(IRepositorioTemporal repositorioTemporal)
        {
            this.repositorioVehiculo = new RepositorioVehiculo(new AccidentesTransito.App.Persistencia.AppContext());
            this.repositorioPeaton = new RepositorioPeaton(new AccidentesTransito.App.Persistencia.AppContext());
            this.repositorioConductor = new RepositorioConductor(new AccidentesTransito.App.Persistencia.AppContext());
            this.repositorioAccidente = new RepositorioAccidente(new AccidentesTransito.App.Persistencia.AppContext());
            this.repositorioTipoVehiculo = new RepositorioTipoVehiculo(new AccidentesTransito.App.Persistencia.AppContext());
            this.repositorioAgente = new RepositorioAgente(new AccidentesTransito.App.Persistencia.AppContext());
            this.repositorioTemporal = repositorioTemporal;
        }

        public void OnGet()
        {

        }
        public void OnPostAgregarVehiculoImplicado(string placaVehiculoImplicado)
        {

            //VehiculosImplicados = repositorioTemporal.ObtenerVehiculos();
            //ConductoresImplicados = repositorioTemporal.ObtenerConductores();
            AccidenteConductorVehiculoImplicados = repositorioTemporal.ObtenerAccidenteConductorVehiculo();
            PeatonesImplicados = repositorioTemporal.ObtenerPeatones();

            if (placaVehiculoImplicado != null)
            {
                placaVehiculoImplicado = placaVehiculoImplicado.ToUpper();
                if (!AccidenteConductorVehiculoImplicados.Exists(acv => acv.Vehiculo.Placa == placaVehiculoImplicado))
                {
                    Vehiculo nuevoVehiculosImplicado = repositorioVehiculo.GetVehiculo(placaVehiculoImplicado);
                    if (nuevoVehiculosImplicado != null)
                    {
                        var nuevoAccidenteConductorVehiculo = new AccidenteConductorVehiculo();
                        nuevoAccidenteConductorVehiculo.Vehiculo = nuevoVehiculosImplicado;
                        repositorioTemporal.AgregarAccidenteConductorVehiculo(nuevoAccidenteConductorVehiculo);
                        //repositorioTemporal.AgregarVehiculo(nuevoVehiculosImplicado);
                        //VehiculosImplicados.Add(nuevoVehiculosImplicado);
                    }
                }
            }
        }
        public IActionResult OnPostAgregarVehiculoNuevo()
        {/*
            if(!ModelState.IsValid)
                {
                    return Page();
                }*/
            AccidenteConductorVehiculoImplicados = repositorioTemporal.ObtenerAccidenteConductorVehiculo();
            PeatonesImplicados = repositorioTemporal.ObtenerPeatones();

                repositorioVehiculo.AddVehiculo(Vehiculo);
                return Page();
        }

        public void OnPostAgregarConductorImplicado(int cedulaConductorImplicado, string placaVehiculoAsociado)
        {

            AccidenteConductorVehiculoImplicados = repositorioTemporal.ObtenerAccidenteConductorVehiculo();
            PeatonesImplicados = repositorioTemporal.ObtenerPeatones();

            if (cedulaConductorImplicado != 0 
                && placaVehiculoAsociado != null 
                && AccidenteConductorVehiculoImplicados.Exists(acv => acv.Vehiculo.Placa == placaVehiculoAsociado.ToUpper()))
            {
                placaVehiculoAsociado = placaVehiculoAsociado.ToUpper();

            var conductorExiste = false;
            foreach(var acv in AccidenteConductorVehiculoImplicados){
                if (acv.Conductor != null){
                    if(acv.Conductor.DocumentoIdentidad == cedulaConductorImplicado){
                        conductorExiste = true;
                    }
                }
            }
                if(!conductorExiste){

                    Conductor nuevoConductorImplicado = repositorioConductor.GetConductor(cedulaConductorImplicado);
                    if (nuevoConductorImplicado != null)
                    {
                        repositorioTemporal.ActualizarAccidenteConductorVehiculo(nuevoConductorImplicado, placaVehiculoAsociado);
                    }
                }
            }
        }
        public IActionResult OnPostAgregarConductorNuevo()
        {
            AccidenteConductorVehiculoImplicados = repositorioTemporal.ObtenerAccidenteConductorVehiculo();
            PeatonesImplicados = repositorioTemporal.ObtenerPeatones();
            
            repositorioConductor.AddConductor(Conductor);
                return Page();
        }

        public void OnPostAgregarPeatonImplicado(int cedulaPeatonImplicado)
        {

            AccidenteConductorVehiculoImplicados = repositorioTemporal.ObtenerAccidenteConductorVehiculo();
            PeatonesImplicados = repositorioTemporal.ObtenerPeatones();

            if (cedulaPeatonImplicado != 0)
            {

                if (!PeatonesImplicados.Exists(p => p.DocumentoIdentidad == cedulaPeatonImplicado))
                {
                    Peaton nuevoPeatonImplicado = repositorioPeaton.GetPeaton(cedulaPeatonImplicado);
                    if (nuevoPeatonImplicado != null)
                    {
                        repositorioTemporal.AgregarPeaton(nuevoPeatonImplicado);
                        
                    }
                }
            }
        }
        public IActionResult OnPostAgregarPeatonNuevo()
        {
            AccidenteConductorVehiculoImplicados = repositorioTemporal.ObtenerAccidenteConductorVehiculo();
            PeatonesImplicados = repositorioTemporal.ObtenerPeatones();

            repositorioPeaton.AddPeaton(Peaton);
                return Page();
        }
        public void OnPostAgregarAccidente()
        {
            Accidente.Agente = repositorioAgente.GetAgente(Agente.DocumentoIdentidad);
            if(Accidente.Agente != null){

            Accidente.Peatones = repositorioTemporal.ObtenerPeatones();
            Accidente.AccidenteConductorVehiculo = repositorioTemporal.ObtenerAccidenteConductorVehiculo();
            repositorioAccidente.AddAccidente(Accidente);

            repositorioTemporal.LimpiarRepositorioTemporal();
            }


        }
    }
}
