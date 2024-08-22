﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using PCDF.Servico.Sicola.API.Data.Context;
using PCDF.Servico.Sicola.API.Data.Data.Sicola;
using System;

namespace PCDF.Servico.Sicola.API.Data.Context.Configurations
{
    public partial class VwFotoEntregueConfiguration : IEntityTypeConfiguration<VwFotoEntregue>
    {
        public void Configure(EntityTypeBuilder<VwFotoEntregue> entity)
        {
            entity.HasNoKey();

            entity.ToView("vw_foto_entregue", "dbo");

            entity.HasComment("Recibo de fotos impressas e entregues ao legista. Deixou de ser usado em 23/04/2014 pois as fotos passaram a ser em arquivo digital.");

            entity.Property(e => e.AnoLaudo).HasColumnName("ano_laudo");

            entity.Property(e => e.CdLaudo).HasColumnName("cd_laudo");

            entity.Property(e => e.DtEntrega)
                .HasColumnType("datetime")
                .HasColumnName("dt_entrega");

            entity.Property(e => e.DtInclusao)
                .HasColumnType("datetime")
                .HasColumnName("dt_inclusao");

            entity.Property(e => e.MtFotografo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mt_fotografo");

            entity.Property(e => e.NmFotografo)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nm_fotografo");

            entity.Property(e => e.NmOrgaoExpedidor)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("nm_orgao_expedidor");

            entity.Property(e => e.NmPericiando)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nm_periciando");

            entity.Property(e => e.NmPerito1)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nm_perito1");

            entity.Property(e => e.NmSexo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nm_sexo");

            entity.Property(e => e.NrDocumento)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nr_documento");

            entity.Property(e => e.NrLaudo).HasColumnName("nr_laudo");

            entity.Property(e => e.Obs)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("obs");

            entity.Property(e => e.Qtde).HasColumnName("qtde");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<VwFotoEntregue> entity);
    }
}
