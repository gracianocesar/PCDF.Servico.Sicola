﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace PCDF.Servico.Sicola.API.Data.Data.Sicola
{
    /// <summary>
    /// Usuário que auxiliou na veste do cadáver.
    /// </summary>
    public partial class VwVeste
    {
        public int CdVeste { get; set; }
        public int? CdCadaver { get; set; }
        public int? CdIncluidor { get; set; }
        public DateTime? DtInclusao { get; set; }
        public int? CdVestiu { get; set; }
        public string NmVestiu { get; set; }
        public string NmIncluidor { get; set; }
    }
}