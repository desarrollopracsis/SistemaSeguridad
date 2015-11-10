using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SistemaSeguridad.BE;


namespace SistemaSeguridad.DA.Repositorio
{
    public class TiposAplicacionDA
    {
        bdSecurityEntities obdSecurityEntities = new bdSecurityEntities();
        public List<TiposAplicacionBE> ObtenerTipoAplicaciones()
        {

            var consulta = from t1 in obdSecurityEntities.tbTiposAplicacion                          
                           select new
                           {
                               t1.CodTipoAplicacion,
                               t1.Nombre
                           };
            return consulta.Select(i => new TiposAplicacionBE()
            {
                CodTipoAplicacion = i.CodTipoAplicacion,
                Nombre = i.Nombre
            }).ToList();

        }
    }
}
