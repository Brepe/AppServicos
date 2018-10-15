using AppService.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppService.Infrastructure.SQLServer.Configurations
{
    class FuncionarioConfiguration : IEntityTypeConfiguration<FuncionarioEntity>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<FuncionarioEntity> builder)
        {
            builder.ToTable("FUNCIONARIO"); // Aqui estamos dando nome a Tabela

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome)
                .HasColumnName("FNCO_FUNCIONARIO")
                .HasColumnType("varchar")
                .IsRequired();

            builder.Property(x => x.Email)
                .HasColumnName("FNCO_EMAIL") /// FNCO seria o minemonico da tabela FNCO = FUNCIONARIO
                .HasColumnType("varchar")
                .IsRequired();

            builder.Property(x => x.Senha)
                .HasColumnName("FNCO_SENHA")
                .HasColumnType("varchar")
                .IsRequired();
        }
    }
}
