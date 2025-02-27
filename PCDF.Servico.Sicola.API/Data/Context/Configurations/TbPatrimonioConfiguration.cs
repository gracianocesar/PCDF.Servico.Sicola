﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using PCDF.Servico.Sicola.API.Data.Context;
using PCDF.Servico.Sicola.API.Data.Data.Sicola;
using System;

namespace PCDF.Servico.Sicola.API.Data.Context.Configurations
{
    public partial class TbPatrimonioConfiguration : IEntityTypeConfiguration<TbPatrimonio>
    {
        public void Configure(EntityTypeBuilder<TbPatrimonio> entity)
        {
            entity.HasKey(e => e.CdPatrimonio);

            entity.ToTable("tb_patrimonio", "dbo");

            entity.HasComment("Bens patrimoniais do IML");

            entity.Property(e => e.CdPatrimonio)
                .HasColumnName("cd_patrimonio")
                .HasComment("Chave primaria autoincremental. Código do registro do bem patrimonial");

            entity.Property(e => e.CdBaixador)
                .HasColumnName("cd_baixador")
                .HasComment("Chave estrangeira na tabela tb_usuario. Código do usuário que informou a saída do bem");

            entity.Property(e => e.CdIncluidor)
                .HasColumnName("cd_incluidor")
                .HasComment("Chave estrangeira na tabela tb_usuario. Código do usuário que incluiu o bem patrimonial");

            entity.Property(e => e.CdOrgaoLotacao)
                .HasColumnName("cd_orgao_lotacao")
                .HasComment("Chave estrangeira na tabela tb_orgao_lotacao. Código do órgão onde está o bem patrimonial (IML)");

            entity.Property(e => e.CdSecaoLotacao)
                .HasColumnName("cd_secao_lotacao")
                .HasComment("Chave estrangeira na tabela tb_secao_lotacao. Código da seção onde está o bem patrimonial");

            entity.Property(e => e.CodigoDrm)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("codigo_drm")
                .HasComment("Código do bem no sistema da DRM");

            entity.Property(e => e.Documento)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("documento")
                .HasComment("Documento que transferiu o bem para o órgão (IML)");

            entity.Property(e => e.DtBaixa)
                .HasColumnType("datetime")
                .HasColumnName("dt_baixa")
                .HasComment("Data da saída do bem patrimonial");

            entity.Property(e => e.DtInclusao)
                .HasColumnType("datetime")
                .HasColumnName("dt_inclusao")
                .HasComment("Data da inclusão do registro do bem patrimonial");

            entity.Property(e => e.DtIncorporou)
                .HasColumnType("datetime")
                .HasColumnName("dt_incorporou")
                .HasComment("Data que o bem chegou ao órgão");

            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estado")
                .HasComment("Estado de conservação do bem patrimonial");

            entity.Property(e => e.Excluido)
                .HasColumnName("excluido")
                .HasComment("Informa se o registro foi excluído");

            entity.Property(e => e.HrInclusao)
                .HasColumnType("datetime")
                .HasColumnName("hr_inclusao")
                .HasComment("Hora da inclusão do registro do bem patrimonial");

            entity.Property(e => e.NmPatrimonio)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nm_patrimonio")
                .HasComment("Nome do bem patrimonial");

            entity.Property(e => e.NrSerie)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nr_serie")
                .HasComment("Número do série do bem patrimonial");

            entity.Property(e => e.Tombamento)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("tombamento")
                .HasComment("Número do tombamento do bem patrimonial");

            entity.Property(e => e.Tp)
                .HasColumnName("tp")
                .HasComment("Este campo não está sendo utilizado");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<TbPatrimonio> entity);
    }
}
