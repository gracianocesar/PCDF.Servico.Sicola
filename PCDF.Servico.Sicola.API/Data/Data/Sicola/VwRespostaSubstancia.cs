﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace PCDF.Servico.Sicola.API.Data.Data.Sicola
{
    /// <summary>
    /// Resposta padronizada para exame laboratorial de uma substância
    /// </summary>
    public partial class VwRespostaSubstancia
    {
        public int CdRespostaSubstancia { get; set; }
        public int? CdSubstancia { get; set; }
        public string NmResposta { get; set; }
        public bool? Excluido { get; set; }
        public string NmSubstancia { get; set; }
    }
}