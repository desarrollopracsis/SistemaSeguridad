using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SistemaSeguridad.BE;
using SistemaSeguridad.DA.Repositorio;

namespace SistemaSeguridad.BL
{
    public class TiposAplicacionBL
    {
        TiposAplicacionDA oTiposAplicacionDA = new TiposAplicacionDA();
        public List<TiposAplicacionBE> ObtenerTipoAplicaciones()
        {
            return oTiposAplicacionDA.ObtenerTipoAplicaciones();
        }
    }
}
