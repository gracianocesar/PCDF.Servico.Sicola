using Microsoft.AspNetCore.Mvc;
using Moq;
using PCDF.Servico.Sicola.API.Application.Services;
using PCDF.Servico.Sicola.API.Controllers;
using PCDF.Servico.Sicola.API.Data.Interfaces;
using PCDF.Servico.Sicola.API.Domain.Entities;
using System.Threading.Tasks;
using Xunit;

namespace PCDF.Servico.Sicola.Tests
{
    public class MensagemControllerTests
    {

        [Fact]
        public async Task Deve_Notificar_Um_Usuario()
        {
            var matricula8DigitosRemetente = "00030236";
            var matricula8DigitosDestinatario = "00019879";
            var assunto = "Assunto";
            var corpo = "Concluído exame ref. laudo <a href='mostraanda.asp?nr_laudo=302&ano_laudo=2021' target='_blank'>302/2021</a>";

            var mensagemRepository = new Mock<IMensagemRepository>();
            mensagemRepository.Setup(x => x.Gravar(It.IsAny<Mensagem>()).Result).Returns(true);


            var usuarioRepository = new Mock<IUsuarioRepository>();
            usuarioRepository.Setup(x => x.Buscar(matricula8DigitosRemetente).Result).Returns(new Usuario
            {
                Codigo = 5674,
                Matricula8Digitos = matricula8DigitosRemetente,
                Nome = "Thiago"
            });

            usuarioRepository.Setup(x => x.Buscar(matricula8DigitosDestinatario).Result).Returns(new Usuario
            {
                Codigo = 5680,
                Matricula8Digitos = matricula8DigitosDestinatario,
                Nome = "Cesar"
            });

            var service = new MensagemService(mensagemRepository.Object, usuarioRepository.Object);
            var controller = new MensagemController(service);

            var result = await controller.Notificar(matricula8DigitosRemetente, matricula8DigitosDestinatario, assunto, corpo);
            var retorno = result as OkObjectResult;
            var notificacao = new Notificacao
            {
                MensagemNotificado = ((Notificacao)retorno.Value).MensagemNotificado,
                Notificado = ((Notificacao)retorno.Value).Notificado
            };

            Assert.True(notificacao.Notificado);
        }
    }
}
