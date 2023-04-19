using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using projWebAPI.Models;
using projWebAPI.Services;

namespace projWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToolController : ControllerBase
    {
        [HttpGet(Name = "List Tools")]
        public List<Tool> GetTools()
        {
            return new ToolService().GetAll();
        }

        [HttpPost(Name = "Register Tool")]
        public ActionResult Insert(Tool tool)
        {
            return new ToolService().Insert(tool) ?  StatusCode(200) : BadRequest();
        }
    }
}
