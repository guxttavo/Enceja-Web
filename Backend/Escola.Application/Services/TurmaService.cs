using Enceja.Application.Entities;
using Enceja.Application.Interfaces;
using Enceja.Application.Interfaces.Repositories;

namespace Enceja.Application.Services
{
    public class TurmaService : BaseService<Turma>, ITurmaService
    {
        public TurmaService(IBaseRepository<Turma> repository) : base(repository)
        {
        }
    }
}
