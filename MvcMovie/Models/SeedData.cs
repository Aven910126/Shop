using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "牛肉麵",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Introduce = "Romantic Comedy",
                        number = "10",
                        Price = 7.99M,
                        Img = "img/1-1.jpg"
                    },

                    new Movie
                    {
                        Title = "陽春麵",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Introduce = "Comedy",
                        number = "10",
                        Price = 8.99M,
                        Img = "img/1-2.jpg"
                    },

                    new Movie
                    {
                        Title = "牛肉湯麵",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Introduce = "Comedy",
                        number = "10",
                        Price = 9.99M,
                        Img = "img/1-3.jpg"
                    },

                    new Movie
                    {
                        Title = "餛飩麵",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Introduce = "Western",
                        number = "10",
                        Img = "img/1-4.jpg"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}