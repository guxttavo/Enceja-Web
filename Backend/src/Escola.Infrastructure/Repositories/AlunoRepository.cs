using Escola.Domain.Entities;
using Escola.Domain.Interfaces.Repositories;

namespace Escola.Infrastructure.Repositories
{
    public class AlunoRepository : BaseRepository<Aluno>, IAlunoRepository
    {
        public AlunoRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
