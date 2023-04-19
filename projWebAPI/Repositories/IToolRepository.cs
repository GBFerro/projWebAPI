using projWebAPI.Models;

namespace projWebAPI.Repositories
{
    public interface IToolRepository
    {
        bool Insert(Tool tool);

        List<Tool> GetAll();
    }
}
