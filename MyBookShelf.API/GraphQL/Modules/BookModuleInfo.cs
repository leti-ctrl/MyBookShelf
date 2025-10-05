using HotChocolate.Execution.Configuration;
using MyBookShelf.GraphQLSchema.Queries;
using MyBookShelf.GraphQLSchema.Types;

namespace MyBookShelf.API.GraphQL.Modules;

/// <summary>
/// Defines the GraphQL schema configuration for the Book module.
/// </summary>
public static class BookModuleInfo
{
    /// <summary>
    /// Registers all GraphQL types and extensions belonging to the Book module.
    /// </summary>
    public static IRequestExecutorBuilder AddBookModule(this IRequestExecutorBuilder builder)
    {
        return builder
            .AddTypeExtension<BookQueries>()
            .AddType<BookType>()
            .AddType<AuthorType>();
    }
}