﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using PCDF.Servico.Sicola.API.Data.Context;
using PCDF.Servico.Sicola.API.Data.Data.Sicola;
using System;

namespace PCDF.Servico.Sicola.API.Data.Context.Configurations
{
    public partial class VwToxicologicoTempoConclusaoConfiguration : IEntityTypeConfiguration<VwToxicologicoTempoConclusao>
    {
        public void Configure(EntityTypeBuilder<VwToxicologicoTempoConclusao> entity)
        {
            entity.HasNoKey();

            entity.ToView("vw_toxicologico_tempo_conclusao", "dbo");

            entity.HasComment("Esta consulta não é utilizada no SICOLA");

            entity.Property(e => e.DtInicio)
                .HasColumnType("datetime")
                .HasColumnName("dt_inicio");

            entity.Property(e => e.DtTermino)
                .HasColumnType("datetime")
                .HasColumnName("dt_termino");

            entity.Property(e => e.NmTpLaudo)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("nm_tp_laudo");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<VwToxicologicoTempoConclusao> entity);
    }
}
