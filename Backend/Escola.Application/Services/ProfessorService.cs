using Enceja.Application.Services;
using Enceja.Application.Entities;
using Enceja.Application.Interfaces.Repositories;
using Enceja.Application.Interfaces;

namespace Enceja.Application.Services
{
    public class ProfessorService : BaseService<Professor>, IProfessorService
    {
        public ProfessorService(IBaseRepository<Professor> repository) : base(repository)
        {
        }
    }
}
