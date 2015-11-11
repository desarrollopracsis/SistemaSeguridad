using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaSeguridad.BE
{
   public class AplicacionesUsuarioBE
    {
        public int CodUsuario { get; set; }
        public int CodAplicacion { get; set; }
        public string Login { get; set; }
        public string keyCheck { get; set; }

        public virtual AplicacionesBE tbAplicaciones { get; set; }
        public virtual UsuariosBE tbUsuarios { get; set; }
    }
}
