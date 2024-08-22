using PCDF.Servico.Sicola.API.Domain.Entities;
using System.Threading.Tasks;

namespace PCDF.Servico.Sicola.API.Data.Interfaces
{
    public interface IMensagemRepository
    {
        Task<bool> Gravar(Mensagem mensagem);
    }
}
