﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using PCDF.Servico.Sicola.API.Data.Context;
using PCDF.Servico.Sicola.API.Data.Data.Sicola;
using System;

namespace PCDF.Servico.Sicola.API.Data.Context.Configurations
{
    public partial class TbCorCabeloConfiguration : IEntityTypeConfiguration<TbCorCabelo>
    {
        public void Configure(EntityTypeBuilder<TbCorCabelo> entity)
        {
            entity.HasKey(e => e.CdCorCabelo);

            entity.ToTable("tb_cor_cabelo", "dbo");

            entity.HasComment("Tabela básica com as possíveis cores de cabelo");

            entity.Property(e => e.CdCorCabelo)
                .HasColumnName("cd_cor_cabelo")
                .HasComment("Chave primaria autoincremental. Código da cor do cabelo");

            entity.Property(e => e.Excluido)
                .HasColumnName("excluido")
                .HasComment("Informa se o registro foi excluído");

            entity.Property(e => e.NmCorCabelo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nm_cor_cabelo")
                .HasComment("Descrição da cor do cabelo");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<TbCorCabelo> entity);
    }
}
