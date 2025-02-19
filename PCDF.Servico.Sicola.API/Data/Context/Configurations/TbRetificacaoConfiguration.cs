﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using PCDF.Servico.Sicola.API.Data.Context;
using PCDF.Servico.Sicola.API.Data.Data.Sicola;
using System;

namespace PCDF.Servico.Sicola.API.Data.Context.Configurations
{
    public partial class TbRetificacaoConfiguration : IEntityTypeConfiguration<TbRetificacao>
    {
        public void Configure(EntityTypeBuilder<TbRetificacao> entity)
        {
            entity.HasKey(e => e.CdRetificacao);

            entity.ToTable("tb_retificacao", "dbo");

            entity.HasComment("Esta tabela não é utilizada no SICOLA. Serviria para informar se um aditamento foi criado para alterar dados do periciando do laudo. Nunca foi implementado");

            entity.Property(e => e.CdRetificacao)
                .HasColumnName("cd_retificacao")
                .HasComment("Esta tabela não é utilizada no SICOLA");

            entity.Property(e => e.CdAditamento)
                .HasColumnName("cd_aditamento")
                .HasComment("Esta tabela não é utilizada no SICOLA");

            entity.Property(e => e.CdLaudo)
                .HasColumnName("cd_laudo")
                .HasComment("Esta tabela não é utilizada no SICOLA");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<TbRetificacao> entity);
    }
}
