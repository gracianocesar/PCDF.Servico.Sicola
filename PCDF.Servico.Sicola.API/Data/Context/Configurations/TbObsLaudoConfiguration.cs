﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using PCDF.Servico.Sicola.API.Data.Context;
using PCDF.Servico.Sicola.API.Data.Data.Sicola;
using System;

namespace PCDF.Servico.Sicola.API.Data.Context.Configurations
{
    public partial class TbObsLaudoConfiguration : IEntityTypeConfiguration<TbObsLaudo>
    {
        public void Configure(EntityTypeBuilder<TbObsLaudo> entity)
        {
            entity.HasKey(e => e.CdObsLaudo);

            entity.ToTable("tb_obs_laudo", "dbo");

            entity.HasComment("Informações adicionais (observações) incluídas nos laudos.");

            entity.Property(e => e.CdObsLaudo)
                .HasColumnName("cd_obs_laudo")
                .HasComment("Chave primaria autoincremental. Código do registro da observação de um laudo");

            entity.Property(e => e.CdExcluidor)
                .HasColumnName("cd_excluidor")
                .HasComment("Chave estrangeira na tabela tb_usuario. Código do usuário que excluiu a observação do laudo");

            entity.Property(e => e.CdLaudo)
                .HasColumnName("cd_laudo")
                .HasComment("Chave estrangeira na tabela tb_laudo. Código do laudo que recebeu a observação");

            entity.Property(e => e.CdUsuario)
                .HasColumnName("cd_usuario")
                .HasComment("Chave estrangeira na tabela tb_usuario. Código do usuário que inseriu a observação do laudo");

            entity.Property(e => e.DtExclusao)
                .HasColumnType("datetime")
                .HasColumnName("dt_exclusao")
                .HasComment("Data da exclusão da observação do laudo");

            entity.Property(e => e.DtObs)
                .HasColumnType("datetime")
                .HasColumnName("dt_obs")
                .HasComment("Data da inclusão da observação do laudo");

            entity.Property(e => e.Imprime)
                .HasColumnName("imprime")
                .HasComment("Informa se a observação será impressa junto com o laudo (true) ou se será exibida apenas nos dados básicos (false)");

            entity.Property(e => e.Texto)
                .HasColumnType("text")
                .HasColumnName("texto")
                .HasComment("Descrição da informação adicional associada ao laudo");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<TbObsLaudo> entity);
    }
}
