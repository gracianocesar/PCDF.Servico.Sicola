﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace PCDF.Servico.Sicola.API.Data.Data.Sicola
{
    /// <summary>
    /// Termo de movimentação de bens patrimoniais. Documento para transferir um bem patrimonial de uma seção para outra
    /// </summary>
    public partial class VwTmbp
    {
        public int CdPatrimonio { get; set; }
        public int CdTmbp { get; set; }
        public string NmPatrimonio { get; set; }
        public DateTime? DtMovimento { get; set; }
        public string Origem { get; set; }
        public string Destino { get; set; }
        public string Estado { get; set; }
        public int? CdSecaoOrigem { get; set; }
        public int? CdSecaoDestino { get; set; }
        public int? AnoTmbp { get; set; }
        public int? ValorTmbp { get; set; }
        public string ChefeOrigem { get; set; }
        public string ChefeDestino { get; set; }
        public string Tombamento { get; set; }
    }
}