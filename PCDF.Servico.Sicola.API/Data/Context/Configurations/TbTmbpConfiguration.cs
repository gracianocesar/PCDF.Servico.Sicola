﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using PCDF.Servico.Sicola.API.Data.Context;
using PCDF.Servico.Sicola.API.Data.Data.Sicola;
using System;

namespace PCDF.Servico.Sicola.API.Data.Context.Configurations
{
    public partial class TbTmbpConfiguration : IEntityTypeConfiguration<TbTmbp>
    {
        public void Configure(EntityTypeBuilder<TbTmbp> entity)
        {
            entity.HasKey(e => e.CdTmbp);

            entity.ToTable("tb_tmbp", "dbo");

            entity.HasComment("Termo de movimentação de bens patrimoniais. Documento para transferir um bem patrimonial de uma seção para outra");

            entity.Property(e => e.CdTmbp)
                .HasColumnName("cd_tmbp")
                .HasComment("Chave primaria autoincremental. Código do registro do TMBP");

            entity.Property(e => e.AnoTmbp)
                .HasColumnName("ano_tmbp")
                .HasComment("Ano do TMBP");

            entity.Property(e => e.CdCadastrador)
                .HasColumnName("cd_cadastrador")
                .HasComment("Chave estrangeira na tabela tb_usuario. Código do usuário que incluiu o TMBP");

            entity.Property(e => e.CdOrgaoLotacao)
                .HasColumnName("cd_orgao_lotacao")
                .HasComment("Órgão onde ficam as seções que estão envolvidas na movimentação do bem patrimonial");

            entity.Property(e => e.CdSecaoDestino)
                .HasColumnName("cd_secao_destino")
                .HasComment("Chave estrangeira na tabela tb_secao_lotacao. Código da seção de destino do bem patrimonial");

            entity.Property(e => e.CdSecaoOrigem)
                .HasColumnName("cd_secao_origem")
                .HasComment("Chave estrangeira na tabela tb_secao_lotacao. Código da seção de origem do bem patrimonial");

            entity.Property(e => e.CdUsuarioDestino)
                .HasColumnName("cd_usuario_destino")
                .HasComment("Chave estrangeira na tabela tb_usuario. Código do usuário que vai assinar pela seção de destino");

            entity.Property(e => e.CdUsuarioOrigem)
                .HasColumnName("cd_usuario_origem")
                .HasComment("Chave estrangeira na tabela tb_usuario. Código do usuário que vai assinar pela seção de origem");

            entity.Property(e => e.DtMovimento)
                .HasColumnType("datetime")
                .HasColumnName("dt_movimento")
                .HasComment("Data da movimentação do bem patrimonial entre as seções");

            entity.Property(e => e.ValorTmbp)
                .HasColumnName("valor_tmbp")
                .HasComment("Número sequencial do TMBP");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<TbTmbp> entity);
    }
}
