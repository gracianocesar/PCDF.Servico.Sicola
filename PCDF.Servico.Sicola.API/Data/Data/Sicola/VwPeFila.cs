﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace PCDF.Servico.Sicola.API.Data.Data.Sicola
{
    /// <summary>
    /// Fila de legistas para deslocamento emergencial fora do IML. Ordenada pela quantidade de deslocamentos já realizados e pela matrícula
    /// </summary>
    public partial class VwPeFila
    {
        public int CdUsuario { get; set; }
        public int? Pontuacao { get; set; }
        public string NmUsuario { get; set; }
        public string Guerra { get; set; }
        public string Matricula { get; set; }
        public DateTime? DtLaudo { get; set; }
    }
}