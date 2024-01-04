namespace task3;

public class Book : AbstractBook,IBorrowable
{
    public void Borrow()
    {
        System.Console.WriteLine("Book is already rented");
    }
    public void ReturnBook()
    {
        System.Console.WriteLine("Book is already returned");
    }
}