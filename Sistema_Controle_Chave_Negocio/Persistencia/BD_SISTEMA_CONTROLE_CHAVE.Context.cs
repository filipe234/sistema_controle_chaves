﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sistema_Controle_Chave_Negocio.Persistencia
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BD_SISTEMA_CONTROLE_CHAVE : DbContext
    {
        public BD_SISTEMA_CONTROLE_CHAVE()
            : base("name=BD_SISTEMA_CONTROLE_CHAVE")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Chave_BD> Chave_BDs { get; set; }
        public virtual DbSet<Funcionario_BD> Funcionario_BDs { get; set; }
        public virtual DbSet<Nivel_Operador_BD> Nivel_Operador_BDs { get; set; }
        public virtual DbSet<Operador_BD> Operador_BDs { get; set; }
        public virtual DbSet<Saida_Chave_BD> Saida_Chave_BDs { get; set; }
        public virtual DbSet<Setor_BD> Setor_BDs { get; set; }
        public virtual DbSet<Situacao_Chave_BD> Situacao_Chave_BDs { get; set; }
        public virtual DbSet<Tipo_Setor_BD> Tipo_Setor_BDs { get; set; }
        public virtual DbSet<Plantao_BD> Plantao_BDs { get; set; }
    }
}
