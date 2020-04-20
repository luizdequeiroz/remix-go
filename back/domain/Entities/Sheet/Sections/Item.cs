namespace domain.Entities
{
    public class Item : Descripted
    {
        public int DifficultyValue { get; set; }
        public string DifficultyDescription { get; set; }

        public int EffectValue { get; set; }
        public string EffectDescription { get; set; }

        public int Weight { get; set; }
    }
}