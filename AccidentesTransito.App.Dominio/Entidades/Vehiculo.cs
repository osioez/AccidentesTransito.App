using System;
using System.ComponentModel.DataAnnotations;
namespace AccidentesTransito.App.Dominio
{
    public class Vehiculo
    {
        public int Id {get; set;}
        [Required (ErrorMessage = "Campo obligatorio"), StringLength(10)]
        public int CapacidadPasajeros {get; set;}
        [Required (ErrorMessage = "Campo obligatorio"), StringLength(30)]
        public string Marca {get; set;}
        [Required (ErrorMessage = "Campo obligatorio"), StringLength(30)]
        public int Modelo {get; set;}
        public TipoVehiculo TipoVehiculo {get; set;}
        [Required (ErrorMessage = "Campo obligatorio"), StringLength(15)]
        public string Placa {get; set;}
    }
}