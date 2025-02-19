﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using PCDF.Servico.Sicola.API.Data.Context;
using PCDF.Servico.Sicola.API.Data.Data.Sicola;
using System;

namespace PCDF.Servico.Sicola.API.Data.Context.Configurations
{
    public partial class TbCautelarBloqueadoConfiguration : IEntityTypeConfiguration<TbCautelarBloqueado>
    {
        public void Configure(EntityTypeBuilder<TbCautelarBloqueado> entity)
        {
            entity.HasKey(e => e.CdCautelarBloqueado);

            entity.ToTable("tb_cautelar_bloqueado", "dbo");

            entity.HasComment("Laudos de lesão cautelar do tipo cautelar que estão com a visualização bloqueada até a homologação. Por padrão a visualização é liberada, exceto se estiver constando nesta tabela.");

            entity.Property(e => e.CdCautelarBloqueado)
                .HasColumnName("cd_cautelar_bloqueado")
                .HasComment("Chave primaria incremental. Código do registro de laudo cautelar de visualização bloqueada");

            entity.Property(e => e.CdExcluidor)
                .HasColumnName("cd_excluidor")
                .HasComment("Chave estrangeira na tabela tb_usuario. Código do usuário que excluiu o registro e liberou a visualização do laudo");

            entity.Property(e => e.CdLaudo)
                .HasColumnName("cd_laudo")
                .HasComment("Chave estrangeira na tabela tb_laudo. Código do laudo de lesões corporais do tipo cautelar que não pode ser visualizado até a homologação");

            entity.Property(e => e.CdUsuario)
                .HasColumnName("cd_usuario")
                .HasComment("Chave estrangeira na tabela tb_usuario. Código do usuário que solicitou o bloqueio da visualização do laudo");

            entity.Property(e => e.DtBloqueio)
                .HasColumnType("datetime")
                .HasColumnName("dt_bloqueio")
                .HasComment("Data da solicitação do bloqueio de visualização do laudo de lesões corporais do tipo cautelar");

            entity.Property(e => e.DtExclusao)
                .HasColumnType("datetime")
                .HasColumnName("dt_exclusao")
                .HasComment("Data da exclusão do registro e liberação da visualização do laudo");

            entity.Property(e => e.Excluido)
                .HasColumnName("excluido")
                .HasComment("Informa se o registro foi excluído");

            entity.Property(e => e.Motivo)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("motivo")
                .HasComment("Descrição do motivo do bloqueio da visualização do laudo");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<TbCautelarBloqueado> entity);
    }
}
