﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using PCDF.Servico.Sicola.API.Data.Context;
using PCDF.Servico.Sicola.API.Data.Data.Sicola;
using System;

namespace PCDF.Servico.Sicola.API.Data.Context.Configurations
{
    public partial class VwRespostaLaudoConfiguration : IEntityTypeConfiguration<VwRespostaLaudo>
    {
        public void Configure(EntityTypeBuilder<VwRespostaLaudo> entity)
        {
            entity.HasNoKey();

            entity.ToView("vw_resposta_laudo", "dbo");

            entity.HasComment("Esta consulta não é utilizada no SICOLA. Não foi criada no IML.");

            entity.Property(e => e.CodLaudo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("COD_LAUDO");

            entity.Property(e => e.CodOcorrenciaIml)
                .HasMaxLength(18)
                .IsUnicode(false)
                .HasColumnName("COD_OCORRENCIA_IML");

            entity.Property(e => e.LaudoToxicologico)
                .HasMaxLength(6000)
                .IsUnicode(false)
                .HasColumnName("laudo_toxicologico");

            entity.Property(e => e.NmMetodo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nm_metodo");

            entity.Property(e => e.NmResposta)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nm_resposta");

            entity.Property(e => e.NmSubstancia)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nm_substancia");

            entity.Property(e => e.NmSuspeita)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nm_suspeita");

            entity.Property(e => e.NrDeclaracao).HasColumnName("nr_declaracao");

            entity.Property(e => e.Quantitativo)
                .HasColumnType("decimal(7, 3)")
                .HasColumnName("quantitativo");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<VwRespostaLaudo> entity);
    }
}
