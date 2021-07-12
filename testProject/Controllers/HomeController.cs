using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using testProject.DAL;
using testProject.Models;

namespace testProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var context = new DataContext();
            //select * from "Users" where ... order by ...
            ViewBag.List = context.Users
                .Where(u => u.Name != "system"
                && !string.IsNullOrEmpty(u.About))
                .OrderBy(u => u.Name)
                .ToList();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult CreateUser()
        {
            return View();
        }

        public IActionResult Create(User user)
        {
            if (!ModelState.IsValid)
            {
                return View("CreateUser");
            }
            var context = new DataContext();
            context.Users.Add(user);
            context.SaveChanges();
            return Redirect("~/Home/Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
