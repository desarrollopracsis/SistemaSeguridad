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
        public List<AplicacionesBE> ObtenerAplicaciones()
        {
            return oAplicacionesDA.ObtenerAplicaciones();
        }
    }
}
