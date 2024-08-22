﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace PCDF.Servico.Sicola.API.Data.Data.Sicola
{
    /// <summary>
    /// Estados da federação. Somente Brasil.
    /// </summary>
    public partial class TbEstado
    {
        /// <summary>
        /// Chave primaria autoincremental. Código do registro do estado brasileiro.
        /// </summary>
        public int CdEstado { get; set; }
        /// <summary>
        /// Nome do estado da federação
        /// </summary>
        public string NmEstado { get; set; }
        /// <summary>
        /// Sigla do estado da federação
        /// </summary>
        public string SiglaEstado { get; set; }
        /// <summary>
        /// Informa se o registro do estado foi excluído
        /// </summary>
        public bool? Excluido { get; set; }
        public long? IdTrilhaAuditoria { get; set; }
    }
}