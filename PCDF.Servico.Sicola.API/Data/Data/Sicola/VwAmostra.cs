﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace PCDF.Servico.Sicola.API.Data.Data.Sicola
{
    /// <summary>
    /// Relação de amostras e suas respectivas substâncias suspeitas. Referente aos pedidos de exames laboratoriais.
    /// </summary>
    public partial class VwAmostra
    {
        public int CdAmostra { get; set; }
        public string NmAmostra { get; set; }
        public int? CdSubstancia { get; set; }
        public bool? Excluido { get; set; }
        public string NmSubstancia { get; set; }
    }
}