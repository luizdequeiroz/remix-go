using System.Collections.Generic;
using System.Threading.Tasks;

namespace service.Interfaces
{
    public interface IGenericService<E>
    {
        Task<E> SetNewAsync(E user);
        Task<IList<E>> GetAllAsync();
        Task<E> GetByIdAsync(int id);
        Task<E> AlterAsync(E user);
        Task<bool> DeleteAsync(int id);
    }
}