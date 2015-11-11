using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaSeguridad.BE
{
   public class CargosBE
    {
        public int CodCargo { get; set; }
        public string Nombre { get; set; }
        public Nullable<int> CodArea { get; set; }

        public virtual AreasBE tbAreas { get; set; }
    }
}
