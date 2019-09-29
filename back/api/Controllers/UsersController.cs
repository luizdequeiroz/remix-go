using domain.Entities;
using Microsoft.AspNetCore.Mvc;
using service.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;
using static api.Controllers.Treatments.Returns;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService userService;

        public UsersController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> Create(User user)
        {
            try
            {
                var userCreated = await userService.SetNewAsync(user);

                return Success(userCreated, "Usuário criado com sucesso!");
            }
            catch (Exception ex)
            {
                return Error(ex);
            }
        }

        [HttpGet]
        public async Task<IActionResult> ReadAll()
        {
            try
            {
                var users = await userService.GetAllAsync();

                if (users.Count() == 0)
                    return Warning("Nenhum usuário encontrado!");

                return Success(users);
            }
            catch (Exception ex)
            {
                return Error(ex);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ReadById(int id)
        {
            try
            {
                var user = await userService.GetByIdAsync(id);

                if (user == null)
                    return Warning("Nenhum usuário foi encontrado!", "Talvez o usuário tenha sido deletado, contate o suporte.");

                return Success(user);
            }
            catch (Exception ex)
            {
                return Error(ex);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, User user)
        {
            try
            {
                user.Id = id;
                var userUpdated = await userService.AlterAsync(user);

                return Success(userUpdated, "Usuário atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                return Error(ex);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                if (!await userService.DeleteAsync(id))
                    return Warning("Não foi possível deletar o usuário!", "Talvez o usuário já tenha sido deletado, contate o suporte.");

                return Success("Usuário deletado com sucesso!");
            }
            catch (Exception ex)
            {
                return Error(ex);
            }
        }
    }
}
