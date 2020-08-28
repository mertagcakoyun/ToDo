using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ToDo.Business.Interfaces;
using ToDo.Entities.Concrete;
using ToDo.WebUI.Areas.Admin.Models;

namespace ToDo.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PriorityController : Controller
    {
        private readonly IPriorityService _priorityService;
        public PriorityController(IPriorityService priorityService)
        {
            _priorityService = priorityService;
        }
        public IActionResult Index()
        {
            TempData["Active"] = "priority";
            List<Priority> priorities = _priorityService.GetAll();
            List<PriorityListViewModel> model = new List<PriorityListViewModel>();
            foreach (var item in priorities)
            {
                PriorityListViewModel priorityModel = new PriorityListViewModel();
                priorityModel.Id = item.Id;
                priorityModel.Description = item.Description;
                model.Add(priorityModel);
            }
            return View(model);
        }
        public IActionResult AddPriorityTask()
        {
            TempData["Active"] = "priority";
            return View(new PriorityAddViewModel());
        }
        [HttpPost]
        public IActionResult AddPriorityTask(PriorityAddViewModel model)
        {
            
            if (ModelState.IsValid)
            {
                _priorityService.Save(new Priority
                {
                    Description = model.Description
                });
                return (RedirectToAction("Index"));
            }
            return View(model);
        }

        public IActionResult UpdatePriority(int id)
        {
            TempData["Active"] = "priority";
            var priority = _priorityService.GetWithId(id);
            PriorityUpdateViewModel model = new PriorityUpdateViewModel
            {
                Id = priority.Id,
                Description = priority.Description

            };
            return View(model);
        }
        [HttpPost]
        public IActionResult UpdatePriority(PriorityUpdateViewModel model)
        {
            if (ModelState.IsValid)
            {
                _priorityService.Update(new Priority
                {
                    Id = model.Id,
                    Description = model.Description
                });
                return RedirectToAction("Index");
            }

            return View(model);
        }



    }
}
