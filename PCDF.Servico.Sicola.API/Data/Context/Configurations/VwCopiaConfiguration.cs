﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using PCDF.Servico.Sicola.API.Data.Context;
using PCDF.Servico.Sicola.API.Data.Data.Sicola;
using System;

namespace PCDF.Servico.Sicola.API.Data.Context.Configurations
{
    public partial class VwCopiaConfiguration : IEntityTypeConfiguration<VwCopia>
    {
        public void Configure(EntityTypeBuilder<VwCopia> entity)
        {
            entity.HasNoKey();

            entity.ToView("vw_copia", "dbo");

            entity.HasComment("Cópia de laudo fornecida para delegacia. Deixou de ser usado em 13/09/2016");

            entity.Property(e => e.Adt).HasColumnName("adt");

            entity.Property(e => e.AnoLaudo).HasColumnName("ano_laudo");

            entity.Property(e => e.CdCopia).HasColumnName("cd_copia");

            entity.Property(e => e.CdDestinatario).HasColumnName("cd_destinatario");

            entity.Property(e => e.CdEntregou).HasColumnName("cd_entregou");

            entity.Property(e => e.CdIncluiu).HasColumnName("cd_incluiu");

            entity.Property(e => e.CdLaudo).HasColumnName("cd_laudo");

            entity.Property(e => e.DtEntrega)
                .HasColumnType("datetime")
                .HasColumnName("dt_entrega");

            entity.Property(e => e.DtInclusao)
                .HasColumnType("datetime")
                .HasColumnName("dt_inclusao");

            entity.Property(e => e.NmDestinatario)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("nm_destinatario");

            entity.Property(e => e.NmDestinatarioCopia)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("nm_destinatario_copia");

            entity.Property(e => e.NmEntregou)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nm_entregou");

            entity.Property(e => e.NmIncluiu)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nm_incluiu");

            entity.Property(e => e.NmTpLaudo)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("nm_tp_laudo");

            entity.Property(e => e.NrLaudo).HasColumnName("nr_laudo");

            entity.Property(e => e.Obs)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("obs");

            entity.Property(e => e.Recebeu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("recebeu");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<VwCopia> entity);
    }
}
