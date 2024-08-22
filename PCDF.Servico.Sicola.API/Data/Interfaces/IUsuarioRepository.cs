using PCDF.Servico.Sicola.API.Domain.Entities;
using System.Threading.Tasks;

namespace PCDF.Servico.Sicola.API.Data.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<Usuario> Buscar(string matricula8Digitos);
    }
}
