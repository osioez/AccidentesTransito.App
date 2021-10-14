using System;
using System.ComponentModel.DataAnnotations;
namespace AccidentesTransito.App.Dominio

{
 public class Agente:IPersona
    {
        public int Id {get;set;}
        [Required (ErrorMessage = "Campo obligatorio"), StringLength(15)]
        public int DocumentoIdentidad {get;set;}
        [Required (ErrorMessage = "Campo obligatorio"), StringLength(50)]
        public String Nombres {get;set;}
        [Required (ErrorMessage = "Campo obligatorio"), StringLength(50)]
        public String Apellidos {get;set;}
        public int IdAgente {get;set;}
        public DateTime FechaRegistro {get;set;}
    }
}

