using System;
namespace AccidentesTransito.App.Dominio
{
 public class Agente:IPersona
    {
        public int Id {get;set;}
        public int DocumentoIdentidad {get;set;}
        public String Nombres {get;set;}
        public String Apellidos {get;set;}
        public int IdAgente {get;set;}
        public DateTime FechaRegistro {get;set;}
    }    
}

