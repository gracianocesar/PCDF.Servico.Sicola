﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using PCDF.Servico.Sicola.API.Data.Context;
using PCDF.Servico.Sicola.API.Data.Data.Sicola;
using System;

namespace PCDF.Servico.Sicola.API.Data.Context.Configurations
{
    public partial class TbMotoristaFunerariaConfiguration : IEntityTypeConfiguration<TbMotoristaFuneraria>
    {
        public void Configure(EntityTypeBuilder<TbMotoristaFuneraria> entity)
        {
            entity.HasKey(e => e.CdMotorista);

            entity.ToTable("tb_motorista_funeraria", "dbo");

            entity.HasComment("Cadastro de motoristas das funerárias");

            entity.Property(e => e.CdMotorista)
                .HasColumnName("cd_motorista")
                .HasComment("Chave primaria autoincremental. Código do registro do motorista da funerária");

            entity.Property(e => e.CdFuneraria)
                .HasColumnName("cd_funeraria")
                .HasComment("Chave estrangeira na tabela tb_funeraria. Código da funerária a qual pertence o motorista");

            entity.Property(e => e.CdIncluidor)
                .HasColumnName("cd_incluidor")
                .HasComment("Chave estrangeira na tabela tb_usuario. Código do usuário que incluiu o motorista");

            entity.Property(e => e.Cnh)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("cnh")
                .HasComment("Número da CNH do motorista da funerária");

            entity.Property(e => e.Cpf)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("cpf")
                .HasComment("Número do CPF do motorista da funerária");

            entity.Property(e => e.DtInclusao)
                .HasColumnType("datetime")
                .HasColumnName("dt_inclusao")
                .HasComment("Data da exclusão do registro");

            entity.Property(e => e.Excluido)
                .HasColumnName("excluido")
                .HasComment("Informa se o registro foi excluído");

            entity.Property(e => e.Imagem)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("imagem")
                .HasComment("Este campo não é utilizado");

            entity.Property(e => e.NmMotorista)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nm_motorista")
                .HasComment("Nome do motorista da funerária");

            entity.Property(e => e.Rg)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("rg")
                .HasComment("Número do RG do motorista da funerária");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<TbMotoristaFuneraria> entity);
    }
}
