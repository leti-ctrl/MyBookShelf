using HotChocolate.Execution.Configuration;
using MyBookShelf.API.GraphQL.Queries;
using MyBookShelf.GraphQLSchema;

namespace MyBookShelf.API.GraphQL;


public static class SchemaSetup
{
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