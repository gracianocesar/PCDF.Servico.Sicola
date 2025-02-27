﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using PCDF.Servico.Sicola.API.Data.Context;
using PCDF.Servico.Sicola.API.Data.Data.Sicola;
using System;

namespace PCDF.Servico.Sicola.API.Data.Context.Configurations
{
    public partial class TbCausaJurPeritoConfiguration : IEntityTypeConfiguration<TbCausaJurPerito>
    {
        public void Configure(EntityTypeBuilder<TbCausaJurPerito> entity)
        {
            entity.HasKey(e => e.CdCausaJuridica);

            entity.ToTable("tb_causa_jur_perito", "dbo");

            entity.HasComment("Tabela de causas jurídicas da morte, informadas pelos legistas para classificação do laudo cadavérico e posterior estatística");

            entity.Property(e => e.CdCausaJuridica)
                .HasColumnName("cd_causa_juridica")
                .HasComment("Chave primaria autoincremental. Código da causa jurídica da morte informada pelo legista");

            entity.Property(e => e.Excluido)
                .HasColumnName("excluido")
                .HasComment("Informa se o registro foi excluído");

            entity.Property(e => e.NmCausaJuridica)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nm_causa_juridica")
                .HasComment("Nome da causa jurídica da morte informada pelo legista");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<TbCausaJurPerito> entity);
    }
}
