using ExtensionsPlus;
using Microsoft.AspNetCore.Mvc;
using service.Utilities.Enums;
using service.Utilities.Interfaces;
using System;
using System.Threading.Tasks;
using static api.Controllers.Treatments.Returns;

namespace api.Controllers
{
    [Route("api")]
    [ApiController]
    public class DynamicController : ControllerBase
    {
        private readonly IServiceSwitch serviceSwitch;

        public DynamicController(IServiceSwitch serviceSwitch)
        {
            this.serviceSwitch = serviceSwitch;
        }

        [HttpPost("{serviceType}")]
        public async Task<IActionResult> CreateAsync(ServiceType serviceType, dynamic entity)
        {
            try
            {
                var registerCreated = await serviceSwitch.Case(serviceType).SetNewAsync(entity);

                return Success(registerCreated, $"{serviceType.ToDescriptionString()} criado com sucesso!");
            }
            catch (Exception ex)
            {
                return Error(ex);
            }
        }

        [HttpGet("{serviceType}")]
        public async Task<IActionResult> ReadAllAsync(ServiceType serviceType)
        {
            try
            {
                var registers = await serviceSwitch.Case(serviceType).GetAllAsync();

                if (registers.Count == 0)
                    return Warning($"Nenhum registro de {serviceType.ToDescriptionString()} encontrado!");

                return Success(registers);
            }
            catch (Exception ex)
            {
                return Error(ex);
            }
        }

        [HttpGet("{serviceType}/{id}")]
        public async Task<IActionResult> ReadByIdAsync(ServiceType serviceType, int id)
        {
            try
            {
                var register = await serviceSwitch.Case(serviceType).GetByIdAsync(id);

                if (register == null)
                    return Warning(
                        $"Nenhum registro de {serviceType.ToDescriptionString()} foi encontrado!", 
                        $"Talvez o registro de {serviceType.ToDescriptionString()} tenha sido deletado, contate o suporte."
                    );

                return Success(register);
            }
            catch (Exception ex)
            {
                return Error(ex);
            }
        }

        [HttpGet("{serviceType}/{propertyName}/{value}")]
        public async Task<IActionResult> ReadByPropertyAsync(ServiceType serviceType, string propertyName, string value)
        {
            try
            {
                var registers = await serviceSwitch.Case(serviceType).GetByPropertyAsync(propertyName, value);

                if (registers.Count == 0)
                    return Warning(
                        $"Nenhum registro de {serviceType.ToDescriptionString()} foi encontrado!",
                        $"Talvez o registro de {serviceType.ToDescriptionString()} tenha sido deletado, contate o suporte."
                    );

                return Success(registers);
            }
            catch (Exception ex)
            {
                return Error(ex);
            }
        }

        [HttpPut("{serviceType}/{id}")]
        public async Task<IActionResult> UpdateAsync(ServiceType serviceType, int id, dynamic entity)
        {
            try
            {
                entity.id = id;
                var registerUpdated = await serviceSwitch.Case(serviceType).AlterAsync(entity);

                return Success(registerUpdated, $"Registro de {serviceType.ToDescriptionString()} atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                return Error(ex);
            }
        }

        [HttpDelete("{serviceType}/{id}")]
        public async Task<IActionResult> DeleteAsync(ServiceType serviceType, int id)
        {
            try
            {
                if (!await serviceSwitch.Case(serviceType).DeleteAsync(id))
                    return Warning(
                        $"Não foi possível deletar o registro de {serviceType.ToDescriptionString()}!", 
                        $"Talvez o registro de {serviceType.ToDescriptionString()} já tenha sido deletado, contate o suporte."
                    );

                return Success($"Registro de {serviceType.ToDescriptionString()} deletado com sucesso!");
            }
            catch (Exception ex)
            {
                return Error(ex);
            }
        }
    }
}