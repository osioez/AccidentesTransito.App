using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace AccidentesTransito.App.Dominio
{
     public class Peaton:IPersona
    {
        public int Id {get;set;}
        [Required (ErrorMessage = "Campo obligatorio"), StringLength(10)]
        public int DocumentoIdentidad {get;set;}
        [Required (ErrorMessage = "Campo obligatorio"), StringLength(50)]
        public String Nombres {get;set;}
        [Required (ErrorMessage = "Campo obligatorio"), StringLength(50)]
        public String Apellidos {get;set;}
        [Required (ErrorMessage = "Campo obligatorio"), StringLength(5)]
        public bool PresentaDiscapacidad {get; set;}
        public ICollection<Accidente> Accidentes {get; set;}
    }
}