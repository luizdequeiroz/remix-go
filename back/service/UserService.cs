using domain.Entities;
using repository.Interfaces;
using service.Interfaces;
using service.Utilities;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace service
{
    public class UserService : GenericService<User>, IUserService
    {
        private readonly CryptoUtility cryptoUtility;
        private readonly TokenUtility tokenUtility;

        public UserService(IGenericRepository<User> repository, CryptoUtility cryptoUtility, TokenUtility tokenUtility) 
            : base(repository)
        {
            this.cryptoUtility = cryptoUtility;
            this.tokenUtility = tokenUtility;
        }

        public async Task<User> LoginAsync(User user)
        {
            user.Password = cryptoUtility.EncryptPassword(user.Password);
            var userConsulted = (await repository.SelectWhere(u => u.Username == user.Username)).SingleOrDefault();

            if (userConsulted == null) return null;
            if (userConsulted.Password != user.Password)
            {
                var exception = new ArgumentException("Incorrect password!");
                throw exception;
            }

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

        public async Task<User> AlterUserAsync(User user)
        {
            if (!string.IsNullOrEmpty(user.Password))
            {
                if (string.IsNullOrEmpty(user.CurrentPassword))
                {
                    var exception = new ArgumentException("É preciso informar a senha atual para alteração da senha!");
                    throw exception;
                }

                var usuarioConsulted = (await repository.SelectWhere(u => u.Id == user.Id)).SingleOrDefault();

                user.Password = cryptoUtility.EncryptPassword(user.Password);
                user.CurrentPassword = cryptoUtility.EncryptPassword(user.CurrentPassword);
                if (usuarioConsulted.Password != user.Password)
                {
                    if (usuarioConsulted.Password != user.CurrentPassword)
                    {
                        var exception = new ArgumentException("Senha atual informada está incorreta!");
                        throw exception;
                    }
                }
            }

            return await AlterAsync(user);
        }
    }
}
