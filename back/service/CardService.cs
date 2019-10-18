using domain.Entities;
using repository.Interfaces;
using service.Interfaces;

namespace service
{
    public class CardService : GenericService<Card>, ICardService
    {
        public CardService(IGenericRepository<Card> repository) : base(repository)
        {
        }
    }
}
