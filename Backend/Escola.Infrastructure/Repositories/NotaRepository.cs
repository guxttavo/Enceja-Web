using Escola.Domain.Entities;
using Escola.Domain.Interfaces.Repositories;

namespace Escola.Infrastructure.Repositories
{
    public class NotaRepository : BaseRepository<Nota>, INotaRepository
    {
        public NotaRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
