using domain.Entities;
using repository.Interfaces;
using service.Interfaces;

namespace service
{
    public class RMXService : GenericService<RMX>, IRMXService
    {
        public RMXService(IGenericRepository<RMX> repository) 
            : base(repository)
        {
        }
    }
}
