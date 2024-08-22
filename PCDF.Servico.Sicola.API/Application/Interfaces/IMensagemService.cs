using PCDF.Servico.Sicola.API.Domain.Entities;
using System.Threading.Tasks;

namespace PCDF.Servico.Sicola.API.Application.Interfaces
{
    public interface IMensagemService
    {
        Task<bool> Gravar(Mensagem mensagem);
        Task<Notificacao> Notificar(string matricula8DigitosRemetente, string matricula8DigitosDestinatario, string assunto, string mensagem);
    }
}
