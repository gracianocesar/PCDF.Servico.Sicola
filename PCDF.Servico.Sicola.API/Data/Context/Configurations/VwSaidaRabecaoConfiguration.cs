﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using PCDF.Servico.Sicola.API.Data.Context;
using PCDF.Servico.Sicola.API.Data.Data.Sicola;
using System;

namespace PCDF.Servico.Sicola.API.Data.Context.Configurations
{
    public partial class VwSaidaRabecaoConfiguration : IEntityTypeConfiguration<VwSaidaRabecao>
    {
        public void Configure(EntityTypeBuilder<VwSaidaRabecao> entity)
        {
            entity.HasNoKey();

            entity.ToView("vw_saida_rabecao", "dbo");

            entity.HasComment("Livro de controle de saídas do rabecão");

            entity.Property(e => e.AnoGuia).HasColumnName("ano_guia");

            entity.Property(e => e.AnoLaudo).HasColumnName("ano_laudo");

            entity.Property(e => e.AnoOcorrencia).HasColumnName("ano_ocorrencia");

            entity.Property(e => e.Causa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("causa");

            entity.Property(e => e.CdIncluidor).HasColumnName("cd_incluidor");

            entity.Property(e => e.CdLaudo).HasColumnName("cd_laudo");

            entity.Property(e => e.CdMotorista).HasColumnName("cd_motorista");

            entity.Property(e => e.CdOrgao).HasColumnName("cd_orgao");

            entity.Property(e => e.CdSaidaRabecao).HasColumnName("cd_saida_rabecao");

            entity.Property(e => e.CdSexo).HasColumnName("cd_sexo");

            entity.Property(e => e.CdViatura).HasColumnName("cd_viatura");

            entity.Property(e => e.DtChegada)
                .HasColumnType("datetime")
                .HasColumnName("dt_chegada");

            entity.Property(e => e.DtIc)
                .HasColumnType("datetime")
                .HasColumnName("dt_ic");

            entity.Property(e => e.DtInclusao)
                .HasColumnType("datetime")
                .HasColumnName("dt_inclusao");

            entity.Property(e => e.DtPedido)
                .HasColumnType("datetime")
                .HasColumnName("dt_pedido");

            entity.Property(e => e.DtSaida)
                .HasColumnType("datetime")
                .HasColumnName("dt_saida");

            entity.Property(e => e.Excluido).HasColumnName("excluido");

            entity.Property(e => e.Local)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("local");

            entity.Property(e => e.Marca)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("marca");

            entity.Property(e => e.NmExcluidor)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nm_excluidor");

            entity.Property(e => e.NmIncluidor)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nm_incluidor");

            entity.Property(e => e.NmMotorista)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nm_motorista");

            entity.Property(e => e.NmOrgao)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("nm_orgao");

            entity.Property(e => e.NmSexo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nm_sexo");

            entity.Property(e => e.NrGuia).HasColumnName("nr_guia");

            entity.Property(e => e.NrLaudo).HasColumnName("nr_laudo");

            entity.Property(e => e.NrOcorrencia).HasColumnName("nr_ocorrencia");

            entity.Property(e => e.Obs)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("obs");

            entity.Property(e => e.OperadorCiade)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("operador_ciade");

            entity.Property(e => e.OperadorIml)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("operador_iml");

            entity.Property(e => e.Periciando)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("periciando");

            entity.Property(e => e.Placa)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("placa");

            entity.Property(e => e.Prefixo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("prefixo");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<VwSaidaRabecao> entity);
    }
}
