

using BibliotecaEleMarti.Models;

namespace BibliotecaEleMarti.Service;

public class BookServiceOnMemory : IServiceCrud<Book>
{
    private static List<Book> _bookList = new();

    public Book Create(Book objectValue)
    {
        throw new NotImplementedException();
    }

    public void DeleteById(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<T> GetAll<T>()
    {
        throw new NotImplementedException();
    }

    public Book GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Book Update(int id)
    {
        throw new NotImplementedException();
    }
}
