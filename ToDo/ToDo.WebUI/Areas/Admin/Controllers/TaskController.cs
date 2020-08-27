using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ToDo.Business.Interfaces;
using ToDo.Entities.Concrete;
using ToDo.WebUI.Areas.Admin.Models;

namespace ToDo.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TaskController : Controller
    {
        ITaskService _taskService;
        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        public IActionResult Index()
        {
            TempData["Active"] = "task";
            List<Task> tasks = _taskService.GetAll();
            List<TaskListViewModel> model = new List<TaskListViewModel>();
            if (ModelState.IsValid)
            {
                
                foreach (var item in tasks)
                {
                    TaskListViewModel taskModel = new TaskListViewModel  //out of foreach
                    {
                        //Use Mapper Library
                        Id = item.Id,
                        Name = item.Name,
                        Description = item.Description,
                        DateCreated = item.DateCreated,
                        Status = item.Status,
                        Priority = item.Priority,
                        PriorityId = item.PriorityId

                    };
                    model.Add(taskModel);
                }

            }
            return View(model);
        }
        public IActionResult AddTask()
        {

            return View();
        }
        [HttpPost]
        public IActionResult AddTask(TaskAddViewModel model)
        {

            return View();
        }
        public IActionResult UpdateTask()
        {

            return View();
        }
        [HttpPost]
        public IActionResult UpdateTask(PriorityUpdateViewModel model)
        {

            return View();
        }
    }
}
