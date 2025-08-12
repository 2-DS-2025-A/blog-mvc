using System.ComponentModel.DataAnnotations;

namespace BlogGallo.Models;

public class Categoria
{
    public int Id { get; set; }

    [Required]
    [StringLength(30)]
    public string Nome { get; set; }

    public Categoria()
    {
    }

    public Categoria(int id, string nome)
    {
        Id = id;
        Nome = nome;
    }
}
