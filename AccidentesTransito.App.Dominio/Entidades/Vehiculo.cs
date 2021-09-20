using System;
namespace AccidentesTransito.App.Dominio
{
    public class Vehiculo
    {
        public int Id {get; set;}
        public int CapacidadPasajeros {get; set;}
        public string Marca {get; set;}
        public int Modelo {get; set;}
        public TipoVehiculo TipoVehiculo {get; set;}
        public string Placa {get; set;}
        public Conductor Conductor {get; set;}
        public bool CondutorEsPropietario {get; set;}
    }
}