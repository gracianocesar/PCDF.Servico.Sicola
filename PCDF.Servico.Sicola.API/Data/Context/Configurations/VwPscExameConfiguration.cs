﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using PCDF.Servico.Sicola.API.Data.Context;
using PCDF.Servico.Sicola.API.Data.Data.Sicola;
using System;

namespace PCDF.Servico.Sicola.API.Data.Context.Configurations
{
    public partial class VwPscExameConfiguration : IEntityTypeConfiguration<VwPscExame>
    {
        public void Configure(EntityTypeBuilder<VwPscExame> entity)
        {
            entity.HasNoKey();

            entity.ToView("vw_psc_exame", "dbo");

            entity.HasComment("Agendamento de exames psicopatológicos de um paciente");

            entity.Property(e => e.AnoProtocolo).HasColumnName("ano_protocolo");

            entity.Property(e => e.CdExame)
                .ValueGeneratedOnAdd()
                .HasColumnName("cd_exame");

            entity.Property(e => e.CdExcluidor).HasColumnName("cd_excluidor");

            entity.Property(e => e.CdIncluidor).HasColumnName("cd_incluidor");

            entity.Property(e => e.CdLaudo).HasColumnName("cd_laudo");

            entity.Property(e => e.CdOrgaoDocumento).HasColumnName("cd_orgao_documento");

            entity.Property(e => e.CdPaciente).HasColumnName("cd_paciente");

            entity.Property(e => e.CdPerito).HasColumnName("cd_perito");

            entity.Property(e => e.CdTpDocumento).HasColumnName("cd_tp_documento");

            entity.Property(e => e.DocDevolvido)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("doc_devolvido");

            entity.Property(e => e.DtDevolvido)
                .HasColumnType("datetime")
                .HasColumnName("dt_devolvido");

            entity.Property(e => e.DtDocumento)
                .HasColumnType("datetime")
                .HasColumnName("dt_documento");

            entity.Property(e => e.DtExame)
                .HasColumnType("datetime")
                .HasColumnName("dt_exame");

            entity.Property(e => e.DtExclusao)
                .HasColumnType("datetime")
                .HasColumnName("dt_exclusao");

            entity.Property(e => e.DtInclusao)
                .HasColumnType("datetime")
                .HasColumnName("dt_inclusao");

            entity.Property(e => e.DtRecebidoDoc)
                .HasColumnType("datetime")
                .HasColumnName("dt_recebido_doc");

            entity.Property(e => e.Faltou).HasColumnName("faltou");

            entity.Property(e => e.NmPaciente)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nm_paciente");

            entity.Property(e => e.NmPerito)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nm_perito");

            entity.Property(e => e.NrDocumento)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nr_documento");

            entity.Property(e => e.NrProtocolo).HasColumnName("nr_protocolo");

            entity.Property(e => e.TipoExame).HasColumnName("tipo_exame");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<VwPscExame> entity);
    }
}
