﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using PCDF.Servico.Sicola.API.Data.Context;
using PCDF.Servico.Sicola.API.Data.Data.Sicola;
using System;

namespace PCDF.Servico.Sicola.API.Data.Context.Configurations
{
    public partial class VwTmbpExternoConfiguration : IEntityTypeConfiguration<VwTmbpExterno>
    {
        public void Configure(EntityTypeBuilder<VwTmbpExterno> entity)
        {
            entity.HasNoKey();

            entity.ToView("vw_tmbp_externo", "dbo");

            entity.HasComment("Termo de movimentação de bens patrimoniais externo (para fora do IML");

            entity.Property(e => e.AnoTmbp).HasColumnName("ano_tmbp");

            entity.Property(e => e.CdOrgaoDestino).HasColumnName("cd_orgao_destino");

            entity.Property(e => e.CdPatrimonio).HasColumnName("cd_patrimonio");

            entity.Property(e => e.CdSecaoOrigem).HasColumnName("cd_secao_origem");

            entity.Property(e => e.CdTmbp).HasColumnName("cd_tmbp");

            entity.Property(e => e.ChefeOrigem)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("chefe_origem");

            entity.Property(e => e.Destino)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.DtMovimento)
                .HasColumnType("datetime")
                .HasColumnName("dt_movimento");

            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estado");

            entity.Property(e => e.NmPatrimonio)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nm_patrimonio");

            entity.Property(e => e.Origem)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Tombamento)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("tombamento");

            entity.Property(e => e.ValorTmbp).HasColumnName("valor_tmbp");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<VwTmbpExterno> entity);
    }
}
