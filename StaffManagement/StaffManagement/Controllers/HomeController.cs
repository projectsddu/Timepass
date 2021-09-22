using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StaffManagement.Models;

namespace StaffManagement.Controllers
{
    public class HomeController:Controller 
    {
        
        private readonly IstaffRespository _staffRepository;
        public HomeController(IstaffRespository staffRepository)
        {
            _staffRepository = new MockStaffRepository();
        }
        public string Index()
        {
            return _staffRepository.GetStaff(1).name;
        }
        public JsonResult Details()
            {
                Staff model = _staffRepository.GetStaff(1);
            return Json(model);
            }
        public ViewResult vds()
        {
            var model = _staffRepository.GetAllStaffs();
            //ViewData["name"] = model.name;
            //ViewData["Id"] = model.Id;
            //ViewData["model"] = model;
            //ViewBag.PageTitle = "Staff Details";
            //ViewBag.Staff = model;
            return View(model);
        }
    }
}
