﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using PCDF.Servico.Sicola.API.Data.Context;
using PCDF.Servico.Sicola.API.Data.Data.Sicola;
using System;

namespace PCDF.Servico.Sicola.API.Data.Context.Configurations
{
    public partial class VwMensagemConfiguration : IEntityTypeConfiguration<VwMensagem>
    {
        public void Configure(EntityTypeBuilder<VwMensagem> entity)
        {
            entity.HasNoKey();

            entity.ToView("vw_mensagem", "dbo");

            entity.HasComment("Mensagens enviadas e recebidas entre usuários do sistema");

            entity.Property(e => e.Assunto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("assunto");

            entity.Property(e => e.CdDestinatario).HasColumnName("cd_destinatario");

            entity.Property(e => e.CdMensagem).HasColumnName("cd_mensagem");

            entity.Property(e => e.CdRemetente).HasColumnName("cd_remetente");

            entity.Property(e => e.DtMensagem)
                .HasColumnType("datetime")
                .HasColumnName("dt_mensagem");

            entity.Property(e => e.DtRecebimento)
                .HasColumnType("datetime")
                .HasColumnName("dt_recebimento");

            entity.Property(e => e.ExcluidoD).HasColumnName("excluido_d");

            entity.Property(e => e.ExcluidoR).HasColumnName("excluido_r");

            entity.Property(e => e.Mensagem)
                .HasColumnType("text")
                .HasColumnName("mensagem");

            entity.Property(e => e.NmDestinatario)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nm_destinatario");

            entity.Property(e => e.NmRemetente)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nm_remetente");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<VwMensagem> entity);
    }
}
