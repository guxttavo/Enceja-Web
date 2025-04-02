using Enceja.Application.Entities;
using Enceja.Application.Interfaces;
using Enceja.Application.Interfaces.Repositories;

namespace Enceja.Application.Services
{
    public class AlunoService : BaseService<Aluno>, IAlunoService
    {
        public AlunoService(IBaseRepository<Aluno> repository) : base(repository)
        {
        }
    }
}
