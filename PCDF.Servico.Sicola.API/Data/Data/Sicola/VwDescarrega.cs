﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace PCDF.Servico.Sicola.API.Data.Data.Sicola
{
    /// <summary>
    /// Técnicos que auxiliaram no descarregamento de um cadáver
    /// </summary>
    public partial class VwDescarrega
    {
        public string NmDescarregou { get; set; }
        public int CdDescarrega { get; set; }
        public int? CdCadaver { get; set; }
        public int? CdIncluidor { get; set; }
        public DateTime? DtInclusao { get; set; }
        public DateTime? HrInclusao { get; set; }
        public int? CdDescarregou { get; set; }
        public string NmIncluidor { get; set; }
    }
}