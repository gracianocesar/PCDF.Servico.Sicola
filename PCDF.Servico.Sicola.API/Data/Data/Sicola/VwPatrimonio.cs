﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace PCDF.Servico.Sicola.API.Data.Data.Sicola
{
    /// <summary>
    /// Bens patrimoniais do IML
    /// </summary>
    public partial class VwPatrimonio
    {
        public string NmUsuario { get; set; }
        public string NmSecaoLotacao { get; set; }
        public string NmOrgaoLotacao { get; set; }
        public bool? Excluido { get; set; }
        public DateTime? DtBaixa { get; set; }
        public string Estado { get; set; }
        public string Tombamento { get; set; }
        public string NmPatrimonio { get; set; }
        public DateTime? DtIncorporou { get; set; }
        public DateTime? HrInclusao { get; set; }
        public DateTime? DtInclusao { get; set; }
        public int CdPatrimonio { get; set; }
        public int? CdOrgaoLotacao { get; set; }
        public string NrSerie { get; set; }
        public string Documento { get; set; }
        public int? CdSecaoLotacao { get; set; }
        public string CodigoDrm { get; set; }
    }
}