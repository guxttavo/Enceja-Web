using Enceja.Domain.Entities;
using Enceja.Domain.Interfaces.Repositories;
using Enceja.Domain.Interfaces;

namespace Enceja.Domain.Services
{
    public class DisciplinaService : BaseService<Disciplina>, IDisciplinaService
    {
        public DisciplinaService(IBaseRepository<Disciplina> repository) : base(repository)
        {
        }
    }
}
