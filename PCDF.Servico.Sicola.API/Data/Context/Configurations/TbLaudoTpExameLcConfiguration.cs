﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using PCDF.Servico.Sicola.API.Data.Context;
using PCDF.Servico.Sicola.API.Data.Data.Sicola;
using System;

namespace PCDF.Servico.Sicola.API.Data.Context.Configurations
{
    public partial class TbLaudoTpExameLcConfiguration : IEntityTypeConfiguration<TbLaudoTpExameLc>
    {
        public void Configure(EntityTypeBuilder<TbLaudoTpExameLc> entity)
        {
            entity.HasKey(e => new { e.CdLaudo, e.CdTpExameLc });

            entity.ToTable("tb_laudo_tp_exame_lc", "dbo");

            entity.HasComment("Motivo do exame do laudo de lesão corporal");

            entity.Property(e => e.CdLaudo)
                .HasColumnName("cd_laudo")
                .HasComment("Chave estrangeira na tabela tb_laudo. Código do laudo de lesões corporais cujo motivo do exame está sendo registrado");

            entity.Property(e => e.CdTpExameLc)
                .HasColumnName("cd_tp_exame_lc")
                .HasComment("Chave estrangeira na tabela tb_tp_exame_lc. Código do motivo da realização do exame de lesões corporais");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<TbLaudoTpExameLc> entity);
    }
}
