using Enceja.Application.Entities;
using Enceja.Application.Interfaces.Repositories;

namespace Enceja.Infrastructure.Repositories
{
    public class AlunoRepository : BaseRepository<Aluno>, IAlunoRepository
    {
        public AlunoRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
