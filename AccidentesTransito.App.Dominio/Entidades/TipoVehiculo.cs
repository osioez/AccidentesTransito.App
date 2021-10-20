using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccidentesTransito.App.Dominio
{
     public class TipoVehiculo
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id {get;set;}
        public String Nombre {get;set;}
        
    }    
}