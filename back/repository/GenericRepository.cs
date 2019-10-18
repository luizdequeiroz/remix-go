using domain;
using domain.Entities;
using ExtensionsPlus;
using repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace repository
{
    public class GenericRepository<E> : IGenericRepository<E> where E : Entity
    {
        private readonly RemixGoContext Context;

        public GenericRepository(RemixGoContext context)
        {
            Context = context;
        }

        public async Task DeleteAsync(E entity)
        {
            await Task.Run(() => Context.Set<E>().Remove(entity));
            await Context.SaveChangesAsync();
        }

        public async Task<E> InsertAsync(E entity)
        {
            await Context.Set<E>().AddAsync(entity);
            await Context.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<E>> SelectAllAsync()
        {
            return await Task.FromResult(Context.Set<E>());
        }

        public async Task<E> SelectByIdAsync(int id)
        {
            return await Context.Set<E>().FindAsync(id);
        }

        public async Task<E> UpdateAsync(E entity)
        {
            E result = await Context.Set<E>().FindAsync(entity.Id);
            result.SetProperties(entity);
            await Context.SaveChangesAsync();
            return result;
        }

        public async Task<IEnumerable<E>> SelectWhere(Expression<Func<E, bool>> expression)
        {
            return await Task.FromResult(Context.Set<E>().Where(expression).AsEnumerable());
        }
    }
}
