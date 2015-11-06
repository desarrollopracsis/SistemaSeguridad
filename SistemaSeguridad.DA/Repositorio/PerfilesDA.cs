using SistemaSeguridad.BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaSeguridad.DA.Repositorio
{
   public  class PerfilesDA
    {
       bdSecurityEntities obdSecurityEntities = new bdSecurityEntities();
       public List<PerfilesBE> ObtenerPerfiles()
       {
           
           var consulta = from t1 in obdSecurityEntities.tbPerfiles
                          select new
                          {
                              t1.CodAplicacion,
                              t1.CodPerfil,
                              t1.Nombre
                          };
           return consulta.Select(i => new PerfilesBE() { CodAplicacion = i.CodAplicacion, CodPerfil = i.CodPerfil, Nombre = i.Nombre }).ToList();
       }
    }
}
