using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace demo.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            
         
            return View(new PersonViewModel());
        }

        [HttpPost]
        public IActionResult Index(PersonViewModel person)
        {

            return View();
        }
    }
}