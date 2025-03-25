using Escola.Application.Services;
using Escola.Domain.Entities;
using Escola.Domain.Interfaces.Repositories;
using Escola.Domain.Interfaces.Services;

namespace Escola.Domain.Services
{
    public class TurmaService : BaseService<Turma>, ITurmaService
    {
        public TurmaService(IBaseRepository<Turma> repository) : base(repository)
        {
        }
    }
}
