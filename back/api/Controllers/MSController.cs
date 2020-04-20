using domain.Entities;
using Microsoft.AspNetCore.Mvc;
using service.Interfaces;
using System.Threading.Tasks;

namespace api.Controllers
{
    public class MSController : GenericController<IMSService, MS>
    {
        public MSController(IMSService msService)
            : base(msService,
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