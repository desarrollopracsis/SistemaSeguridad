using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SistemaSeguridad.DA.Repositorio;
using SistemaSeguridad.BE;

namespace SistemaSeguridad.BL
{
    public class AplicacionesBL
    {
        AplicacionesDA oAplicacionesDA = new AplicacionesDA();
        public List<AplicacionesBE> ObtenerAplicaciones(string criterioBusqueda = "")
        {
            return oAplicacionesDA.ObtenerAplicaciones(criterioBusqueda);
        }
        
        public AplicacionesBE ObtenerAplicacionPorCod(int CodAplicacion)
        {
            return oAplicacionesDA.ObtenerAplicacionPorCod(CodAplicacion);
        }

        public ResponseBE InsertarAplicacion(AplicacionesBE oAplicacionesBE)
        {
            var response = new ResponseBE();

            response = oAplicacionesDA.InsertarAplicacion(oAplicacionesBE);

            response.Mensaje = response.Estado ? "Se guardó la aplicación correctamente"
                                            : "NO se guardó la aplicación correctamente";
            return response;
        }




        public ResponseBE ModificarAplicacion(AplicacionesBE oAplicacionesBE)
        {
            var response = new ResponseBE();

            response = oAplicacionesDA.ModificarAplicacion(oAplicacionesBE);

            response.Mensaje = response.Estado ? "Se modificó la aplicación correctamente"
                                            : "NO se modificó la aplicación correctamente";
            return response;
        }

        public ResponseBE EliminarAplicacion(AplicacionesBE oAplicacionesBE)
        {
            var response = new ResponseBE();

            response = oAplicacionesDA.EliminarAplicacion(oAplicacionesBE);

            response.Mensaje = response.Estado ? "Se eliminó la aplicación correctamente"
                                            : "NO se eliminó la aplicación correctamente";
            return response;
        }

    }
}
