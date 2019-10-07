using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace domain.Entities
{
    public class Card : Entity
    {
        [ForeignKey("User")]
        public int PlayerId { get; set; }
        public User Player { get; set; }

        public string CharacterName { get; set; }
        public int Age { get; set; }
        public string Class { get; set; }
        public string Race { get; set; }
        public int Level { get; set; }

        public int Adrenaline { get; set; }
        public int AdrenalineEfficiencyLimit { get; set; }

        public int Attack { get; set; }
        public int AttackEfficiencyLimit { get; set; }

        public int Defense { get; set; }
        public int DefenseEfficiencyLimit { get; set; }

        public int Dexterity { get; set; }
        public int DexterityEfficiencyLimit { get; set; }

        public int Strength { get; set; }
        public int StrengthEfficiencyLimit { get; set; }

        public int Resistance { get; set; }
        public int ResistanceEfficiencyLimit { get; set; }

        public int Sapience { get; set; }
        public int SapienceEfficiencyLimit { get; set; }

        public int Velocity { get; set; }
        public int VelocityEfficiencyLimit { get; set; }

        public IList<CardCapabilitie> CardCapabilities { get; set; }
        public IList<CardSkill> CardSkills { get; set; }
        public IList<CardDisadvantage> CardDisadvantages { get; set; }
        public IList<CardPractice> CardPractices { get; set; }
        public IList<CardEnhancedMove> CardEnhancedMoves { get; set; }

        public IList<CardPropertyAndRiche> CardPropertiesAndRiches { get; set; }
        public IList<CardItem> CardItems { get; set; }
        public IList<CardWeapon> CardWeapons { get; set; }

        public string Annotations { get; set; }

        public int ExperiencePoints { get; set; }
        public int ExperienceLevel { get; set; }

        public IList<CardArmor> CardArmors { get; set; }
    }
}