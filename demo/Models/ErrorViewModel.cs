using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;

namespace demo.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }

    public class Student
    {
        public string  Username { get; set; }
        public string Password { get; set; }

        public StudentProfile StudentProfile { get; set; }

        [BindNever]
        public int RoleId { get; set; }

    
    }

    public class StudentProfile
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        

    }


    public class StudentViewModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
    }
}