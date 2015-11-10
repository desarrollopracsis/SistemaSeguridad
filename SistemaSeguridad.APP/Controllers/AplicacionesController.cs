using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SistemaSeguridad.BL;

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
        public JsonResult ObtenerAplicaciones()
        {
            var oAplicacipones = oAplicaciponesBL.ObtenerAplicaciones();
            var oTiposAplicacipon = oTiposAplicaciponBL.ObtenerTipoAplicaciones();

            return Json(new
            {
                Aplicaciones = oAplicacipones
                ,
                TiposAplicaciones = oTiposAplicacipon
            }, JsonRequestBehavior.AllowGet);
        }

    }
}
