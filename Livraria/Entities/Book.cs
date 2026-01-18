

using Microsoft.Extensions.Primitives;
using System.ComponentModel.DataAnnotations.Schema;
namespace Livraria.Entities;

public class Book : Entity
{
    public string Title { get; private set; }
    public string Author { get; private set; }

    public BookGenrer Genre  { get; private set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal Price { get; private set; }
    public int Stock { get; private set; }

    public Book(string title, string author, BookGenrer genre, decimal price, int stock)
    {
        Title = title;
        Author = author;
        Genre = genre;
        Price = price;
        Stock = stock;

        if(Title.Length < 2 || Title.Length > 120)
        {
            throw new ArgumentException("Precisa ter entre 2 a 120 caracteres");
        } else if (Author.Length < 2 ||  Author.Length > 120)
        {
            throw new ArgumentException("Precisa ter entre 2 a 120 caracteres");
        } else if (price < 0 || stock < 0)
        {
            throw new ArgumentException("Precisa ser maior que 0");
        }
    }

    public void Update(string title, string author, BookGenrer genre, decimal price, int stock)
    {
        Title = title;
        Author = author;
        Genre = genre;
        Price = price;
        Stock = stock;
        UpdatedAt = DateTime.Now;
    }

}
