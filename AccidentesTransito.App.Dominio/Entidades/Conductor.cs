using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccidentesTransito.App.Dominio
{
     public class Conductor:IPersona
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id {get;set;}
        [Required (ErrorMessage = "Campo obligatorio")]
        public int DocumentoIdentidad {get;set;}
        [Required (ErrorMessage = "Campo obligatorio"), StringLength(50)]
        public String Nombres {get;set;}
        [Required (ErrorMessage = "Campo obligatorio"), StringLength(50)]
        public String Apellidos {get;set;}
        [Required (ErrorMessage = "Campo obligatorio"), StringLength(50)]
        public String TipoLicencia {get;set;}
        
    }    
}