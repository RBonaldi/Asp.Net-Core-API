using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modelo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Infra.Data.Mapping
{
    public class IdentificadorCadastroMap : IEntityTypeConfiguration<IdentificadorCadastro>
    {
        public void Configure(EntityTypeBuilder<IdentificadorCadastro> builder)
        {
            builder.ToTable("IdentificadorCadastro");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.criadoPor);

            builder.Property(c => c.alteradoPor);

            builder.Property(c => c.criadoEm);

            builder.Property(c => c.alteradoEm);
        }
    }
}
