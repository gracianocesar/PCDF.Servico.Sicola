﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace PCDF.Servico.Sicola.API.Data.Data.Sicola
{
    /// <summary>
    /// Bens patrimoniais do IML
    /// </summary>
    public partial class TbPatrimonio
    {
        /// <summary>
        /// Chave primaria autoincremental. Código do registro do bem patrimonial
        /// </summary>
        public int CdPatrimonio { get; set; }
        /// <summary>
        /// Data da inclusão do registro do bem patrimonial
        /// </summary>
        public DateTime? DtInclusao { get; set; }
        /// <summary>
        /// Hora da inclusão do registro do bem patrimonial
        /// </summary>
        public DateTime? HrInclusao { get; set; }
        /// <summary>
        /// Chave estrangeira na tabela tb_usuario. Código do usuário que incluiu o bem patrimonial
        /// </summary>
        public int? CdIncluidor { get; set; }
        /// <summary>
        /// Chave estrangeira na tabela tb_orgao_lotacao. Código do órgão onde está o bem patrimonial (IML)
        /// </summary>
        public int? CdOrgaoLotacao { get; set; }
        /// <summary>
        /// Chave estrangeira na tabela tb_secao_lotacao. Código da seção onde está o bem patrimonial
        /// </summary>
        public int? CdSecaoLotacao { get; set; }
        /// <summary>
        /// Data que o bem chegou ao órgão
        /// </summary>
        public DateTime? DtIncorporou { get; set; }
        /// <summary>
        /// Nome do bem patrimonial
        /// </summary>
        public string NmPatrimonio { get; set; }
        /// <summary>
        /// Número do tombamento do bem patrimonial
        /// </summary>
        public string Tombamento { get; set; }
        /// <summary>
        /// Estado de conservação do bem patrimonial
        /// </summary>
        public string Estado { get; set; }
        /// <summary>
        /// Data da saída do bem patrimonial
        /// </summary>
        public DateTime? DtBaixa { get; set; }
        /// <summary>
        /// Chave estrangeira na tabela tb_usuario. Código do usuário que informou a saída do bem
        /// </summary>
        public int? CdBaixador { get; set; }
        /// <summary>
        /// Informa se o registro foi excluído
        /// </summary>
        public bool? Excluido { get; set; }
        /// <summary>
        /// Número do série do bem patrimonial
        /// </summary>
        public string NrSerie { get; set; }
        /// <summary>
        /// Documento que transferiu o bem para o órgão (IML)
        /// </summary>
        public string Documento { get; set; }
        /// <summary>
        /// Este campo não está sendo utilizado
        /// </summary>
        public int? Tp { get; set; }
        /// <summary>
        /// Código do bem no sistema da DRM
        /// </summary>
        public string CodigoDrm { get; set; }
        public long? IdTrilhaAuditoria { get; set; }
    }
}