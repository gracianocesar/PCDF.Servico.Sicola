﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace PCDF.Servico.Sicola.API.Data.Data.Sicola
{
    /// <summary>
    /// Pedidos de bens de consumo realizados pelas seções do IML para a seção de material
    /// </summary>
    public partial class TbPedidos
    {
        /// <summary>
        /// Chave primaria autoincremental. Código do registro do pedido de material criado pelas seções do IML
        /// </summary>
        public int CodPedido { get; set; }
        /// <summary>
        /// Data da criação do pedido de material de consumo
        /// </summary>
        public DateTime? DataPedido { get; set; }
        /// <summary>
        /// Chave estrangeira na tabela tb_secao_lotacao. Código da seção onde será entregue o pedido de material
        /// </summary>
        public int? CodSecao { get; set; }
        /// <summary>
        /// Chave estrangeira na tabela tb_orgao_lotacao. Código do órgão onde está localizada a seção solicitante
        /// </summary>
        public int? CodOrgao { get; set; }
        /// <summary>
        /// Matrícula do usuário que incluiu o pedido de material de consumo
        /// </summary>
        public string MatrPedido { get; set; }
        /// <summary>
        /// Informa se o pedido já foi atendido pela seção de material
        /// </summary>
        public string Fechado { get; set; }
        /// <summary>
        /// Informa se o registro foi excluído
        /// </summary>
        public string Excluido { get; set; }
        /// <summary>
        /// Data em que o material foi entregue à seção solicitante
        /// </summary>
        public DateTime? DataAtendeu { get; set; }
        public long? IdTrilhaAuditoria { get; set; }
        public string MatrPedidoBkp { get; set; }
    }
}