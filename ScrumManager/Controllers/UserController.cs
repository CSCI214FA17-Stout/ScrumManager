using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using ScrumManager.Services.Interfaces;
using ScrumManager.Models.AccountViewModels;
using Lab12Authentication.Models.ViewModels;

namespace ScrumManager.Controllers
{
    [Authorize(Roles = "Admin")]

    ///[allow(anonymous)]
    public class UsersController : Controller
    {
        private IAuthenticationRepository _users;

        public UsersController(IAuthenticationRepository ev)
        {
            _users = ev;
        }


        public IActionResult Index()
        {
            return View(_users.ReadAllUsers());
        }


        public IActionResult AssignRole()
        {
            var roles = new AssignRoleVM
            {
                UserNames = _users.ReadAllUsers().Select(u => u.UserName).ToList(),
                RoleNames = _users.ReadAllRoles().Select(r => r.Name).ToList()
            };
            return View(roles);
        }

        [HttpPost]
        public IActionResult AssignRole(AssignRoleVM AssignRole)
        {
            if (ModelState.IsValid)
            {
                _users.AssignRole(AssignRole.UserName, AssignRole.RoleName);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}