using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult MyProjects()
        {
            List<Project> staredProjects = Project.GetProjects();
            return View(staredProjects);
        }
        public IActionResult AboutMe()
        {
            return View();
        }
        public IActionResult ContactInfo()
        {
            return View();
        }
    }
}
