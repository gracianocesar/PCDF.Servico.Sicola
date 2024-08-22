﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace PCDF.Servico.Sicola.API.Data.Data.Sicola
{
    /// <summary>
    /// Registro de critérios de pesquisa de laudos realizados no SICOLA
    /// </summary>
    public partial class TbLogPesquisaLaudo
    {
        /// <summary>
        /// Chave primaria autoincremental. Código do registro da pesquisa por laudo realizada
        /// </summary>
        public int CdLog { get; set; }
        /// <summary>
        /// Chave estrangeira na tabela tb_usuario. Código do usuário que realizou a pesquisa
        /// </summary>
        public int? CdUsuario { get; set; }
        /// <summary>
        /// Data da realização da pesquisa de laudo no SICOLA
        /// </summary>
        public DateTime? DtInclusao { get; set; }
        /// <summary>
        /// Identificação do computador utilizado para realizar a pesquisa pelo laudo
        /// </summary>
        public string Ip { get; set; }
        /// <summary>
        /// Descrição dos critérios utilizados na pesquisa pelo laudo
        /// </summary>
        public string Criterio { get; set; }
        public long? IdTrilhaAuditoria { get; set; }
    }
}