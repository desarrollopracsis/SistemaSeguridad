using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SistemaSeguridad.BL;
using SistemaSeguridad.BE;

namespace SistemaSeguridad.APP.Controllers
{
    public class AplicacionesController : Controller
    {
        //
        // GET: /Aplicacion/

        public ActionResult Index()
        {
            return View();
        }

        AplicacionesBL oAplicaciponesBL = new AplicacionesBL();
        TiposAplicacionBL oTiposAplicaciponBL = new TiposAplicacionBL();
        [HttpGet]
        public JsonResult ObtenerAplicaciones(string criterioBusqueda = "")
        {
            var oAplicacipones = oAplicaciponesBL.ObtenerAplicaciones(criterioBusqueda).OrderByDescending(x => x.CodAplicacion);
            var oTiposAplicacipon = oTiposAplicaciponBL.ObtenerTipoAplicaciones();

            return Json(new
            {
                Aplicaciones = oAplicacipones
                ,
                TiposAplicaciones = oTiposAplicacipon
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult ObtenerAplicacionPorCod(int nCodAplicacion)
        {
            var oAplicacion = oAplicaciponesBL.ObtenerAplicacionPorCod(nCodAplicacion);
            return Json(new { Aplicacion = oAplicacion }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult InsertarAplicacion(AplicacionesBE AplicacionesBE)
        {
          

            //AplicacionesBE oAplicacionesBE = new AplicacionesBE()
            //{
            //    CodAplicacion = CodAplicacion,
            //    Nombre = Nombre,
            //    FechaCreacion = FechaCreacion,
            //    FechaImplementacion = FechaImplementacion,
            //    CodTipoAplicacion = CodTipoAplicacion

            //};
            var response = oAplicaciponesBL.InsertarAplicacion(AplicacionesBE);

            return Json(response);
        }


        [HttpPost]
        public JsonResult ModificarAplicacion(AplicacionesBE AplicacionesBE)
        {

            var response = oAplicaciponesBL.ModificarAplicacion(AplicacionesBE);

            return Json(response);
        }

        [HttpPost]
        public JsonResult EliminarAplicacion(AplicacionesBE AplicacionesBE)
        {

            var response = oAplicaciponesBL.EliminarAplicacion(AplicacionesBE);

            return Json(response);
        }

    }
}
