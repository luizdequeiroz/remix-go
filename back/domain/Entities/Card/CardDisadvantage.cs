using System.ComponentModel.DataAnnotations.Schema;

namespace domain.Entities
{
    public class CardDisadvantage : CardRelationship
    {
        [ForeignKey("Disadvantage")]
        public int DisadvantageId { get; set; }
        public Disadvantage Disadvantage { get; set; }
    }
}