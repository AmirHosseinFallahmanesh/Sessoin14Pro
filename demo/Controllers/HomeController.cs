using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using demo.Models;

namespace demo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create([Bind("Username","Password") ] Student student)
        {
            return Json(student);
        }

        public IActionResult CreateTemp(Student student)
        {
            return Json(student);
        }

        public IActionResult Edit()
        {
            Student student = new Student()
            {
                Username = "a@a",
                Password = "123",
                StudentProfile = new StudentProfile()
                {
                    Age = 12,
                    Name = "amir",
                    Surname = "amiri"
                }
            };
            return View(student);
        }


        public IActionResult Profile( [Bind(Prefix ="StudentProfile")] StudentProfile profile)
        {
            return Json(profile);
        }


         
        public IActionResult GetArray()
        {
            return View();
        }
        [HttpPost]
        public IActionResult GetArray(List<Student> students)
        {
            return View();
        }



        //public IActionResult Create(string name,string surname,bool remember,int age=-1)
        //{
        //    return Json(null);
        //}


    }
}
