namespace MyBookShelf.Domain;

public class Book
{
    public Book(string title, Author author)
    {
        Title = title;
        Author = author;
    }

    public string Title { get; set; }
    
    public Author Author { get; set; }
}