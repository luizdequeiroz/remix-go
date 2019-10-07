using System.ComponentModel.DataAnnotations.Schema;

namespace domain.Entities
{
    public class CardPractice : CardRelationship
    {
        [ForeignKey("Practice")]
        public int PracticeId { get; set; }
        public Practice Practice { get; set; }
    }
}