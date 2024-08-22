﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using PCDF.Servico.Sicola.API.Data.Context;
using PCDF.Servico.Sicola.API.Data.Data.Sicola;
using System;

namespace PCDF.Servico.Sicola.API.Data.Context.Configurations
{
    public partial class VwHomologadorConfiguration : IEntityTypeConfiguration<VwHomologador>
    {
        public void Configure(EntityTypeBuilder<VwHomologador> entity)
        {
            entity.HasNoKey();

            entity.ToView("vw_homologador", "dbo");

            entity.HasComment("Usuários que homologam laudos. É a listagem de todos os usuário que possuem a permissão H1 (entrar na área da homologação)");

            entity.Property(e => e.CdUsuario)
                .ValueGeneratedOnAdd()
                .HasColumnName("cd_usuario");

            entity.Property(e => e.NmUsuario)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nm_usuario");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<VwHomologador> entity);
    }
}
