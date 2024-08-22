using Microsoft.EntityFrameworkCore;
using PCDF.Servico.Sicola.API.Data.Context;
using PCDF.Servico.Sicola.API.Domain.Entities;
using PCDF.ServicoSicola.API.Data.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PCDF.ServicoSicola.API.Data.Repositories
{
    public class DocumentoAssinaturaRepository : IDocumentoAssinaturaRepository
    {
        private readonly ImlContext _imlContext;

        public DocumentoAssinaturaRepository(ImlContext imlContext)
        {
            _imlContext = imlContext;
        }

        public async Task<DocumentoAssinatura> Buscar(int idPdfLaudo)
        {
            return await _imlContext.TbAssinaturaLaudo
                .Select(x => new DocumentoAssinatura
                {
                    Id = x.IdPdfLaudo,
                    Assinado = x.Assinado.GetValueOrDefault(),
                    BlocoAssinaturasCriado = x.BlocoAssinaturasCriado.GetValueOrDefault(),
                    CodigoIncluidor = x.CdIncluidor.GetValueOrDefault(),
                    CodigoLaudo = x.CdLaudo.GetValueOrDefault(),
                    Conteudo = x.PdfLaudo,
                    DataInclusao = x.DtInclusao.GetValueOrDefault(),
                    TipoDocumento = x.DscTipoArquivoImagem
                }).SingleOrDefaultAsync(x => x.Id == idPdfLaudo);
        }

        public async Task<bool> Atualizar(AssinaturaLaudo assinaturaLaudo)
        {
            var documento = _imlContext.TbAssinaturaLaudo.SingleOrDefault(x => x.IdPdfLaudo == assinaturaLaudo.Id);

            if (documento == null)
            {
                throw new InvalidOperationException("O bloco de assinaturas para o protocolo informado não foi encontrado");
            }

            documento.NrProtocolo = assinaturaLaudo.NumeroProtocolo;
            documento.AnoProtocolo = assinaturaLaudo.AnoProtocolo;
            documento.CodOrgaoProtocolo = assinaturaLaudo.CodigoOrgaoProtocolo;
            documento.CodTipoDocumentoProtocolo = assinaturaLaudo.TipoDocumentoProtocolo;

            documento.NrProtocoloPai = assinaturaLaudo.NumeroProtocoloPai;
            documento.AnoProtocoloPai = assinaturaLaudo.AnoProtocoloPai;
            documento.CodOrgaoProtocoloPai = assinaturaLaudo.CodigoOrgaoProtocoloPai;

            documento.NrDocumento = assinaturaLaudo.NumeroDocumento;
            documento.BlocoAssinaturasCriado = true;

            return await _imlContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> AtualizarDataFimVigencia(int idPdfLaudo)
        {
            var laudo = _imlContext.TbAssinaturaLaudo.Where(l => l.IdPdfLaudo == idPdfLaudo).SingleOrDefault();
            laudo.DtFimVigencia = DateTime.Now;
            laudo.BlocoAssinaturasCriado = null;
            return await _imlContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> ConfirmarAssinatura(int numeroProtocolo, int anoProtocolo, int codigoOrgaoProtocolo)
        {
            var documento = _imlContext.TbAssinaturaLaudo.SingleOrDefault(x => x.NrProtocolo == numeroProtocolo &&
                                                                               x.AnoProtocolo == anoProtocolo &&
                                                                               x.CodOrgaoProtocolo == codigoOrgaoProtocolo);

            if (documento == null)
            {
                throw new InvalidOperationException("O bloco de assinaturas para o protocolo informado não foi encontrado");
            }

            documento.Assinado = true;

            return await _imlContext.SaveChangesAsync() > 0;
        }


        public async Task<byte[]> ObterArquivo(int numeroProtocolo, int anoProtocolo, int codigoOrgao, int tipoDocumento)
        {
            var pdf = await _imlContext.TbAssinaturaLaudo.FirstOrDefaultAsync(x => x.NrProtocolo == numeroProtocolo &&
                                                                        x.AnoProtocolo == anoProtocolo &&
                                                                        x.CodOrgaoProtocolo == codigoOrgao &&
                                                                        x.CodTipoDocumentoProtocolo == tipoDocumento);

            return pdf?.PdfLaudo;
        }

        public async Task<bool> BlocoLaudoFinalizado(int numeroLaudo, int numeroProtocoloPai, int anoProtocoloPai, int codigoOrgaoProtocoloPai, int codigoTipoDocumento, bool assinado)
        {
            var laudo = await _imlContext.TbAssinaturaLaudo.Where(x => x.NrLaudo == numeroLaudo
                                                                               && x.NrProtocoloPai == numeroProtocoloPai
                                                                               && x.AnoProtocoloPai == anoProtocoloPai
                                                                               && x.CodOrgaoProtocoloPai == codigoOrgaoProtocoloPai
                                                                               && x.CodTipoDocumentoProtocolo == codigoTipoDocumento
                                                                               && x.Assinado == assinado).FirstOrDefaultAsync();
            if (laudo != null)
                return true;
            return false;
        }
    }
}
