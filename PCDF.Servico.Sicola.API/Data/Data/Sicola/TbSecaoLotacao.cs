﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace PCDF.Servico.Sicola.API.Data.Data.Sicola
{
    /// <summary>
    /// Seção de lotação dos usuários do SICOLA
    /// </summary>
    public partial class TbSecaoLotacao
    {
        public TbSecaoLotacao()
        {
            TbUsuario = new HashSet<TbUsuario>();
        }

        /// <summary>
        /// Chave primaria autoincremental. Código da seção de lotação dos usuários do SICOLA
        /// </summary>
        public int CdSecaoLotacao { get; set; }
        /// <summary>
        /// Nome da seção
        /// </summary>
        public string NmSecaoLotacao { get; set; }
        /// <summary>
        /// Informa se o registro foi excluído
        /// </summary>
        public int? Excluido { get; set; }
        public long? IdTrilhaAuditoria { get; set; }

        public virtual ICollection<TbUsuario> TbUsuario { get; set; }
    }
}