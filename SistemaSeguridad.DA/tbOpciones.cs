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
    
    public partial class tbOpciones
    {
        public tbOpciones()
        {
            this.tbOpcionesPerfil = new HashSet<tbOpcionesPerfil>();
            this.tbSiteMap = new HashSet<tbSiteMap>();
        }
    
        public int CodOpcion { get; set; }
        public string Nombre { get; set; }
        public Nullable<int> CodAplicacion { get; set; }
        public Nullable<int> CodOpcionPadre { get; set; }
        public string URL { get; set; }
        public string description { get; set; }
        public string title { get; set; }
        public string icono { get; set; }
        public string jsfunction { get; set; }
    
        public virtual tbAplicaciones tbAplicaciones { get; set; }
        public virtual ICollection<tbOpcionesPerfil> tbOpcionesPerfil { get; set; }
        public virtual ICollection<tbSiteMap> tbSiteMap { get; set; }
    }
}
