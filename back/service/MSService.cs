using domain.Entities;
using repository.Interfaces;
using service.Interfaces;

namespace service
{
    public class MSService : GenericService<MS>, IMSService
    {
        public MSService(IGenericRepository<MS> repository) 
            : base(repository)
        {
        }
    }
}
