using System.ComponentModel.DataAnnotations.Schema;

namespace domain.Entities
{
    public class CardArmor : CardRelationship
    {
        [ForeignKey("Armor")]
        public int ArmorId { get; set; }
        public Armor Armor { get; set; }
    }
}