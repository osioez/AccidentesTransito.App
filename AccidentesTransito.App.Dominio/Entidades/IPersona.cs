using System;
namespace AccidentesTransito.App.Dominio
{
    public interface IPersona
    {
        int Id {get;set;}
        int DocumentoIdentidad {get;set;}
        String Nombres {get;set;}
        String Apellidos {get;set;}

    }
}

    
