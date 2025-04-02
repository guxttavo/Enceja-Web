using Enceja.Application.Entities;
using Enceja.Application.Interfaces.Repositories;
using Enceja.Application.Interfaces;

namespace Enceja.Application.Services
{
    public class DisciplinaService : BaseService<Disciplina>, IDisciplinaService
    {
        public DisciplinaService(IBaseRepository<Disciplina> repository) : base(repository)
        {
        }
    }
}
