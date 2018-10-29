using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modelo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Infra.Data.Mapping
{
    public class FormularioMap : IEntityTypeConfiguration<Formulario>
    {
        public void Configure(EntityTypeBuilder<Formulario> builder)
        {
            builder.ToTable("Formulario");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.descricao)
                .IsRequired()
                .HasColumnName("descricao");
        }
    }
}
