using PCDF.Servico.Sicola.API.Application.Interfaces;
using PCDF.Servico.Sicola.API.Data.Interfaces;
using PCDF.Servico.Sicola.API.Domain.Entities;
using System.Threading.Tasks;

namespace PCDF.Servico.Sicola.API.Application.Services
{
    public class LaudoVwService : ILaudoVwService
    {
        private readonly ILaudoVwRepository _laudoRepository;
        public LaudoVwService(ILaudoVwRepository laudoRepository)
        {
            _laudoRepository = laudoRepository;
        }
        public async Task<Laudo> ConsultaLauroPorNumeroAno(int numeroLaudo, int anoLaudo)
        {
            var laudo = new Laudo();
            if (numeroLaudo > 0 && anoLaudo > 0)
            {
                laudo = await _laudoRepository.ConsultaLauroPorNumeroAno(numeroLaudo, anoLaudo);
            }
            return laudo;
        }
    }
}
