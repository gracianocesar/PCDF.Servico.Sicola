﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using PCDF.Servico.Sicola.API.Data.Context;
using PCDF.Servico.Sicola.API.Data.Data.Sicola;
using System;

namespace PCDF.Servico.Sicola.API.Data.Context.Configurations
{
    public partial class VwInformaticaConfiguration : IEntityTypeConfiguration<VwInformatica>
    {
        public void Configure(EntityTypeBuilder<VwInformatica> entity)
        {
            entity.HasNoKey();

            entity.ToView("vw_informatica", "dbo");

            entity.HasComment("Esta consulta não é utilizada no SICOLA");

            entity.Property(e => e.CdOrgaoLotacao).HasColumnName("cd_orgao_lotacao");

            entity.Property(e => e.Descrição)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESCRIÇÃO")
                .IsFixedLength(true);

            entity.Property(e => e.DtBaixa)
                .HasColumnType("datetime")
                .HasColumnName("dt_baixa");

            entity.Property(e => e.NmSecaoLotacao)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nm_secao_lotacao")
                .IsFixedLength(true);

            entity.Property(e => e.NrSerie)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NR SERIE")
                .IsFixedLength(true);

            entity.Property(e => e.Tombamento)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("tombamento")
                .IsFixedLength(true);

            entity.Property(e => e.Tp).HasColumnName("tp");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<VwInformatica> entity);
    }
}
