using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modelo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Infra.Data.Mapping
{
    public class CampoMap : IEntityTypeConfiguration<Campo>
    {
        public void Configure(EntityTypeBuilder<Campo> builder)
        {
            builder.ToTable("Campo");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.idGrupo);

            builder.Property(c => c.idTipoCampo);

            builder.Property(c => c.ordem);

            builder.Property(c => c.obrigatorio);

            builder.Property(c => c.descricao);

            builder.Property(c => c.mascara);

            builder.Property(c => c.fonte);
        }
    }
}