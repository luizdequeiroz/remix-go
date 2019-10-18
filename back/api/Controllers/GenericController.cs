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
    public class GenericController<TIService, PrincipalEntity> : ControllerBase where TIService : IGenericService<PrincipalEntity> where PrincipalEntity : Entity
    {
        protected readonly TIService iService;

        private readonly string createdMessage;
        private readonly string readAllHasNoResultMessage;
        private readonly string readByIdHasNoResultTitle;
        private readonly string readByIdHasNoResultMessage;
        private readonly string updatedMessage;
        private readonly string deleteFailedTitle;
        private readonly string deleteFailedMessage;
        private readonly string deletedMessage;

        public GenericController(TIService iService,
            string createdMessage,
            string readAllHasNoResultMessage,
            string readByIdHasNoResultTitle,
            string readByIdHasNoResultMessage,
            string updatedMessage,
            string deleteFailedTitle,
            string deleteFailedMessage,
            string deletedMessage
        )
        {
            this.iService = iService;
            this.createdMessage = createdMessage;
            this.readAllHasNoResultMessage = readAllHasNoResultMessage;
            this.readByIdHasNoResultTitle = readByIdHasNoResultTitle;
            this.readByIdHasNoResultMessage = readByIdHasNoResultMessage;
            this.updatedMessage = updatedMessage;
            this.deleteFailedTitle = deleteFailedTitle;
            this.deleteFailedMessage = deleteFailedMessage;
            this.deletedMessage = deletedMessage;
        }

        [HttpPost]
        public virtual async Task<IActionResult> CreateAsync(PrincipalEntity entity)
        {
            try
            {
                var userCreated = await iService.SetNewAsync(entity);

                return Success(userCreated, createdMessage);
            }
            catch (Exception ex)
            {
                return Error(ex);
            }
        }

        [HttpGet]
        public virtual async Task<IActionResult> ReadAllAsync()
        {
            try
            {
                var users = await iService.GetAllAsync();

                if (users.Count() == 0)
                    return Warning(readAllHasNoResultMessage);

                return Success(users);
            }
            catch (Exception ex)
            {
                return Error(ex);
            }
        }

        [HttpGet("{id}")]
        public virtual async Task<IActionResult> ReadByIdAsync(int id)
        {
            try
            {
                var user = await iService.GetByIdAsync(id);

                if (user == null)
                    return Warning(readByIdHasNoResultTitle, readByIdHasNoResultMessage);

                return Success(user);
            }
            catch (Exception ex)
            {
                return Error(ex);
            }
        }

        [HttpPut("{id}")]
        public virtual async Task<IActionResult> UpdateAsync(int id, PrincipalEntity entity)
        {
            try
            {
                entity.Id = id;
                var userUpdated = await iService.AlterAsync(entity);

                return Success(userUpdated, updatedMessage);
            }
            catch (Exception ex)
            {
                return Error(ex);
            }
        }

        [HttpDelete("{id}")]
        public virtual async Task<IActionResult> DeleteAsync(int id)
        {
            try
            {
                if (!await iService.DeleteAsync(id))
                    return Warning(deleteFailedTitle, deleteFailedMessage);

                return Success(deletedMessage);
            }
            catch (Exception ex)
            {
                return Error(ex);
            }
        }
    }
}