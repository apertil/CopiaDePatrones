﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PatronesDeDiseño
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PatronesEntities : DbContext
    {
        public PatronesEntities()
            : base("name=PatronesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AutorPatron> AutorPatron { get; set; }
        public virtual DbSet<Lanas> Lanas { get; set; }
        public virtual DbSet<Patrones> Patrones { get; set; }
        public virtual DbSet<Prendas> Prendas { get; set; }
        public virtual DbSet<TiposCaracteristicas> TiposCaracteristicas { get; set; }
        public virtual DbSet<TiposDeTejer> TiposDeTejer { get; set; }
        public virtual DbSet<GeneroEdad> GeneroEdad { get; set; }
        public virtual DbSet<Revistas> Revistas { get; set; }
    }
}
