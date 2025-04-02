using Enceja.Application.Services;
using Enceja.Application.Entities;
using Enceja.Application.Interfaces.Repositories;
using Enceja.Application.Interfaces;


namespace Enceja.Application.Services
{
    public class UsuarioService : BaseService<Usuario>, IUsuarioService
    {
        public UsuarioService(IBaseRepository<Usuario> repository) : base(repository)
        {
        }
    }
}
