using Escola.Domain.Entities;
using Escola.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Escola.Infrastructure.Repositories
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<Usuario> GetByCpfAsync(string cpf)
        {
            return await _context.Usuarios.FirstOrDefaultAsync(usuario => usuario.Cpf == cpf);
        }
    }
}
