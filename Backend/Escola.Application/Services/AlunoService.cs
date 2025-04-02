using Enceja.Domain.Entities;
using Enceja.Domain.Interfaces;
using Enceja.Domain.Interfaces.Repositories;

namespace Enceja.Domain.Services
{
    public class AlunoService : BaseService<Aluno>, IAlunoService
    {
        public AlunoService(IBaseRepository<Aluno> repository) : base(repository)
        {
        }
    }
}
