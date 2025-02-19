﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using PCDF.Servico.Sicola.API.Data.Context;
using PCDF.Servico.Sicola.API.Data.Data.Sicola;
using System;

namespace PCDF.Servico.Sicola.API.Data.Context.Configurations
{
    public partial class TbSaidaRabecaoEquipeConfiguration : IEntityTypeConfiguration<TbSaidaRabecaoEquipe>
    {
        public void Configure(EntityTypeBuilder<TbSaidaRabecaoEquipe> entity)
        {
            entity.HasKey(e => e.CdEquipe);

            entity.ToTable("tb_saida_rabecao_equipe", "dbo");

            entity.HasComment("Membro da equipe do rabecão que realizou a remoção do cadáver");

            entity.Property(e => e.CdEquipe)
                .HasColumnName("cd_equipe")
                .HasComment("Chave primaria autoincremental. Código do registro do membro da equipe de remoção");

            entity.Property(e => e.CdExcluidor)
                .HasColumnName("cd_excluidor")
                .HasComment("Chave estrangeira na tabela tb_usuario. Código do usuário que excluiu o registro do membro da equipe");

            entity.Property(e => e.CdIncluidor)
                .HasColumnName("cd_incluidor")
                .HasComment("Chave estrangeira na tabela tb_usuario. Código do usuário que incluiu o membro da equipe");

            entity.Property(e => e.CdMembroEquipe)
                .HasColumnName("cd_membro_equipe")
                .HasComment("Chave estrangeira na tabela tb_usuario. Código do usuário membro que compõe a equipe de remoção");

            entity.Property(e => e.CdSaidaRabecao)
                .HasColumnName("cd_saida_rabecao")
                .HasComment("Data da saída do rabecão");

            entity.Property(e => e.DtExclusao)
                .HasColumnType("datetime")
                .HasColumnName("dt_exclusao")
                .HasComment("Data da exclusão do registro de membro da equipe de remoção");

            entity.Property(e => e.DtInclusao)
                .HasColumnType("datetime")
                .HasColumnName("dt_inclusao")
                .HasComment("Data da inclusão do membro da equipe de remoção");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<TbSaidaRabecaoEquipe> entity);
    }
}
