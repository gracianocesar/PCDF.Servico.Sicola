﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using PCDF.Servico.Sicola.API.Data.Context;
using PCDF.Servico.Sicola.API.Data.Data.Sicola;
using System;

namespace PCDF.Servico.Sicola.API.Data.Context.Configurations
{
    public partial class VwOnlineConfiguration : IEntityTypeConfiguration<VwOnline>
    {
        public void Configure(EntityTypeBuilder<VwOnline> entity)
        {
            entity.HasNoKey();

            entity.ToView("vw_online", "dbo");

            entity.HasComment("Usuários do sicola que estão online");

            entity.Property(e => e.DtAcesso)
                .HasColumnType("datetime")
                .HasColumnName("dt_acesso");

            entity.Property(e => e.NmOrgaoLotacao)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nm_orgao_lotacao");

            entity.Property(e => e.NmUsuario)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nm_usuario");

            entity.Property(e => e.Pagina)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pagina");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<VwOnline> entity);
    }
}
