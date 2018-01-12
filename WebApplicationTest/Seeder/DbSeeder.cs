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

            //Artists
            var dilba = new Artist { ArtistName = "Dilba" };
            if(!context.Artists.Any(a => a.ArtistName == "Dilba"))
                context.Artists.Add(dilba);

            var orup = new Artist { ArtistName = "Orup" };
            if (!context.Artists.Any(a => a.ArtistName == "Orup"))
                context.Artists.Add(orup);

            //Dilba songs
            var imSorry = new Song { SongName = "Im sorry", Artist = dilba };
            if (!context.Songs.Any(a => a.SongName == "Im sorry"))
                context.Songs.Add(imSorry);
            var tryAgain = new Song { SongName = "Try again", Artist = dilba};
            if (!context.Songs.Any(a => a.SongName == "Try again"))
                context.Songs.Add(tryAgain);

            //Orup songs
            var trubbel = new Song { SongName = "Trubbel", Artist = orup };
            if (!context.Songs.Any(a => a.SongName == "Trubbel"))
                context.Songs.Add(trubbel);
            var magaluf = new Song { SongName = "Magaluf", Artist = orup };
            if (!context.Songs.Any(a => a.SongName == "Magaluf"))
                context.Songs.Add(magaluf);
        }
    }
}
