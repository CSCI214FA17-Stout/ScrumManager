using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ScrumManager.Data;
using ScrumManager.Models;
using ScrumManager.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrumManager.Services.DbRepository
{
    public class DbAuthenticationRepository : IAuthenticationRepository
    {
        private ApplicationDbContext _db;
        private UserManager<ApplicationUser> _userManager;
        public DbAuthenticationRepository(ApplicationDbContext db, UserManager<ApplicationUser> uman)
        {
            _db = db;
            _userManager = uman;
        }

        public IQueryable<IdentityRole> ReadAllRoles()
        {
            return _db.Roles;
        }

        public IQueryable<ApplicationUser> ReadAllUsers()
        {
            return _db.Users.Include(r => r.Roles);
        }

        public bool AssignRole(string username, string rolename)
        {
            var user = ReadAllUsers().FirstOrDefault(u => u.UserName == username);
            if (user != null)
            {
                var roles = ReadAllRoles();
                // Get the rolenames by joining user.Roles to roles
                var q = from ur in user.Roles
                        join r in roles on ur.RoleId equals r.Id
                        select new
                        {
                            RoleName = r.Name
                        };
                var role = q.FirstOrDefault(o => o.RoleName == rolename);
                if (role == null)
                {
                    _userManager.AddToRoleAsync(user, rolename).Wait();
                    return true;
                }
            }
            return false;
        }

    }
}
