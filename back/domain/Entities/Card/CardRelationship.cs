using System.ComponentModel.DataAnnotations.Schema;

namespace domain.Entities
{
    public abstract class CardRelationship : Entity
    {
        [ForeignKey("Card")]
        public int CardId { get; set; }
        public Card Card { get; set; }
    }
}
