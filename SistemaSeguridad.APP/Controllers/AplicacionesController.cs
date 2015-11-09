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
        [HttpGet]
        public JsonResult ObtenerAplicaciones()
        {
            var oAplicacipones = oAplicaciponesBL.ObtenerAplicaciones();

            return Json(new
            {
                Aplicaciones = oAplicacipones
            }, JsonRequestBehavior.AllowGet);
        }

    }
}
