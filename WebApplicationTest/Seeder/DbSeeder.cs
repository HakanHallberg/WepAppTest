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
            var user = new ApplicationUser { UserName = "admin@gmail.com", Email = "admin@gmail.com" };
            var result = userManager.CreateAsync(user, "p@Ssw0rd").Result;
            var admin = new IdentityRole { Name = "admin" };
            var role = roleManager.CreateAsync(admin).Result;
            userManager.AddToRoleAsync(user, "admin");
        }
    }
}
