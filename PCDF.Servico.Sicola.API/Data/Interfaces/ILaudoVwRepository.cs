using PCDF.Servico.Sicola.API.Data.Data.Sicola;
using System.Threading.Tasks;

namespace PCDF.Servico.Sicola.API.Data.Interfaces
{
    public interface ILaudoVwRepository
    {
        Task<VwLaudo> ConsultaLauroPorNumeroAno(int numeroLaudo, int anoLaudo);
    }
}
