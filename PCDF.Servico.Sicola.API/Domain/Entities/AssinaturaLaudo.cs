namespace PCDF.Servico.Sicola.API.Domain.Entities
{
    public class AssinaturaLaudo
    {
        public int Id { get; set; }

        public int NumeroProtocoloPai { get; set; }

        public int AnoProtocoloPai { get; set; }

        public int CodigoOrgaoProtocoloPai { get; set; }

        public int NumeroProtocolo { get; set; }

        public int AnoProtocolo { get; set; }

        public int CodigoOrgaoProtocolo { get; set; }

        public int TipoDocumentoProtocolo { get; set; }

        public int NumeroDocumento { get; set; }
    }
}
