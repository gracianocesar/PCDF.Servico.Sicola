﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using PCDF.Servico.Sicola.API.Data.Context;
using PCDF.Servico.Sicola.API.Data.Data.Sicola;
using System;

namespace PCDF.Servico.Sicola.API.Data.Context.Configurations
{
    public partial class TbLogQuesitoConfiguration : IEntityTypeConfiguration<TbLogQuesito>
    {
        public void Configure(EntityTypeBuilder<TbLogQuesito> entity)
        {
            entity.HasKey(e => e.CdLogQuesito);

            entity.ToTable("tb_log_quesito", "dbo");

            entity.HasComment("Alterações nas respostas dos quesitos dos laudos");

            entity.Property(e => e.CdLogQuesito)
                .HasColumnName("cd_log_quesito")
                .HasComment("Chave primaria autoincremental. Código do registro da alteração na resposta do quesito do laudo");

            entity.Property(e => e.CdLaudo)
                .HasColumnName("cd_laudo")
                .HasComment("Chave estrangeira na tabela tb_laudo. Código do laudo cuja resposta do quesito foi alterada");

            entity.Property(e => e.CdQuesitoLaudo)
                .HasColumnName("cd_quesito_laudo")
                .HasComment("Chave estrangeira na tabela tb_quesito_laudo. Código do quesito que teve a resposta alterada");

            entity.Property(e => e.CdUsuario)
                .HasColumnName("cd_usuario")
                .HasComment("Chave estrangeira na tabela tb_usuario. Código do usuário (legista) que alterou a resposta do quesito");

            entity.Property(e => e.DtInclusao)
                .HasColumnType("datetime")
                .HasColumnName("dt_inclusao")
                .HasComment("Data da alteração da resposta do quesito do laudo");

            entity.Property(e => e.RespostaAntiga)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("resposta_antiga")
                .HasComment("Resposta do quesito antes da alteração");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<TbLogQuesito> entity);
    }
}
