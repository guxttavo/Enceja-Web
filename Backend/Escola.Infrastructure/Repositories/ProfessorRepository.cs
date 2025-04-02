using Enceja.Application.Entities;
using Enceja.Application.Interfaces.Repositories;

namespace Enceja.Infrastructure.Repositories
{
    public class ProfessorRepository : BaseRepository<Professor>, IProfessorRepository
    {
        public ProfessorRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
