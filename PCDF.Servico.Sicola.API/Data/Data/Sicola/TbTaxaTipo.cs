﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace PCDF.Servico.Sicola.API.Data.Data.Sicola
{
    /// <summary>
    /// Tipo de parentesco ou autorização para o fornecimento da cópia do laudo ao solicitante
    /// </summary>
    public partial class TbTaxaTipo
    {
        /// <summary>
        /// Chave primaria autoincremental. Código do tipo de parentesco ou autorização
        /// </summary>
        public int CdTipo { get; set; }
        /// <summary>
        /// Descrição do parentesco ou autorização para fornecimento da cópia do laudo
        /// </summary>
        public string NmTipo { get; set; }
        /// <summary>
        /// Informa se o registro foi excluído
        /// </summary>
        public bool? Excluido { get; set; }
        public long? IdTrilhaAuditoria { get; set; }
    }
}