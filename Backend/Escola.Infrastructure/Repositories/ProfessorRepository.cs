using Enceja.Domain.Entities;
using Enceja.Domain.Interfaces.Repositories;

namespace Enceja.Infrastructure.Repositories
{
    public class ProfessorRepository : BaseRepository<Professor>, IProfessorRepository
    {
        public ProfessorRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
