﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using PCDF.Servico.Sicola.API.Data.Context;
using PCDF.Servico.Sicola.API.Data.Data.Sicola;
using System;

namespace PCDF.Servico.Sicola.API.Data.Context.Configurations
{
    public partial class TbDicionarioConfiguration : IEntityTypeConfiguration<TbDicionario>
    {
        public void Configure(EntityTypeBuilder<TbDicionario> entity)
        {
            entity.HasKey(e => e.CdPalavra);

            entity.ToTable("tb_dicionario", "dbo");

            entity.HasComment("Palavras da língua portuguesa para correção ortográfica dos documentos (laudos ou relatórios)");

            entity.Property(e => e.CdPalavra)
                .HasColumnName("cd_palavra")
                .HasComment("Chave primaria autoincremental. Código do registro da palavra");

            entity.Property(e => e.Incluidor)
                .HasColumnName("incluidor")
                .HasComment("Chave estrangeira na tabela tb_usuario. Código do usuário incluiu o registro");

            entity.Property(e => e.Palavra)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("palavra")
                .HasComment("Palavra da lingua portugues que será utilizada para verificar correção ortográfica nos laudos");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<TbDicionario> entity);
    }
}
