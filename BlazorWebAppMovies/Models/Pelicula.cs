using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorWebAppMovies;

public class Pelicula
{
    public int Id { get; set; }

    [Required]
    [StringLength(60, MinimumLength = 3)]
    public string? Titulo { get; set; }

    public DateOnly FechaPublicacion { get; set; }

    [Required]
    [StringLength(30)]
    [RegularExpression(@"^[A-Z]+[a-zA-Z()\s-]*$")]
    public string? Genero { get; set; }

    [Range(0, 100)]
    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18,2)")]
    public Decimal Precio { get; set; }

    [Required]
    [RegularExpression(@"^(G|PG-13|R|NC-17)$")]
    public string? Clasificacion { get; set; }
    
}
