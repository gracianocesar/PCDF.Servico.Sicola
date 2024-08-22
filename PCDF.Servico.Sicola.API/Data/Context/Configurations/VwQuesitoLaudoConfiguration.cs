﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using PCDF.Servico.Sicola.API.Data.Context;
using PCDF.Servico.Sicola.API.Data.Data.Sicola;
using System;

namespace PCDF.Servico.Sicola.API.Data.Context.Configurations
{
    public partial class VwQuesitoLaudoConfiguration : IEntityTypeConfiguration<VwQuesitoLaudo>
    {
        public void Configure(EntityTypeBuilder<VwQuesitoLaudo> entity)
        {
            entity.HasNoKey();

            entity.ToView("vw_quesito_laudo", "dbo");

            entity.HasComment("Quesitos dos laudos");

            entity.Property(e => e.CdQuesitoLaudo).HasColumnName("cd_quesito_laudo");

            entity.Property(e => e.CdTpLaudo).HasColumnName("cd_tp_laudo");

            entity.Property(e => e.Excluido).HasColumnName("excluido");

            entity.Property(e => e.NmQuesito)
                .HasMaxLength(400)
                .IsUnicode(false)
                .HasColumnName("nm_quesito");

            entity.Property(e => e.NmTpLaudo)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("nm_tp_laudo");

            entity.Property(e => e.Ordem).HasColumnName("ordem");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<VwQuesitoLaudo> entity);
    }
}
