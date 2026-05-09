using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;

namespace MvcMovie.Models;


public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<

                DbContextOptions<MvcMovieContext>>());

        if (context.Movie.Any())
        {
            return;
        }

        context.Movie.AddRange(
            new Movie
            {
                Title = "The Dark Knight",
                ReleaseDate = DateTime.Parse("2008-7-18"),
                Genre = "Action",
                Price = 9.99M,
                Rating = "PG-13"
            },
            new Movie

            {
                Title = "Interstellar",
                ReleaseDate = DateTime.Parse("2014-11-7"),
                Genre = "Sci-Fi",
                Price = 9.99M,
                Rating = "PG-13"

            },
            new Movie
            {
                Title = "Project Hail Mary",
                ReleaseDate = DateTime.Parse("2026-3-20"),
                Genre = "Sci-Fi",
                Price = 9.99M,
                Rating = "PG-13"
            },
            new Movie
            {
                Title = "The Lord of the Rings",
                ReleaseDate = DateTime.Parse("2001-12-19"),
                
                Genre = "Fantasy",
                Price = 8.99M,
                Rating = "PG-13"
            }
        );

        context.SaveChanges();
    }
}