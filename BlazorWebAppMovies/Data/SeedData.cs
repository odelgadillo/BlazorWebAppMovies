using Microsoft.EntityFrameworkCore;

namespace BlazorWebAppMovies.Data;

public class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using var context = new BlazorWebAppMoviesContext(
            serviceProvider.GetRequiredService<DbContextOptions<BlazorWebAppMoviesContext>>());

        if (context == null || context.Pelicula == null)
        {
            throw new NullReferenceException("Null BlazorWebAppMoviesContext or Movie DbSet");
        }

        if (context.Pelicula.Any()) return;

        context.Pelicula.AddRange(
            new Pelicula
            {
                Titulo = "Mad Max",
                FechaPublicacion = new DateOnly(1979, 4, 12),
                Genero = "Sci-Fi (Cyberpunk)",
                Precio = 2.51M
            },
            new Pelicula
            {
                Titulo = "The Road Warrior",
                FechaPublicacion = new DateOnly(1981, 12, 24),
                Genero = "Sci-Fi (Cyberpunk)",
                Precio = 2.78M
            },
            new Pelicula
            {
                Titulo = "Mad Max: Beyond Thunderdome",
                FechaPublicacion = new DateOnly(1985, 7, 10),
                Genero = "Sci-Fi (Cyberpunk)",
                Precio = 3.99M
            },
            new Pelicula
            {
                Titulo = "Mad Max: Fury Road",
                FechaPublicacion = new DateOnly(2015, 5, 15),
                Genero = "Sci-Fi (Cyberpunk)",
                Precio = 8.43M
            },
            new Pelicula
            {
                Titulo = "Furiosa: A Mad Max Saga",
                FechaPublicacion = new DateOnly(2024, 5, 24),
                Genero = "Sci-Fi (Cyberpunk)",
                Precio = 13.49M
            }
        );
        context.SaveChanges();
    }
}
