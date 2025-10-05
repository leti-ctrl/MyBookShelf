using MyBookShelf.Domain;

namespace MyBookShelf.API.GraphQL.Queries;

[ExtendObjectType(OperationTypeNames.Query)]
public class BookQueries
{
    public Book GetBook()
        => new Book("C# in Depth", new Author("Jon Skeet" ));
}