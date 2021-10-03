using System;
namespace AccidentesTransito.App.Dominio
{
     public class Peaton:IPersona
    {
        public int Id {get;set;}
        public int DocumentoIdentidad {get;set;}
        public String Nombres {get;set;}
        public String Apellidos {get;set;}
        public bool PresentaDiscapacidad {get; set;}
/*
        public Peaton(int documentoIdentidad, String nombres, String apellidos, bool presentaDiscapacidad){
            DocumentoIdentidad = documentoIdentidad;
            Nombres = nombres;
            Apellidos = apellidos;
            PresentaDiscapacidad = presentaDiscapacidad;
        }*/
        
    }
}