﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace PCDF.Servico.Sicola.API.Data.Data.Sicola
{
    /// <summary>
    /// Metodologias utilizadas no laboratório para realizar exames
    /// </summary>
    public partial class TbMetodo
    {
        /// <summary>
        /// Chave primaria autoincremental. Código do registro do método de exame laboratorial
        /// </summary>
        public int CdMetodo { get; set; }
        /// <summary>
        /// Nome do método de exame utilizado no laboratório
        /// </summary>
        public string NmMetodo { get; set; }
        /// <summary>
        /// Informa se o registro foi excluído
        /// </summary>
        public bool? Excluido { get; set; }
        public long? IdTrilhaAuditoria { get; set; }
    }
}