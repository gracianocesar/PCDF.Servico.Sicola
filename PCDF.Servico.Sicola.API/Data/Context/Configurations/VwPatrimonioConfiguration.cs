﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using PCDF.Servico.Sicola.API.Data.Context;
using PCDF.Servico.Sicola.API.Data.Data.Sicola;
using System;

namespace PCDF.Servico.Sicola.API.Data.Context.Configurations
{
    public partial class VwPatrimonioConfiguration : IEntityTypeConfiguration<VwPatrimonio>
    {
        public void Configure(EntityTypeBuilder<VwPatrimonio> entity)
        {
            entity.HasNoKey();

            entity.ToView("vw_patrimonio", "dbo");

            entity.HasComment("Bens patrimoniais do IML");

            entity.Property(e => e.CdOrgaoLotacao).HasColumnName("cd_orgao_lotacao");

            entity.Property(e => e.CdPatrimonio).HasColumnName("cd_patrimonio");

            entity.Property(e => e.CdSecaoLotacao).HasColumnName("cd_secao_lotacao");

            entity.Property(e => e.CodigoDrm)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("codigo_drm");

            entity.Property(e => e.Documento)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("documento");

            entity.Property(e => e.DtBaixa)
                .HasColumnType("datetime")
                .HasColumnName("dt_baixa");

            entity.Property(e => e.DtInclusao)
                .HasColumnType("datetime")
                .HasColumnName("dt_inclusao");

            entity.Property(e => e.DtIncorporou)
                .HasColumnType("datetime")
                .HasColumnName("dt_incorporou");

            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estado");

            entity.Property(e => e.Excluido).HasColumnName("excluido");

            entity.Property(e => e.HrInclusao)
                .HasColumnType("datetime")
                .HasColumnName("hr_inclusao");

            entity.Property(e => e.NmOrgaoLotacao)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nm_orgao_lotacao");

            entity.Property(e => e.NmPatrimonio)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nm_patrimonio");

            entity.Property(e => e.NmSecaoLotacao)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nm_secao_lotacao");

            entity.Property(e => e.NmUsuario)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nm_usuario");

            entity.Property(e => e.NrSerie)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nr_serie");

            entity.Property(e => e.Tombamento)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("tombamento");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<VwPatrimonio> entity);
    }
}
