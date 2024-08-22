﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace PCDF.Servico.Sicola.API.Data.Data.Sicola
{
    /// <summary>
    /// Mensagens enviadas e recebidas entre usuários do sistema
    /// </summary>
    public partial class TbMensagem
    {
        /// <summary>
        /// Chave primaria autoincremental. Código do registro da mensagem enviada no SICOLA
        /// </summary>
        public int CdMensagem { get; set; }
        /// <summary>
        /// Chave estrangeira na tabela tb_usuario. Código do usuário que enviou a mensagem
        /// </summary>
        public int? CdRemetente { get; set; }
        /// <summary>
        /// Chave estrangeira na tabela tb_usuario. Código do usuário destinatário da mensagem
        /// </summary>
        public int? CdDestinatario { get; set; }
        /// <summary>
        /// Data da criação da mensagem pelo remetente
        /// </summary>
        public DateTime? DtMensagem { get; set; }
        /// <summary>
        /// Conteúdo da mensagem enviada
        /// </summary>
        public string Mensagem { get; set; }
        /// <summary>
        /// Data do recebimento da mensagem pelo destinatário
        /// </summary>
        public DateTime? DtRecebimento { get; set; }
        /// <summary>
        /// Informa se a mensagem foi excluída pelo remetente (não exclui para o destinatário)
        /// </summary>
        public bool? ExcluidoR { get; set; }
        /// <summary>
        /// Informa se a mensagem foi excluída pelo destinatário (não exclui para o remetente)
        /// </summary>
        public bool? ExcluidoD { get; set; }
        /// <summary>
        /// Resumo do conteúdo da mensagem
        /// </summary>
        public string Assunto { get; set; }
        public long? IdTrilhaAuditoria { get; set; }
    }
}