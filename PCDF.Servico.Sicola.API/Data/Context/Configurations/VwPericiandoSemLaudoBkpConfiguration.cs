﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using PCDF.Servico.Sicola.API.Data.Context;
using PCDF.Servico.Sicola.API.Data.Data.Sicola;
using System;

namespace PCDF.Servico.Sicola.API.Data.Context.Configurations
{
    public partial class VwPericiandoSemLaudoBkpConfiguration : IEntityTypeConfiguration<VwPericiandoSemLaudoBkp>
    {
        public void Configure(EntityTypeBuilder<VwPericiandoSemLaudoBkp> entity)
        {
            entity.HasNoKey();

            entity.ToView("vw_periciando_sem_laudo_bkp", "dbo");

            entity.HasComment("Esta consulta não é utilizada no SICOLA");

            entity.Property(e => e.AnoOcorrencia).HasColumnName("ano_ocorrencia");

            entity.Property(e => e.CdCidadeEndereco).HasColumnName("cd_cidade_endereco");

            entity.Property(e => e.CdCidadeNaturalidade).HasColumnName("cd_cidade_naturalidade");

            entity.Property(e => e.CdDestinatario).HasColumnName("cd_destinatario");

            entity.Property(e => e.CdEstadoCivil).HasColumnName("cd_estado_civil");

            entity.Property(e => e.CdIncluidor).HasColumnName("cd_incluidor");

            entity.Property(e => e.CdNacionalidade).HasColumnName("cd_nacionalidade");

            entity.Property(e => e.CdOrgaoExpedidor).HasColumnName("cd_orgao_expedidor");

            entity.Property(e => e.CdOrgaoOcorrencia).HasColumnName("cd_orgao_ocorrencia");

            entity.Property(e => e.CdPericiando).HasColumnName("cd_periciando");

            entity.Property(e => e.CdProfissao).HasColumnName("cd_profissao");

            entity.Property(e => e.CdSexo).HasColumnName("cd_sexo");

            entity.Property(e => e.CdTpDocumento).HasColumnName("cd_tp_documento");

            entity.Property(e => e.CdUfEndereco).HasColumnName("cd_uf_endereco");

            entity.Property(e => e.CdUfNaturalidade).HasColumnName("cd_uf_naturalidade");

            entity.Property(e => e.DtDocumento)
                .HasColumnType("datetime")
                .HasColumnName("dt_documento");

            entity.Property(e => e.DtInclusao)
                .HasColumnType("datetime")
                .HasColumnName("dt_inclusao");

            entity.Property(e => e.DtNascimento)
                .HasColumnType("datetime")
                .HasColumnName("dt_nascimento");

            entity.Property(e => e.Endereco)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("endereco");

            entity.Property(e => e.HrInclusao)
                .HasColumnType("datetime")
                .HasColumnName("hr_inclusao");

            entity.Property(e => e.NmMae)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nm_mae");

            entity.Property(e => e.NmPai)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nm_pai");

            entity.Property(e => e.NmPericiando)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nm_periciando");

            entity.Property(e => e.NrOcorrencia).HasColumnName("nr_ocorrencia");

            entity.Property(e => e.Rg)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RG");

            entity.Property(e => e.RgDono)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RG_dono");

            entity.Property(e => e.RgExpedidor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RG_expedidor");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<VwPericiandoSemLaudoBkp> entity);
    }
}
