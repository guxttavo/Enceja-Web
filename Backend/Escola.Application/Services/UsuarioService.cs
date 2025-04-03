using Enceja.Domain.Services;
using Enceja.Domain.Interfaces.Repositories;
using Enceja.Domain.Interfaces;
using Enceja.Domain.Entities;

namespace Enceja.Application.Services
{
    public class UsuarioService : BaseService<Usuario>, IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository) : base(usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public async Task<Usuario> GetByEmailAsync(string email)
        {
            return await _usuarioRepository.GetByEmailAsync(email);
        }
    }
}
