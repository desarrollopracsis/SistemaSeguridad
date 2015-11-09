using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SistemaSeguridad.BE;

namespace SistemaSeguridad.DA.Repositorio
{
    public class AplicacionesDA
    {
        bdSecurityEntities obdSecurityEntities = new bdSecurityEntities();
        public List<AplicacionesBE> ObtenerAplicaciones()
        {

            var consulta = from t1 in obdSecurityEntities.tbAplicaciones
                           select new
                           {
                               t1.CodAplicacion,
                               t1.Nombre,
                               t1.FechaCreacion,
                               t1.FechaImplementacion,
                               t1.CodTipoAplicacion
                           };
            return consulta.Select(i => new AplicacionesBE() { 
                CodAplicacion = i.CodAplicacion, Nombre = i.Nombre, FechaCreacion = i.FechaCreacion
                , FechaImplementacion = i.FechaImplementacion, CodTipoAplicacion = i.CodTipoAplicacion 
            }).ToList();
        }
    }
}
