﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using PCDF.Servico.Sicola.API.Data.Context;
using PCDF.Servico.Sicola.API.Data.Data.Sicola;
using System;

namespace PCDF.Servico.Sicola.API.Data.Context.Configurations
{
    public partial class TbEstatErroConfiguration : IEntityTypeConfiguration<TbEstatErro>
    {
        public void Configure(EntityTypeBuilder<TbEstatErro> entity)
        {
            entity.HasKey(e => e.CdEstatErro);

            entity.ToTable("tb_estat_erro", "dbo");

            entity.HasComment("Estatística de erros em laudos pelos servidores da recepção do IML");

            entity.Property(e => e.CdEstatErro)
                .HasColumnName("cd_estat_erro")
                .HasComment("Chave primaria autoincremental. Código do registro do erro cometido pelo servidor da recepção");

            entity.Property(e => e.CdHomologou)
                .HasColumnName("cd_homologou")
                .HasComment("Chave estrangeira na tabela tb_usuario. Código do usuário da SAPE que detectou o erro no laudo");

            entity.Property(e => e.CdIncluidor)
                .HasColumnName("cd_incluidor")
                .HasComment("Chave estrangeira na tabela tb_usuario. Código do usuário da recepção que cometeu o erro no laudo");

            entity.Property(e => e.CdLaudo)
                .HasColumnName("cd_laudo")
                .HasComment("Chave estrangeira na tabela tb_laudo. Código do documento (laudo ou relatório) onde foi detectado o erro");

            entity.Property(e => e.DtIncluiu)
                .HasColumnType("datetime")
                .HasColumnName("dt_incluiu")
                .HasComment("Data do registro do erro detectado no laudo");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<TbEstatErro> entity);
    }
}
