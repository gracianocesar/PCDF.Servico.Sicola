﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace PCDF.Servico.Sicola.API.Data.Data.Sicola
{
    /// <summary>
    /// Papiloscopistas que confirmaram a identificação do cadáver
    /// </summary>
    public partial class TbLaudoIiPerito
    {
        /// <summary>
        /// Chave estrangeira na tabela tb_laudo_ii. Código do pedido de identificação papiloscópica
        /// </summary>
        public int CdLaudoIi { get; set; }
        /// <summary>
        /// Chave estrangeira na tabela tb_perito_ii. Código do papiloscopista que trabalhou na identificação do cadáver
        /// </summary>
        public int CdPeritoIi { get; set; }
        public int? CdNecropapiloscopica { get; set; }
        public DateTime? DtInclusao { get; set; }
        public int? CdIncluidor { get; set; }
        public long? IdTrilhaAuditoria { get; set; }
    }
}