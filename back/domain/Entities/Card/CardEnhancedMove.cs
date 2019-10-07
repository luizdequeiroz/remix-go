using System.ComponentModel.DataAnnotations.Schema;

namespace domain.Entities
{
    public class CardEnhancedMove : CardRelationship
    {
        [ForeignKey("EnhancedMove")]
        public int EnhancedMoveId { get; set; }
        public EnhancedMove EnhancedMove { get; set; }
    }
}