using SistemaSeguridad.BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaSeguridad.DA.Repositorio
{
   public class UsuariosDA
    {
       bdSecurityEntities obdSecurityEntities = new bdSecurityEntities();

       public List<UsuariosBE> ObtenerUsuarios(object criterioBusqueda = null)
       {
           string queryBusqueda = "";

           if (criterioBusqueda != null)
           {
               //queryBusqueda = "  where t1.Nombre.Contains( string.Empty + criterioBusqueda)  ";
           }

           var consulta = from t1 in obdSecurityEntities.tbUsuarios
                          //let TipoAplicacion = t1.CodUsuariossssss

                          select new
                          {
                              t1.CodUsuario,
                              t1.Cedula,
                              t1.Nombres, t1.Apellidos,
                              t1.CodCargo
                          };
           return consulta.Select(i => new UsuariosBE()
           {
               CodUsuario = i.CodUsuario,
               Cedula = i.Cedula,
               Nombres = i.Nombres +  " "  +i.Apellidos,
               CodCargo = i.CodCargo
           }).ToList();

       }

    }
}
