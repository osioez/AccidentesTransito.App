using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccidentesTransito.App.Dominio
{
    public class AccidenteConductorVehiculo
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id {get; set;}
        [ForeignKey("Accidente")]
        public int AccidenteId {get; set;}
        public Accidente Accidente {get; set;}
        [ForeignKey("Conductor")]
        public int ConductorId {get; set;}
        public Conductor Conductor {get; set;}
        [ForeignKey("Vehiculo")]
        public int VehiculoId {get; set;}
        public Vehiculo Vehiculo {get; set;}
    }
}