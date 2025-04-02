using Enceja.Domain.Services;
using Enceja.Domain.Entities;
using Enceja.Domain.Interfaces.Repositories;
using Enceja.Domain.Interfaces;

namespace Enceja.Domain.Services
{
    public class ProfessorService : BaseService<Professor>, IProfessorService
    {
        public ProfessorService(IBaseRepository<Professor> repository) : base(repository)
        {
        }
    }
}
