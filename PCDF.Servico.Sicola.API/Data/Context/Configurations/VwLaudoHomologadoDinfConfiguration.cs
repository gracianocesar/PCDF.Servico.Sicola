﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using PCDF.Servico.Sicola.API.Data.Context;
using PCDF.Servico.Sicola.API.Data.Data.Sicola;
using System;

namespace PCDF.Servico.Sicola.API.Data.Context.Configurations
{
    public partial class VwLaudoHomologadoDinfConfiguration : IEntityTypeConfiguration<VwLaudoHomologadoDinf>
    {
        public void Configure(EntityTypeBuilder<VwLaudoHomologadoDinf> entity)
        {
            entity.HasNoKey();

            entity.ToView("vw_laudo_homologado_DINF", "dbo");

            entity.HasComment("Esta consulta não foi feita no IML, provavelmente foi feita pela DITEC para interagir com o Millenium");

            entity.Property(e => e.AnoLaudo).HasColumnName("ano_laudo");

            entity.Property(e => e.AnoOcorrencia).HasColumnName("ano_ocorrencia");

            entity.Property(e => e.AnoProtocolo).HasColumnName("ano_protocolo");

            entity.Property(e => e.Cancelado).HasColumnName("cancelado");

            entity.Property(e => e.CdArquivador).HasColumnName("cd_arquivador");

            entity.Property(e => e.CdCidadeEndereco).HasColumnName("cd_cidade_endereco");

            entity.Property(e => e.CdCidadeNaturalidade).HasColumnName("cd_cidade_naturalidade");

            entity.Property(e => e.CdCorPele).HasColumnName("cd_cor_pele");

            entity.Property(e => e.CdDestinatario).HasColumnName("cd_destinatario");

            entity.Property(e => e.CdEstadoCivil).HasColumnName("cd_estado_civil");

            entity.Property(e => e.CdHomologador).HasColumnName("cd_homologador");

            entity.Property(e => e.CdIncluidor).HasColumnName("cd_incluidor");

            entity.Property(e => e.CdLaudo).HasColumnName("cd_laudo");

            entity.Property(e => e.CdNacionalidade).HasColumnName("cd_nacionalidade");

            entity.Property(e => e.CdOrgaoExpedidor).HasColumnName("cd_orgao_expedidor");

            entity.Property(e => e.CdOrgaoOcorrencia).HasColumnName("cd_orgao_ocorrencia");

            entity.Property(e => e.CdPerito1).HasColumnName("cd_perito1");

            entity.Property(e => e.CdPerito2).HasColumnName("cd_perito2");

            entity.Property(e => e.CdProfissao).HasColumnName("cd_profissao");

            entity.Property(e => e.CdSexo).HasColumnName("cd_sexo");

            entity.Property(e => e.CdTpDocumento).HasColumnName("cd_tp_documento");

            entity.Property(e => e.CdTpLaudo).HasColumnName("cd_tp_laudo");

            entity.Property(e => e.CdUfEndereco).HasColumnName("cd_uf_endereco");

            entity.Property(e => e.CdUfNaturalidade).HasColumnName("cd_uf_naturalidade");

            entity.Property(e => e.DtArquivado)
                .HasColumnType("datetime")
                .HasColumnName("dt_arquivado");

            entity.Property(e => e.DtAssinatura)
                .HasColumnType("datetime")
                .HasColumnName("dt_assinatura");

            entity.Property(e => e.DtDocumento)
                .HasColumnType("datetime")
                .HasColumnName("dt_documento");

            entity.Property(e => e.DtEnvioPerito2)
                .HasColumnType("datetime")
                .HasColumnName("dt_envio_perito2");

            entity.Property(e => e.DtHomologado)
                .HasColumnType("datetime")
                .HasColumnName("dt_homologado");

            entity.Property(e => e.DtInicio)
                .HasColumnType("datetime")
                .HasColumnName("dt_inicio");

            entity.Property(e => e.DtLaudo)
                .HasColumnType("datetime")
                .HasColumnName("dt_laudo");

            entity.Property(e => e.DtNascimento)
                .HasColumnType("datetime")
                .HasColumnName("dt_nascimento");

            entity.Property(e => e.Endereco)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("endereco");

            entity.Property(e => e.HrArquivado)
                .HasColumnType("datetime")
                .HasColumnName("hr_arquivado");

            entity.Property(e => e.HrAssinatura)
                .HasColumnType("datetime")
                .HasColumnName("hr_assinatura");

            entity.Property(e => e.HrHomologado)
                .HasColumnType("datetime")
                .HasColumnName("hr_homologado");

            entity.Property(e => e.HrLaudo)
                .HasColumnType("datetime")
                .HasColumnName("hr_laudo");

            entity.Property(e => e.MatriculaPerito1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("matricula_perito1");

            entity.Property(e => e.MatriculaPerito2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("matricula_perito2");

            entity.Property(e => e.MtIncluidor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mt_incluidor");

            entity.Property(e => e.NmArquivador)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nm_arquivador");

            entity.Property(e => e.NmCidadeEndereco)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nm_cidade_endereco");

            entity.Property(e => e.NmCidadeNaturalidade)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nm_cidade_naturalidade");

            entity.Property(e => e.NmCorPele)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nm_cor_pele");

            entity.Property(e => e.NmDestinatario)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("nm_destinatario");

            entity.Property(e => e.NmDocumento)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nm_documento");

            entity.Property(e => e.NmEstadoCivil)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nm_estado_civil");

            entity.Property(e => e.NmHomologador)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nm_homologador");

            entity.Property(e => e.NmIncluidor)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nm_incluidor");

            entity.Property(e => e.NmMae)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nm_mae");

            entity.Property(e => e.NmNacionalidade)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nm_nacionalidade");

            entity.Property(e => e.NmOrgaoExpedidor)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("nm_orgao_expedidor");

            entity.Property(e => e.NmOrgaoOcorrencia)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("nm_orgao_ocorrencia");

            entity.Property(e => e.NmPai)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nm_pai");

            entity.Property(e => e.NmPericiando)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("nm_periciando");

            entity.Property(e => e.NmPerito1)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nm_perito1");

            entity.Property(e => e.NmPerito2)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nm_perito2");

            entity.Property(e => e.NmProfissao)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nm_profissao");

            entity.Property(e => e.NmSexo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nm_sexo");

            entity.Property(e => e.NmTpLaudo)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("nm_tp_laudo");

            entity.Property(e => e.NmUfEndereco)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nm_uf_endereco");

            entity.Property(e => e.NmUfNaturalidade)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("nm_uf_naturalidade");

            entity.Property(e => e.NrConselho1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nr_conselho1");

            entity.Property(e => e.NrConselho2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nr_conselho2");

            entity.Property(e => e.NrDeclaracao).HasColumnName("nr_declaracao");

            entity.Property(e => e.NrDocumento)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nr_documento");

            entity.Property(e => e.NrLaudo).HasColumnName("nr_laudo");

            entity.Property(e => e.NrOcorrencia).HasColumnName("nr_ocorrencia");

            entity.Property(e => e.NrProtocolo).HasColumnName("nr_protocolo");

            entity.Property(e => e.OrgaoOcorrenciaDinf).HasColumnName("ORGAO_OCORRENCIA_DINF");

            entity.Property(e => e.Prazo).HasColumnName("prazo");

            entity.Property(e => e.Rg)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("rg");

            entity.Property(e => e.RgDono)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("rg_dono");

            entity.Property(e => e.RgExpedidor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("rg_expedidor");

            entity.Property(e => e.SiglaConselho1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("sigla_conselho1");

            entity.Property(e => e.SiglaConselho2)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("sigla_conselho2");

            entity.Property(e => e.Telefone)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("telefone");

            entity.Property(e => e.TituloTpLaudo)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("titulo_tp_laudo");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<VwLaudoHomologadoDinf> entity);
    }
}
