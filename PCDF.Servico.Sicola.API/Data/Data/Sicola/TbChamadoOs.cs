﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace PCDF.Servico.Sicola.API.Data.Data.Sicola
{
    /// <summary>
    /// Chamados técnicos feitos pela seção de material e transporte do IML junto a diversas empresas prestadoras de serviço para a PCDF
    /// </summary>
    public partial class TbChamadoOs
    {
        /// <summary>
        /// Chave primaria autoincremental. Código do registro do chamado técnico
        /// </summary>
        public int CdChamado { get; set; }
        /// <summary>
        /// Data da inclusão do registro do chamado técnico junto a empresas prestadoras de serviço
        /// </summary>
        public DateTime DtInclusao { get; set; }
        /// <summary>
        /// Chave estrageira na tabela tb_usuario. Código do usuário incluidor do registro do chamado
        /// </summary>
        public int? CdIncluidor { get; set; }
        /// <summary>
        /// Data da exclusão do registro do chamado
        /// </summary>
        public DateTime? DtExclusao { get; set; }
        /// <summary>
        /// Chave estrangeira na tabela tb_usuario. Código do usuário excluidor do registro de chamado
        /// </summary>
        public int? CdExcluidor { get; set; }
        /// <summary>
        /// Data da abertura do chamado junto á empresa prestadora de serviços
        /// </summary>
        public DateTime? DtChamado { get; set; }
        /// <summary>
        /// Data do encerramento do chamado pela empresa prestadora do serviço
        /// </summary>
        public DateTime? DtTermino { get; set; }
        /// <summary>
        /// Nome do funcionário que recebeu o chamado na empresa prestadora do serviço
        /// </summary>
        public string NmExterno { get; set; }
        /// <summary>
        /// Nome do servidor do IML que fez a abertura do chamado na empresa que prrestará o serviço
        /// </summary>
        public string NmIml { get; set; }
        /// <summary>
        /// Número do patrimônio do bem objeto da abertura do chamado
        /// </summary>
        public string Patrimonio { get; set; }
        /// <summary>
        /// Número do chamado registrado na empresa prestadora de serviço
        /// </summary>
        public string NrChamado { get; set; }
        /// <summary>
        /// Descrição do problema e dos acontecimentos durante a vigência do chamado
        /// </summary>
        public string Historico { get; set; }
        /// <summary>
        /// Nome da empresa prestadora do serviço
        /// </summary>
        public string NmEmpresa { get; set; }
        public long? IdTrilhaAuditoria { get; set; }
    }
}