﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using PCDF.Servico.Sicola.API.Data.Context;
using PCDF.Servico.Sicola.API.Data.Data.Sicola;
using System;

namespace PCDF.Servico.Sicola.API.Data.Context.Configurations
{
    public partial class VwAditamentosHomologadosPorHomologadorConfiguration : IEntityTypeConfiguration<VwAditamentosHomologadosPorHomologador>
    {
        public void Configure(EntityTypeBuilder<VwAditamentosHomologadosPorHomologador> entity)
        {
            entity.HasNoKey();

            entity.ToView("vw_aditamentos_homologados_por_homologador", "dbo");

            entity.HasComment("Esta consulta não é utilizada no SICOLA");

            entity.Property(e => e.DtHomologado)
                .HasColumnType("datetime")
                .HasColumnName("dt_homologado");

            entity.Property(e => e.NmHomologador)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nm_homologador");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<VwAditamentosHomologadosPorHomologador> entity);
    }
}
