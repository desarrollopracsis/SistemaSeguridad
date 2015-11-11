using SistemaSeguridad.BE;
using SistemaSeguridad.DA.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaSeguridad.BL
{
   public class UsuariosBL
    {
       UsuariosDA oUsuariosDA = new UsuariosDA();
       public List<UsuariosBE> ObtenerAplicaciones()
        {
            return oUsuariosDA.ObtenerUsuarios();
        }
    }
}
