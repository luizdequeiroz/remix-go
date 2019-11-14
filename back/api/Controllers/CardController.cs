using domain.Entities;
using service.Interfaces;

namespace api.Controllers
{
    public class CardController : GenericController<ICardService, Card>
    {
        public CardController(ICardService cardService)
            : base(cardService,
                  "Ficha criada com sucesso!",
                  "Nenhuma ficha encontrada!",
                  "Nenhuma ficha foi encontrada!",
                  "Talvez a ficha tenha sido deletada, contate o suporte.",
                  "Ficga atualizada com sucesso!",
                  "Não foi possível deletar a ficha!",
                  "Talvez a ficha já tenha sido deletada, contate o suporte.",
                  "Ficha deletada com sucesso!")
        {
        }
    }
}