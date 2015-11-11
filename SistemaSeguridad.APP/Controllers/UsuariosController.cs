using SistemaSeguridad.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaSeguridad.APP.Controllers
{
    public class UsuariosController : Controller
    {
        //
        // GET: /Usuarios/

        public ActionResult Index()
        {
            return View();
        }

        UsuariosBL oUsuariosBL = new UsuariosBL();
        CargosBL oCargosBL = new CargosBL();
        [HttpGet]
        public JsonResult ObtenerUsuarios()
        {
            var oUsuarios = oUsuariosBL.ObtenerAplicaciones();
            var oCargos = oCargosBL.ObtenerCargos();

            return Json(new
            {
                Usuarios = oUsuarios
                ,
                Cargos = oCargos
            }, JsonRequestBehavior.AllowGet);
        }


        public ActionResult Registro()
        {
            return View();
        }
    }
}
