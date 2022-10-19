namespace BibliotecaEleMarti.Models;

public class Borrow
{
    public int Id { get; set; }
    public DateOnly StartDate { get; set; }
    public DateOnly EndDate { get; set; }

    public Book BorrowedBook { get; set; }

    public Customer Customer{ get; set; }
}
