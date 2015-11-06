using SistemaSeguridad.BE;
using SistemaSeguridad.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaSeguridad.APP.Controllers
{
    public class PerfilesController : Controller
    {
        //
        // GET: /Perfiles/
        public ActionResult Index()
        {
            return View();
        }
        PerfilesBL oPerfilesBL = new PerfilesBL();
        [HttpGet]
        public JsonResult ObtenerPerfiles()
        {
            var oPerfiles = oPerfilesBL.ObtenerPerfiles();
          
            return Json(new
            {
                Perfiles = oPerfiles
            }, JsonRequestBehavior.AllowGet);
        }
    }
}
