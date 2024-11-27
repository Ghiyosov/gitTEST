namespace GitTest.library;

public class books
{
    public int ID { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Author { get; set; }

    public books(int id, string title, string description, string author)
    {
        Title = title;
        Description = description;
        Author = author;
    }
}