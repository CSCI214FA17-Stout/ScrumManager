using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ScrumManager.Services.Interfaces;

namespace ScrumManager.Controllers
{
    public class HomeController : Controller
    {
        private IEventRepository _events;

        public HomeController(IEventRepository ev)
        {
            _events = ev;
        }
        public IActionResult Index()
        {
            return View(_events.ReadAll());
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
