using Microsoft.Extensions.Logging;
using PCDF.Servico.Sicola.API.Domain.Entities;
using PCDF.ServicoSicola.API.Application.Interfaces;
using PCDF.ServicoSicola.API.Data.Interfaces;
using System;
using System.Threading.Tasks;

namespace PCDF.ServicoSicola.API.Application.Services
{
    public class DocumentoAssinaturaService : IDocumentoAssinaturaService
    {
        private readonly IDocumentoAssinaturaRepository _documentoAssinaturaRepository;
        private readonly ILogger<IDocumentoAssinaturaService> _log;

        public DocumentoAssinaturaService(IDocumentoAssinaturaRepository documentoAssinaturaRepository, ILogger<IDocumentoAssinaturaService> log)
        {
            _documentoAssinaturaRepository = documentoAssinaturaRepository;
            _log = log;
        }

        public Task<DocumentoAssinatura> Buscar(int idPdfLaudo)
        {
            return _documentoAssinaturaRepository.Buscar(idPdfLaudo);
        }
        public Task<bool> Atualizar(AssinaturaLaudo assinaturaLaudo)
        {
            return _documentoAssinaturaRepository.Atualizar(assinaturaLaudo);
        }

        public Task<bool> ConfirmarAssinatura(int numeroProtocolo, int anoProtocolo, int codigoOrgaoProtocolo)
        {
            return _documentoAssinaturaRepository.ConfirmarAssinatura(numeroProtocolo, anoProtocolo, codigoOrgaoProtocolo);
        }

        public Task<byte[]> ObterArquivo(int numeroProtocolo, int anoProtocolo, int codigoOrgao, int tipoDocumento)
        {
            return _documentoAssinaturaRepository.ObterArquivo(numeroProtocolo, anoProtocolo, codigoOrgao, tipoDocumento);
        }

        public Task<bool> BlocoLaudoFinalizado(int numeroLaudo, int numeroProtocoloPai, int anoProtocoloPai, int codigoOrgaoProtocoloPai, int codigoTipoDocumento, bool assinado)
        {
            try
            {
                return _documentoAssinaturaRepository.BlocoLaudoFinalizado(numeroLaudo, numeroProtocoloPai, anoProtocoloPai, codigoOrgaoProtocoloPai, codigoTipoDocumento, assinado);
            }
            catch (Exception ex)
            {
                _log.LogError(ex, "Erro ao consultar bloco laudo finalizado");
            }
            return Task.FromResult(false);
        }

        public Task<bool> AtualizarDataFimVigencia(int idPdfLaudo)
        {
            try
            {
                return _documentoAssinaturaRepository.AtualizarDataFimVigencia(idPdfLaudo);
            }
            catch (Exception ex)
            {
                _log.LogError(ex, "Erro ao atualizar data fim vigência");
            }
            return Task.FromResult(false);
        }

    }
}
