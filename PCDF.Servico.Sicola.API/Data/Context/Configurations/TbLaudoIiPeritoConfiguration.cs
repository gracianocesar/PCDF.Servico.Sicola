﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using PCDF.Servico.Sicola.API.Data.Context;
using PCDF.Servico.Sicola.API.Data.Data.Sicola;
using System;

namespace PCDF.Servico.Sicola.API.Data.Context.Configurations
{
    public partial class TbLaudoIiPeritoConfiguration : IEntityTypeConfiguration<TbLaudoIiPerito>
    {
        public void Configure(EntityTypeBuilder<TbLaudoIiPerito> entity)
        {
            entity.HasKey(e => new { e.CdLaudoIi, e.CdPeritoIi });

            entity.ToTable("tb_laudo_ii_perito", "dbo");

            entity.HasComment("Papiloscopistas que confirmaram a identificação do cadáver");

            entity.Property(e => e.CdLaudoIi)
                .HasColumnName("cd_laudo_ii")
                .HasComment("Chave estrangeira na tabela tb_laudo_ii. Código do pedido de identificação papiloscópica");

            entity.Property(e => e.CdPeritoIi)
                .HasColumnName("cd_perito_ii")
                .HasComment("Chave estrangeira na tabela tb_perito_ii. Código do papiloscopista que trabalhou na identificação do cadáver");

            entity.Property(e => e.CdIncluidor).HasColumnName("cd_incluidor");

            entity.Property(e => e.CdNecropapiloscopica).HasColumnName("cd_necropapiloscopica");

            entity.Property(e => e.DtInclusao)
                .HasColumnType("datetime")
                .HasColumnName("dt_inclusao");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<TbLaudoIiPerito> entity);
    }
}
