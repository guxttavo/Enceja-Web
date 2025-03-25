using Escola.Domain.Entities;
using Escola.Domain.Interfaces.Repositories;

namespace Escola.Infrastructure.Repositories
{
    public class TurmaRepository : BaseRepository<Turma>, ITurmaRepository
    {
        public TurmaRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
