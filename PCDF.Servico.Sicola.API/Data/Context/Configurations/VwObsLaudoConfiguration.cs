﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using PCDF.Servico.Sicola.API.Data.Context;
using PCDF.Servico.Sicola.API.Data.Data.Sicola;
using System;

namespace PCDF.Servico.Sicola.API.Data.Context.Configurations
{
    public partial class VwObsLaudoConfiguration : IEntityTypeConfiguration<VwObsLaudo>
    {
        public void Configure(EntityTypeBuilder<VwObsLaudo> entity)
        {
            entity.HasNoKey();

            entity.ToView("vw_obs_laudo", "dbo");

            entity.HasComment("Informações adicionais (observações) incluídas nos laudos.");

            entity.Property(e => e.CdExcluidor).HasColumnName("cd_excluidor");

            entity.Property(e => e.CdLaudo).HasColumnName("cd_laudo");

            entity.Property(e => e.CdObsLaudo)
                .ValueGeneratedOnAdd()
                .HasColumnName("cd_obs_laudo");

            entity.Property(e => e.CdUsuario).HasColumnName("cd_usuario");

            entity.Property(e => e.DtExclusao)
                .HasColumnType("datetime")
                .HasColumnName("dt_exclusao");

            entity.Property(e => e.DtObs)
                .HasColumnType("datetime")
                .HasColumnName("dt_obs");

            entity.Property(e => e.Imprime).HasColumnName("imprime");

            entity.Property(e => e.NmUsuario)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nm_usuario");

            entity.Property(e => e.Texto)
                .HasColumnType("text")
                .HasColumnName("texto");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<VwObsLaudo> entity);
    }
}
