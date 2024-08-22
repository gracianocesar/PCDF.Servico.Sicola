
using Microsoft.EntityFrameworkCore;
using PCDF.Servico.Sicola.API.Data.Context;
using PCDF.Servico.Sicola.API.Data.Interfaces;
using PCDF.Servico.Sicola.API.Domain.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace PCDF.Servico.Sicola.API.Data.Repositories
{
    public class UsuarioRopository : IUsuarioRepository
    {
        private readonly ImlContext _imlContext;
        public UsuarioRopository(ImlContext imlContext)
        {
            _imlContext = imlContext;
        }

        public async Task<Usuario> Buscar(string matricula8Digitos)
        {
           return await _imlContext.TbUsuario.Where(u => u.Excluido == null)
                .Select(x => new Usuario
                {
                    Codigo = x.CdUsuario,
                    Matricula8Digitos = x.Matricula,
                    Nome = x.NmUsuario
                }).FirstOrDefaultAsync(x => x.Matricula8Digitos == matricula8Digitos);            
        }
    }
}
