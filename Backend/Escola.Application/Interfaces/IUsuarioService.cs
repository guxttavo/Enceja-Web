using Enceja.Domain.Entities;

namespace Enceja.Domain.Interfaces
{
    public interface IUsuarioService : IBaseService<Usuario>
    {
        Task<Usuario> GetByEmailAsync(string email);
    }
}
