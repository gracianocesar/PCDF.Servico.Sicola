﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using PCDF.Servico.Sicola.API.Data.Context;
using PCDF.Servico.Sicola.API.Data.Data.Sicola;
using System;

namespace PCDF.Servico.Sicola.API.Data.Context.Configurations
{
    public partial class VwEtiquetaRuimConfiguration : IEntityTypeConfiguration<VwEtiquetaRuim>
    {
        public void Configure(EntityTypeBuilder<VwEtiquetaRuim> entity)
        {
            entity.HasNoKey();

            entity.ToView("vw_etiqueta_ruim", "dbo");

            entity.HasComment("Etiquetas da Central de Guarda e Custódia de Vestígio que foram danificadas dentro do IML");

            entity.Property(e => e.CdEtiqueta).HasColumnName("cd_etiqueta");

            entity.Property(e => e.CdExcluidor).HasColumnName("cd_excluidor");

            entity.Property(e => e.CdIncluidor).HasColumnName("cd_incluidor");

            entity.Property(e => e.CdMotivo).HasColumnName("cd_motivo");

            entity.Property(e => e.DtExclusao)
                .HasColumnType("datetime")
                .HasColumnName("dt_exclusao");

            entity.Property(e => e.DtInclusao)
                .HasColumnType("datetime")
                .HasColumnName("dt_inclusao");

            entity.Property(e => e.NmMotivo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nm_motivo");

            entity.Property(e => e.Numero).HasColumnName("numero");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<VwEtiquetaRuim> entity);
    }
}
