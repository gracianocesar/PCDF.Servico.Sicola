using PCDF.Servico.Sicola.API.Domain.Entities;
using System.Threading.Tasks;

namespace PCDF.Servico.Sicola.API.Application.Interfaces
{
    public interface IUsuarioService
    {
        Task<Usuario> Buscar(string matricula8Digitos);
    }
}
