using System;
using System.ComponentModel.DataAnnotations;
namespace AccidentesTransito.App.Dominio
{
     public class Conductor:IPersona
    {
        public int Id {get;set;}
        [Required (ErrorMessage = "Campo obligatorio"), StringLength(10)]
        public int DocumentoIdentidad {get;set;}
        [Required (ErrorMessage = "Campo obligatorio"), StringLength(50)]
        public String Nombres {get;set;}
        [Required (ErrorMessage = "Campo obligatorio"), StringLength(50)]
        public String Apellidos {get;set;}
        [Required (ErrorMessage = "Campo obligatorio"), StringLength(50)]
        public String TipoLicencia {get;set;}
        
    }    
}