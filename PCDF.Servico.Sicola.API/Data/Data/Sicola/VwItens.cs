﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace PCDF.Servico.Sicola.API.Data.Data.Sicola
{
    /// <summary>
    /// Itens de bens de consumo que fazem parte de um pedido de material de consumo feito à seção de material
    /// </summary>
    public partial class VwItens
    {
        public int CodItem { get; set; }
        public int? CodPedido { get; set; }
        public int? QuantidadePedida { get; set; }
        public int? QuantidadeAtendida { get; set; }
        public int? CodOrgao { get; set; }
        public string Excluido { get; set; }
        public int? CodMaterial { get; set; }
        public string DescMaterial { get; set; }
    }
}