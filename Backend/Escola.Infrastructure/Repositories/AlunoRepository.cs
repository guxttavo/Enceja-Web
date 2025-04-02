using Enceja.Domain.Entities;
using Enceja.Domain.Interfaces.Repositories;

namespace Enceja.Infrastructure.Repositories
{
    public class AlunoRepository : BaseRepository<Aluno>, IAlunoRepository
    {
        public AlunoRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
