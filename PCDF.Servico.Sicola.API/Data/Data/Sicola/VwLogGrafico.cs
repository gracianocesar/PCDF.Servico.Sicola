﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace PCDF.Servico.Sicola.API.Data.Data.Sicola
{
    /// <summary>
    /// Registro de visualização de gráficos (JPG) dos gráficos por usuários do SICOLA
    /// </summary>
    public partial class VwLogGrafico
    {
        public int? CdLaudo { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string NmUsuario { get; set; }
        public string Ip { get; set; }
    }
}