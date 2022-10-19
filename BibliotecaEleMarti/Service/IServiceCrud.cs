namespace BibliotecaEleMarti.Service;

public interface IServiceCrud<T>
{
    public T Create(T objectValue); //POST
    public IEnumerable<T> GetAll<T>(); // GET
    public T GetById(int id); // GET

    public T Update(int id); // PUT

    public void DeleteById(int id); // DELETE

    

}
