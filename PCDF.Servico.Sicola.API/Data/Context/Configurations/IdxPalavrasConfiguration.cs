﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using PCDF.Servico.Sicola.API.Data.Context;
using PCDF.Servico.Sicola.API.Data.Data.Sicola;
using System;

namespace PCDF.Servico.Sicola.API.Data.Context.Configurations
{
    public partial class IdxPalavrasConfiguration : IEntityTypeConfiguration<IdxPalavras>
    {
        public void Configure(EntityTypeBuilder<IdxPalavras> entity)
        {
            entity.HasKey(e => new { e.IdPalavra, e.IdDoc, e.Secao, e.Deslocamento })
                .HasName("PK__IDX_Palavras__66EA454A");

            entity.ToTable("IDX_Palavras", "dbo");

            entity.HasIndex(e => e.IdDoc, "IDX_ID_DOC");

            entity.Property(e => e.IdPalavra).HasColumnName("ID_PALAVRA");

            entity.Property(e => e.IdDoc).HasColumnName("ID_DOC");

            entity.Property(e => e.Secao).HasColumnName("SECAO");

            entity.Property(e => e.Deslocamento).HasColumnName("DESLOCAMENTO");

            entity.Property(e => e.PosicaoFinal).HasColumnName("POSICAO_FINAL");

            entity.Property(e => e.PosicaoInicial).HasColumnName("POSICAO_INICIAL");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<IdxPalavras> entity);
    }
}
