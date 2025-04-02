using Enceja.Domain.Entities;
using Enceja.Domain.Interfaces.Repositories;

namespace Enceja.Infrastructure.Repositories
{
    public class NotaRepository : BaseRepository<Nota>, INotaRepository
    {
        public NotaRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
