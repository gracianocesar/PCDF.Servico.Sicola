﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using PCDF.Servico.Sicola.API.Data.Context;
using PCDF.Servico.Sicola.API.Data.Data.Sicola;
using System;

namespace PCDF.Servico.Sicola.API.Data.Context.Configurations
{
    public partial class VwTempTempoConclusaoLaudoVivoConfiguration : IEntityTypeConfiguration<VwTempTempoConclusaoLaudoVivo>
    {
        public void Configure(EntityTypeBuilder<VwTempTempoConclusaoLaudoVivo> entity)
        {
            entity.HasNoKey();

            entity.ToView("vw_temp_tempo_conclusao_laudo_vivo", "dbo");

            entity.HasComment("Esta consulta não é utilizada no SICOLA");

            entity.Property(e => e.AnoLaudo).HasColumnName("ano_laudo");

            entity.Property(e => e.Cancelado).HasColumnName("cancelado");

            entity.Property(e => e.CdTpLaudo).HasColumnName("cd_tp_laudo");

            entity.Property(e => e.DtHomologado)
                .HasColumnType("datetime")
                .HasColumnName("dt_homologado");

            entity.Property(e => e.DtLaudo)
                .HasColumnType("datetime")
                .HasColumnName("dt_laudo");

            entity.Property(e => e.NrLaudo).HasColumnName("nr_laudo");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<VwTempTempoConclusaoLaudoVivo> entity);
    }
}
