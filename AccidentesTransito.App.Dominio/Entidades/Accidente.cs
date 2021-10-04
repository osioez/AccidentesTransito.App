using System;
using System.Collections.Generic;
namespace AccidentesTransito.App.Dominio
{
    public class Accidente
    {
        public int Id {get; set;}
        public DateTime Fecha {get; set;}
        public Agente Agente {get;set;}
        public float GeoRreferenciaX {get; set;}
        public float GeoRreferenciaY {get; set;}
        public Barrio Barrio {get; set;}
        public ICollection<Peaton> Peatones {get; set;}
        public ICollection<AccidenteConductorVehiculo> AccidenteConductorVehiculo {get; set;}
        public int CantidadLesionados {get; set;}
        public int CantidadFallecidos {get; set;}
        public string Descripcion {get; set;}

    }
}