using System.Threading.Tasks;
using domain.Entities;

namespace service.Interfaces
{
    public interface IUserService : IGenericService<User>
    {
        Task<User> LoginAsync(User user);
        Task<User> SetNewUserAsync(User user);
    }
}
