using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDo.Web.Models;


namespace ToDo.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SignUp() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignUp2(UserSignUpViewModel model)
        {
            return View();
        }

    }

 
}
