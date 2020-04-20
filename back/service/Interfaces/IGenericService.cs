using domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace service.Interfaces
{
    public interface IGenericService<E> where E : Entity
    {
        Task<E> SetNewAsync(E entity);
        Task<IList<E>> GetAllAsync();
        Task<E> GetByIdAsync(int id);
        Task<IList<E>> GetByPropertyAsync(string propertyName, string value);
        Task<E> AlterAsync(E entity);
        Task<bool> DeleteAsync(int id);
    }
}