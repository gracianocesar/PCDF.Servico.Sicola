﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using PCDF.Servico.Sicola.API.Data.Context;
using PCDF.Servico.Sicola.API.Data.Data.Sicola;
using System;

namespace PCDF.Servico.Sicola.API.Data.Context.Configurations
{
    public partial class VwSecaoLaudoConfiguration : IEntityTypeConfiguration<VwSecaoLaudo>
    {
        public void Configure(EntityTypeBuilder<VwSecaoLaudo> entity)
        {
            entity.HasNoKey();

            entity.ToView("vw_secao_laudo", "dbo");

            entity.HasComment("Seção (parte) dos laudos onde o legista digita as informações da perícia realizada");

            entity.Property(e => e.CdSecaoLaudo).HasColumnName("cd_secao_laudo");

            entity.Property(e => e.CdTpLaudo).HasColumnName("cd_tp_laudo");

            entity.Property(e => e.Excluido).HasColumnName("excluido");

            entity.Property(e => e.NmSecaoLaudo)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nm_secao_laudo");

            entity.Property(e => e.NmTpLaudo)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("nm_tp_laudo");

            entity.Property(e => e.Ordem).HasColumnName("ordem");

            entity.Property(e => e.TextoPadrao)
                .HasMaxLength(400)
                .IsUnicode(false)
                .HasColumnName("texto_padrao");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<VwSecaoLaudo> entity);
    }
}
