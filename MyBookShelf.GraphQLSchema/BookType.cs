using HotChocolate.Types;
using MyBookShelf.Domain;

namespace MyBookShelf.GraphQLSchema;

public class BookType : ObjectType<Book>
{
    protected override void Configure(IObjectTypeDescriptor<Book> descriptor)
    {
        descriptor.Description("Represents a book in the shelf");

        descriptor
            .Field(b => b.Title)
            .Description("The title of the book");

        descriptor
            .Field(b => b.Author)
            .Description("The author of this book");
    }
}