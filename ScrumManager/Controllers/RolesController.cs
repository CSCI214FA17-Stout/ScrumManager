using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ScrumManager.Services.Interfaces;

namespace ScrumManager.Controllers
{
    public class RolesController : Controller
    {
        private IAuthenticationRepository _roles;

        public RolesController(IAuthenticationRepository ev)
        {
            _roles = ev;
        }

        public IActionResult Index()
        {
            return View(_roles.ReadAllRoles());
        }
    }
}