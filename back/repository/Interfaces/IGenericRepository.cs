using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace repository.Interfaces
{
    public interface IGenericRepository<E>
    {
        Task<E> InsertAsync(E entity);
        Task<IEnumerable<E>> SelectAllAsync();
        Task<E> SelectByIdAsync(int id);
        Task<E> UpdateAsync(E entity);
        Task DeleteAsync(E entity);
        Task<IEnumerable<E>> SelectWhere(Expression<Func<E, bool>> expression);
    }
}
