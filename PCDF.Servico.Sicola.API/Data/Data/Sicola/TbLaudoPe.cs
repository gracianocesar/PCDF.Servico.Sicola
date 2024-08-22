﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace PCDF.Servico.Sicola.API.Data.Data.Sicola
{
    /// <summary>
    /// Laudos que foram feitos através de deslocamento externo ao IML pelo legista
    /// </summary>
    public partial class TbLaudoPe
    {
        /// <summary>
        /// Chave primaria autoincremental. Código do registro de um laudo feito fora do IML
        /// </summary>
        public int CdLaudoPe { get; set; }
        /// <summary>
        /// Chave estrangeira na tabela tb_laudo. Código do laudo que foi feito fora do IML
        /// </summary>
        public int? CdLaudo { get; set; }
        /// <summary>
        /// Data do registro da informação de que o laudo foi feito fora do IML
        /// </summary>
        public DateTime? DtInclusao { get; set; }
        /// <summary>
        /// Chave estrangeira na tabela tb_usuario. Código do usuário que informou que o laudo foi feito fora do IML
        /// </summary>
        public int? CdIncluidor { get; set; }
        /// <summary>
        /// Chave estrangeira na tabela tb_usuario. Código do perito do laudo que foi feito fora do IML
        /// </summary>
        public int? CdUsuario { get; set; }
        /// <summary>
        /// Informa se o registro foi excluído
        /// </summary>
        public bool? Excluido { get; set; }
        /// <summary>
        /// Local externo ao IML onde foi feita a perícia do laudo
        /// </summary>
        public string Local { get; set; }
        public long? IdTrilhaAuditoria { get; set; }
    }
}