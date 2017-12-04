using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using ScrumManager.Data;
using ScrumManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrumManager.Services
{
    public class Initializer
    {
        private ApplicationDbContext _context;
        private RoleManager<IdentityRole> _roleManager;
        private UserManager<ApplicationUser> _userManager;

        public Initializer(
           ApplicationDbContext context,
           RoleManager<IdentityRole> roleManager,
           UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public async Task SeedAsync()
        {
            _context.Database.EnsureCreated();

            if (!_context.Roles.Any(r => r.Name == "Admin"))
            {
                await _roleManager.CreateAsync(new IdentityRole { Name = "Admin" });
            }

            if (!_context.Roles.Any(r => r.Name == "TeamA"))
            {
                await _roleManager.CreateAsync(new IdentityRole { Name = "TeamA" });
            }

            if (!_context.Roles.Any(r => r.Name == "TeamB"))
            {
                await _roleManager.CreateAsync(new IdentityRole { Name = "TeamB" });
            }

            if (!_context.Roles.Any(r => r.Name == "User"))
            {
                await _roleManager.CreateAsync(new IdentityRole { Name = "User" });
            }


            if (!_context.Users.Any(u => u.UserName == "admin@test.com"))
            {
                var user = new ApplicationUser
                {
                    Email = "admin@test.com",
                    UserName = "admin@test.com"
                };
                await _userManager.CreateAsync(user, "Pass1!");
                await _userManager.AddToRoleAsync(user, "Admin");
            }
        }
    }
}
