using Enceja.Domain.Entities;
using System.Threading.Tasks;

namespace Enceja.Domain.Interfaces.Repositories
{
    public interface IUsuarioRepository : IBaseRepository<Usuario>
    {
        Task<Usuario> GetByEmailAsync(string email);
    }
}
