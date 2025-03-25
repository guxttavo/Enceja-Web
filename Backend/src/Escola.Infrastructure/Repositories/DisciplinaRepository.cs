using Escola.Domain.Entities;
using Escola.Domain.Interfaces.Repositories;

namespace Escola.Infrastructure.Repositories
{
    public class DisciplinaRepository : BaseRepository<Disciplina>, IDisciplinaRepository
    {
        public DisciplinaRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
