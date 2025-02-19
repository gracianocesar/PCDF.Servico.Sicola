﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using PCDF.Servico.Sicola.API.Data.Context;
using PCDF.Servico.Sicola.API.Data.Data.Sicola;
using System;

namespace PCDF.Servico.Sicola.API.Data.Context.Configurations
{
    public partial class TbProfissaoConfiguration : IEntityTypeConfiguration<TbProfissao>
    {
        public void Configure(EntityTypeBuilder<TbProfissao> entity)
        {
            entity.HasKey(e => e.CdProfissao);

            entity.ToTable("tb_profissao", "dbo");

            entity.HasComment("Tabela básica de profissões");

            entity.Property(e => e.CdProfissao)
                .HasColumnName("cd_profissao")
                .HasComment("Chave primaria autoincremental. Código do registro da profissão");

            entity.Property(e => e.Cbo)
                .HasColumnName("cbo")
                .HasComment("Número da profissão no Código Brasileiro de Ocupações");

            entity.Property(e => e.Excluido)
                .HasColumnName("excluido")
                .HasComment("Informa se o registro foi excluído");

            entity.Property(e => e.NmProfissao)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nm_profissao")
                .HasComment("Descrição da profissão");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<TbProfissao> entity);
    }
}
