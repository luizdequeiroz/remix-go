using api.DTOs;
using domain.Entities;
using ExtensionsPlus;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using service.Interfaces;
using System;
using System.Threading.Tasks;
using static api.Controllers.Treatments.Returns;

namespace api.Controllers
{
    //[Authorize("Bearer")]
    public class UsersController : GenericController<IUserService, User>
    {
        public UsersController(IUserService userService)
            : base(userService,
                "Usuário criado com sucesso!",
                "Nenhum usuário encontrada!",
                "Nenhum usuário foi encontrada!",
                "Talvez o usuário tenha sido deletado, contate o suporte.",
                "Usuário atualizado com sucesso!",
                "Não foi possível deletar o usuário!",
                "Talvez o usuário já tenha sido deletado, contate o suporte.",
                "Usuário deletado com sucesso!")
        {
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<IActionResult> LoginAsync(UserDTO userDTO)
        {
            try
            {
                var user = new User();
                user.SetProperties(userDTO);
                var userLogged = await iService.LoginAsync(user);

                if (userLogged == null)
                    return Warning("Usuário inválido.");

                return Success(userLogged);
            }
            catch (Exception ex)
            {
                return Error(ex);
            }
        }

        [AllowAnonymous]
        [HttpPost]
        public override async Task<IActionResult> CreateAsync(User user)
        {
            try
            {
                var userCreated = await iService.SetNewUserAsync(user);

                return Success(userCreated, createdMessage);
            }
            catch (Exception ex)
            {
                return Error(ex);
            }
        }

        [HttpPut("{id}")]
        public override async Task<IActionResult> UpdateAsync(int id, User user)
        {
            try
            {
                user.Id = id;
                var userAltered = await iService.AlterUserAsync(user);

                return Success(userAltered, updatedMessage);
            }
            catch (Exception ex)
            {
                return Error(ex);
            }
        }
    }
}
