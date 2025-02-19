﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using PCDF.Servico.Sicola.API.Data.Context;
using PCDF.Servico.Sicola.API.Data.Data.Sicola;
using System;

namespace PCDF.Servico.Sicola.API.Data.Context.Configurations
{
    public partial class VwDescarregaConfiguration : IEntityTypeConfiguration<VwDescarrega>
    {
        public void Configure(EntityTypeBuilder<VwDescarrega> entity)
        {
            entity.HasNoKey();

            entity.ToView("vw_descarrega", "dbo");

            entity.HasComment("Técnicos que auxiliaram no descarregamento de um cadáver");

            entity.Property(e => e.CdCadaver).HasColumnName("cd_cadaver");

            entity.Property(e => e.CdDescarrega).HasColumnName("cd_descarrega");

            entity.Property(e => e.CdDescarregou).HasColumnName("cd_descarregou");

            entity.Property(e => e.CdIncluidor).HasColumnName("cd_incluidor");

            entity.Property(e => e.DtInclusao)
                .HasColumnType("datetime")
                .HasColumnName("dt_inclusao");

            entity.Property(e => e.HrInclusao)
                .HasColumnType("datetime")
                .HasColumnName("hr_inclusao");

            entity.Property(e => e.NmDescarregou)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nm_descarregou");

            entity.Property(e => e.NmIncluidor)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nm_incluidor");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<VwDescarrega> entity);
    }
}
