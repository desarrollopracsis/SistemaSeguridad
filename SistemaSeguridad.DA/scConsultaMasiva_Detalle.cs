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
    
    public partial class scConsultaMasiva_Detalle
    {
        public int idcmDetalle { get; set; }
        public Nullable<int> idconsulta { get; set; }
        public string tipodoc { get; set; }
        public string numerodocumento { get; set; }
        public string apellido { get; set; }
        public string departamento { get; set; }
        public Nullable<int> idusuario { get; set; }
        public string producto { get; set; }
        public Nullable<int> numdecos { get; set; }
        public string provincia { get; set; }
        public string distrito { get; set; }
        public string score { get; set; }
        public string bancarizado { get; set; }
        public string error { get; set; }
        public string mensaje { get; set; }
    
        public virtual scConsultaMasiva scConsultaMasiva { get; set; }
    }
}
