using domain.Entities;
using repository.Interfaces;
using service.Interfaces;

namespace service
{
    public class TableService : GenericService<Table>, ITableService
    {
        public TableService(IGenericRepository<Table> repository) : base(repository)
        {
        }
    }
}
