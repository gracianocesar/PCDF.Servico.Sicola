using PCDF.Servico.Sicola.API.Domain.Entities;
using System.Threading.Tasks;

namespace PCDF.ServicoSicola.API.Application.Interfaces
{
    public interface IDocumentoAssinaturaService
    {
        Task<DocumentoAssinatura> Buscar(int idPdfLaudo);

        Task<bool> Atualizar(AssinaturaLaudo assinaturaLaudo);

        Task<bool> ConfirmarAssinatura(int numeroProtocolo, int anoProtocolo, int codigoOrgaoProtocolo);

        Task<byte[]> ObterArquivo(int numeroProtocolo, int anoProtocolo, int codigoOrgao, int tipoDocumento);
        Task<bool> BlocoLaudoFinalizado(int numeroLaudo, int numeroProtocoloPai, int anoProtocoloPai, int codigoOrgaoProtocoloPai, int codigoTipoDocumento, bool assinado);
        Task<bool> AtualizarDataFimVigencia(int idPdfLaudo);
    }
}
