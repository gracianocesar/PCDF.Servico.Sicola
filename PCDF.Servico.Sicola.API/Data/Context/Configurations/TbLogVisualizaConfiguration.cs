﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using PCDF.Servico.Sicola.API.Data.Context;
using PCDF.Servico.Sicola.API.Data.Data.Sicola;
using System;

namespace PCDF.Servico.Sicola.API.Data.Context.Configurations
{
    public partial class TbLogVisualizaConfiguration : IEntityTypeConfiguration<TbLogVisualiza>
    {
        public void Configure(EntityTypeBuilder<TbLogVisualiza> entity)
        {
            entity.HasKey(e => e.CdLogVisualiza);

            entity.ToTable("tb_log_visualiza", "dbo");

            entity.HasComment("Visualizações dos documentos (laudos, relatório ou SVO)");

            entity.Property(e => e.CdLogVisualiza)
                .HasColumnName("cd_log_visualiza")
                .HasComment("Chave primaria autoincremental. Código do registro da visualização de um laudo");

            entity.Property(e => e.CdLaudo)
                .HasColumnName("cd_laudo")
                .HasComment("Chave estrangeira na tabela tb_laudo. Código do laudo que foi visualizado");

            entity.Property(e => e.CdUsuario)
                .HasColumnName("cd_usuario")
                .HasComment("Chave estrangeira na tabela tb_usuario. Código do usuário que visualizou o laudo");

            entity.Property(e => e.DtInclusao)
                .HasColumnType("datetime")
                .HasColumnName("dt_inclusao")
                .HasComment("Data da visualização do laudo pelo usuário");

            entity.Property(e => e.Ip)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ip")
                .HasComment("Identificação do computador utilizado para visualizar o laudo");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<TbLogVisualiza> entity);
    }
}
