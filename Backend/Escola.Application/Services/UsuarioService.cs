using Enceja.Domain.Services;
using Enceja.Domain.Interfaces.Repositories;
using Enceja.Domain.Interfaces;
using Enceja.Domain.Entities;


namespace Enceja.Domain.Services
{
    public class UsuarioService : BaseService<Usuario>, IUsuarioService
    {
        public UsuarioService(IBaseRepository<Usuario> repository) : base(repository)
        {
        }
    }
}
