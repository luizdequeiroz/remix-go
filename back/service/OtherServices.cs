using domain.Entities;
using repository.Interfaces;

namespace service
{
    public interface IPlayerTableService { }

    public interface IArmorService { }
    public interface ICapabilitieService { }
    public interface IDisadvantageService { }
    public interface IEnhancedMoveService { }
    public interface IGenericAdvantageService { }
    public interface IItemService { }
    public interface IPracticeService { }
    public interface IPropertyAndRicheService { }
    public interface ISkillService { }
    public interface IWeaponService { }

    public interface ISheetArmorService { }
    public interface ISheetCapabilitieService { }
    public interface ISheetDisadvantageService { }
    public interface ISheetEnhancedMoveService { }
    public interface ISheetGenericAdvantageService { }
    public interface ISheetItemService { }
    public interface ISheetPracticeService { }
    public interface ISheetPropertyAndRicheService { }
    public interface ISheetSkillService { }
    public interface ISheetWeaponService { }

    public class PlayerTableService : GenericService<PlayerTable>, IPlayerTableService
    {
        public PlayerTableService(IGenericRepository<PlayerTable> repository)
            : base(repository)
        {
        }
    }

    //
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
    public class GenericAdvantageService : GenericService<GenericAdvantage>, IGenericAdvantageService
    {
        public GenericAdvantageService(IGenericRepository<GenericAdvantage> repository)
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

    //
    public class SheetArmorService : GenericService<SheetArmor>, ISheetArmorService
    {
        public SheetArmorService(IGenericRepository<SheetArmor> repository)
            : base(repository)
        {
        }
    }
    public class SheetCapabilitieService : GenericService<SheetCapabilitie>, ISheetCapabilitieService
    {
        public SheetCapabilitieService(IGenericRepository<SheetCapabilitie> repository)
            : base(repository)
        {
        }
    }
    public class SheetDisadvantageService : GenericService<SheetDisadvantage>, ISheetDisadvantageService
    {
        public SheetDisadvantageService(IGenericRepository<SheetDisadvantage> repository)
            : base(repository)
        {
        }
    }
    public class SheetEnhancedMoveService : GenericService<SheetEnhancedMove>, ISheetEnhancedMoveService
    {
        public SheetEnhancedMoveService(IGenericRepository<SheetEnhancedMove> repository)
            : base(repository)
        {
        }
    }
    public class SheetGenericAdvantageService : GenericService<SheetGenericAdvantage>, ISheetGenericAdvantageService
    {
        public SheetGenericAdvantageService(IGenericRepository<SheetGenericAdvantage> repository)
            : base(repository)
        {
        }
    }
    public class SheetItemService : GenericService<SheetItem>, ISheetItemService
    {
        public SheetItemService(IGenericRepository<SheetItem> repository)
            : base(repository)
        {
        }
    }
    public class SheetPracticeService : GenericService<SheetPractice>, ISheetPracticeService
    {
        public SheetPracticeService(IGenericRepository<SheetPractice> repository)
            : base(repository)
        {
        }
    }
    public class SheetPropertyAndRicheService : GenericService<SheetPropertyAndRiche>, ISheetPropertyAndRicheService
    {
        public SheetPropertyAndRicheService(IGenericRepository<SheetPropertyAndRiche> repository)
            : base(repository)
        {
        }
    }
    public class SheetSkillService : GenericService<SheetSkill>, ISheetSkillService
    {
        public SheetSkillService(IGenericRepository<SheetSkill> repository)
            : base(repository)
        {
        }
    }
    public class SheetWeaponService : GenericService<SheetWeapon>, ISheetWeaponService
    {
        public SheetWeaponService(IGenericRepository<SheetWeapon> repository)
            : base(repository)
        {
        }
    }
}
