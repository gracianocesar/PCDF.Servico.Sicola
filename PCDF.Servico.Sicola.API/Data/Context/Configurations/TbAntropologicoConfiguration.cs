﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using PCDF.Servico.Sicola.API.Data.Context;
using PCDF.Servico.Sicola.API.Data.Data.Sicola;
using System;

namespace PCDF.Servico.Sicola.API.Data.Context.Configurations
{
    public partial class TbAntropologicoConfiguration : IEntityTypeConfiguration<TbAntropologico>
    {
        public void Configure(EntityTypeBuilder<TbAntropologico> entity)
        {
            entity.HasKey(e => e.CdAntropologico);

            entity.ToTable("tb_antropologico", "dbo");

            entity.HasComment("Esta tabela informa se um laudo pertence à seção de antropologia forense.");

            entity.Property(e => e.CdAntropologico)
                .HasColumnName("cd_antropologico")
                .HasComment("Campo auto incremental. Código do registro.");

            entity.Property(e => e.CdLaudo)
                .HasColumnName("cd_laudo")
                .HasComment("Chave estrangeira na tabela tb_laudo. Código do documento que pertence à seção de antropologia.");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<TbAntropologico> entity);
    }
}
