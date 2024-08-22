using Microsoft.EntityFrameworkCore;
using PCDF.Servico.Sicola.API.Data.Context;
using PCDF.Servico.Sicola.API.Data.Data.Sicola;
using PCDF.Servico.Sicola.API.Data.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace PCDF.Servico.Sicola.API.Data.Repositories
{
    public class LaudoVwRepository : ILaudoVwRepository
    {

        private readonly ImlContext _imlContext;

        public LaudoVwRepository(ImlContext imlContext)
        {
            _imlContext = imlContext;
        }

        public async Task<VwLaudo> ConsultaLauroPorNumeroAno(int numeroLaudo, int anoLaudo)
        {
            return await _imlContext.VwLaudo.Where(l => l.NrLaudo == numeroLaudo && l.AnoLaudo == anoLaudo).SingleOrDefaultAsync();
        }
    }
}
