﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using PCDF.Servico.Sicola.API.Data.Context;
using PCDF.Servico.Sicola.API.Data.Data.Sicola;
using System;

namespace PCDF.Servico.Sicola.API.Data.Context.Configurations
{
    public partial class VwDetranConfiguration : IEntityTypeConfiguration<VwDetran>
    {
        public void Configure(EntityTypeBuilder<VwDetran> entity)
        {
            entity.HasNoKey();

            entity.ToView("vw_detran", "dbo");

            entity.HasComment("Laudos cadavéricos com as causas jurídica e médica da morte, utilizada para estatística fornecida ao Detran.");

            entity.Property(e => e.AnoLaudo).HasColumnName("ano_laudo");

            entity.Property(e => e.AnoOcorrencia).HasColumnName("ano_ocorrencia");

            entity.Property(e => e.CausaJurDp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("causa_jur_dp");

            entity.Property(e => e.CausaJurPerito)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("causa_jur_perito");

            entity.Property(e => e.CdLaudo).HasColumnName("cd_laudo");

            entity.Property(e => e.DtLaudo)
                .HasColumnType("datetime")
                .HasColumnName("dt_laudo");

            entity.Property(e => e.DtNascimento)
                .HasColumnType("datetime")
                .HasColumnName("dt_nascimento");

            entity.Property(e => e.NmCausaMedica)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nm_causa_medica");

            entity.Property(e => e.NmDocumento)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nm_documento");

            entity.Property(e => e.NmInstrumento)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("nm_instrumento");

            entity.Property(e => e.NmOrgaoOcorrencia)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("nm_orgao_ocorrencia");

            entity.Property(e => e.NmPericiando)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("nm_periciando");

            entity.Property(e => e.NmSexo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nm_sexo");

            entity.Property(e => e.NrDeclaracao).HasColumnName("nr_declaracao");

            entity.Property(e => e.NrDocumento)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nr_documento");

            entity.Property(e => e.NrLaudo).HasColumnName("nr_laudo");

            entity.Property(e => e.NrOcorrencia).HasColumnName("nr_ocorrencia");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<VwDetran> entity);
    }
}
