using HotChocolate.Types;
using MyBookShelf.Domain;

namespace MyBookShelf.GraphQLSchema.Types;

/// <summary>
/// GraphQL object type definition for the <see cref="Book"/> domain entity.
/// Configures how the Book model is exposed in the GraphQL schema.
/// </summary>
/// <remarks>
/// This type defines how the Book domain object is represented in GraphQL.
/// </remarks>
public class BookType : ObjectType<Book>
{
    /// <summary>
    /// Configures the fields and metadata for the <see cref="Book"/> GraphQL object type.
    /// </summary>
    /// <param name="descriptor">
    /// The object type descriptor used to define the Book type in the GraphQL schema.
    /// </param>
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