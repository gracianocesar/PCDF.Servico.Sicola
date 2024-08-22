﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace PCDF.Servico.Sicola.API.Data.Data.Sicola
{
    /// <summary>
    /// Itens que compoem um termo de movimentação de bens patrimoniais (TMBP). 
    /// </summary>
    public partial class TbItemTmbp
    {
        /// <summary>
        /// Chave estrangeira na tabela tb_patrimonio. Código do bem patrimonial que compoe o TMBP
        /// </summary>
        public int CdPatrimonio { get; set; }
        /// <summary>
        /// Chave estrangeira na tabela tb_tmbp. Código do TMBP do qual o item faz parte
        /// </summary>
        public int CdTmbp { get; set; }
        public long? IdTrilhaAuditoria { get; set; }
    }
}