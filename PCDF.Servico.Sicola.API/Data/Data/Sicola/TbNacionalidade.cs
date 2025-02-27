﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace PCDF.Servico.Sicola.API.Data.Data.Sicola
{
    /// <summary>
    /// Tabela básica com os países para registrar a nacionalidade dos periciandos
    /// </summary>
    public partial class TbNacionalidade
    {
        /// <summary>
        /// Chave primaria autoincremental. Código do registro do país
        /// </summary>
        public int CdNacionalidade { get; set; }
        /// <summary>
        /// Nome do país referente a nacionalidade do periciando
        /// </summary>
        public string NmNacionalidade { get; set; }
        /// <summary>
        /// Informa se o registro foi excluído
        /// </summary>
        public bool? Excluido { get; set; }
        public long? IdTrilhaAuditoria { get; set; }
    }
}