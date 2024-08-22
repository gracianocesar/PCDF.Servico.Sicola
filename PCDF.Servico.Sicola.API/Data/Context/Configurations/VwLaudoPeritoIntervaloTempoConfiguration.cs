﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using PCDF.Servico.Sicola.API.Data.Context;
using PCDF.Servico.Sicola.API.Data.Data.Sicola;
using System;

namespace PCDF.Servico.Sicola.API.Data.Context.Configurations
{
    public partial class VwLaudoPeritoIntervaloTempoConfiguration : IEntityTypeConfiguration<VwLaudoPeritoIntervaloTempo>
    {
        public void Configure(EntityTypeBuilder<VwLaudoPeritoIntervaloTempo> entity)
        {
            entity.HasNoKey();

            entity.ToView("vw_laudo_perito_intervalo_tempo", "dbo");

            entity.HasComment("Esta consulta não é utilizada no SICOLA");

            entity.Property(e => e.AnoLaudo).HasColumnName("ano_laudo");

            entity.Property(e => e.CdPerito1).HasColumnName("cd_perito1");

            entity.Property(e => e.DtInicio)
                .HasColumnType("datetime")
                .HasColumnName("dt_inicio");

            entity.Property(e => e.DtLaudo)
                .HasColumnType("datetime")
                .HasColumnName("dt_laudo");

            entity.Property(e => e.NrLaudo).HasColumnName("nr_laudo");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<VwLaudoPeritoIntervaloTempo> entity);
    }
}
