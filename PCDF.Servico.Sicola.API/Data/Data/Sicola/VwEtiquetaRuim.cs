﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace PCDF.Servico.Sicola.API.Data.Data.Sicola
{
    /// <summary>
    /// Etiquetas da Central de Guarda e Custódia de Vestígio que foram danificadas dentro do IML
    /// </summary>
    public partial class VwEtiquetaRuim
    {
        public int CdEtiqueta { get; set; }
        public int? Numero { get; set; }
        public int? CdMotivo { get; set; }
        public int? CdIncluidor { get; set; }
        public DateTime? DtInclusao { get; set; }
        public int? CdExcluidor { get; set; }
        public DateTime? DtExclusao { get; set; }
        public string NmMotivo { get; set; }
    }
}