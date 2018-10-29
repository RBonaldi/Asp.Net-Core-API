using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Modelo.Domain.Entities;
using Modelo.Infra.Data.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Infra.Data.Context
{
    public class SqlContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer("DATA SOURCE=bhz-sql-dev1;DATABASE=DsvMrvPodio;Integrated Security=SSPI");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Formulario>(new FormularioMap().Configure);
            modelBuilder.Entity<Grupo>(new GrupoMap().Configure);
            modelBuilder.Entity<TipoCampo>(new TipoCampoMap().Configure);
            modelBuilder.Entity<Campo>(new CampoMap().Configure);
            modelBuilder.Entity<IdentificadorCadastro>(new IdentificadorCadastroMap().Configure);
            modelBuilder.Entity<RegistroCadastro>(new RegistroCadastroMap().Configure);
        }
    }
}
