using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modelo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Infra.Data.Mapping
{
    public class TipoCampoMap : IEntityTypeConfiguration<TipoCampo>
    {
        public void Configure(EntityTypeBuilder<TipoCampo> builder)
        {
            builder.ToTable("TipoCampo");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.descricao);
        }
    }
}
