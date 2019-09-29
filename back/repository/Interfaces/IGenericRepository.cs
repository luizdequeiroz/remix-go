using System.Collections.Generic;
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
    }
}
