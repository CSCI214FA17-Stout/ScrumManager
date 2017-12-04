using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using ScrumManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrumManager.Services.Interfaces
{
    
    public interface IAuthenticationRepository
    {
        IQueryable<IdentityRole> ReadAllRoles();
        IQueryable<ApplicationUser> ReadAllUsers();
        bool AssignRole(string username, string rolename);
    }

}
