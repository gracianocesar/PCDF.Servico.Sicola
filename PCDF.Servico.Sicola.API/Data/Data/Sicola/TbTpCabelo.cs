﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace PCDF.Servico.Sicola.API.Data.Data.Sicola
{
    /// <summary>
    /// Tabela básica de tipo de cabelo
    /// </summary>
    public partial class TbTpCabelo
    {
        /// <summary>
        /// Chave primaria autoincremental. Código do registro do tipo de cabelo
        /// </summary>
        public int CdTpCabelo { get; set; }
        /// <summary>
        /// Descrição do tipo de cabelo
        /// </summary>
        public string NmTpCabelo { get; set; }
        /// <summary>
        /// Informa se o registro foi excluído
        /// </summary>
        public bool? Excluido { get; set; }
        public long? IdTrilhaAuditoria { get; set; }
    }
}