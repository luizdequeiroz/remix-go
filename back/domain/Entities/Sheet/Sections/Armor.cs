namespace domain.Entities
{
    public class Armor : Descripted
    {
        public int PenaltyValue { get; set; }
        public string PenaltyDescrition { get; set; }

        public int BonusValue { get; set; }
        public string BonusDescription { get; set; }

        public int Weight { get; set; }
    }
}