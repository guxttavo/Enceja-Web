using Escola.Application.Services;
using Escola.Domain.Entities;
using Escola.Domain.Interfaces.Repositories;
using Escola.Domain.Interfaces.Services;

namespace Escola.Domain.Services
{
    public class AlunoService : BaseService<Aluno>, IAlunoService
    {
        public AlunoService(IBaseRepository<Aluno> repository) : base(repository)
        {
        }
    }
}
