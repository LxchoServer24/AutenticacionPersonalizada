﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AutenticacionPersonalizada.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class usrEntities3 : DbContext
    {
        public usrEntities3()
            : base("name=usrEntities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<cita> cita { get; set; }
        public virtual DbSet<pez> pez { get; set; }
        public virtual DbSet<TiposCitas> TiposCitas { get; set; }
        public virtual DbSet<usuario> usuario { get; set; }
    }
}