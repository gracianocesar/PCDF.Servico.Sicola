using PCDF.Servico.Sicola.API.Application.Interfaces;
using PCDF.Servico.Sicola.API.Data.Interfaces;
using PCDF.Servico.Sicola.API.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace PCDF.Servico.Sicola.API.Application.Services
{
    public class MensagemService : IMensagemService
    {
        public IMensagemRepository _mensagemRepository;
        public IUsuarioRepository _usuarioRepository;
        public MensagemService(IMensagemRepository mensagemRepository, IUsuarioRepository usuarioRepository)
        {
            _mensagemRepository = mensagemRepository;
            _usuarioRepository = usuarioRepository;
        }

        public Task<bool> Gravar(Mensagem mensagem)
        {
            return _mensagemRepository.Gravar(mensagem);
        }

        public async Task<Notificacao> Notificar(string matricula8DigitosRemetente
                                    , string matricula8DigitosDestinatario
                                    , string assunto
                                    , string mensagem)
        {
            var retonrnoNotificacao = new Notificacao();
            if (!string.IsNullOrEmpty(matricula8DigitosRemetente)
             && !string.IsNullOrEmpty(matricula8DigitosDestinatario)
             && !string.IsNullOrEmpty(assunto)
             && !string.IsNullOrEmpty(mensagem))
            {
                var remetente = _usuarioRepository.Buscar(matricula8DigitosRemetente).Result;
                var destinatario = _usuarioRepository.Buscar(matricula8DigitosDestinatario).Result;

                if (remetente != null && remetente.Codigo > 0
                 && destinatario != null && destinatario.Codigo > 0)
                {
                    var msg = new Mensagem
                    {
                        Assunto = assunto,
                        Corpo = mensagem,
                        DataMensagem = DateTime.Now,
                        Destinatario = destinatario,
                        Remetente = remetente
                    };

                    retonrnoNotificacao.Notificado = await _mensagemRepository.Gravar(msg);
                    if (retonrnoNotificacao.Notificado)
                    {
                        retonrnoNotificacao.MensagemNotificado = "Destinatário notifiado com sucesso.";
                    }
                    else
                    {
                        retonrnoNotificacao.MensagemNotificado = "Não foi possível notificar o usuário";
                    }
                }
                else
                {
                    retonrnoNotificacao.Notificado = false;
                    retonrnoNotificacao.MensagemNotificado = "Não foi possível notificar. Remetente e(ou) Destinatário não possue(m) cadastro no SICOLA.";
                }
            }
            return retonrnoNotificacao;
        }
    }
}
