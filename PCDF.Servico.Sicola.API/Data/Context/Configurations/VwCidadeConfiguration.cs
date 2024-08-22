﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using PCDF.Servico.Sicola.API.Data.Context;
using PCDF.Servico.Sicola.API.Data.Data.Sicola;
using System;

namespace PCDF.Servico.Sicola.API.Data.Context.Configurations
{
    public partial class VwCidadeConfiguration : IEntityTypeConfiguration<VwCidade>
    {
        public void Configure(EntityTypeBuilder<VwCidade> entity)
        {
            entity.HasNoKey();

            entity.ToView("vw_cidade", "dbo");

            entity.HasComment("Relação de cidades e o nome do usuário que a incluiu");

            entity.Property(e => e.CdCidade).HasColumnName("cd_cidade");

            entity.Property(e => e.Excluido).HasColumnName("excluido");

            entity.Property(e => e.Incluidor)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("incluidor");

            entity.Property(e => e.NmCidade)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nm_cidade");

            entity.Property(e => e.NmUsuario)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nm_usuario");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<VwCidade> entity);
    }
}
