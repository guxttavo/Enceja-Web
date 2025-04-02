using Enceja.Application.Entities;
using Enceja.Application.Interfaces.Repositories;

namespace Enceja.Infrastructure.Repositories
{
    public class NotaRepository : BaseRepository<Nota>, INotaRepository
    {
        public NotaRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
