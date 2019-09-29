using domain.Entities;
using repository.Interfaces;
using service.Interfaces;

namespace service
{
    public class UserService : GenericService<User>, IUserService
    {
        public UserService(IGenericRepository<User> repository)
        {
            this.repository = repository;
        }
    }
}
