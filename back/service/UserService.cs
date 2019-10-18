using System.Linq;
using System.Threading.Tasks;
using domain.Entities;
using repository.Interfaces;
using service.Interfaces;
using service.Utilities;

namespace service
{
    public class UserService : GenericService<User>, IUserService
    {
        private readonly CryptoUtility cryptoUtility;
        private readonly TokenUtility tokenUtility;

        public UserService(IGenericRepository<User> repository, CryptoUtility cryptoUtility, TokenUtility tokenUtility) : base(repository)
        {
            this.cryptoUtility = cryptoUtility;
            this.tokenUtility = tokenUtility;
        }

        public async Task<User> LoginAsync(User user)
        {
            user.Password = cryptoUtility.EncryptPassword(user.Password);
            var userConsulted = (await repository.SelectWhere(u => u.Username == user.Username && u.Password == user.Password)).SingleOrDefault();
            if (userConsulted == null) return null;

            var token = tokenUtility.GetToken(userConsulted);
            userConsulted.Token = token;
            userConsulted.Cards = null;
            return userConsulted;
        }

        public async Task<User> SetNewUserAsync(User user)
        {
            user.Password = cryptoUtility.EncryptPassword(user.Password);
            return await SetNewAsync(user);
        }
    }
}
