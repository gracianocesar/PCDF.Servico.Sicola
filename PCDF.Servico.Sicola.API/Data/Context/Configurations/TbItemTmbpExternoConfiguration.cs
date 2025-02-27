﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using PCDF.Servico.Sicola.API.Data.Context;
using PCDF.Servico.Sicola.API.Data.Data.Sicola;
using System;

namespace PCDF.Servico.Sicola.API.Data.Context.Configurations
{
    public partial class TbItemTmbpExternoConfiguration : IEntityTypeConfiguration<TbItemTmbpExterno>
    {
        public void Configure(EntityTypeBuilder<TbItemTmbpExterno> entity)
        {
            entity.HasKey(e => new { e.CdPatrimonio, e.CdTmbp });

            entity.ToTable("tb_item_tmbp_externo", "dbo");

            entity.HasComment("Itens que compoem um termo de movimentação de bens patrimoniais (TMBP) para fora do IML");

            entity.Property(e => e.CdPatrimonio)
                .HasColumnName("cd_patrimonio")
                .HasComment("Chave estrangeira na tabela tb_patrimonio. Código do bem patrimonial que compoe o TMBP EXTERNO");

            entity.Property(e => e.CdTmbp)
                .HasColumnName("cd_tmbp")
                .HasComment("Chave estrangeira na tabela tb_tmbp_externo. Código do TMBP externo ao qual o item pertence");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<TbItemTmbpExterno> entity);
    }
}
