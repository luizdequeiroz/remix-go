using domain.Entities;
using repository.Interfaces;
using service.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ExtensionsPlus;
using System.Linq;
using domain.Attributes.FieldsControl;

namespace service
{
    public abstract class GenericService<E> : IGenericService<E> where E : Entity
    {
        protected IGenericRepository<E> repository;

        protected GenericService(IGenericRepository<E> repository)
        {
            this.repository = repository;
        }

        public async Task<E> AlterAsync(E entity)
        {
            var original = await GetByIdAsync(entity.Id);
            var exceptions = new List<string>();
            entity.GetType().GetProperties().ToList().ForEach(prop =>
            {
                if (prop.GetCustomAttributes(typeof(NotSetAutomatically), true).Length > 0)
                {
                    exceptions.Add(prop.Name);
                }

                var value = prop.GetValue(entity);
                bool isUnsetted = false;

                switch (prop.PropertyType.Name)
                {
                    case "String":
                        isUnsetted = string.IsNullOrEmpty(value?.ToString());
                        break;
                    case "Int32":
                        isUnsetted = Convert.ToInt32(value) == default(int);
                        break;
                    case "Double":
                        isUnsetted = Convert.ToDouble(value) == default(double);
                        break;
                    case "DateTime":
                        isUnsetted = Convert.ToDateTime(value) == default(DateTime);
                        break;
                    default: break;
                }

                if (isUnsetted) exceptions.Add(prop.Name);
            });

            original.SetDifferentProperties(entity, exceptions.ToArray());
            original.UpdateDate = DateTime.Now;
            return await repository.UpdateAsync(original);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            E result = await GetByIdAsync(id);
            if (result == null) return false;
            await repository.DeleteAsync(result);

            return true;
        }

        public async Task<IList<E>> GetAllAsync()
        {
            var all = await repository.SelectAllAsync();
            return all.ToList();
        }

        public async Task<E> GetByIdAsync(int id)
        {
            return await repository.SelectByIdAsync(id);
        }

        public async Task<IList<E>> GetByPropertyAsync(string propertyName, string value)
        {
            var collection = await repository.SelectWhereAsync(item => item.GetType().GetProperty(propertyName).GetValue(item).ToString() == value);
            return collection.ToList();
        }

        public async Task<E> SetNewAsync(E entity)
        {
            return await repository.InsertAsync(entity);
        }
    }
}
