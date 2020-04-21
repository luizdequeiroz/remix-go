using domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using service.Interfaces;
using service.Utilities.Enums;
using service.Utilities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace service.Utilities
{
    public class ServiceSwitch : IServiceSwitch
    {
        private readonly IServiceProvider serviceProvider;
        private readonly string FullNameEntities = "domain.Entities.{0}, domain";

        public ServiceSwitch(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public Func<object, Task<dynamic>> SetNewAsync { get; private set; }
        public Func<Task<IList<dynamic>>> GetAllAsync { get; private set; }
        public Func<int, Task<dynamic>> GetByIdAsync { get; private set; }
        public Func<string, string, Task<IList<dynamic>>> GetByPropertyAsync { get; private set; }
        public Func<object, Task<dynamic>> AlterAsync { get; private set; }
        public Func<int, Task<bool>> DeleteAsync { get; private set; }

        public IServiceSwitch Case(ServiceType serviceType)
        {
            dynamic service;
            switch (serviceType)
            {
                case ServiceType.User: service = serviceProvider.GetService<IUserService>(); break;
                case ServiceType.Table: service = serviceProvider.GetService<ITableService>(); break;
                case ServiceType.RMX: service = serviceProvider.GetService<IRMXService>(); break;
                case ServiceType.MS: service = serviceProvider.GetService<IMSService>(); break;
                case ServiceType.PlayerTable: service = serviceProvider.GetService<IPlayerTableService>(); break;
                
                case ServiceType.Armor: service = serviceProvider.GetService<IArmorService>(); break;
                case ServiceType.Capabilitie: service = serviceProvider.GetService<ICapabilitieService>(); break;
                case ServiceType.Disadvantage: service = serviceProvider.GetService<IDisadvantageService>(); break;
                case ServiceType.EnhancedMove: service = serviceProvider.GetService<IEnhancedMoveService>(); break;
                case ServiceType.GenericAdvantage: service = serviceProvider.GetService<IGenericAdvantageService>(); break;
                case ServiceType.Item: service = serviceProvider.GetService<IItemService>(); break;
                case ServiceType.Practice: service = serviceProvider.GetService<IPracticeService>(); break;
                case ServiceType.PropertyAndRiche: service = serviceProvider.GetService<IPropertyAndRicheService>(); break;
                case ServiceType.Skill: service = serviceProvider.GetService<ISkillService>(); break;
                case ServiceType.Weapon: service = serviceProvider.GetService<IWeaponService>(); break;

                case ServiceType.SheetArmor: service = serviceProvider.GetService<ISheetArmorService>(); break;
                case ServiceType.SheetCapabilitie: service = serviceProvider.GetService<ISheetCapabilitieService>(); break;
                case ServiceType.SheetDisadvantage: service = serviceProvider.GetService<ISheetDisadvantageService>(); break;
                case ServiceType.SheetEnhancedMove: service = serviceProvider.GetService<ISheetEnhancedMoveService>(); break;
                case ServiceType.SheetGenericAdvantage: service = serviceProvider.GetService<ISheetGenericAdvantageService>(); break;
                case ServiceType.SheetItem: service = serviceProvider.GetService<ISheetItemService>(); break;
                case ServiceType.SheetPractice: service = serviceProvider.GetService<ISheetPracticeService>(); break;
                case ServiceType.SheetPropertyAndRiche: service = serviceProvider.GetService<ISheetPropertyAndRicheService>(); break;
                case ServiceType.SheetSkill: service = serviceProvider.GetService<ISheetSkillService>(); break;
                case ServiceType.SheetWeapon: service = serviceProvider.GetService<ISheetWeaponService>(); break;

                default:
                    var exception = new Exception("Service type is invalid.");
                    throw exception;
            }

            SetNewAsync = async (entity) =>
            {
                var typeServiceType = Type.GetType(string.Format(FullNameEntities, serviceType.ToString()));

                dynamic result;
                switch (typeServiceType.Name)
                {
                    case "User": result = await service.SetNewAsync(JsonConvert.DeserializeObject<User>(entity.ToString())); break;
                    case "Table": result = await service.SetNewAsync(JsonConvert.DeserializeObject<Table>(entity.ToString())); break;
                    case "RMX": result = await service.SetNewAsync(JsonConvert.DeserializeObject<RMX>(entity.ToString())); break;
                    case "MS": result = await service.SetNewAsync(JsonConvert.DeserializeObject<MS>(entity.ToString())); break;
                    case "PlayerTable": result = await service.SetNewAsync(JsonConvert.DeserializeObject<PlayerTable>(entity.ToString())); break;
                    
                    case "Armor": result = await service.SetNewAsync(JsonConvert.DeserializeObject<Armor>(entity.ToString())); break;
                    case "Capabilitie": result = await service.SetNewAsync(JsonConvert.DeserializeObject<Capabilitie>(entity.ToString())); break;
                    case "Disadvantage": result = await service.SetNewAsync(JsonConvert.DeserializeObject<Disadvantage>(entity.ToString())); break;
                    case "EnhancedMove": result = await service.SetNewAsync(JsonConvert.DeserializeObject<EnhancedMove>(entity.ToString())); break;
                    case "GenericAdvantage": result = await service.SetNewAsync(JsonConvert.DeserializeObject<GenericAdvantage>(entity.ToString())); break;
                    case "Item": result = await service.SetNewAsync(JsonConvert.DeserializeObject<Item>(entity.ToString())); break;
                    case "Practice": result = await service.SetNewAsync(JsonConvert.DeserializeObject<Practice>(entity.ToString())); break;
                    case "PropertyAndRiche": result = await service.SetNewAsync(JsonConvert.DeserializeObject<PropertyAndRiche>(entity.ToString())); break;
                    case "Skill": result = await service.SetNewAsync(JsonConvert.DeserializeObject<Skill>(entity.ToString())); break;
                    case "Weapon": result = await service.SetNewAsync(JsonConvert.DeserializeObject<Weapon>(entity.ToString())); break;
                    
                    case "SheetArmor": result = await service.SetNewAsync(JsonConvert.DeserializeObject<SheetArmor>(entity.ToString())); break;
                    case "SheetCapabilitie": result = await service.SetNewAsync(JsonConvert.DeserializeObject<SheetCapabilitie>(entity.ToString())); break;
                    case "SheetDisadvantage": result = await service.SetNewAsync(JsonConvert.DeserializeObject<SheetDisadvantage>(entity.ToString())); break;
                    case "SheetEnhancedMove": result = await service.SetNewAsync(JsonConvert.DeserializeObject<SheetEnhancedMove>(entity.ToString())); break;
                    case "SheetGenericAdvantage": result = await service.SetNewAsync(JsonConvert.DeserializeObject<SheetGenericAdvantage>(entity.ToString())); break;
                    case "SheetItem": result = await service.SetNewAsync(JsonConvert.DeserializeObject<SheetItem>(entity.ToString())); break;
                    case "SheetPractice": result = await service.SetNewAsync(JsonConvert.DeserializeObject<SheetPractice>(entity.ToString())); break;
                    case "SheetPropertyAndRiche": result = await service.SetNewAsync(JsonConvert.DeserializeObject<SheetPropertyAndRiche>(entity.ToString())); break;
                    case "SheetSkill": result = await service.SetNewAsync(JsonConvert.DeserializeObject<SheetSkill>(entity.ToString())); break;
                    case "SheetWeapon": result = await service.SetNewAsync(JsonConvert.DeserializeObject<SheetWeapon>(entity.ToString())); break;
                    default:
                        var exception = new Exception("Service type is invalid.");
                        throw exception;
                }

                return result;
            };
            GetAllAsync = async () => ((await service.GetAllAsync()) as IEnumerable<dynamic>).ToList();
            GetByIdAsync = async id => await service.GetByIdAsync(id);
            GetByPropertyAsync = async (propertyName, value) => (await service.GetByPropertyAsync(propertyName, value) as IEnumerable<dynamic>).ToList();
            AlterAsync = async entity =>
            {
                var typeServiceType = Type.GetType(string.Format(FullNameEntities, serviceType.ToString()));

                dynamic result;
                switch (typeServiceType.Name)
                {
                    case "User": result = await service.AlterAsync(JsonConvert.DeserializeObject<User>(entity.ToString())); break;
                    case "Table": result = await service.AlterAsync(JsonConvert.DeserializeObject<Table>(entity.ToString())); break;
                    case "RMX": result = await service.AlterAsync(JsonConvert.DeserializeObject<RMX>(entity.ToString())); break;
                    case "MS": result = await service.AlterAsync(JsonConvert.DeserializeObject<MS>(entity.ToString())); break;
                    case "PlayerTable": result = await service.AlterAsync(JsonConvert.DeserializeObject<PlayerTable>(entity.ToString())); break;
                    
                    case "Armor": result = await service.AlterAsync(JsonConvert.DeserializeObject<Armor>(entity.ToString())); break;
                    case "Capabilitie": result = await service.AlterAsync(JsonConvert.DeserializeObject<Capabilitie>(entity.ToString())); break;
                    case "Disadvantage": result = await service.AlterAsync(JsonConvert.DeserializeObject<Disadvantage>(entity.ToString())); break;
                    case "EnhancedMove": result = await service.AlterAsync(JsonConvert.DeserializeObject<EnhancedMove>(entity.ToString())); break;
                    case "GenericAdvantage": result = await service.AlterAsync(JsonConvert.DeserializeObject<GenericAdvantage>(entity.ToString())); break;
                    case "Item": result = await service.AlterAsync(JsonConvert.DeserializeObject<Item>(entity.ToString())); break;
                    case "Practice": result = await service.AlterAsync(JsonConvert.DeserializeObject<Practice>(entity.ToString())); break;
                    case "PropertyAndRiche": result = await service.AlterAsync(JsonConvert.DeserializeObject<PropertyAndRiche>(entity.ToString())); break;
                    case "Skill": result = await service.AlterAsync(JsonConvert.DeserializeObject<Skill>(entity.ToString())); break;
                    case "Weapon": result = await service.AlterAsync(JsonConvert.DeserializeObject<Weapon>(entity.ToString())); break;
                    
                    case "SheetArmor": result = await service.AlterAsync(JsonConvert.DeserializeObject<SheetArmor>(entity.ToString())); break;
                    case "SheetCapabilitie": result = await service.AlterAsync(JsonConvert.DeserializeObject<SheetCapabilitie>(entity.ToString())); break;
                    case "SheetDisadvantage": result = await service.AlterAsync(JsonConvert.DeserializeObject<SheetDisadvantage>(entity.ToString())); break;
                    case "SheetEnhancedMove": result = await service.AlterAsync(JsonConvert.DeserializeObject<SheetEnhancedMove>(entity.ToString())); break;
                    case "SheetGenericAdvantage": result = await service.AlterAsync(JsonConvert.DeserializeObject<SheetGenericAdvantage>(entity.ToString())); break;
                    case "SheetItem": result = await service.AlterAsync(JsonConvert.DeserializeObject<SheetItem>(entity.ToString())); break;
                    case "SheetPractice": result = await service.AlterAsync(JsonConvert.DeserializeObject<SheetPractice>(entity.ToString())); break;
                    case "SheetPropertyAndRiche": result = await service.AlterAsync(JsonConvert.DeserializeObject<SheetPropertyAndRiche>(entity.ToString())); break;
                    case "SheetSkill": result = await service.AlterAsync(JsonConvert.DeserializeObject<SheetSkill>(entity.ToString())); break;
                    case "SheetWeapon": result = await service.AlterAsync(JsonConvert.DeserializeObject<SheetWeapon>(entity.ToString())); break;
                    default:
                        var exception = new Exception("Service type is invalid.");
                        throw exception;
                }

                return result;
            };
            DeleteAsync = async id => (bool)await service.DeleteAsync(id);

            return this;
        }
    }
}
