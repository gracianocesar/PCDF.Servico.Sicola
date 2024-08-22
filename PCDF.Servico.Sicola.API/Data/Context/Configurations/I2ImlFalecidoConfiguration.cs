﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using PCDF.Servico.Sicola.API.Data.Context;
using PCDF.Servico.Sicola.API.Data.Data.Sicola;
using System;

namespace PCDF.Servico.Sicola.API.Data.Context.Configurations
{
    public partial class I2ImlFalecidoConfiguration : IEntityTypeConfiguration<I2ImlFalecido>
    {
        public void Configure(EntityTypeBuilder<I2ImlFalecido> entity)
        {
            entity.HasNoKey();

            entity.ToView("I2_IML_FALECIDO", "dbo");

            entity.HasComment("Esta consulta não foi criada no IML, não sei a sua utilidade");

            entity.Property(e => e.DataNascimento)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DATA NASCIMENTO");

            entity.Property(e => e.DataSituacao)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DATA SITUACAO");

            entity.Property(e => e.Etiqnome)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("ETIQNOME");

            entity.Property(e => e.Nome)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("NOME");

            entity.Property(e => e.NomeMae)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("NOME MAE");

            entity.Property(e => e.Situacao)
                .IsRequired()
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("SITUACAO");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<I2ImlFalecido> entity);
    }
}
