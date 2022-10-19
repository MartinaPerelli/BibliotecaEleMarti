using BibliotecaEleMarti.Enumerators;

namespace BibliotecaEleMarti.Models;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public BookGenre Genre{ get; set; }


}
