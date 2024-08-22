using PCDF.Servico.Sicola.API.Domain.Entities;
using System.Threading.Tasks;

namespace PCDF.Servico.Sicola.API.Application.Interfaces
{
    public interface ILaudoVwService
    {
        Task<Laudo> ConsultaLauroPorNumeroAno(int numeroLaudo, int anoLaudo);
    }
}
