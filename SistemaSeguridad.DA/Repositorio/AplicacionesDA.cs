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


        public List<AplicacionesBE> ObtenerAplicaciones(object criterioBusqueda = null)
        {
            string queryBusqueda = "";

            if (criterioBusqueda != null)
            {
                queryBusqueda = "  where t1.Nombre.Contains( string.Empty + criterioBusqueda)  ";
            }


            var consulta = from t1 in obdSecurityEntities.tbAplicaciones                                
                           let TipoAplicacion = t1.tbTiposAplicacion
                           
                           select new
                           {
                               t1.CodAplicacion,
                               t1.Nombre,
                               t1.FechaCreacion,
                               t1.FechaImplementacion,
                               t1.CodTipoAplicacion,
                               TipoAplicacion
                           };
            return consulta.Select(i => new AplicacionesBE()
            {
                CodAplicacion = i.CodAplicacion,
                Nombre = i.Nombre,
                FechaCreacion = i.FechaCreacion,
                FechaImplementacion = i.FechaImplementacion,
                CodTipoAplicacion = i.CodTipoAplicacion,
                NombreTipoAplicacion = i.TipoAplicacion.Nombre

            }).ToList();

        }

        public void InsertarAplicacion(AplicacionesBE oAplicacionBE)
        {
            try
            {
                tbAplicaciones otbAplicaciones = new tbAplicaciones()
                {
                    Nombre = oAplicacionBE.Nombre,
                    FechaCreacion = oAplicacionBE.FechaCreacion,
                    FechaImplementacion = oAplicacionBE.FechaImplementacion,
                    CodTipoAplicacion = oAplicacionBE.CodTipoAplicacion
                };

                obdSecurityEntities.tbAplicaciones.Add(otbAplicaciones);
                obdSecurityEntities.SaveChanges();
            }
            catch (Exception)
            {
                
                throw;
            }

        }
    }
}
