using domain.Entities;
using service.Interfaces;

namespace api.Controllers
{
    public class CardController : GenericController<ICardService, Card>
    {
        public CardController(ICardService cardService)
            : base(cardService)
        {
        }
    }
}