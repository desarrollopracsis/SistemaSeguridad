using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SistemaSeguridad.BE
{
    public class AplicacionesBE {
        public int CodAplicacion { get; set; }
        public string Nombre { get; set; }
        public string FechaCreacion { get; set; }
        public string FechaImplementacion { get; set; }
        public int CodTipoAplicacion { get; set; }
        public string NombreTipoAplicacion { get; set; }
        public TiposAplicacionBE TipoAplicacion { get; set; }
    }
}
