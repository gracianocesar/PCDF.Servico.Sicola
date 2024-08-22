using System;

namespace PCDF.Servico.Sicola.API.Domain.Entities
{
    public class DocumentoAssinatura
    {
        public int Id { get; set; }

        public int CodigoLaudo { get; set; }

        public DateTime DataInclusao { get; set; }

        public int CodigoIncluidor { get; set; }

        public string TipoDocumento { get; set; }

        public bool Assinado { get; set; }

        public bool BlocoAssinaturasCriado { get; set; }

        public byte[] Conteudo { get; set; }
    }
}
