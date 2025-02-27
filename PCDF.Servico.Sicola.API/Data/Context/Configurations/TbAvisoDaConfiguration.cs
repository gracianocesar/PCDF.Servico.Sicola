﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using PCDF.Servico.Sicola.API.Data.Context;
using PCDF.Servico.Sicola.API.Data.Data.Sicola;
using System;

namespace PCDF.Servico.Sicola.API.Data.Context.Configurations
{
    public partial class TbAvisoDaConfiguration : IEntityTypeConfiguration<TbAvisoDa>
    {
        public void Configure(EntityTypeBuilder<TbAvisoDa> entity)
        {
            entity.HasKey(e => e.CdAviso)
                .HasName("PK_tb_aciso_da");

            entity.ToTable("tb_aviso_da", "dbo");

            entity.HasComment("Avisos feitos pela divisão administrativa do IML aos servidores do IML e demais usuários do SICOLA");

            entity.Property(e => e.CdAviso)
                .HasColumnName("cd_aviso")
                .HasComment("Chave primaria. Campo autoincremental. Código do aviso informativo");

            entity.Property(e => e.Aviso)
                .HasColumnType("text")
                .HasColumnName("aviso")
                .HasComment("Texto do aviso, é a redação do aviso/informativo que será exibido na página inicial do SICOLA");

            entity.Property(e => e.CorFonte)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("cor_fonte")
                .HasComment("Cor da fonte que será exibido o aviso");

            entity.Property(e => e.CorFundo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("cor_fundo")
                .HasComment("Cor do fundo que será exibido o aviso");

            entity.Property(e => e.DtFinal)
                .HasColumnType("datetime")
                .HasColumnName("dt_final")
                .HasComment("Data em que o aviso deixará de ser exibido na página inicial do SICOLA");

            entity.Property(e => e.DtInicio)
                .HasColumnType("datetime")
                .HasColumnName("dt_inicio")
                .HasComment("Data em que o aviso começará a ser exibido na página inicial do SICOLA");

            entity.Property(e => e.Excluido)
                .HasColumnName("excluido")
                .HasComment("Informa se o aviso foi excluído e não deverá ser exibido novamente.");

            entity.Property(e => e.PgInicial)
                .HasColumnName("pg_inicial")
                .HasComment("Informa se o aviso será exibido na página inicial do SICOLA");

            entity.Property(e => e.Popup)
                .HasColumnName("popup")
                .HasComment("Informa se o aviso será exibido em janela sobreposta (popup).");

            entity.Property(e => e.TamanhoFonte)
                .HasColumnName("tamanho_fonte")
                .HasComment("Tamanho da fonte que será exibido o aviso");

            entity.Property(e => e.Titulo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("titulo")
                .HasComment("Título do aviso - resumo do conteúdo do aviso/informativo. É exibido acima do texto do aviso.");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<TbAvisoDa> entity);
    }
}
