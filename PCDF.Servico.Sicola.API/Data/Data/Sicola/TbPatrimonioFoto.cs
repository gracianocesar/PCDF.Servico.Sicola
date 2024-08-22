﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace PCDF.Servico.Sicola.API.Data.Data.Sicola
{
    /// <summary>
    /// Fotografias dos bens patrimoniais do IML
    /// </summary>
    public partial class TbPatrimonioFoto
    {
        /// <summary>
        /// Chave primaria autoincremental. Código do registro da fotografia de um bem patrimonial
        /// </summary>
        public int CdPatrimonioFoto { get; set; }
        /// <summary>
        /// Nome do arquivo JPG gravado na pasta fotopatrimonio
        /// </summary>
        public string NmArquivo { get; set; }
        /// <summary>
        /// Data da inclusão da fotografia do bem
        /// </summary>
        public DateTime? DtInclusao { get; set; }
        /// <summary>
        /// Chave estrangeira na tabela tb_usuario. Código do usuário que incluiu a fotografia do bem patrimonial
        /// </summary>
        public int? CdIncluidor { get; set; }
        /// <summary>
        /// Descrição da fotografia
        /// </summary>
        public string Legenda { get; set; }
        /// <summary>
        /// Data em que a fotografia foi registrada
        /// </summary>
        public DateTime? DtImagem { get; set; }
        /// <summary>
        /// Chave estrangeira na tabela tb_patrimonio. Código do patrimônio no cadastro de bens do IML
        /// </summary>
        public int? CdPatrimonio { get; set; }
        public long? IdTrilhaAuditoria { get; set; }
    }
}