﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace PCDF.Servico.Sicola.API.Data.Data.Sicola
{
    /// <summary>
    /// Registro de critérios de pesquisa de laudos realizados no SICOLA
    /// </summary>
    public partial class VwLogPesquisaLaudo
    {
        public int CdLog { get; set; }
        public int? CdUsuario { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string Ip { get; set; }
        public string Criterio { get; set; }
        public string NmUsuario { get; set; }
        public string NmOrgaoLotacao { get; set; }
    }
}