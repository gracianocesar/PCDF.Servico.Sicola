﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace PCDF.Servico.Sicola.API.Data.Data.Sicola
{
    /// <summary>
    /// Laudos classificados como ignorados (periciandos sem identificação)
    /// </summary>
    public partial class TbIgnorado
    {
        /// <summary>
        /// Chave primaria autoincremental. Código do registro do laudo classificado como ignorado
        /// </summary>
        public int CdIgnorado { get; set; }
        /// <summary>
        /// Data em que o laudo foi classificado como ignorado pela seção de necrópsia
        /// </summary>
        public DateTime? DtInclusao { get; set; }
        /// <summary>
        /// Chave estrangeira na tabela tb_usuario. Código do usuário que classificou o laudo como sendo de uma pessoa ignorada
        /// </summary>
        public int? CdIncluidor { get; set; }
        /// <summary>
        /// Chave estrangeira na tabela tb_laudo. Código do laudo classificado como sendo de uma pessoa ignorada
        /// </summary>
        public int? CdLaudo { get; set; }
        /// <summary>
        /// Informa se o registro foi excluído
        /// </summary>
        public bool? Excluido { get; set; }
        /// <summary>
        /// Chave estrangeira na tabela tb_usuario. Código do usuário que excluiu o registro que classificava o laudo como ignorado
        /// </summary>
        public int? CdExcluidor { get; set; }
        public long? IdTrilhaAuditoria { get; set; }
    }
}