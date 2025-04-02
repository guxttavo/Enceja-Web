using Enceja.Application.Entities;
using Enceja.Application.Interfaces.Repositories;

namespace Enceja.Infrastructure.Repositories
{
    public class DisciplinaRepository : BaseRepository<Disciplina>, IDisciplinaRepository
    {
        public DisciplinaRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
