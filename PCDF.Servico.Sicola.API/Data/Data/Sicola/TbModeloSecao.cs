﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace PCDF.Servico.Sicola.API.Data.Data.Sicola
{
    /// <summary>
    /// Modelos de textos para as seções (partes) do laudo
    /// </summary>
    public partial class TbModeloSecao
    {
        /// <summary>
        /// Chave primaria autoincremental. Código do registro do modelo de texto para o laudo
        /// </summary>
        public int CdModeloSecao { get; set; }
        /// <summary>
        /// Nome descritivo do tipo de modelo de texto para o laudo
        /// </summary>
        public string NmModelo { get; set; }
        /// <summary>
        /// Chave estrangeira na tabela tb_tp_laudo. Código do tipo de laudo que receberá o modelo de texto
        /// </summary>
        public int? CdTpLaudo { get; set; }
        /// <summary>
        /// Chave estrangeira na tabela tb_secao_laudo. Código da seção (parte) do laudo que receberá o texto
        /// </summary>
        public int? CdSecaoLaudo { get; set; }
        /// <summary>
        /// Texto que será utilizado como modelo para novos laudos do tipo definido
        /// </summary>
        public string TextoModelo { get; set; }
        public long? IdTrilhaAuditoria { get; set; }
    }
}