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
    
    public partial class tbAplicaciones
    {
        public tbAplicaciones()
        {
            this.tbAplicacionesUsuario = new HashSet<tbAplicacionesUsuario>();
            this.tbOpciones = new HashSet<tbOpciones>();
            this.tbPerfiles = new HashSet<tbPerfiles>();
            this.tbProyectos = new HashSet<tbProyectos>();
        }
    
        public int CodAplicacion { get; set; }
        public string Nombre { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public System.DateTime FechaImplementacion { get; set; }
        public int CodTipoAplicacion { get; set; }
    
        public virtual tbTiposAplicacion tbTiposAplicacion { get; set; }
        public virtual ICollection<tbAplicacionesUsuario> tbAplicacionesUsuario { get; set; }
        public virtual ICollection<tbOpciones> tbOpciones { get; set; }
        public virtual ICollection<tbPerfiles> tbPerfiles { get; set; }
        public virtual ICollection<tbProyectos> tbProyectos { get; set; }
    }
}
