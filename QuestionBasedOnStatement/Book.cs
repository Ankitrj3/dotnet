using System.Collections.Generic;
using System.Text;
public class Book
{
    public int BookId{get; set;}
    public string? BookName{get; set;}
    public string? AuthorName{get; set;}
    public int? CopiesAvailable{get; set;}

    public Book(){}
    public Book(int BookId, string? BookName, string? AuthorName, int? CopiesAvailable)
    {
        this.BookId = BookId;
        this.BookName = BookName;
        this.AuthorName = AuthorName;
        this.CopiesAvailable = CopiesAvailable;
    }
}
class LMS
{
    private List<Book> _books = new List<Book>();
    public void AddBook(Book books)
    {
        _books.Add(books);
    }
    public int GetTotalBooks()
    {
        int totalBooks = 0;
        foreach(Book b in _books)
        {
            totalBooks++;
        }
        return totalBooks;
    }
    public List<Book> GetBooksByAuthor(string author)
    {
        List<Book> result = new List<Book>();
        foreach (Book b in _books)
        {
            if (b.AuthorName == author)
                result.Add(b);
        }
        return result;
    }
}