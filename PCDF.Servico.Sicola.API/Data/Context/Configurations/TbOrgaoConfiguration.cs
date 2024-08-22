﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using PCDF.Servico.Sicola.API.Data.Context;
using PCDF.Servico.Sicola.API.Data.Data.Sicola;
using System;

namespace PCDF.Servico.Sicola.API.Data.Context.Configurations
{
    public partial class TbOrgaoConfiguration : IEntityTypeConfiguration<TbOrgao>
    {
        public void Configure(EntityTypeBuilder<TbOrgao> entity)
        {
            entity.HasKey(e => e.CdOrgao);

            entity.ToTable("tb_orgao", "dbo");

            entity.Property(e => e.CdOrgao).HasColumnName("cd_orgao");

            entity.Property(e => e.CodCorrelacao).HasColumnName("cod_correlacao");

            entity.Property(e => e.Excluido).HasColumnName("excluido");

            entity.Property(e => e.NmOrgao)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("nm_orgao");

            entity.Property(e => e.Ordem).HasColumnName("ordem");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<TbOrgao> entity);
    }
}
