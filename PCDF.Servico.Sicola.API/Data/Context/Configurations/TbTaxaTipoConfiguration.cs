﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using PCDF.Servico.Sicola.API.Data.Context;
using PCDF.Servico.Sicola.API.Data.Data.Sicola;
using System;

namespace PCDF.Servico.Sicola.API.Data.Context.Configurations
{
    public partial class TbTaxaTipoConfiguration : IEntityTypeConfiguration<TbTaxaTipo>
    {
        public void Configure(EntityTypeBuilder<TbTaxaTipo> entity)
        {
            entity.HasKey(e => e.CdTipo);

            entity.ToTable("tb_taxa_tipo", "dbo");

            entity.HasComment("Tipo de parentesco ou autorização para o fornecimento da cópia do laudo ao solicitante");

            entity.Property(e => e.CdTipo)
                .HasColumnName("cd_tipo")
                .HasComment("Chave primaria autoincremental. Código do tipo de parentesco ou autorização");

            entity.Property(e => e.Excluido)
                .HasColumnName("excluido")
                .HasComment("Informa se o registro foi excluído");

            entity.Property(e => e.NmTipo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nm_tipo")
                .HasComment("Descrição do parentesco ou autorização para fornecimento da cópia do laudo");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<TbTaxaTipo> entity);
    }
}
