using domain.Entities;
using repository.Interfaces;

namespace service
{
    public interface IPlayerTableService { }
    public interface IArmorService { }
    public interface ICapabilitieService { }
    public interface IDisadvantageService { }
    public interface IEnhancedMoveService { }
    public interface IItemService { }
    public interface IPracticeService { }
    public interface IPropertyAndRicheService { }
    public interface ISkillService { }
    public interface IWeaponService { }
    public interface ICardArmorService { }
    public interface ICardCapabilitieService { }
    public interface ICardDisadvantageService { }
    public interface ICardEnhancedMoveService { }
    public interface ICardItemService { }
    public interface ICardPracticeService { }
    public interface ICardPropertyAndRicheService { }
    public interface ICardSkillService { }
    public interface ICardWeaponService { }

    public class PlayerTableService : GenericService<PlayerTable>, IPlayerTableService
    {
        public PlayerTableService(IGenericRepository<PlayerTable> repository)
            : base(repository)
        {
        }
    }
    public class ArmorService : GenericService<Armor>, IArmorService
    {
        public ArmorService(IGenericRepository<Armor> repository)
            : base(repository)
        {
        }
    }
    public class CapabilitieService : GenericService<Capabilitie>, ICapabilitieService
    {
        public CapabilitieService(IGenericRepository<Capabilitie> repository)
            : base(repository)
        {
        }
    }
    public class DisadvantageService : GenericService<Disadvantage>, IDisadvantageService
    {
        public DisadvantageService(IGenericRepository<Disadvantage> repository)
            : base(repository)
        {
        }
    }
    public class EnhancedMoveService : GenericService<EnhancedMove>, IEnhancedMoveService
    {
        public EnhancedMoveService(IGenericRepository<EnhancedMove> repository)
            : base(repository)
        {
        }
    }
    public class ItemService : GenericService<Item>, IItemService
    {
        public ItemService(IGenericRepository<Item> repository)
            : base(repository)
        {
        }
    }
    public class PracticeService : GenericService<Practice>, IPracticeService
    {
        public PracticeService(IGenericRepository<Practice> repository)
            : base(repository)
        {
        }
    }
    public class PropertyAndRicheService : GenericService<PropertyAndRiche>, IPropertyAndRicheService
    {
        public PropertyAndRicheService(IGenericRepository<PropertyAndRiche> repository)
            : base(repository)
        {
        }
    }
    public class SkillService : GenericService<Skill>, ISkillService
    {
        public SkillService(IGenericRepository<Skill> repository)
            : base(repository)
        {
        }
    }
    public class WeaponService : GenericService<Weapon>, IWeaponService
    {
        public WeaponService(IGenericRepository<Weapon> repository)
            : base(repository)
        {
        }
    }
    public class CardArmorService : GenericService<CardArmor>, ICardArmorService
    {
        public CardArmorService(IGenericRepository<CardArmor> repository)
            : base(repository)
        {
        }
    }
    public class CardCapabilitieService : GenericService<CardCapabilitie>, ICardCapabilitieService
    {
        public CardCapabilitieService(IGenericRepository<CardCapabilitie> repository)
            : base(repository)
        {
        }
    }
    public class CardDisadvantageService : GenericService<CardDisadvantage>, ICardDisadvantageService
    {
        public CardDisadvantageService(IGenericRepository<CardDisadvantage> repository)
            : base(repository)
        {
        }
    }
    public class CardEnhancedMoveService : GenericService<CardEnhancedMove>, ICardEnhancedMoveService
    {
        public CardEnhancedMoveService(IGenericRepository<CardEnhancedMove> repository)
            : base(repository)
        {
        }
    }
    public class CardItemService : GenericService<CardItem>, ICardItemService
    {
        public CardItemService(IGenericRepository<CardItem> repository)
            : base(repository)
        {
        }
    }
    public class CardPracticeService : GenericService<CardPractice>, ICardPracticeService
    {
        public CardPracticeService(IGenericRepository<CardPractice> repository)
            : base(repository)
        {
        }
    }
    public class CardPropertyAndRicheService : GenericService<CardPropertyAndRiche>, ICardPropertyAndRicheService
    {
        public CardPropertyAndRicheService(IGenericRepository<CardPropertyAndRiche> repository)
            : base(repository)
        {
        }
    }
    public class CardSkillService : GenericService<CardSkill>, ICardSkillService
    {
        public CardSkillService(IGenericRepository<CardSkill> repository)
            : base(repository)
        {
        }
    }
    public class CardWeaponService : GenericService<CardWeapon>, ICardWeaponService
    {
        public CardWeaponService(IGenericRepository<CardWeapon> repository)
            : base(repository)
        {
        }
    }
}
