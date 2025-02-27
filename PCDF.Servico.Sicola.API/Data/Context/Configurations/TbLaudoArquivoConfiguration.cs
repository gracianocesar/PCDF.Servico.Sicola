﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using PCDF.Servico.Sicola.API.Data.Context;
using PCDF.Servico.Sicola.API.Data.Data.Sicola;
using System;

namespace PCDF.Servico.Sicola.API.Data.Context.Configurations
{
    public partial class TbLaudoArquivoConfiguration : IEntityTypeConfiguration<TbLaudoArquivo>
    {
        public void Configure(EntityTypeBuilder<TbLaudoArquivo> entity)
        {
            entity.HasKey(e => e.CdLaudoArquivo);

            entity.ToTable("tb_laudo_arquivo", "dbo");

            entity.HasComment("Arquivos digitais anexados via upload a um determinado laudo. PDF JPG DOC XLS");

            entity.Property(e => e.CdLaudoArquivo)
                .HasColumnName("cd_laudo_arquivo")
                .HasComment("Chave primaria autoincremental. Código do registro do arquivo digital anexado ao laudo");

            entity.Property(e => e.CdExcluidor)
                .HasColumnName("cd_excluidor")
                .HasComment("Chave estrangeira na tabela tb_usuario. Código do usuário que excluiu o registro do arquivo digital anexado");

            entity.Property(e => e.CdIncluidor)
                .HasColumnName("cd_incluidor")
                .HasComment("Chave estrangeira na tabela tb_usuario. Código do usuário que anexou o arquivo digital ao laudo");

            entity.Property(e => e.CdLaudo)
                .HasColumnName("cd_laudo")
                .HasComment("Chave estrangeira na tabela tb_laudo. Código do laudo que está vinculado ao arquivo digital anexado");

            entity.Property(e => e.DtExclusao)
                .HasColumnType("datetime")
                .HasColumnName("dt_exclusao")
                .HasComment("Data da exclusão do registro do arquivo digital anexado. O arquivo gravado no HD não é excluído");

            entity.Property(e => e.DtInclusao)
                .HasColumnType("datetime")
                .HasColumnName("dt_inclusao")
                .HasComment("Data em que o arquivo digital foi anexado");

            entity.Property(e => e.Ip)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ip")
                .HasComment("Identificação do computador que originou o upload do arquivo digital");

            entity.Property(e => e.NmArquivo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nm_arquivo")
                .HasComment("Nome do arquivo gravado no HD na pasta ARQUIVOS");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<TbLaudoArquivo> entity);
    }
}
