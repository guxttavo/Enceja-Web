using Enceja.Domain.Entities;
using Enceja.Domain.Interfaces;
using Enceja.Domain.Interfaces.Repositories;

namespace Enceja.Domain.Services
{
    public class NotaService : BaseService<Nota>, INotaService
    {
        public NotaService(IBaseRepository<Nota> repository) : base(repository)
        {
        }
    }
}
