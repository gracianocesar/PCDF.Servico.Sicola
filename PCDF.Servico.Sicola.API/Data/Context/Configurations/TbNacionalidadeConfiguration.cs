﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using PCDF.Servico.Sicola.API.Data.Context;
using PCDF.Servico.Sicola.API.Data.Data.Sicola;
using System;

namespace PCDF.Servico.Sicola.API.Data.Context.Configurations
{
    public partial class TbNacionalidadeConfiguration : IEntityTypeConfiguration<TbNacionalidade>
    {
        public void Configure(EntityTypeBuilder<TbNacionalidade> entity)
        {
            entity.HasKey(e => e.CdNacionalidade);

            entity.ToTable("tb_nacionalidade", "dbo");

            entity.HasComment("Tabela básica com os países para registrar a nacionalidade dos periciandos");

            entity.Property(e => e.CdNacionalidade)
                .HasColumnName("cd_nacionalidade")
                .HasComment("Chave primaria autoincremental. Código do registro do país");

            entity.Property(e => e.Excluido)
                .HasColumnName("excluido")
                .HasComment("Informa se o registro foi excluído");

            entity.Property(e => e.NmNacionalidade)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nm_nacionalidade")
                .HasComment("Nome do país referente a nacionalidade do periciando");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<TbNacionalidade> entity);
    }
}
