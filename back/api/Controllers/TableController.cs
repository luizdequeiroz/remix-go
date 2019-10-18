using domain.Entities;
using service.Interfaces;

namespace api.Controllers
{
    public class TableController : GenericController<ITableService, Table>
    {
        public TableController(ITableService tableService)
            : base(tableService,
                "Mesa criada com sucesso!",
                "Nenhuma mesa encontrada!",
                "Nenhuma mesa foi encontrada!",
                "Talvez a mesa tenha sido deletada, contate o suporte.",
                "Mesa atualizada com sucesso!",
                "Não foi possível deletar a mesa!",
                "Talvez a já tenha sido deletada, contate o suporte.",
                "Mesa deletada com sucesso!")
        {
        }
    }
}