using System.ComponentModel.DataAnnotations.Schema;

namespace domain.Entities
{
    public class CardSkill : CardRelationship
    {
        [ForeignKey("Skill")]
        public int SkillId { get; set; }
        public Skill Skill { get; set; }
    }
}