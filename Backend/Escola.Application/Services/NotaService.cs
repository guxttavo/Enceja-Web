using Enceja.Application.Entities;
using Enceja.Application.Interfaces;
using Enceja.Application.Interfaces.Repositories;

namespace Enceja.Application.Services
{
    public class NotaService : BaseService<Nota>, INotaService
    {
        public NotaService(IBaseRepository<Nota> repository) : base(repository)
        {
        }
    }
}
