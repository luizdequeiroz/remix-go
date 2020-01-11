using Microsoft.AspNetCore.Mvc;
using service.Utilities.Enums;
using service.Utilities.Interfaces;
using System;
using System.Threading.Tasks;
using static api.Controllers.Treatments.Returns;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DynamicController : ControllerBase
    {
        private readonly IServiceSwitch serviceSwitch;

        public DynamicController(IServiceSwitch serviceSwitch)
        {
            this.serviceSwitch = serviceSwitch;
        }

        [HttpPost("{serviceType}")]
        public async Task<IActionResult> CreateAsync(ServiceType serviceType, object entity)
        {
            try
            {
                var registerCreated = await serviceSwitch.Case(serviceType).SetNewAsync(entity);

                return Success(registerCreated, "Registered successfully");
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
                    return Warning("None found");

                return Success(registers);
            }
            catch (Exception ex)
            {
                return Error(ex);
            }
        }
    }
}