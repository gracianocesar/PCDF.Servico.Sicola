﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace PCDF.Servico.Sicola.API.Data.Data.Sicola
{
    /// <summary>
    /// Informações relacionadas ao documento (laudo ou relatório ou controle do SVO (serviço de verificação de óbitos))
    /// </summary>
    public partial class TbLaudo
    {
        /// <summary>
        /// Código único do documento. Autoincrementado.
        /// </summary>
        public int CdLaudo { get; set; }
        /// <summary>
        /// Código do tipo de documento. Chave estrangeira, tabela tb_tp_laudo
        /// </summary>
        public int? CdTpLaudo { get; set; }
        /// <summary>
        /// Código do relator ou médico do SVO
        /// </summary>
        public int? CdPerito1 { get; set; }
        /// <summary>
        /// Código do revisor ou médico do SVO
        /// </summary>
        public int? CdPerito2 { get; set; }
        /// <summary>
        /// Data da criação do documento (data da inclusão do registro na tabela)
        /// </summary>
        public DateTime? DtLaudo { get; set; }
        /// <summary>
        /// Campo não utilizado, pois a hora é armazenada junto com a data do documento
        /// </summary>
        public DateTime? HrLaudo { get; set; }
        /// <summary>
        /// Data da assinatura do documento
        /// </summary>
        public DateTime? DtAssinatura { get; set; }
        /// <summary>
        /// Horário da assinatura do documento
        /// </summary>
        public DateTime? HrAssinatura { get; set; }
        /// <summary>
        /// Chave primaria, armazena o número do documento
        /// </summary>
        public int NrLaudo { get; set; }
        /// <summary>
        /// Chave primaria. armazena o ano do documento
        /// </summary>
        public int AnoLaudo { get; set; }
        /// <summary>
        /// Chave estrangeira tb_usuario. Código do usuário que homologou o documento
        /// </summary>
        public int? CdHomologador { get; set; }
        /// <summary>
        /// Data da homologação do documento
        /// </summary>
        public DateTime? DtHomologado { get; set; }
        /// <summary>
        /// Campo não utilizado, pois a hora da homologação é armazenada junto com a data da homologação.
        /// </summary>
        public DateTime? HrHomologado { get; set; }
        /// <summary>
        /// Chave estrangeira tb_usuario. Código do usuário que arquivou o documento
        /// </summary>
        public int? CdArquivador { get; set; }
        /// <summary>
        /// Data do arquivamento do documento
        /// </summary>
        public DateTime? DtArquivado { get; set; }
        /// <summary>
        /// Campo não utilizado, pois a hora do arquivamento é armazenada junto com a data  do arquivamento
        /// </summary>
        public DateTime? HrArquivado { get; set; }
        /// <summary>
        /// Código do usuário incluidor do documento
        /// </summary>
        public int? CdIncluidor { get; set; }
        /// <summary>
        /// Informa se o documento está cancelado
        /// </summary>
        public bool? Cancelado { get; set; }
        /// <summary>
        /// Nome do periciando (pessoa que se submeteu à perícia)
        /// </summary>
        public string NmPericiando { get; set; }
        /// <summary>
        /// Chave estrangeira da tabela tb_nacionalidade. Código do país onde nasceu o periciando.
        /// </summary>
        public int? CdNacionalidade { get; set; }
        /// <summary>
        /// Chave estrangeira da tabela tb_estado. Código do estado onde nasceu o periciando
        /// </summary>
        public int? CdUfNaturalidade { get; set; }
        /// <summary>
        /// Chave estrangeira da tabela tb_cidade. Código da cidade onde nasceu o periciando
        /// </summary>
        public int? CdCidadeNaturalidade { get; set; }
        /// <summary>
        /// Chave estrangeira da tabela tb_estado_civil. Código do estado civil do periciando
        /// </summary>
        public int? CdEstadoCivil { get; set; }
        /// <summary>
        /// Data de nascimento do periciando
        /// </summary>
        public DateTime? DtNascimento { get; set; }
        /// <summary>
        /// Chave estrangeira da tabela tb_sexo. Código do sexo do periciando
        /// </summary>
        public int? CdSexo { get; set; }
        /// <summary>
        /// Nome do pai do periciando
        /// </summary>
        public string NmPai { get; set; }
        /// <summary>
        /// Nome da mãe do periciando
        /// </summary>
        public string NmMae { get; set; }
        /// <summary>
        /// Endereço do periciando
        /// </summary>
        public string Endereco { get; set; }
        /// <summary>
        /// Chave estrangeira da tabela tb_cidade. Código da cidade do endereço do periciando
        /// </summary>
        public int? CdCidadeEndereco { get; set; }
        /// <summary>
        /// Chave estrangeira da tabela tb_estado. Código do estado do endereço do periciando
        /// </summary>
        public int? CdUfEndereco { get; set; }
        /// <summary>
        /// Chave estrangeira da tabela tb_profissao. Código da profissão do periciando
        /// </summary>
        public int? CdProfissao { get; set; }
        /// <summary>
        /// Número do Registro Geral do periciando
        /// </summary>
        public string Rg { get; set; }
        /// <summary>
        /// Nome do órgão expedidor do RG do periciando
        /// </summary>
        public string RgExpedidor { get; set; }
        /// <summary>
        /// A quem pertence o RG apresentado para o exame do periciando
        /// </summary>
        public string RgDono { get; set; }
        /// <summary>
        /// Chave estrangeira da tabela tb_documento. Código do tipo de documento apresentado para o exame do periciando
        /// </summary>
        public int? CdTpDocumento { get; set; }
        /// <summary>
        /// Data da emissão do documento apresentado para o exame do periciando
        /// </summary>
        public DateTime? DtDocumento { get; set; }
        /// <summary>
        /// Número do documento apresentado para o exame do periciando
        /// </summary>
        public string NrDocumento { get; set; }
        /// <summary>
        /// Chave estrangeira da tabela tb_orgao. Código do órgão que expediu o documento apresentado para o exame do periciando
        /// </summary>
        public int? CdOrgaoExpedidor { get; set; }
        /// <summary>
        /// Número da ocorrência policial registrada sobre o fato que motivou o exame
        /// </summary>
        public int? NrOcorrencia { get; set; }
        /// <summary>
        /// Ano da ocorrência policial
        /// </summary>
        public int? AnoOcorrencia { get; set; }
        /// <summary>
        /// Chave estrangeira da tabela tb_orgao. Código do órgão (DP) emissor da ocorrência policial
        /// </summary>
        public int? CdOrgaoOcorrencia { get; set; }
        /// <summary>
        /// Chave estrangeira da tabela tb_orgao. Código do órgão a quem se destina o documento (laudo)
        /// </summary>
        public int? CdDestinatario { get; set; }
        /// <summary>
        /// Chave estrangeira da tabela tb_cor_pele. Código da cor da pele do periciando
        /// </summary>
        public int? CdCorPele { get; set; }
        /// <summary>
        /// Número do telefone de contato do periciando
        /// </summary>
        public string Telefone { get; set; }
        /// <summary>
        /// Data em que o relator encaminhou o documento (laudo) para o revisor.
        /// </summary>
        public DateTime? DtEnvioPerito2 { get; set; }
        /// <summary>
        /// Número do protocolo da PCDF
        /// </summary>
        public int? NrProtocolo { get; set; }
        /// <summary>
        /// Ano do protocolo da PCDF
        /// </summary>
        public int? AnoProtocolo { get; set; }
        /// <summary>
        /// Data que o relator assumiu o documento (laudo) para iniciar a perícia médica
        /// </summary>
        public DateTime? DtInicio { get; set; }
        /// <summary>
        /// Data em que ocorreu o fato que motivou o exame. Este campo ainda não foi utilizado (até 08/11/2018)
        /// </summary>
        public DateTime? DtFato { get; set; }
        /// <summary>
        /// Número do CPF do periciando
        /// </summary>
        public string Cpf { get; set; }
        /// <summary>
        /// Nome do cargo do relator do documento nos casos em que o documento é um relatório
        /// </summary>
        public string NmCargoPerito1 { get; set; }
        /// <summary>
        /// Nome do cargo do revisor do documento nos casos em que o documento é um relatório
        /// </summary>
        public string NmCargoPerito2 { get; set; }
        /// <summary>
        /// Nome social do periciando. Para travestis e transexuais
        /// </summary>
        public string NmSocial { get; set; }
        public string DscAssunto { get; set; }
        public string NrPassaporte { get; set; }
        public string NrCtps { get; set; }
        public long? IdTrilhaAuditoria { get; set; }
        public string Situacao { get; set; }
        public int? CdOrgaoGerador { get; set; }
    }
}