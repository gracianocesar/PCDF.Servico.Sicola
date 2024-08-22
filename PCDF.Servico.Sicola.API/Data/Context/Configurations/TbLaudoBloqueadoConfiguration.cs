﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using PCDF.Servico.Sicola.API.Data.Context;
using PCDF.Servico.Sicola.API.Data.Data.Sicola;
using System;

namespace PCDF.Servico.Sicola.API.Data.Context.Configurations
{
    public partial class TbLaudoBloqueadoConfiguration : IEntityTypeConfiguration<TbLaudoBloqueado>
    {
        public void Configure(EntityTypeBuilder<TbLaudoBloqueado> entity)
        {
            entity.HasKey(e => e.CdLaudoBloqueado);

            entity.ToTable("tb_laudo_bloqueado", "dbo");

            entity.HasComment("Laudos com visualização bloqueada por algum usuário");

            entity.Property(e => e.CdLaudoBloqueado)
                .HasColumnName("cd_laudo_bloqueado")
                .HasComment("Chave primaria autoincremental. Código do registro do laudo que deverá ser bloqueada a visualização");

            entity.Property(e => e.CdExcluidor)
                .HasColumnName("cd_excluidor")
                .HasComment("Chave estrangeira na tabela tb_usuario. Código do usuário que excluiu o registro de bloqueio de visualização");

            entity.Property(e => e.CdIncluidor)
                .HasColumnName("cd_incluidor")
                .HasComment("Chave estrangeira na tabela tb_usuario. Código do usuário que solicitou o bloqueio da visualização do laudo");

            entity.Property(e => e.CdLaudo)
                .HasColumnName("cd_laudo")
                .HasComment("Chave estrangeira na tabela tb_laudo. Código do laudo com a visualização bloqueada");

            entity.Property(e => e.DtExclusao)
                .HasColumnType("datetime")
                .HasColumnName("dt_exclusao")
                .HasComment("Data da exclusão do registro de bloqueio da visualização");

            entity.Property(e => e.DtInclusao)
                .HasColumnType("datetime")
                .HasColumnName("dt_inclusao")
                .HasComment("Data do início do bloqueio da visualização do laudo");

            entity.Property(e => e.Excluido)
                .HasColumnName("excluido")
                .HasComment("Informa se o registro foi excluído");

            entity.Property(e => e.Motivo)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("motivo")
                .HasComment("Descrição do motivo do bloqueio da visualização do laudo, Será exibido aos usuários que tentarem ver o laudo.");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<TbLaudoBloqueado> entity);
    }
}
