using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PCDF.Servico.Sicola.API.Application.Interfaces;
using System.Net;
using System.Net.Http;
using System.Net.Mime;
using System.Threading.Tasks;


namespace PCDF.Servico.Sicola.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MensagemController : ControllerBase
    {
        private readonly IMensagemService _mensagemService;
        public MensagemController(IMensagemService mensagemService)
        {
            _mensagemService = mensagemService;
        }

        /// <summary>
        /// Notificar usuario com nova mensagem
        /// </summary>
        /// <remarks>
        /// Exemplo de request: 
        /// POST: /api/mensagem
        /// </remarks>
        /// <returns>Documento atualizado</returns>
        /// <response code="200">Usuario notificado com sucesso</response>
        /// <response code="400">Erro ao notificar o usuario</response>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Produces(MediaTypeNames.Application.Json)]
        [HttpPost("notificar/{matricula8DigitosRemetente}/{matricula8DigitosDestinatario}/{assunto}/{mensagem}")]
        public async Task<IActionResult> Notificar(string matricula8DigitosRemetente, string matricula8DigitosDestinatario, string assunto, string mensagem)
        {
            var result = await _mensagemService.Notificar(matricula8DigitosRemetente, matricula8DigitosDestinatario, assunto, mensagem);
            if (!result.Notificado)
            {
                var resp = new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    ReasonPhrase = result.MensagemNotificado
                };
                throw new System.Web.Http.HttpResponseException(resp);
            }
            return Ok(result);
        }
    }
}
