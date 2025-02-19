﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using PCDF.Servico.Sicola.API.Data.Context;
using PCDF.Servico.Sicola.API.Data.Data.Sicola;
using System;

namespace PCDF.Servico.Sicola.API.Data.Context.Configurations
{
    public partial class TbContraprovaConfiguration : IEntityTypeConfiguration<TbContraprova>
    {
        public void Configure(EntityTypeBuilder<TbContraprova> entity)
        {
            entity.HasKey(e => e.CdContraprova);

            entity.ToTable("tb_contraprova", "dbo");

            entity.HasComment("Registro de memorandos de envio de material de contraprova à CGCV pelo laboratório do IML. Aparentemente deixou de ser usado em 2011, pois é a data do último registro.");

            entity.Property(e => e.CdContraprova)
                .HasColumnName("cd_contraprova")
                .HasComment("Chave primaria. Código do registro do memorando");

            entity.Property(e => e.AnoProtocolo)
                .HasColumnName("ano_protocolo")
                .HasComment("Ano do protocolo da PCDF referente ao memorando");

            entity.Property(e => e.DtAssinatura)
                .HasColumnType("datetime")
                .HasColumnName("dt_assinatura")
                .HasComment("Data da assinatura do memorando");

            entity.Property(e => e.DtIncluido)
                .HasColumnType("datetime")
                .HasColumnName("dt_incluido")
                .HasComment("Data em que foi registrado o memorando");

            entity.Property(e => e.Excluido)
                .HasColumnName("excluido")
                .HasComment("Informa se o registro foi excluído");

            entity.Property(e => e.Memo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("memo")
                .HasComment("Número e ano do memorando de encaminhamento de material para contraprova");

            entity.Property(e => e.NrProtocolo)
                .HasColumnName("nr_protocolo")
                .HasComment("Número do protocolo da PCDF referente ao memorando");

            entity.Property(e => e.Texto)
                .HasMaxLength(400)
                .IsUnicode(false)
                .HasColumnName("texto")
                .IsFixedLength(true)
                .HasComment("Texto do memorando");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<TbContraprova> entity);
    }
}
