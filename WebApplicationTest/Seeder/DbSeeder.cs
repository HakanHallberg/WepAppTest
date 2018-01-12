using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationTest.Data;
using WebApplicationTest.Models;

namespace WebApplicationTest.Seeder
{
    public class DbSeeder
    {
        public static void Seed(ApplicationDbContext context, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            var User = new ApplicationUser { UserName = "admin" };
            var result = userManager.CreateAsync(User, "12345").Result;
            var Admin = new IdentityRole { Name = "admin" };
            var role = roleManager.CreateAsync(Admin).Result;
            userManager.AddToRoleAsync(User, "admin");
        }
    }
}
