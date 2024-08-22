﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using PCDF.Servico.Sicola.API.Data.Context;
using PCDF.Servico.Sicola.API.Data.Data.Sicola;
using System;

namespace PCDF.Servico.Sicola.API.Data.Context.Configurations
{
    public partial class VwExamesLaboratoriaisConfiguration : IEntityTypeConfiguration<VwExamesLaboratoriais>
    {
        public void Configure(EntityTypeBuilder<VwExamesLaboratoriais> entity)
        {
            entity.HasNoKey();

            entity.ToView("vw_exames_laboratoriais", "dbo");

            entity.HasComment("Esta consulta não é utilizada no SICOLA");

            entity.Property(e => e.AnoLaudo).HasColumnName("ano_laudo");

            entity.Property(e => e.AnoOcorrencia).HasColumnName("ano_ocorrencia");

            entity.Property(e => e.Cancelado).HasColumnName("cancelado");

            entity.Property(e => e.CausaJuridica)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CAUSA_JURIDICA");

            entity.Property(e => e.CausaMedica)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CAUSA_MEDICA");

            entity.Property(e => e.CdLaudo).HasColumnName("cd_laudo");

            entity.Property(e => e.DtLaudo)
                .HasColumnType("datetime")
                .HasColumnName("dt_laudo");

            entity.Property(e => e.DtNascimento)
                .HasColumnType("datetime")
                .HasColumnName("dt_nascimento");

            entity.Property(e => e.Instrumento)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("INSTRUMENTO");

            entity.Property(e => e.NmMetodo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nm_metodo");

            entity.Property(e => e.NmPericiando)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nm_periciando");

            entity.Property(e => e.NmResposta)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nm_resposta");

            entity.Property(e => e.NmSexo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nm_sexo");

            entity.Property(e => e.NmSuspeita)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nm_suspeita");

            entity.Property(e => e.NrLaudo).HasColumnName("nr_laudo");

            entity.Property(e => e.NrOcorrencia).HasColumnName("nr_ocorrencia");

            entity.Property(e => e.Quantitativo)
                .HasColumnType("decimal(7, 3)")
                .HasColumnName("quantitativo");

            entity.Property(e => e.Solicitante)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("SOLICITANTE");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<VwExamesLaboratoriais> entity);
    }
}
