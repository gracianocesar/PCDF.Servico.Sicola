﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace PCDF.Servico.Sicola.API.Data.Data.Sicola
{
    /// <summary>
    /// Laudos que fazem parte do memorando de envio de contraprova à CGCV pelo laboratório do IML
    /// </summary>
    public partial class TbContraprovaItem
    {
        /// <summary>
        /// Chave primaria autoincremental. Código do item registrado
        /// </summary>
        public int CdItem { get; set; }
        /// <summary>
        /// Chave estrangeira na tabela tb_contraprova. Código do registro do memorando de encaminhamento á CGCV
        /// </summary>
        public int CdContraprova { get; set; }
        /// <summary>
        /// Chave estrangeira na tabela tb_laudo. Código do laudo que faz parte do memorando de encaminhamento à CGCV
        /// </summary>
        public int CdLaudo { get; set; }
        /// <summary>
        /// Chave estrangeira na tabela tb_usuario. Código do usuário que incluiu o item no memorando
        /// </summary>
        public int CdIncluidor { get; set; }
        /// <summary>
        /// Informa se o registro foi excluído
        /// </summary>
        public bool? Excluido { get; set; }
        public long? IdTrilhaAuditoria { get; set; }
    }
}