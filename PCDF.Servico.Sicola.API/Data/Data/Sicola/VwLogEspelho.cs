﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace PCDF.Servico.Sicola.API.Data.Data.Sicola
{
    /// <summary>
    /// Usuários que visualizaram as informações básicas do laudo (espelho) sem a parte da perícia médica
    /// </summary>
    public partial class VwLogEspelho
    {
        public string NmUsuario { get; set; }
        public int CdLogEspelho { get; set; }
        public int? CdLaudo { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string Ip { get; set; }
        public string NmOrgaoLotacao { get; set; }
        public string Matricula { get; set; }
    }
}