using System;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MoviesApp.Models;

namespace MoviesApp.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MoviesContext(serviceProvider.GetRequiredService<DbContextOptions<MoviesContext>>()))
            {
                // Look for any movies.
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(
                        new Movie
                        {
                            Title = "Spider-man: No Way Home",
                            ReleaseDate = DateTime.Parse("2021-12-16"),
                            Genre = "Fantasy",
                            Price = 7.99M
                        },
                        new Movie
                        {
                            Title = "The Matrix Resurrection",
                            ReleaseDate = DateTime.Parse("2021-12-16"),
                            Genre = "Fantasy",
                            Price = 8.99M
                        },
                        new Movie
                        {
                            Title = "Venom 2",
                            ReleaseDate = DateTime.Parse("2021-09-14"),
                            Genre = "Fantasy",
                            Price = 9.99M
                        },
                        new Movie
                        {
                            Title = "Space Jam: A New Legacy",
                            ReleaseDate = DateTime.Parse("2021-07-12"),
                            Genre = "Cartoon",
                            Price = 3.99M
                        }
                    );
                    
                    context.SaveChanges();
                }
                
                var userManager = serviceProvider.GetService<UserManager<ApplicationUser>>();
                var roleManager = serviceProvider.GetService<RoleManager<IdentityRole>>();

                if (!roleManager.RoleExistsAsync("Admin").Result)
                {
                    roleManager.CreateAsync(new IdentityRole { Name = "Admin" }).Wait();
                }
                if (userManager.FindByEmailAsync("admin@example.com").Result == null)
                {
                    var user = new ApplicationUser
                    {
                        UserName = "admin@example.com",
                        Email = "admin@example.com",
                        FirstName = "Admin",
                        LastName = "Admin"
                    };

                    IdentityResult result = userManager.CreateAsync(user, "Passw0rd").Result;
 
                    if (result.Succeeded)
                    {
                        userManager.AddToRoleAsync(user, "Admin").Wait();
                    }
                }
            }
        }
    }
}