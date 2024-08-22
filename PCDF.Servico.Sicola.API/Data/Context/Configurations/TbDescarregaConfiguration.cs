﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using PCDF.Servico.Sicola.API.Data.Context;
using PCDF.Servico.Sicola.API.Data.Data.Sicola;
using System;

namespace PCDF.Servico.Sicola.API.Data.Context.Configurations
{
    public partial class TbDescarregaConfiguration : IEntityTypeConfiguration<TbDescarrega>
    {
        public void Configure(EntityTypeBuilder<TbDescarrega> entity)
        {
            entity.HasKey(e => e.CdDescarrega);

            entity.ToTable("tb_descarrega", "dbo");

            entity.HasComment("Registro de usuários que auxiliaram no descarregamento de um corpo ao chegar o rabecão ao IML");

            entity.Property(e => e.CdDescarrega)
                .HasColumnName("cd_descarrega")
                .HasComment("Chave primaria autoincremental. Código do registro do usuário que auxiliou no descarregamento do corpo");

            entity.Property(e => e.CdCadaver)
                .HasColumnName("cd_cadaver")
                .HasComment("Chave estrangeira na tabela tb_cadaver. Código do cadáver que foi descarregado do rabecão");

            entity.Property(e => e.CdDescarregou)
                .HasColumnName("cd_descarregou")
                .HasComment("Chave estrangeira na tabela tb_usuario. Código do usuário que auxiliou no descarregamento do cadáver");

            entity.Property(e => e.CdIncluidor)
                .HasColumnName("cd_incluidor")
                .HasComment("Chave estrangeira na tabela tb_usuario. Código do usuário que incluiu o registro do auxílio ao descarregamento");

            entity.Property(e => e.DtInclusao)
                .HasColumnType("datetime")
                .HasColumnName("dt_inclusao")
                .HasComment("Data da inclusão do registro na tabela");

            entity.Property(e => e.HrInclusao)
                .HasColumnType("datetime")
                .HasColumnName("hr_inclusao")
                .HasComment("Hora da inclusao do registro na tabela. A partir de 29/08/2007 a hora passou a ser registrada junto à data no campo acima");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<TbDescarrega> entity);
    }
}
