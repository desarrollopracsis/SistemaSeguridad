//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaSeguridad.DA
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbAreas
    {
        public tbAreas()
        {
            this.tbAreas1 = new HashSet<tbAreas>();
            this.tbCargos = new HashSet<tbCargos>();
        }
    
        public int CodArea { get; set; }
        public string Nombre { get; set; }
        public Nullable<int> CodAreaSuperior { get; set; }
        public string Sigla { get; set; }
        public string NombreCorto { get; set; }
    
        public virtual ICollection<tbAreas> tbAreas1 { get; set; }
        public virtual tbAreas tbAreas2 { get; set; }
        public virtual ICollection<tbCargos> tbCargos { get; set; }
    }
}
