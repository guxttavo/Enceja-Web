using Enceja.Application.Entities;
using Enceja.Application.Interfaces.Repositories;

namespace Enceja.Infrastructure.Repositories
{
    public class TurmaRepository : BaseRepository<Turma>, ITurmaRepository
    {
        public TurmaRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
