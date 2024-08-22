﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace PCDF.Servico.Sicola.API.Data.Data.Sicola
{
    /// <summary>
    /// Alterações realizadas na qualificação do periciando do laudo
    /// </summary>
    public partial class TbLogRecepcao
    {
        /// <summary>
        /// Chave primaria autoincremental. Código do registro da alteração na qualificação do periciando
        /// </summary>
        public int CdLogRecepcao { get; set; }
        /// <summary>
        /// Chave estrangeira na tabela tb_laudo. Código do laudo que sofreu alteração na qualificação do periciando
        /// </summary>
        public int? CdLaudo { get; set; }
        /// <summary>
        /// Data da alteração na qualificação do periciando
        /// </summary>
        public DateTime? DtInclusao { get; set; }
        /// <summary>
        /// Informação da alteração realizada
        /// </summary>
        public string Loglog { get; set; }
        public long? IdTrilhaAuditoria { get; set; }
    }
}