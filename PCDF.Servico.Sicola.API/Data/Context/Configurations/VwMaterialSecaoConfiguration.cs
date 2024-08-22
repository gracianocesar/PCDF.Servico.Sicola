﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using PCDF.Servico.Sicola.API.Data.Context;
using PCDF.Servico.Sicola.API.Data.Data.Sicola;
using System;

namespace PCDF.Servico.Sicola.API.Data.Context.Configurations
{
    public partial class VwMaterialSecaoConfiguration : IEntityTypeConfiguration<VwMaterialSecao>
    {
        public void Configure(EntityTypeBuilder<VwMaterialSecao> entity)
        {
            entity.HasNoKey();

            entity.ToView("vw_material_secao", "dbo");

            entity.HasComment("Material de consumo e a seção que o utiliza. Informa para qual seção um material de consumo pode ser distribuido");

            entity.Property(e => e.CodMaterial).HasColumnName("Cod_Material");

            entity.Property(e => e.CodOrgao).HasColumnName("Cod_Orgao");

            entity.Property(e => e.CodSecao).HasColumnName("Cod_Secao");

            entity.Property(e => e.DescMaterial)
                .HasMaxLength(250)
                .HasColumnName("Desc_Material");

            entity.Property(e => e.EstoqueAtual).HasColumnName("Estoque_Atual");

            entity.Property(e => e.EstoqueMaximo).HasColumnName("Estoque_Maximo");

            entity.Property(e => e.EstoqueMinimo).HasColumnName("Estoque_Minimo");

            entity.Property(e => e.Excluido).HasMaxLength(1);

            entity.Property(e => e.NmSecao)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nm_secao");

            entity.Property(e => e.UnidadeMedida)
                .HasMaxLength(15)
                .HasColumnName("Unidade_Medida");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<VwMaterialSecao> entity);
    }
}
