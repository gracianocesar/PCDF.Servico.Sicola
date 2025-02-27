﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace PCDF.Servico.Sicola.API.Data.Data.Sicola
{
    /// <summary>
    /// Arquivos digitais anexados via upload a um determinado laudo. PDF JPG DOC XLS
    /// </summary>
    public partial class TbLaudoArquivo
    {
        /// <summary>
        /// Chave primaria autoincremental. Código do registro do arquivo digital anexado ao laudo
        /// </summary>
        public int CdLaudoArquivo { get; set; }
        /// <summary>
        /// Chave estrangeira na tabela tb_laudo. Código do laudo que está vinculado ao arquivo digital anexado
        /// </summary>
        public int? CdLaudo { get; set; }
        /// <summary>
        /// Data em que o arquivo digital foi anexado
        /// </summary>
        public DateTime? DtInclusao { get; set; }
        /// <summary>
        /// Chave estrangeira na tabela tb_usuario. Código do usuário que anexou o arquivo digital ao laudo
        /// </summary>
        public int? CdIncluidor { get; set; }
        /// <summary>
        /// Identificação do computador que originou o upload do arquivo digital
        /// </summary>
        public string Ip { get; set; }
        /// <summary>
        /// Data da exclusão do registro do arquivo digital anexado. O arquivo gravado no HD não é excluído
        /// </summary>
        public DateTime? DtExclusao { get; set; }
        /// <summary>
        /// Chave estrangeira na tabela tb_usuario. Código do usuário que excluiu o registro do arquivo digital anexado
        /// </summary>
        public int? CdExcluidor { get; set; }
        /// <summary>
        /// Nome do arquivo gravado no HD na pasta ARQUIVOS
        /// </summary>
        public string NmArquivo { get; set; }
        public long? IdTrilhaAuditoria { get; set; }
    }
}