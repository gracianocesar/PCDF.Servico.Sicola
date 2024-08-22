using PCDF.Servico.Sicola.API.Data.Context;
using PCDF.Servico.Sicola.API.Data.Data.Sicola;
using PCDF.Servico.Sicola.API.Data.Interfaces;
using PCDF.Servico.Sicola.API.Domain.Entities;
using System.Threading.Tasks;

namespace PCDF.Servico.Sicola.API.Data.Repositories
{
    public class MensagemRepository : IMensagemRepository
    {
        private readonly ImlContext _imlContext;

        public MensagemRepository(ImlContext imlContext)
        {
            _imlContext = imlContext;
        }

        public async Task<bool> Gravar(Mensagem mensagem)
        {
            _imlContext.TbMensagem.Add(new TbMensagem
            {
                CdDestinatario = mensagem.Destinatario.Codigo,
                CdRemetente = mensagem.Remetente.Codigo,
                DtMensagem = mensagem.DataMensagem,
                Mensagem = mensagem.Corpo,
                Assunto = mensagem.Assunto,
                ExcluidoD = false,
                ExcluidoR = false
            });
            return await _imlContext.SaveChangesAsync() > 0;
        }
    }
}
