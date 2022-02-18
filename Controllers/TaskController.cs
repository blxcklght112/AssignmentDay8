using Day8.DTO;
using Day8.Models;
using Day8.Services;
using Microsoft.AspNetCore.Mvc;

namespace Day8.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskController : ControllerBase
    {
        private ITaskService _taskService;

        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpPost("/AddTask")]
        public void AddTask([FromBody] DTOTask task)
        {
            _taskService.AddTask(task);
        }

        [HttpGet("/GetTaskById")]
        public TaskModel GetTaskById(int id)
        {
            return _taskService.GetTaskById(id);
        }

        [HttpGet("/GetAllTask")]
        public List<TaskModel> GetAllTask()
        {
            return _taskService.GetAllTask();
        }

        [HttpDelete("/DeleteTask")]
        public void DeleteTask(int id)
        {
            _taskService.DeleteTask(id);
        }

        [HttpPut("/EditTask")]
        public void EditTask(TaskModel model)
        {
            _taskService.EditTask(model);
        }

        [HttpDelete("/DeleteTasks")]
        public void DeleteTasks(List<int> ids)
        {
            _taskService.DeleteTasks(ids);
        }

        [HttpPost("/AddTasks")]
        public void AddTasks(List<DTOTask> tasks)
        {
            _taskService.AddTasks(tasks);
        }
    }
}