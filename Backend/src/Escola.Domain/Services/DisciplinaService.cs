using Escola.Application.Services;
using Escola.Domain.Entities;
using Escola.Domain.Interfaces.Repositories;
using Escola.Domain.Interfaces.Services;

namespace Escola.Domain.Services
{
    public class DisciplinaService : BaseService<Disciplina>, IDisciplinaService
    {
        public DisciplinaService(IBaseRepository<Disciplina> repository) : base(repository)
        {
        }
    }
}
