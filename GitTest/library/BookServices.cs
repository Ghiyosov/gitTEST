namespace GitTest.library;

public class BookServices
{
    public List<books> ListBooks { get; set; }

    public void AddBooks(books books)
    {
        books.ID = ListBooks.Count + 1;
        ListBooks.Add(books);
    }

    public List<books> GetBooks()
    {
        return ListBooks;
    }

    public void UpdateBooks(books book)
    {
        foreach (var a in ListBooks)
        {
            if (a.ID == book.ID)
            {
                a.Author = book.Author;
                a.Title = book.Title; 
            }
            
        }
    }

    public void DeleteBooks(int id)
    {
        ListBooks.RemoveAll(x => x.ID == id);
    }
}