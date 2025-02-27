﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using PCDF.Servico.Sicola.API.Data.Context;
using PCDF.Servico.Sicola.API.Data.Data.Sicola;
using System;

namespace PCDF.Servico.Sicola.API.Data.Context.Configurations
{
    public partial class TbLaudoImportadoConfiguration : IEntityTypeConfiguration<TbLaudoImportado>
    {
        public void Configure(EntityTypeBuilder<TbLaudoImportado> entity)
        {
            entity.HasKey(e => e.CdLaudo);

            entity.ToTable("tb_laudo_importado", "dbo");

            entity.HasComment("Laudos cujos dados foram importados do sistema Millenium");

            entity.Property(e => e.CdLaudo)
                .ValueGeneratedNever()
                .HasColumnName("cd_laudo")
                .HasComment("Chave estrangeira na tabela tb_laudo. Código do laudo cujos dados foram importados da ocorrência policial");

            entity.Property(e => e.CdImportador)
                .HasColumnName("cd_importador")
                .HasComment("Chave estrangeira na tabela tb_usuario. Código do usuário que fez a importação dos dados da ocorrência");

            entity.Property(e => e.DtImportacao)
                .HasColumnType("datetime")
                .HasColumnName("dt_importacao")
                .HasComment("Data da importação dos dados da ocorrência para o laudo");

            entity.Property(e => e.HistoricoOcorrencia)
                .HasColumnType("text")
                .HasColumnName("historico_ocorrencia")
                .HasComment("Histórico da ocorrência policial");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<TbLaudoImportado> entity);
    }
}
