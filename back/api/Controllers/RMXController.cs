using domain.Entities;
using service.Interfaces;

namespace api.Controllers
{
    public class RMXController : GenericController<IRMXService, RMX>
    {
        public RMXController(IRMXService rmxService)
            : base(rmxService,
                "Ficha criada com sucesso!",
                "Nenhuma ficha encontrada!",
                "Nenhuma ficha foi encontrada!",
                "Talvez a ficha tenha sido deletada, contate o suporte.",
                "Ficha atualizada com sucesso!",
                "Não foi possível deletar a ficha!",
                "Talvez a ficha já tenha sido deletada, contate o suporte.",
                "Ficha deletada com sucesso!")
        {
        }
    }
}