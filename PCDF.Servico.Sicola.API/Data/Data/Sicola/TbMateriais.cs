﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace PCDF.Servico.Sicola.API.Data.Data.Sicola
{
    /// <summary>
    /// Material de consumo utilizado no órgão
    /// </summary>
    public partial class TbMateriais
    {
        /// <summary>
        /// Chave primaria autoincremental. Código do registro do material de consumo
        /// </summary>
        public int CodMaterial { get; set; }
        /// <summary>
        /// Descrição do material de consumo utilizado no órgão
        /// </summary>
        public string DescMaterial { get; set; }
        /// <summary>
        /// Chave estrangeira na tabela tb_orgao. Código do órgão ao qual pertence o material de consumo
        /// </summary>
        public int? CodOrgao { get; set; }
        /// <summary>
        /// Quantidade mínima do material necessária em estoque
        /// </summary>
        public int? EstoqueMinimo { get; set; }
        /// <summary>
        /// Quantidade máxima do material necessária em estoque
        /// </summary>
        public int? EstoqueMaximo { get; set; }
        /// <summary>
        /// Quantidade atual do material em estoque no órgão
        /// </summary>
        public int? EstoqueAtual { get; set; }
        /// <summary>
        /// Unidade de medida do material
        /// </summary>
        public string UnidadeMedida { get; set; }
        /// <summary>
        /// Informa se o material de consumo foi excluído
        /// </summary>
        public string Excluido { get; set; }
        public long? IdTrilhaAuditoria { get; set; }
    }
}