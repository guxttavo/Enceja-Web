using Escola.Application.Services;
using Escola.Domain.Entities;
using Escola.Domain.Interfaces.Repositories;
using Escola.Domain.Interfaces.Services;

namespace Escola.Domain.Services
{
    public class NotaService : BaseService<Nota>, INotaService
    {
        public NotaService(IBaseRepository<Nota> repository) : base(repository)
        {
        }
    }
}
