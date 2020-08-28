﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ToDo.Business.Interfaces;
using ToDo.Entities.Concrete;
using ToDo.WebUI.Areas.Admin.Models;

namespace ToDo.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TaskController : Controller
    {
        private readonly ITaskService _taskService;
        private readonly IPriorityService _priorityService;
        public TaskController(ITaskService taskService, IPriorityService priorityService)
        {
            _taskService = taskService;
            _priorityService = priorityService;
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
            TempData["Active"] = "task";
            ViewBag.Priorities = new SelectList(_priorityService.GetAll(), "Id", "Description");

            return View(new TaskAddViewModel());
        }
        [HttpPost]
        public IActionResult AddTask(TaskAddViewModel model)
        {
            if (ModelState.IsValid)
            {
                _taskService.Save(new Task
                {
                    Description = model.Description,
                    Name = model.Name,
                    PriorityId = model.PriorityId

                });
                return RedirectToAction("Index");
            }
           return View(model);
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
