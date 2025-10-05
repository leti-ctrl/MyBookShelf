using HotChocolate.Execution.Configuration;
using MyBookShelf.GraphQLSchema.Queries;
using MyBookShelf.GraphQLSchema.Types;

namespace MyBookShelf.API.GraphQL;

/// <summary>
/// Provides extension methods for configuring the GraphQL schema and services
/// within the dependency injection container.
/// </summary>
/// <remarks>
/// This static class is responsible for registering all GraphQL-related
/// components of the <c>MyBookShelf</c> application, including query types,
/// object type mappings, and other schema configurations.
/// <para>
/// The schema is based on a modular design, where individual query and mutation
/// types can be added via type extensions (e.g. <see cref="BookQueries"/>).
/// </para>
/// </remarks>
public static class SchemaSetup
{
    /// <summary>
    /// Registers the GraphQL server and schema configuration for the MyBookShelf API.
    /// </summary>
    /// <param name="services">
    /// The dependency injection service collection used to register GraphQL components.
    /// </param>
    /// <returns>
    /// An <see cref="IRequestExecutorBuilder"/> instance that can be used to further
    /// customize the GraphQL server configuration.
    /// </returns>
    /// <example>
    /// Example usage in <c>Program.cs</c>:
    /// <code>
    /// var builder = WebApplication.CreateBuilder(args);
    /// builder.Services.AddBookShelfGraphQL();
    /// var app = builder.Build();
    /// app.MapGraphQL();
    /// app.Run();
    /// </code>
    /// </example>
    public static IRequestExecutorBuilder AddBookShelfGraphQL(this IServiceCollection services)
    {
        return services
            .AddGraphQLServer()
            .AddQueryType()                  // root Query
            .AddTypeExtension<BookQueries>() // estensioni modulari
            //.AddMutationType()               // root Mutation
            //.AddTypeExtension<BookMutations>()
            .AddType<BookType>()
            .AddType<AuthorType>();
    }
}