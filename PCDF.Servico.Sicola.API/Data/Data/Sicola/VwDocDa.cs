﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace PCDF.Servico.Sicola.API.Data.Data.Sicola
{
    /// <summary>
    /// Documentos emitidos pela D.A. Este recurso nunca foi utilizado.
    /// </summary>
    public partial class VwDocDa
    {
        public string Protocolo { get; set; }
        public bool? Excluido { get; set; }
        public string Obs { get; set; }
        public string Assunto { get; set; }
        public string Destino { get; set; }
        public DateTime? DtIncluiu { get; set; }
        public int? CdIncluiu { get; set; }
        public int? CdSecaoEmite { get; set; }
        public int? Numero { get; set; }
        public int? CdTpDocDa { get; set; }
        public string Descricao { get; set; }
        public string NmSecaoEmite { get; set; }
        public string NmIncluiu { get; set; }
        public int CdDocDa { get; set; }
    }
}