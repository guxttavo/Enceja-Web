using Enceja.Domain.Entities;
using Enceja.Domain.Interfaces.Repositories;

namespace Enceja.Infrastructure.Repositories
{
    public class DisciplinaRepository : BaseRepository<Disciplina>, IDisciplinaRepository
    {
        public DisciplinaRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
