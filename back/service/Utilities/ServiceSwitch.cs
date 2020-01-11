using domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using service.Interfaces;
using service.Utilities.Enums;
using service.Utilities.Interfaces;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace service.Utilities
{
    public class ServiceSwitch : IServiceSwitch
    {
        private readonly IServiceProvider serviceProvider;

        public ServiceSwitch(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public Func<object, Task<dynamic>> SetNewAsync { get; private set; }
        public Func<Task<IList<dynamic>>> GetAllAsync { get; private set; }
        public Func<object, Task<dynamic>> GetByIdAsync { get; private set; }
        public Func<object, Task<dynamic>> AlterAsync { get; private set; }
        public Func<object, Task<dynamic>> DeleteAsync { get; private set; }

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
                case ServiceType.CAPABILITIE: service = serviceProvider.GetService<ICapabilitieService>(); break;
                case ServiceType.DISADVANTAGE: service = serviceProvider.GetService<IDisadvantageService>(); break;
                case ServiceType.ENHANCEDMOVE: service = serviceProvider.GetService<IEnhancedMoveService>(); break;
                case ServiceType.ITEM: service = serviceProvider.GetService<IItemService>(); break;
                case ServiceType.PRACTICE: service = serviceProvider.GetService<IPracticeService>(); break;
                case ServiceType.PROPERTYANDRICHE: service = serviceProvider.GetService<IPropertyAndRicheService>(); break;
                case ServiceType.SKILL: service = serviceProvider.GetService<ISkillService>(); break;
                case ServiceType.WEAPON: service = serviceProvider.GetService<IWeaponService>(); break;

                case ServiceType.CARDARMOR: service = serviceProvider.GetService<ICardArmorService>(); break;
                case ServiceType.CARDCAPABILITIE: service = serviceProvider.GetService<ICardCapabilitieService>(); break;
                case ServiceType.CARDDISADVANTAGE: service = serviceProvider.GetService<ICardDisadvantageService>(); break;
                case ServiceType.CARDENHANCEDMOVE: service = serviceProvider.GetService<ICardEnhancedMoveService>(); break;
                case ServiceType.CARDITEM: service = serviceProvider.GetService<ICardItemService>(); break;
                case ServiceType.CARDPRACTICE: service = serviceProvider.GetService<ICardPracticeService>(); break;
                case ServiceType.CARDPROPERTYANDRICHE: service = serviceProvider.GetService<ICardPropertyAndRicheService>(); break;
                case ServiceType.CARDSKILL: service = serviceProvider.GetService<ICardSkillService>(); break;
                case ServiceType.CARDWEAPON: service = serviceProvider.GetService<ICardWeaponService>(); break;

                default:
                    var exception = new Exception("Service type is invalid.");
                    throw exception;
            }

            SetNewAsync = async (entity) =>
            {
                var serviceTypeName = serviceType.ToString();
                var typeServiceType = Type.GetType($"domain.Entities.{serviceTypeName}, domain");
                var changedEntity = ConvertToObject(entity, typeServiceType);
                var result = await service.SetNewAsync(changedEntity);
                return ConvertToDynamic(result);
            };
            GetAllAsync = async () => ((await service.GetAllAsync()) as IEnumerable<object>).Select(r => ConvertToDynamic(r)).ToList();
            GetByIdAsync = async (entity) => await service.GetByIdAsync(entity);
            AlterAsync = async (entity) => await service.AlterAsync(entity);
            DeleteAsync = async (entity) => await service.DeleteAsync(entity);

            return this;
        }

        private object ConvertToObject(dynamic dynamic, Type type)
        {
            var dictionary = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(dynamic);
            var @object = type.Assembly.CreateInstance($"{type.FullName}, domain");

            foreach (var key in dictionary.Keys)
            {
                @object.GetType().GetProperty(key).SetValue(@object, dictionary[key]);
            }

            return @object;
        }

        private dynamic ConvertToDynamic(object @object)
        {
            dynamic dynamic = new ExpandoObject();
            var dictionary = dynamic as IDictionary<string, object>;

            var properties = @object.GetType().GetProperties();

            foreach (var prop in properties)
            {
                dictionary.Add(prop.Name, prop.GetValue(@object));
            }

            return dynamic;
        }
    }
}
