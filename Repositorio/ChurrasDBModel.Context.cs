﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Repositorio
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ChurrasEntities : DbContext
    {
        public ChurrasEntities()
            : base("name=ChurrasEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Churra> Churras { get; set; }
        public virtual DbSet<Participante> Participantes { get; set; }
        public virtual DbSet<ControleTemperatura> ControleTemperaturas { get; set; }
    }
}
