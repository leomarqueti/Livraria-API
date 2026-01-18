using Livraria.Communication.Request;
using Livraria.Entities;
using Livraria.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Livraria.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BooksController : ControllerBase
{
    //Funciona como um banco de dados 
    //private static List<Book> _books = new List<Book>();


    private readonly LivrariaDbContext _context;
    public BooksController(LivrariaDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    [ProducesResponseType(typeof(Book), StatusCodes.Status201Created)]

    public IActionResult Created([FromBody] RequestCreateBookJson request)
    {

        var book = new Book(
           request.Title,
           request.Author,
           request.Genre,
           request.Price,
           request.Stock
        );

        _context.Books.Add( book );

        _context.SaveChanges();

        //_books.Add(book);


        return Created(string.Empty, book);

    }


    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]

    public IActionResult GetAll()
    {

        var books = _context.Books.ToList();
        return Ok(books);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(typeof(Book), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]

    public IActionResult GetId([FromRoute] Guid id) {

        //var book = _books.FirstOrDefault(x => x.Id == id);


        var book = _context.Books.FirstOrDefault(x => x.Id == id);  

        if (book == null) {

            return NotFound();
        }

        return Ok(book);
    }


    [HttpPut("{id}")]
    [ProducesResponseType(typeof(Book), StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]

    public IActionResult Uptade([FromRoute] Guid id, [FromBody] RequestUpdateBookJson request) { 
        
        var book = _context.Books.FirstOrDefault(x => x.Id == id); ;

        if (book == null) {
            return NotFound();
        }

        book.Update(
            request.Title,
            request.Author,
            request.Genre,
            request.Price,
            request.Stock
            );

        _context.SaveChanges();
        return NoContent();
    
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(typeof(Book), StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]

    public IActionResult DeleteId([FromRoute] Guid id) { 
        var book = _context.Books.FirstOrDefault(x => x.Id == id);

        if (book == null) {
            return NotFound();
        }

        _context.Books.Remove(book);

        _context.SaveChanges(); 
        return NoContent();
    }

}
