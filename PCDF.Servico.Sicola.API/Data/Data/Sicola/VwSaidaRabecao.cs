﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace PCDF.Servico.Sicola.API.Data.Data.Sicola
{
    /// <summary>
    /// Livro de controle de saídas do rabecão
    /// </summary>
    public partial class VwSaidaRabecao
    {
        public int CdSaidaRabecao { get; set; }
        public int? CdLaudo { get; set; }
        public DateTime? DtInclusao { get; set; }
        public int? CdIncluidor { get; set; }
        public bool? Excluido { get; set; }
        public int? CdOrgao { get; set; }
        public int? NrGuia { get; set; }
        public int? AnoGuia { get; set; }
        public int? NrOcorrencia { get; set; }
        public int? AnoOcorrencia { get; set; }
        public DateTime? DtPedido { get; set; }
        public string OperadorCiade { get; set; }
        public string Local { get; set; }
        public string Periciando { get; set; }
        public int? CdSexo { get; set; }
        public string Causa { get; set; }
        public int? CdMotorista { get; set; }
        public int? CdViatura { get; set; }
        public DateTime? DtSaida { get; set; }
        public DateTime? DtChegada { get; set; }
        public string OperadorIml { get; set; }
        public int? NrLaudo { get; set; }
        public int? AnoLaudo { get; set; }
        public string NmIncluidor { get; set; }
        public string NmOrgao { get; set; }
        public string NmSexo { get; set; }
        public string NmMotorista { get; set; }
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Prefixo { get; set; }
        public string Obs { get; set; }
        public string NmExcluidor { get; set; }
        public DateTime? DtIc { get; set; }
    }
}