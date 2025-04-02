using Enceja.Domain.Entities;
using Enceja.Domain.Interfaces.Repositories;

namespace Enceja.Infrastructure.Repositories
{
    public class TurmaRepository : BaseRepository<Turma>, ITurmaRepository
    {
        public TurmaRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
