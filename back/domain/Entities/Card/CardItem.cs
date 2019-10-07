using System.ComponentModel.DataAnnotations.Schema;

namespace domain.Entities
{
    public class CardItem : CardRelationship
    {
        [ForeignKey("Item")]
        public int ItemId { get; set; }
        public Item Item { get; set; }
    }
}