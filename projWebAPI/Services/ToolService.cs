using projWebAPI.Models;
using projWebAPI.Repositories;

namespace projWebAPI.Services
{
    public class ToolService
    {
        private IToolRepository _toolRepository;
        public ToolService()
        {
            _toolRepository = new ToolRepository();
        }

        public bool Insert(Tool tool)
        {
            return _toolRepository.Insert(tool);
        }
        
        public List<Tool> GetAll()
        {
            return _toolRepository.GetAll();
        }   
    }
}
