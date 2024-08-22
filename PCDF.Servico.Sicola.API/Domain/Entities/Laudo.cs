using PCDF.Servico.Sicola.API.Data.Data.Sicola;
using System;

namespace PCDF.Servico.Sicola.API.Domain.Entities
{
    public class Laudo
    {
        public int CdLaudo { get; set; }
        public int? CdTpLaudo { get; set; }
        public int? CdPerito1 { get; set; }
        public int? CdPerito2 { get; set; }
        public DateTime? DtLaudo { get; set; }
        public DateTime? HrLaudo { get; set; }
        public DateTime? DtAssinatura { get; set; }
        public DateTime? HrAssinatura { get; set; }
        public int NrLaudo { get; set; }
        public int AnoLaudo { get; set; }
        public int? CdHomologador { get; set; }
        public DateTime? DtHomologado { get; set; }
        public DateTime? HrHomologado { get; set; }
        public int? CdArquivador { get; set; }
        public DateTime? DtArquivado { get; set; }
        public DateTime? HrArquivado { get; set; }
        public int? CdIncluidor { get; set; }
        public bool? Cancelado { get; set; }
        public string NmPericiando { get; set; }
        public int? CdNacionalidade { get; set; }
        public int? CdUfNaturalidade { get; set; }
        public int? CdCidadeNaturalidade { get; set; }
        public int? CdEstadoCivil { get; set; }
        public DateTime? DtNascimento { get; set; }
        public int? CdSexo { get; set; }
        public string NmPai { get; set; }
        public string NmMae { get; set; }
        public string Endereco { get; set; }
        public int? CdCidadeEndereco { get; set; }
        public int? CdUfEndereco { get; set; }
        public int? CdProfissao { get; set; }
        public string Rg { get; set; }
        public string RgExpedidor { get; set; }
        public string RgDono { get; set; }
        public int? CdTpDocumento { get; set; }
        public DateTime? DtDocumento { get; set; }
        public string NrDocumento { get; set; }
        public int? CdOrgaoExpedidor { get; set; }
        public int? NrOcorrencia { get; set; }
        public int? AnoOcorrencia { get; set; }
        public int? CdOrgaoOcorrencia { get; set; }
        public int? CdDestinatario { get; set; }
        public int? CdCorPele { get; set; }
        public string Telefone { get; set; }
        public DateTime? DtEnvioPerito2 { get; set; }
        public int? NrProtocolo { get; set; }
        public int? AnoProtocolo { get; set; }
        public string NmDestinatario { get; set; }
        public string NmTpLaudo { get; set; }
        public string NmDocumento { get; set; }
        public string NmOrgaoOcorrencia { get; set; }
        public string NmNacionalidade { get; set; }
        public string NmCidadeNaturalidade { get; set; }
        public string NmUfNaturalidade { get; set; }
        public string NmSexo { get; set; }
        public string NmCorPele { get; set; }
        public string NmEstadoCivil { get; set; }
        public string NmProfissao { get; set; }
        public string NmOrgaoExpedidor { get; set; }
        public string NmPerito2 { get; set; }
        public string MtIncluidor { get; set; }
        /// <summary>
        /// laudo de exame de corpo de delito etc
        /// </summary>
        public string TituloTpLaudo { get; set; }
        public string NmCidadeEndereco { get; set; }
        public string NmUfEndereco { get; set; }
        public string SiglaConselho2 { get; set; }
        public string NrConselho2 { get; set; }
        public string NmPerito1 { get; set; }
        public string SiglaConselho1 { get; set; }
        public string NrConselho1 { get; set; }
        public string NmHomologador { get; set; }
        public string NmArquivador { get; set; }
        public string NmIncluidor { get; set; }
        public int? Prazo { get; set; }
        public int? NrDeclaracao { get; set; }
        public string MatriculaPerito1 { get; set; }
        public string MatriculaPerito2 { get; set; }
        public DateTime? DtInicio { get; set; }
        public int? CodOrgaoOcorrencia { get; set; }
        public string CodOcorrenciaIml { get; set; }
        public string CodLaudo { get; set; }
        public DateTime? DtFato { get; set; }
        public string Cpf { get; set; }
        public string NmCargoPerito1 { get; set; }
        public string NmCargoPerito2 { get; set; }
        public int? CdTpExameLc { get; set; }
        public string NmSocial { get; set; }
        public string DscAssunto { get; set; }
        public string NrPassaporte { get; set; }
        public string NrCtps { get; set; }
        public int? CdOrgaoGerador { get; set; }
        public string NmTpExameLc { get; set; }

        public static implicit operator Laudo(VwLaudo x)
        {
            return new Laudo {
                CdLaudo = x.CdLaudo,
                CdTpLaudo = x.CdTpLaudo,
                CdPerito1 = x.CdPerito1,
                CdPerito2 = x.CdPerito2,
                DtLaudo = x.DtLaudo,
                HrLaudo = x.HrLaudo,
                DtAssinatura = x.DtAssinatura,
                HrAssinatura = x.HrAssinatura,
                NrLaudo = x.NrLaudo,
                AnoLaudo = x.AnoLaudo,
                CdHomologador = x.CdHomologador,
                DtHomologado = x.DtHomologado,
                HrHomologado = x.HrHomologado,
                CdArquivador = x.CdArquivador,
                DtArquivado = x.DtArquivado,
                HrArquivado = x.HrArquivado,
                CdIncluidor = x.CdIncluidor,
                Cancelado = x.Cancelado,
                NmPericiando = x.NmPericiando,
                CdNacionalidade = x.CdNacionalidade,
                CdUfNaturalidade = x.CdUfNaturalidade,
                CdCidadeNaturalidade = x.CdCidadeNaturalidade,
                CdEstadoCivil = x.CdEstadoCivil,
                DtNascimento = x.DtNascimento,
                CdSexo = x.CdSexo,
                NmPai = x.NmPai,
                NmMae = x.NmMae,
                Endereco = x.Endereco,
                CdCidadeEndereco = x.CdCidadeEndereco,
                CdUfEndereco = x.CdUfEndereco,
                CdProfissao = x.CdProfissao,
                Rg = x.Rg,
                RgExpedidor = x.RgExpedidor,
                RgDono = x.RgDono,
                CdTpDocumento = x.CdTpDocumento,
                DtDocumento = x.DtDocumento,
                NrDocumento = x.NrDocumento,
                CdOrgaoExpedidor = x.CdOrgaoExpedidor,
                NrOcorrencia = x.NrOcorrencia,
                AnoOcorrencia = x.AnoOcorrencia,
                CdOrgaoOcorrencia = x.CdOrgaoOcorrencia,
                CdDestinatario = x.CdDestinatario,
                CdCorPele = x.CdCorPele,
                Telefone = x.Telefone,
                DtEnvioPerito2 = x.DtEnvioPerito2,
                NrProtocolo = x.NrProtocolo,
                AnoProtocolo = x.AnoProtocolo,
                NmDestinatario = x.NmDestinatario,
                NmTpLaudo = x.NmTpLaudo,
                NmDocumento = x.NmDocumento,
                NmOrgaoOcorrencia = x.NmOrgaoOcorrencia,
                NmNacionalidade = x.NmNacionalidade,
                NmCidadeNaturalidade = x.NmCidadeNaturalidade,
                NmUfNaturalidade = x.NmUfNaturalidade,
                NmSexo = x.NmSexo,
                NmCorPele = x.NmCorPele,
                NmEstadoCivil = x.NmEstadoCivil,
                NmProfissao = x.NmProfissao,
                NmOrgaoExpedidor = x.NmOrgaoExpedidor,
                NmPerito2 = x.NmPerito2,
                MtIncluidor = x.MtIncluidor,
                TituloTpLaudo = x.TituloTpLaudo,
                NmCidadeEndereco = x.NmCidadeEndereco,
                NmUfEndereco = x.NmUfEndereco,
                SiglaConselho2 = x.SiglaConselho2,
                NrConselho2 = x.NrConselho2,
                NmPerito1 = x.NmPerito1,
                SiglaConselho1 = x.SiglaConselho1,
                NrConselho1 = x.NrConselho1,
                NmHomologador = x.NmHomologador,
                NmArquivador = x.NmArquivador,
                NmIncluidor = x.NmIncluidor,
                Prazo = x.Prazo,
                NrDeclaracao = x.NrDeclaracao,
                MatriculaPerito1 = x.MatriculaPerito1,
                MatriculaPerito2 = x.MatriculaPerito2,
                DtInicio = x.DtInicio,
                CodOrgaoOcorrencia = x.CodOrgaoOcorrencia,
                CodOcorrenciaIml = x.CodOcorrenciaIml,
                CodLaudo = x.CodLaudo,
                DtFato = x.DtFato,
                Cpf = x.Cpf,
                NmCargoPerito1 = x.NmCargoPerito1,
                NmCargoPerito2 = x.NmCargoPerito2,
                CdTpExameLc = x.CdTpExameLc,
                NmSocial = x.NmSocial,
                DscAssunto = x.DscAssunto,
                NrPassaporte = x.NrPassaporte,
                NrCtps = x.NrCtps,
                CdOrgaoGerador = x.CdOrgaoGerador,
                NmTpExameLc = x.NmTpExameLc
            };
        }
    }
}
