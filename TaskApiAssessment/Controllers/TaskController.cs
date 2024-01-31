using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using TaskApiAssessment.IRepo;
using TaskApiAssessment.Models;

namespace TaskApiAssessment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        ITaskRepo _taskRepo;
        public TaskController(ITaskRepo taskRepo)
        {
            _taskRepo = taskRepo;
            

        }
        [HttpGet]
        [Route("GetTask/{id}")]
        public IActionResult GetTask(int id)
        {
            Taskk user = _taskRepo.GetTask(id);
            return Ok(user);


        }
        [HttpPost]
        [Route("AddTask")]
        public IActionResult AddTask(Taskk task)
        {
            _taskRepo.Add(task);
            return Ok("Added successfully.");
        }
        [HttpGet]
        [Route("AllTasks")]
        public IActionResult AllTasks()
        {
            List<Taskk> list=_taskRepo.AllTasks();
            return Ok(list);
        }
        [HttpDelete]
        [Route("DeleteTask/{id}")]
        public IActionResult DeleteTask(int id)
        {
            _taskRepo.DeleteTask(id);
            return Ok("Task deleted Successfully!!!");
        }
        [HttpPatch]
        [Route("EditTask/{id}")]
        public IActionResult EditUser(int id, Taskk task)
        {
            _taskRepo.EditTask(id, task);
            return Ok("Task edited successfully!!!");
        }
    }
}
