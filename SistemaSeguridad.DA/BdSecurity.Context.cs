﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class bdSecurityEntities : DbContext
    {
        public bdSecurityEntities()
            : base("name=bdSecurityEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<dtproperties> dtproperties { get; set; }
        public DbSet<scConsultaMasiva> scConsultaMasiva { get; set; }
        public DbSet<scParametroConfig> scParametroConfig { get; set; }
        public DbSet<sysdiagrams> sysdiagrams { get; set; }
        public DbSet<tbAccesoIBS> tbAccesoIBS { get; set; }
        public DbSet<tbAplicaciones> tbAplicaciones { get; set; }
        public DbSet<tbAplicacionesUsuario> tbAplicacionesUsuario { get; set; }
        public DbSet<tbAreas> tbAreas { get; set; }
        public DbSet<tbAuditorias> tbAuditorias { get; set; }
        public DbSet<tbCargos> tbCargos { get; set; }
        public DbSet<tbCompanias> tbCompanias { get; set; }
        public DbSet<tbDetallesAuditoria> tbDetallesAuditoria { get; set; }
        public DbSet<tbDocumentos> tbDocumentos { get; set; }
        public DbSet<tbEstados> tbEstados { get; set; }
        public DbSet<tbLogAcceso> tbLogAcceso { get; set; }
        public DbSet<tbOpciones> tbOpciones { get; set; }
        public DbSet<tbOpcionesPerfil> tbOpcionesPerfil { get; set; }
        public DbSet<tbPerfiles> tbPerfiles { get; set; }
        public DbSet<tbPerfilesUsuario> tbPerfilesUsuario { get; set; }
        public DbSet<tbProyectos> tbProyectos { get; set; }
        public DbSet<tbSiteMap> tbSiteMap { get; set; }
        public DbSet<tbTipoDocumentos> tbTipoDocumentos { get; set; }
        public DbSet<tbTiposAplicacion> tbTiposAplicacion { get; set; }
        public DbSet<tbTiposCompania> tbTiposCompania { get; set; }
        public DbSet<tbUsuarios> tbUsuarios { get; set; }
        public DbSet<scConsultaMasiva_Detalle> scConsultaMasiva_Detalle { get; set; }
        public DbSet<T1> T1 { get; set; }
        public DbSet<tbAmbientesAplicacion> tbAmbientesAplicacion { get; set; }
        public DbSet<tbDominioUnix> tbDominioUnix { get; set; }
        public DbSet<tbDominioWindows> tbDominioWindows { get; set; }
    }
}
