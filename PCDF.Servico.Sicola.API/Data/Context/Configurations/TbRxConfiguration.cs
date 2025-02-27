﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using PCDF.Servico.Sicola.API.Data.Context;
using PCDF.Servico.Sicola.API.Data.Data.Sicola;
using System;

namespace PCDF.Servico.Sicola.API.Data.Context.Configurations
{
    public partial class TbRxConfiguration : IEntityTypeConfiguration<TbRx>
    {
        public void Configure(EntityTypeBuilder<TbRx> entity)
        {
            entity.HasKey(e => e.CdRx);

            entity.ToTable("tb_rx", "dbo");

            entity.HasComment("Registro de raio X realizado em um cadáver");

            entity.Property(e => e.CdRx)
                .HasColumnName("cd_rx")
                .HasComment("Chave primaria autoincremental. Código do registro de raio X realizado em um cadáver");

            entity.Property(e => e.CdCadaver)
                .HasColumnName("cd_cadaver")
                .HasComment("Chave estrangeira na tabela cd_cadaver. Código do cadáver onde foi feito o Raio X");

            entity.Property(e => e.CdFezRx)
                .HasColumnName("cd_fez_rx")
                .HasComment("Chave estrangeira na tabela tb_usuario. Código do usuário que realizou o procedimento de Raio X no cadáver");

            entity.Property(e => e.CdIncluidor)
                .HasColumnName("cd_incluidor")
                .HasComment("Chave estrangeira na tabela tb_usuario. Código do usuário que incluiu o registro de raio X realizado");

            entity.Property(e => e.DtInclusao)
                .HasColumnType("datetime")
                .HasColumnName("dt_inclusao")
                .HasComment("Data da inclusão do registro");

            entity.Property(e => e.QtdeFilmes)
                .HasColumnName("qtde_filmes")
                .HasComment("Quantidade de filmes de raio x utilizados");

            entity.Property(e => e.QtdeProjetis)
                .HasColumnName("qtde_projetis")
                .HasComment("Quantidade de projetis encontrados no corpo");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<TbRx> entity);
    }
}
