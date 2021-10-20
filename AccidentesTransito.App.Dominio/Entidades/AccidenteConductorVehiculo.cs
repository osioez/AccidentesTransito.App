using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccidentesTransito.App.Dominio
{
    public class AccidenteConductorVehiculo
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id {get; set;}
        public Accidente Accidente {get; set;}
        public Conductor Conductor {get; set;}
        public Vehiculo Vehiculo {get; set;}
    }
}