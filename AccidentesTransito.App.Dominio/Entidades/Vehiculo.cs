using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccidentesTransito.App.Dominio
{
    public class Vehiculo
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id {get; set;}
        [Required (ErrorMessage = "Campo obligatorio")]
        public int CapacidadPasajeros {get; set;}
        [Required (ErrorMessage = "Campo obligatorio")]
        public string Marca {get; set;}
        [Required (ErrorMessage = "Campo obligatorio")]
        public int Modelo {get; set;}
        [ForeignKey("Category")]
        public int TipoVehiculoId {get; set;}
        public TipoVehiculo TipoVehiculo {get; set;}
        [Required (ErrorMessage = "Campo obligatorio")]
        public string Placa {get; set;}
    }
}