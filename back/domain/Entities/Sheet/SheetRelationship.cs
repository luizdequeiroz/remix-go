using System.ComponentModel.DataAnnotations.Schema;

namespace domain.Entities
{
    public abstract class SheetRelationship : Entity
    {
        [ForeignKey("RMX")]
        public int? RMXId { get; set; }
        public RMX RMX { get; set; }

        [ForeignKey("MS")]
        public int? MSId { get; set; }
        public MS MS { get; set; }
    }
}
