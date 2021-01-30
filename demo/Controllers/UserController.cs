using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace demo.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            var user = new UserViewModel()
            {
                Country = "CA"
            };
            return View(user);
        }

        [HttpPost]
        public IActionResult Index(UserViewModel userViewModel)
        {
        
            return View();
        }
    }
}