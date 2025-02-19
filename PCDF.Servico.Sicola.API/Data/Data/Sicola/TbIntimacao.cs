﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace PCDF.Servico.Sicola.API.Data.Data.Sicola
{
    /// <summary>
    /// Intimações de periciandos para comparecimento ao IML. Esta tabela e o recurso nunca foram utilizados.
    /// </summary>
    public partial class TbIntimacao
    {
        /// <summary>
        /// Chave primaria autoincremental. Código do registro da intimação de periciando
        /// </summary>
        public int CdIntimacao { get; set; }
        /// <summary>
        /// Data da inclusão da intimação
        /// </summary>
        public DateTime? DtIncluiu { get; set; }
        /// <summary>
        /// Chave estrangeira na tabela tb_usuario. Código do usuário que incluiu a intimação
        /// </summary>
        public int? CdIncluiu { get; set; }
        /// <summary>
        /// Data da assinatura da intimação pelo IML
        /// </summary>
        public DateTime? DtAssinatura { get; set; }
        /// <summary>
        /// Chave estrangeira na tabela tb_secao_lotacao
        /// </summary>
        public int? CdSecao { get; set; }
        /// <summary>
        /// Nome do periciando intimado a comparecer ao IML
        /// </summary>
        public string NmIntimado { get; set; }
        /// <summary>
        /// Endereço do periciando intimado
        /// </summary>
        public string Endereco { get; set; }
        /// <summary>
        /// Data do comparecimento do periciando intimado
        /// </summary>
        public DateTime? DtIntimacao { get; set; }
        /// <summary>
        /// Chave estrangeira na tabela tb_motivo_intimacao. Código do motivo da intimação do periciando
        /// </summary>
        public int? CdMotivo { get; set; }
        /// <summary>
        /// Chave estrangeira na tabela tb_orgao. Código do órgão de comparecimento
        /// </summary>
        public int? CdOrgao { get; set; }
        public long? IdTrilhaAuditoria { get; set; }
    }
}