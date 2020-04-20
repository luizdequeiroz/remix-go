using domain.Entities;
using Microsoft.AspNetCore.Mvc;
using service.Interfaces;
using System;
using System.Threading.Tasks;
using static api.Controllers.Treatments.Returns;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenericController<TIService, PrincipalEntity> : ControllerBase where TIService : IGenericService<PrincipalEntity> where PrincipalEntity : Entity
    {
        protected readonly TIService iService;

        protected readonly string createdMessage;
        protected readonly string readAllHasNoResultMessage;
        protected readonly string readByIdHasNoResultTitle;
        protected readonly string readByIdHasNoResultMessage;
        protected readonly string updatedMessage;
        protected readonly string deleteFailedTitle;
        protected readonly string deleteFailedMessage;
        protected readonly string deletedMessage;

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

        public GenericController(TIService iService) : this(iService,
            "Registered successfully",
            "None found",
            "No records found",
            "Maybe the record has been deleted, contact support",
            "Registration updated successfully",
            "Unable to delete record",
            "Maybe the record has already been deleted, contact support",
            "Record successfully deleted")
        {
        }

        [HttpPost]
        public virtual async Task<IActionResult> CreateAsync(PrincipalEntity entity)
        {
            try
            {
                var registerCreated = await iService.SetNewAsync(entity);

                return Success(registerCreated, createdMessage);
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
                var registers = await iService.GetAllAsync();

                if (registers.Count == 0)
                    return Warning(readAllHasNoResultMessage);

                return Success(registers);
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
                var register = await iService.GetByIdAsync(id);

                if (register == null)
                    return Warning(readByIdHasNoResultTitle, readByIdHasNoResultMessage);

                return Success(register);
            }
            catch (Exception ex)
            {
                return Error(ex);
            }
        }

        [HttpGet("{propertyName}/{value}")]
        public async Task<IActionResult> ReadByPropertyAsync(string propertyName, string value)
        {
            try
            {
                var registers = await iService.GetByPropertyAsync(propertyName, value);

                if (registers.Count == 0)
                    return Warning(readAllHasNoResultMessage);

                return Success(registers);
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
                var registerUpdated = await iService.AlterAsync(entity);

                return Success(registerUpdated, updatedMessage);
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