using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDo.Business.Interfaces;

namespace ToDo.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITaskService _taskService;
        public HomeController(ITaskService taskService)
        {
            _taskService = taskService;
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
