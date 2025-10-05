using HotChocolate.Types;
using MyBookShelf.Domain;

namespace MyBookShelf.GraphQLSchema.Queries;

/// <summary>
/// Represents the set of GraphQL query operations related to books.
/// </summary>
/// <remarks>
/// This class extends the root <c>Query</c> type in the GraphQL schema
/// and defines operations that allow clients to retrieve book-related data.
/// <para>
/// Queries defined here are exposed through the GraphQL API and can be
/// expanded to support filtering, pagination, or integration with
/// application and persistence layers.
/// </para>
/// </remarks>
[ExtendObjectType(OperationTypeNames.Query)]
public class BookQueries
{
    
    /// <summary>
    /// Retrieves a single <see cref="Book"/> instance.
    /// </summary>
    /// <remarks>
    /// This is a simple example query that returns a static book instance.
    /// In a real-world application, this method would typically query
    /// a service or repository from the application or infrastructure layers
    /// to fetch data from a database or external API.
    /// </remarks>
    /// <returns>
    /// A <see cref="Book"/> object representing a sample book record.
    /// </returns>
    public Book GetBook()
        => new Book("C# in Depth", new Author("Jon Skeet" ));
}