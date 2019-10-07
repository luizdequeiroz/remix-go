using System.ComponentModel.DataAnnotations.Schema;

namespace domain.Entities
{
    [Table("UserCardTable")]
    public class PlayerTable : CardRelationship
    {
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User Player { get; set; }

        [ForeignKey("Table")]
        public int TableId { get; set; }
        public Table Table { get; set; }
    }
}
