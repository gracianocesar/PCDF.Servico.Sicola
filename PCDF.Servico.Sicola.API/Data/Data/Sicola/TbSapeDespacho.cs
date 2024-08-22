﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace PCDF.Servico.Sicola.API.Data.Data.Sicola
{
    /// <summary>
    /// Despacho do legista para a seção de protocolo (SAPE)
    /// </summary>
    public partial class TbSapeDespacho
    {
        /// <summary>
        /// Chave primaria autoincremental. Código do registro do despacho para a SAPE
        /// </summary>
        public int CdSapeDespacho { get; set; }
        /// <summary>
        /// Número do documento de referência para o despacho
        /// </summary>
        public string Referencia { get; set; }
        /// <summary>
        /// Data da inclusão do despacho
        /// </summary>
        public DateTime? DtInclusao { get; set; }
        /// <summary>
        /// Chave estrangeira na tabela tb_usuario. Código do usuário que incluiu o despacho
        /// </summary>
        public int? CdIncluidor { get; set; }
        /// <summary>
        /// Data informada pelo legista para o despacho
        /// </summary>
        public DateTime? DtDespacho { get; set; }
        /// <summary>
        /// Texto do despacho do legista para a SAPE
        /// </summary>
        public string Despacho { get; set; }
        /// <summary>
        /// Data da exclusão do despacho
        /// </summary>
        public DateTime? DtExclusao { get; set; }
        /// <summary>
        /// Chave estrangeira na tabela tb_usuario. Código do usuário que excluiu o despacho
        /// </summary>
        public int? CdExcluidor { get; set; }
        /// <summary>
        /// Data do recebimento do despacho na SAPE
        /// </summary>
        public DateTime? DtRecebido { get; set; }
        /// <summary>
        /// Chave estrangeira na tabela tb_usuario. Código do usuário que recebeu o despacho na SAPE
        /// </summary>
        public int? CdRecebedor { get; set; }
        public long? IdTrilhaAuditoria { get; set; }
    }
}