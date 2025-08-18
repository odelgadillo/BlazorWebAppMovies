using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorWebAppMovies;

public class Pelicula
{
    public int Id { get; set; }
    public string? Titulo { get; set; }
    public DateOnly FechaPublicacion { get; set; }
    public string? Genero { get; set; }

    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18,2)")]
    public Decimal Precio { get; set; }
}
