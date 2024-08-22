﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace PCDF.Servico.Sicola.API.Data.Data.Sicola
{
    /// <summary>
    /// Usuários que não preencheram o cadastro com dados pessoais básicos.
    /// </summary>
    public partial class TbDaPendente
    {
        /// <summary>
        /// Chave estrangeira na tabela tb_usuario. Código do usuário que ainda não preencheu o cadastro com dados pessoais
        /// </summary>
        public int CdUsuario { get; set; }
        /// <summary>
        /// Tempo em dias que está pendente
        /// </summary>
        public int? Tempo { get; set; }
        public long? IdTrilhaAuditoria { get; set; }
    }
}