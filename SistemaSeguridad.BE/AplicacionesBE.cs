using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaSeguridad.BE
{
    public class AplicacionesBE
    {
        public int CodAplicacion { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaImplementacion { get; set; }
        public int CodTipoAplicacion { get; set; }
    }
}
