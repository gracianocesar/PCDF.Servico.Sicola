using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PCDF.Servico.Sicola.API.Domain.Entities;
using PCDF.ServicoSicola.API.Application.Interfaces;
using System.Net.Mime;
using System.Threading.Tasks;

namespace PCDF.ServicoSicola.API.Controllers
{
    /// <summary>
    /// Permite manipular as informações dos documentos do sicola
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class DocumentoAssinaturaController : ControllerBase
    {
        private readonly IDocumentoAssinaturaService _documentoAssinaturaService;

        public DocumentoAssinaturaController(IDocumentoAssinaturaService documentoAssinaturaService)
        {
            _documentoAssinaturaService = documentoAssinaturaService;
        }

        /// <summary>
        /// Retorna um documento (laudo ou aditamento) do sicola
        /// </summary>
        /// <remarks>
        /// Exemplo de request: 
        /// GET: /api/documentoassinatura/{idPdfLaudo}
        /// </remarks>
        /// <returns>Lista de distribuições</returns>
        /// <response code="200">Documento do sicola</response>
        /// <response code="404">Documento não encontrado</response>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [Produces(MediaTypeNames.Application.Json)]
        [HttpGet("{idPdfLaudo}")]
        public async Task<IActionResult> Obter(int idPdfLaudo)
        {
            var result = await _documentoAssinaturaService.Buscar(idPdfLaudo);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        /// <summary>
        /// Atualiza um documento (laudo ou aditamento) do sicola
        /// </summary>
        /// <remarks>
        /// Exemplo de request: 
        /// GET: /api/documentoassinatura
        /// </remarks>
        /// <returns>Documento atualizado</returns>
        /// <response code="200">Documento do sicola atualizado com sucesso</response>
        /// <response code="400">Erro ao atualizaro o documento</response>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Produces(MediaTypeNames.Application.Json)]
        [HttpPut]
        public async Task<IActionResult> AtualizarInformacoes(AssinaturaLaudo assinaturaLaudo)
        {
            var result = await _documentoAssinaturaService.Atualizar(assinaturaLaudo);

            if (!result)
            {
                return BadRequest();
            }

            return Ok();
        }

        /// <summary>
        /// Atualiza um documento (laudo ou aditamento) do sicola
        /// </summary>
        /// <remarks>
        /// Exemplo de request: 
        /// PUT: /api/documentoassinatura/assinado/{numeroProtocolo}/{anoProtocolo}/{codigoOrgaoProtocolo}
        /// </remarks>
        /// <returns>Documento atualizado</returns>
        /// <response code="200">Documento do sicola atualizado com sucesso</response>
        /// <response code="400">Erro ao atualizaro o documento</response>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Produces(MediaTypeNames.Application.Json)]
        [HttpPut("assinado/{numeroProtocolo}/{anoProtocolo}/{codigoOrgaoProtocolo}/{tipoDocumento}")]
        public async Task<IActionResult> ConfirmarAssinatura(int numeroProtocolo, int anoProtocolo, int codigoOrgaoProtocolo)
        {
            var result = await _documentoAssinaturaService.ConfirmarAssinatura(numeroProtocolo, anoProtocolo, codigoOrgaoProtocolo);

            if (!result)
            {
                return BadRequest();
            }

            return Ok();
        }
    }
}
