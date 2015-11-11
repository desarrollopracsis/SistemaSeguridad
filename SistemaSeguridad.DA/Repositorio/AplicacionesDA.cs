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


        public List<AplicacionesBE> ObtenerAplicaciones(string criterioBusqueda = "")
        {

            List<AplicacionesBE> ListaAplicaciones = new List<AplicacionesBE>();


            var consulta = from t1 in obdSecurityEntities.tbAplicaciones
                           where  t1.Nombre.Contains(criterioBusqueda)
                           select new
                           {
                               t1.CodAplicacion,
                               t1.Nombre,
                               t1.FechaCreacion,
                               t1.FechaImplementacion,
                               t1.CodTipoAplicacion,
                           };

            foreach (var item in consulta)
            {
                AplicacionesBE aplicacion =  new AplicacionesBE();
               aplicacion.CodAplicacion = item.CodAplicacion;
                aplicacion.Nombre = item.Nombre;
                aplicacion.FechaCreacion = item.FechaCreacion.ToShortDateString();
                aplicacion.FechaImplementacion = item.FechaImplementacion.ToShortDateString();
                aplicacion.CodTipoAplicacion = item.CodTipoAplicacion;
                ListaAplicaciones.Add(aplicacion);
            }
            return ListaAplicaciones;

        }


        public List<AplicacionesBE> ObtenerAplicacionesPorFiltro(string criterioBusqueda = "")
        {


            List<AplicacionesBE> ListaAplicaciones = new List<AplicacionesBE>();


            var consulta = from t1 in obdSecurityEntities.tbAplicaciones 
                           where t1.Nombre.Contains(criterioBusqueda) 
                           select new
                           {
                               t1.CodAplicacion,
                               t1.Nombre,
                               t1.FechaCreacion,
                               t1.FechaImplementacion,
                               t1.CodTipoAplicacion
                           };

            foreach (var item in consulta)
            {
                AplicacionesBE aplicacion = new AplicacionesBE();
                aplicacion.CodAplicacion = item.CodAplicacion;
                aplicacion.Nombre = item.Nombre;
                aplicacion.FechaCreacion = item.FechaCreacion.ToShortDateString();
                aplicacion.FechaImplementacion = item.FechaImplementacion.ToShortDateString();
                aplicacion.CodTipoAplicacion = item.CodTipoAplicacion;                
                ListaAplicaciones.Add(aplicacion);
            }
            return ListaAplicaciones;

        }


        public AplicacionesBE ObtenerAplicacionPorCod(int CodAplicacion)
        {

            var oAplicacion = (from t1 in obdSecurityEntities.tbAplicaciones
                               where t1.CodAplicacion == CodAplicacion
                               select new
                               {
                                   t1.CodAplicacion,
                                   t1.Nombre,
                                   t1.FechaCreacion,
                                   t1.FechaImplementacion,
                                   t1.CodTipoAplicacion
                               }).FirstOrDefault();

            var oAplicacionesRetu = new AplicacionesBE();

            if (oAplicacion == null) return oAplicacionesRetu;

            oAplicacionesRetu.CodAplicacion = oAplicacion.CodAplicacion;
            oAplicacionesRetu.Nombre = oAplicacion.Nombre;
            oAplicacionesRetu.FechaCreacion = oAplicacion.FechaCreacion.ToShortDateString();
            oAplicacionesRetu.FechaImplementacion = oAplicacion.FechaImplementacion.ToShortDateString();
            oAplicacionesRetu.CodTipoAplicacion = oAplicacion.CodTipoAplicacion;
            return oAplicacionesRetu;
        }


        public ResponseBE InsertarAplicacion(AplicacionesBE oAplicacionBE)
        {
            var response = new ResponseBE();
            try
            {
                tbAplicaciones otbAplicaciones = new tbAplicaciones()
                {
                    Nombre = oAplicacionBE.Nombre,
                    FechaCreacion = DateTime.ParseExact(oAplicacionBE.FechaCreacion, "dd/MM/yyyy", null),
                    FechaImplementacion = DateTime.ParseExact(oAplicacionBE.FechaImplementacion, "dd/MM/yyyy", null),
                    CodTipoAplicacion = oAplicacionBE.CodTipoAplicacion
                };

                obdSecurityEntities.tbAplicaciones.Add(otbAplicaciones);
                obdSecurityEntities.SaveChanges();
                response.Codigo = otbAplicaciones.CodAplicacion;
                response.Estado = true;
            }
            catch (Exception ex)
            {
                response.Estado = false;
                response.Error = (ex.InnerException == null) ? ex.Message : ex.InnerException.Message;
                //throw;
            }

            return response;

        }

        public ResponseBE ModificarAplicacion(AplicacionesBE oAplicacionBE)
        {
            var response = new ResponseBE();
            try
            {


                var otbAplicaciones = obdSecurityEntities.tbAplicaciones.Where(x => x.CodAplicacion == oAplicacionBE.CodAplicacion).FirstOrDefault();

                otbAplicaciones.Nombre = oAplicacionBE.Nombre;
                otbAplicaciones.FechaCreacion = DateTime.ParseExact(oAplicacionBE.FechaCreacion, "dd/MM/yyyy", null);
                otbAplicaciones.FechaImplementacion = DateTime.ParseExact(oAplicacionBE.FechaImplementacion, "dd/MM/yyyy", null);
                otbAplicaciones.CodTipoAplicacion = oAplicacionBE.CodTipoAplicacion;

                obdSecurityEntities.SaveChanges();
                response.Codigo = otbAplicaciones.CodAplicacion;
                response.Estado = true;
            }
            catch (Exception ex)
            {
                response.Estado = false;
                response.Error = (ex.InnerException == null) ? ex.Message : ex.InnerException.Message;
                //throw;
            }

            return response;

        }

        public ResponseBE EliminarAplicacion(AplicacionesBE oAplicacionBE) {

            var response = new ResponseBE();
            try
            {
                var otbAplicaciones = obdSecurityEntities.tbAplicaciones.Where(x => x.CodAplicacion == oAplicacionBE.CodAplicacion).FirstOrDefault();
                obdSecurityEntities.tbAplicaciones.Remove(otbAplicaciones);
                obdSecurityEntities.SaveChanges();
                response.Estado = true;
            }
            catch (Exception ex)
            {
                response.Estado = false;
                response.Error = (ex.InnerException == null) ? ex.Message : ex.InnerException.Message;
               // throw;
            }
            return response;
        }

    }
}
