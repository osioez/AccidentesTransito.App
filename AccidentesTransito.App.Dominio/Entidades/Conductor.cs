using System;
namespace AccidentesTransito.App.Dominio
{
     public class Conductor:IPersona
    {
        public int Id {get;set;}
        public int DocumentoIdentidad {get;set;}
        public String Nombres {get;set;}
        public String Apellidos {get;set;}
        public String TipoLicencia {get;set;}
        
    }    
}