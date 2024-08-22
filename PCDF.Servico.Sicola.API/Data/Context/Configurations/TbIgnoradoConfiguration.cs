﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using PCDF.Servico.Sicola.API.Data.Context;
using PCDF.Servico.Sicola.API.Data.Data.Sicola;
using System;

namespace PCDF.Servico.Sicola.API.Data.Context.Configurations
{
    public partial class TbIgnoradoConfiguration : IEntityTypeConfiguration<TbIgnorado>
    {
        public void Configure(EntityTypeBuilder<TbIgnorado> entity)
        {
            entity.HasKey(e => e.CdIgnorado);

            entity.ToTable("tb_ignorado", "dbo");

            entity.HasComment("Laudos classificados como ignorados (periciandos sem identificação)");

            entity.Property(e => e.CdIgnorado)
                .HasColumnName("cd_ignorado")
                .HasComment("Chave primaria autoincremental. Código do registro do laudo classificado como ignorado");

            entity.Property(e => e.CdExcluidor)
                .HasColumnName("cd_excluidor")
                .HasComment("Chave estrangeira na tabela tb_usuario. Código do usuário que excluiu o registro que classificava o laudo como ignorado");

            entity.Property(e => e.CdIncluidor)
                .HasColumnName("cd_incluidor")
                .HasComment("Chave estrangeira na tabela tb_usuario. Código do usuário que classificou o laudo como sendo de uma pessoa ignorada");

            entity.Property(e => e.CdLaudo)
                .HasColumnName("cd_laudo")
                .HasComment("Chave estrangeira na tabela tb_laudo. Código do laudo classificado como sendo de uma pessoa ignorada");

            entity.Property(e => e.DtInclusao)
                .HasColumnType("datetime")
                .HasColumnName("dt_inclusao")
                .HasComment("Data em que o laudo foi classificado como ignorado pela seção de necrópsia");

            entity.Property(e => e.Excluido)
                .HasColumnName("excluido")
                .HasComment("Informa se o registro foi excluído");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<TbIgnorado> entity);
    }
}
