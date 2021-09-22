using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StaffManagement.Models;

namespace StaffManagement.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository _studentRepo;
       public StudentController(IStudentRepository studentRepository)
        {
            _studentRepo = new MockStudentRepo();
        }
        public string index()
        {
            return _studentRepo.GetStudentDetails(2).name;
        }
        public JsonResult details()
        {
            return Json(_studentRepo.GetAllStudentDetails());
        }
        public ViewResult vrs()
        {
            ViewData["name"] = _studentRepo.GetStudentDetails(2).name;
            return View();
        }
    }
}
