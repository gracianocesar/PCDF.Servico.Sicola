﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using PCDF.Servico.Sicola.API.Data.Context;
using PCDF.Servico.Sicola.API.Data.Data.Sicola;
using System;

namespace PCDF.Servico.Sicola.API.Data.Context.Configurations
{
    public partial class VwSaidaRabecaoEquipeConfiguration : IEntityTypeConfiguration<VwSaidaRabecaoEquipe>
    {
        public void Configure(EntityTypeBuilder<VwSaidaRabecaoEquipe> entity)
        {
            entity.HasNoKey();

            entity.ToView("vw_saida_rabecao_equipe", "dbo");

            entity.HasComment("Membro da equipe do rabecão que realizou a remoção do cadáver");

            entity.Property(e => e.CdEquipe).HasColumnName("cd_equipe");

            entity.Property(e => e.CdExcluidor).HasColumnName("cd_excluidor");

            entity.Property(e => e.CdIncluidor).HasColumnName("cd_incluidor");

            entity.Property(e => e.CdMembroEquipe).HasColumnName("cd_membro_equipe");

            entity.Property(e => e.CdSaidaRabecao).HasColumnName("cd_saida_rabecao");

            entity.Property(e => e.DtExclusao)
                .HasColumnType("datetime")
                .HasColumnName("dt_exclusao");

            entity.Property(e => e.DtInclusao)
                .HasColumnType("datetime")
                .HasColumnName("dt_inclusao");

            entity.Property(e => e.NmExcluidor)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nm_excluidor");

            entity.Property(e => e.NmIncluidor)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nm_incluidor");

            entity.Property(e => e.NmMembroEquipe)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nm_membro_equipe");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<VwSaidaRabecaoEquipe> entity);
    }
}
