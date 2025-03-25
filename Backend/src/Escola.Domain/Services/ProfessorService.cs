using Escola.Application.Services;
using Escola.Domain.Entities;
using Escola.Domain.Interfaces.Repositories;
using Escola.Domain.Interfaces.Services;

namespace Escola.Domain.Services
{
    public class ProfessorService : BaseService<Professor>, IProfessorService
    {
        public ProfessorService(IBaseRepository<Professor> repository) : base(repository)
        {
        }
    }
}
