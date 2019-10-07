using System.ComponentModel.DataAnnotations.Schema;

namespace domain.Entities
{
    public class CardWeapon : CardRelationship
    {
        [ForeignKey("Weapon")]
        public int WeaponId { get; set; }
        public Weapon Weapon { get; set; }
    }
}