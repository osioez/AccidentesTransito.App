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
        public List<Vehiculo> Vehiculos {get; set;}
        public List<Peaton> Peatones {get; set;}
        public int CantidadLesionados {get; set;}
        public int CantidadFallecidos {get; set;}
        public string Descripcion {get; set;}

    }
}