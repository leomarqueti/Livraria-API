namespace Livraria.Communication.Request;

public class RequestUpdateBookJson
{
    public string Title { get; set; }
    public string Author { get; set; }

    public BookGenrer Genre { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }

}
