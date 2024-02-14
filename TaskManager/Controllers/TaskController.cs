using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;
using System.Xml.Linq;

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
        public async Task<ActionResult<List<Model.Task>>> GetTasks()
        {
            try
            {
                return Ok(await _taskService.GetTasks());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        [AllowAnonymous]
        public async Task<IActionResult> CreateTask(string name)
        {
            try
            {
                return Ok(await _taskService.CreateTask(name));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        [AllowAnonymous]
        public async Task<IActionResult> CompleteTask(Guid taskId)
        {
            try
            {
                return Ok(await _taskService.CompleteTask(taskId));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

        [HttpDelete]
        [AllowAnonymous]
        public async Task<IActionResult> DeleteTask(Guid taskId)
        {
            try
            {
                return Ok(await _taskService.DeleteTask(taskId));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
