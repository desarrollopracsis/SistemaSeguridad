using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaSeguridad.BE
{
   public class AreasBE
    {
       public AreasBE()
        {
            this.tbAreas1 = new HashSet<AreasBE>();
            this.tbCargos = new HashSet<CargosBE>();
        }
    
        public int CodArea { get; set; }
        public string Nombre { get; set; }
        public Nullable<int> CodAreaSuperior { get; set; }
        public string Sigla { get; set; }
        public string NombreCorto { get; set; }

        public virtual ICollection<AreasBE> tbAreas1 { get; set; }
        public virtual AreasBE tbAreas2 { get; set; }
        public virtual ICollection<CargosBE> tbCargos { get; set; }
    }
}
