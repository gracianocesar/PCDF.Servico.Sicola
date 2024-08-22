﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using PCDF.Servico.Sicola.API.Data.Context;
using PCDF.Servico.Sicola.API.Data.Data.Sicola;
using System;

namespace PCDF.Servico.Sicola.API.Data.Context.Configurations
{
    public partial class TbAditamentoConfiguration : IEntityTypeConfiguration<TbAditamento>
    {
        public void Configure(EntityTypeBuilder<TbAditamento> entity)
        {
            entity.HasKey(e => e.CdAditamento);

            entity.ToTable("tb_aditamento", "dbo");

            entity.HasComment("Tabela para armazenamento dos aditamentos aos documentos (laudos ou relatórios ou SVO)");

            entity.Property(e => e.CdAditamento)
                .HasColumnName("cd_aditamento")
                .HasComment("Chave primaria autoincrementada. Código do aditamento.");

            entity.Property(e => e.Administrativo)
                .HasColumnName("administrativo")
                .HasComment("Informa se o aditamento é de caráter admnistrativo para correção de dados do periciando ou se é pericial, acrescenta ou altera informações do documento.");

            entity.Property(e => e.Cancelado)
                .HasColumnName("cancelado")
                .HasComment("Informa se o aditamento está cancelado ou não.");

            entity.Property(e => e.CdArquivador)
                .HasColumnName("cd_arquivador")
                .HasComment("Chave estrangeira na tabela tb_usuario. Código do usuário que arquivou o aditamento.");

            entity.Property(e => e.CdDestinatario)
                .HasColumnName("cd_destinatario")
                .HasComment("Chave estrangeira na tabela tb_orgao. Código do destinatário do aditamento.");

            entity.Property(e => e.CdHomologador)
                .HasColumnName("cd_homologador")
                .HasComment("Chave estrangeira na tabela tb_usuario. Código do usuário homologador do aditamento.");

            entity.Property(e => e.CdIncluidor)
                .HasColumnName("cd_incluidor")
                .HasComment("Chave estrangeira na tabela tb_usuario. Código do usuário que incluiu o aditamento.");

            entity.Property(e => e.CdLaudo)
                .HasColumnName("cd_laudo")
                .HasComment("Chave estrangeira na tabela tb_laudo. Código do documento ao qual se refere o aditamento.");

            entity.Property(e => e.CdPerito1)
                .HasColumnName("cd_perito1")
                .HasComment("Chave estrangeira na tabela tb_usuario. Código do relator do documento.");

            entity.Property(e => e.CdPerito2)
                .HasColumnName("cd_perito2")
                .HasComment("Chave estrangeira na tabela tb_usuario. Código do revisor do documento.");

            entity.Property(e => e.DtArquivado)
                .HasColumnType("datetime")
                .HasColumnName("dt_arquivado")
                .HasComment("Data/hora do arquivamento do aditamento.");

            entity.Property(e => e.DtAssinatura)
                .HasColumnType("datetime")
                .HasColumnName("dt_assinatura")
                .HasComment("Data da assinatura do aditamento pelo relator e revisor.");

            entity.Property(e => e.DtHomologado)
                .HasColumnType("datetime")
                .HasColumnName("dt_homologado")
                .HasComment("Data/hora da homologação do aditamento.");

            entity.Property(e => e.DtInclusao)
                .HasColumnType("datetime")
                .HasColumnName("dt_inclusao")
                .HasComment("Data e hora da inclusão do aditamento.");

            entity.Property(e => e.HrArquivado)
                .HasColumnType("datetime")
                .HasColumnName("hr_arquivado")
                .HasComment("Hora do arquivamento do aditamento.");

            entity.Property(e => e.HrAssinatura)
                .HasColumnType("datetime")
                .HasColumnName("hr_assinatura")
                .HasComment("Hora da assinatura do aditamento pelo rerlator e revisor.");

            entity.Property(e => e.HrHomologado)
                .HasColumnType("datetime")
                .HasColumnName("hr_homologado")
                .HasComment("Hora da homologação do aditamento.");

            entity.Property(e => e.HrInclusao)
                .HasColumnType("datetime")
                .HasColumnName("hr_inclusao")
                .HasComment("Hora da inclusão do aditamento.");

            entity.Property(e => e.NmPericiando)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nm_periciando")
                .HasComment("Nome do periciando do documento(laudo). Pode ser diferente do documento se tratar-se de aditamento administrativo para correção do nome errado.");

            entity.Property(e => e.QtFotos)
                .HasColumnName("qt_fotos")
                .HasComment("Quantidade de fotos do aditamento.");

            entity.Property(e => e.Texto)
                .HasColumnType("text")
                .HasColumnName("texto")
                .HasComment("Conteúdo (texto) do aditamento.");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<TbAditamento> entity);
    }
}
