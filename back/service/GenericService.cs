using domain.Entities;
using repository.Interfaces;
using service.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ExtensionsPlus;
using System.Linq;

namespace service
{
    public abstract class GenericService<E> : IGenericService<E> where E : Entity
    {
        protected IGenericRepository<E> repository;

        public GenericService(IGenericRepository<E> repository)
        {
            this.repository = repository;
        }

        public async Task<E> AlterAsync(E entity)
        {
            var original = await GetByIdAsync(entity.Id);
            original.SetDifferentProperties(entity);
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
            return (await repository.SelectAllAsync()).ToList();
        }

        public async Task<E> GetByIdAsync(int id)
        {
            return await repository.SelectByIdAsync(id);
        }

        public async Task<E> SetNewAsync(E entity)
        {
            return await repository.InsertAsync(entity);
        }
    }
}
