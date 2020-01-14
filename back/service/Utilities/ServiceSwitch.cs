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
        public Func<object, Task<dynamic>> AlterAsync { get; private set; }
        public Func<int, Task<bool>> DeleteAsync { get; private set; }

        public IServiceSwitch Case(ServiceType serviceType)
        {
            dynamic service;
            switch (serviceType)
            {
                case ServiceType.User: service = serviceProvider.GetService<IUserService>(); break;
                case ServiceType.Table: service = serviceProvider.GetService<ITableService>(); break;
                case ServiceType.Card: service = serviceProvider.GetService<ICardService>(); break;
                case ServiceType.PlayerTable: service = serviceProvider.GetService<IPlayerTableService>(); break;
                case ServiceType.Armor: service = serviceProvider.GetService<IArmorService>(); break;
                case ServiceType.Capabilitie: service = serviceProvider.GetService<ICapabilitieService>(); break;
                case ServiceType.Disadvantage: service = serviceProvider.GetService<IDisadvantageService>(); break;
                case ServiceType.EnhancedMove: service = serviceProvider.GetService<IEnhancedMoveService>(); break;
                case ServiceType.Item: service = serviceProvider.GetService<IItemService>(); break;
                case ServiceType.Practice: service = serviceProvider.GetService<IPracticeService>(); break;
                case ServiceType.PropertyAndRiche: service = serviceProvider.GetService<IPropertyAndRicheService>(); break;
                case ServiceType.Skill: service = serviceProvider.GetService<ISkillService>(); break;
                case ServiceType.Weapon: service = serviceProvider.GetService<IWeaponService>(); break;

                case ServiceType.CardArmor: service = serviceProvider.GetService<ICardArmorService>(); break;
                case ServiceType.CardCapabilitie: service = serviceProvider.GetService<ICardCapabilitieService>(); break;
                case ServiceType.CardDisadvantage: service = serviceProvider.GetService<ICardDisadvantageService>(); break;
                case ServiceType.CardEnhancedMove: service = serviceProvider.GetService<ICardEnhancedMoveService>(); break;
                case ServiceType.CardItem: service = serviceProvider.GetService<ICardItemService>(); break;
                case ServiceType.CardPractice: service = serviceProvider.GetService<ICardPracticeService>(); break;
                case ServiceType.CardPropertyAndRiche: service = serviceProvider.GetService<ICardPropertyAndRicheService>(); break;
                case ServiceType.CardSkill: service = serviceProvider.GetService<ICardSkillService>(); break;
                case ServiceType.CardWeapon: service = serviceProvider.GetService<ICardWeaponService>(); break;

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
                    case "Card": result = await service.SetNewAsync(JsonConvert.DeserializeObject<Card>(entity.ToString())); break;
                    case "PlayerTable": result = await service.SetNewAsync(JsonConvert.DeserializeObject<PlayerTable>(entity.ToString())); break;
                    case "Armor": result = await service.SetNewAsync(JsonConvert.DeserializeObject<Armor>(entity.ToString())); break;
                    case "Capabilitie": result = await service.SetNewAsync(JsonConvert.DeserializeObject<Capabilitie>(entity.ToString())); break;
                    case "Disadvantage": result = await service.SetNewAsync(JsonConvert.DeserializeObject<Disadvantage>(entity.ToString())); break;
                    case "EnhancedMove": result = await service.SetNewAsync(JsonConvert.DeserializeObject<EnhancedMove>(entity.ToString())); break;
                    case "Item": result = await service.SetNewAsync(JsonConvert.DeserializeObject<Item>(entity.ToString())); break;
                    case "Practice": result = await service.SetNewAsync(JsonConvert.DeserializeObject<Practice>(entity.ToString())); break;
                    case "PropertyAndRiche": result = await service.SetNewAsync(JsonConvert.DeserializeObject<PropertyAndRiche>(entity.ToString())); break;
                    case "Skill": result = await service.SetNewAsync(JsonConvert.DeserializeObject<Skill>(entity.ToString())); break;
                    case "Weapon": result = await service.SetNewAsync(JsonConvert.DeserializeObject<Weapon>(entity.ToString())); break;
                    case "CardArmor": result = await service.SetNewAsync(JsonConvert.DeserializeObject<CardArmor>(entity.ToString())); break;
                    case "CardCapabilitie": result = await service.SetNewAsync(JsonConvert.DeserializeObject<CardCapabilitie>(entity.ToString())); break;
                    case "CardDisadvantage": result = await service.SetNewAsync(JsonConvert.DeserializeObject<CardDisadvantage>(entity.ToString())); break;
                    case "CardEnhancedMove": result = await service.SetNewAsync(JsonConvert.DeserializeObject<CardEnhancedMove>(entity.ToString())); break;
                    case "CardItem": result = await service.SetNewAsync(JsonConvert.DeserializeObject<CardItem>(entity.ToString())); break;
                    case "CardPractice": result = await service.SetNewAsync(JsonConvert.DeserializeObject<CardPractice>(entity.ToString())); break;
                    case "CardPropertyAndRiche": result = await service.SetNewAsync(JsonConvert.DeserializeObject<CardPropertyAndRiche>(entity.ToString())); break;
                    case "CardSkill": result = await service.SetNewAsync(JsonConvert.DeserializeObject<CardSkill>(entity.ToString())); break;
                    case "CardWeapon": result = await service.SetNewAsync(JsonConvert.DeserializeObject<CardWeapon>(entity.ToString())); break;
                    default:
                        var exception = new Exception("Service type is invalid.");
                        throw exception;
                }

                return result;
            };
            GetAllAsync = async () => ((await service.GetAllAsync()) as IEnumerable<dynamic>).ToList();
            GetByIdAsync = async id => await service.GetByIdAsync(id);
            AlterAsync = async entity =>
            {
                var typeServiceType = Type.GetType(string.Format(FullNameEntities, serviceType.ToString()));

                dynamic result;
                switch (typeServiceType.Name)
                {
                    case "User": result = await service.AlterAsync(JsonConvert.DeserializeObject<User>(entity.ToString())); break;
                    case "Table": result = await service.AlterAsync(JsonConvert.DeserializeObject<Table>(entity.ToString())); break;
                    case "Card": result = await service.AlterAsync(JsonConvert.DeserializeObject<Card>(entity.ToString())); break;
                    case "PlayerTable": result = await service.AlterAsync(JsonConvert.DeserializeObject<PlayerTable>(entity.ToString())); break;
                    case "Armor": result = await service.AlterAsync(JsonConvert.DeserializeObject<Armor>(entity.ToString())); break;
                    case "Capabilitie": result = await service.AlterAsync(JsonConvert.DeserializeObject<Capabilitie>(entity.ToString())); break;
                    case "Disadvantage": result = await service.AlterAsync(JsonConvert.DeserializeObject<Disadvantage>(entity.ToString())); break;
                    case "EnhancedMove": result = await service.AlterAsync(JsonConvert.DeserializeObject<EnhancedMove>(entity.ToString())); break;
                    case "Item": result = await service.AlterAsync(JsonConvert.DeserializeObject<Item>(entity.ToString())); break;
                    case "Practice": result = await service.AlterAsync(JsonConvert.DeserializeObject<Practice>(entity.ToString())); break;
                    case "PropertyAndRiche": result = await service.AlterAsync(JsonConvert.DeserializeObject<PropertyAndRiche>(entity.ToString())); break;
                    case "Skill": result = await service.AlterAsync(JsonConvert.DeserializeObject<Skill>(entity.ToString())); break;
                    case "Weapon": result = await service.AlterAsync(JsonConvert.DeserializeObject<Weapon>(entity.ToString())); break;
                    case "CardArmor": result = await service.AlterAsync(JsonConvert.DeserializeObject<CardArmor>(entity.ToString())); break;
                    case "CardCapabilitie": result = await service.AlterAsync(JsonConvert.DeserializeObject<CardCapabilitie>(entity.ToString())); break;
                    case "CardDisadvantage": result = await service.AlterAsync(JsonConvert.DeserializeObject<CardDisadvantage>(entity.ToString())); break;
                    case "CardEnhancedMove": result = await service.AlterAsync(JsonConvert.DeserializeObject<CardEnhancedMove>(entity.ToString())); break;
                    case "CardItem": result = await service.AlterAsync(JsonConvert.DeserializeObject<CardItem>(entity.ToString())); break;
                    case "CardPractice": result = await service.AlterAsync(JsonConvert.DeserializeObject<CardPractice>(entity.ToString())); break;
                    case "CardPropertyAndRiche": result = await service.AlterAsync(JsonConvert.DeserializeObject<CardPropertyAndRiche>(entity.ToString())); break;
                    case "CardSkill": result = await service.AlterAsync(JsonConvert.DeserializeObject<CardSkill>(entity.ToString())); break;
                    case "CardWeapon": result = await service.AlterAsync(JsonConvert.DeserializeObject<CardWeapon>(entity.ToString())); break;
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
