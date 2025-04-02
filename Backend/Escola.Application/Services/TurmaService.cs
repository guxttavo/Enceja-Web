using Enceja.Domain.Entities;
using Enceja.Domain.Interfaces;
using Enceja.Domain.Interfaces.Repositories;

namespace Enceja.Domain.Services
{
    public class TurmaService : BaseService<Turma>, ITurmaService
    {
        public TurmaService(IBaseRepository<Turma> repository) : base(repository)
        {
        }
    }
}
