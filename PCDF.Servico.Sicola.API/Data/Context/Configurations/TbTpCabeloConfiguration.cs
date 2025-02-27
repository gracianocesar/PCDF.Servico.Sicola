﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using PCDF.Servico.Sicola.API.Data.Context;
using PCDF.Servico.Sicola.API.Data.Data.Sicola;
using System;

namespace PCDF.Servico.Sicola.API.Data.Context.Configurations
{
    public partial class TbTpCabeloConfiguration : IEntityTypeConfiguration<TbTpCabelo>
    {
        public void Configure(EntityTypeBuilder<TbTpCabelo> entity)
        {
            entity.HasKey(e => e.CdTpCabelo);

            entity.ToTable("tb_tp_cabelo", "dbo");

            entity.HasComment("Tabela básica de tipo de cabelo");

            entity.Property(e => e.CdTpCabelo)
                .HasColumnName("cd_tp_cabelo")
                .HasComment("Chave primaria autoincremental. Código do registro do tipo de cabelo");

            entity.Property(e => e.Excluido)
                .HasColumnName("excluido")
                .HasComment("Informa se o registro foi excluído");

            entity.Property(e => e.NmTpCabelo)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("nm_tp_cabelo")
                .HasComment("Descrição do tipo de cabelo");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<TbTpCabelo> entity);
    }
}
