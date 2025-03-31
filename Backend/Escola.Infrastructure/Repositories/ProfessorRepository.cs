using Escola.Domain.Entities;
using Escola.Domain.Interfaces.Repositories;

namespace Escola.Infrastructure.Repositories
{
    public class ProfessorRepository : BaseRepository<Professor>, IProfessorRepository
    {
        public ProfessorRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
