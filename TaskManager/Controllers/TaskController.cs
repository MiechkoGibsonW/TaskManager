using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace TaskManager.Controllers
{

    [ApiController]
    [Route("api/[controller]/[action]")]
    public class TaskController : ControllerBase
    {
        private readonly ILogger<TaskController> _logger;
        private ITaskService _taskService;
        public TaskController(ILogger<TaskController> logger, ITaskService taskService)
        {
            _logger = logger;
            _taskService = taskService; 
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<Model.Task>>> GetTasks()
        {
            return BadRequest(await _taskService.GetTasks());
        }
    
        [HttpPut]
        [AllowAnonymous]
        public async Task<IActionResult> CreateTask(Model.Task task)
        {
            return BadRequest(await _taskService.CreateTask(task));
        }

        [HttpPut]
        [AllowAnonymous]
        public async Task<IActionResult> UpdateTask(Model.Task task)
        {
            return BadRequest(await _taskService.UpdateTask(task));

        }

        [HttpDelete]
        [AllowAnonymous]
        public async Task<IActionResult> DeleteTask(Model.Task task)
        {
            return BadRequest(await _taskService.DeleteTask(task));

        }
    }
}
