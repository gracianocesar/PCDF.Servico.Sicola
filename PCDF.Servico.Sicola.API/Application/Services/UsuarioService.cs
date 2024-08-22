using PCDF.Servico.Sicola.API.Application.Interfaces;
using PCDF.Servico.Sicola.API.Data.Interfaces;
using PCDF.Servico.Sicola.API.Domain.Entities;
using System.Threading.Tasks;

namespace PCDF.Servico.Sicola.API.Application.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        public Task<Usuario> Buscar(string matricula8Digitos)
        {
            return _usuarioRepository.Buscar(matricula8Digitos);
        }
    }
}
