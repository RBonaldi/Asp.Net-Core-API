using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modelo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Infra.Data.Mapping
{
    public class RegistroCadastroMap : IEntityTypeConfiguration<RegistroCadastro>
    {
        public void Configure(EntityTypeBuilder<RegistroCadastro> builder)
        {
            builder.ToTable("RegistroCadastro");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.idCampo);

            builder.Property(c => c.idIdentificadorCadastro);

            builder.Property(c => c.valor);
        }
    }
}
