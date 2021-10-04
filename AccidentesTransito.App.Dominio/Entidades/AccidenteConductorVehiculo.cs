using System;
using System.Collections.Generic;
namespace AccidentesTransito.App.Dominio
{
    public class AccidenteConductorVehiculo
    {
        public int Id {get; set;}
        public Accidente Accidente {get; set;}
        public Conductor Conductor {get; set;}
        public Vehiculo Vehiculo {get; set;}
    }
}