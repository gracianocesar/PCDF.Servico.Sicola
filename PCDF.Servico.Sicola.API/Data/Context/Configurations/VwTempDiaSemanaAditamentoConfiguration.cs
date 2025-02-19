﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using PCDF.Servico.Sicola.API.Data.Context;
using PCDF.Servico.Sicola.API.Data.Data.Sicola;
using System;

namespace PCDF.Servico.Sicola.API.Data.Context.Configurations
{
    public partial class VwTempDiaSemanaAditamentoConfiguration : IEntityTypeConfiguration<VwTempDiaSemanaAditamento>
    {
        public void Configure(EntityTypeBuilder<VwTempDiaSemanaAditamento> entity)
        {
            entity.HasNoKey();

            entity.ToView("vw_temp_dia_semana_aditamento", "dbo");

            entity.HasComment("Esta consulta não é utilizada no SICOLA");

            entity.Property(e => e.CdAditamento).HasColumnName("cd_aditamento");

            entity.Property(e => e.DiaSemana)
                .HasMaxLength(30)
                .HasColumnName("Dia Semana");

            entity.Property(e => e.DtInclusao)
                .HasColumnType("datetime")
                .HasColumnName("dt_inclusao");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<VwTempDiaSemanaAditamento> entity);
    }
}
