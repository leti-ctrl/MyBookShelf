using HotChocolate.Types;
using MyBookShelf.Domain;

namespace MyBookShelf.GraphQLSchema.Types;

/// <summary>
/// GraphQL object type definition for the <see cref="Author"/> domain entity.
/// Configures how the Author model is exposed in the GraphQL schema.
/// </summary>
/// <remarks>
/// This type defines the fields and metadata for the Author object in the GraphQL schema.
/// </remarks>
public class AuthorType : ObjectType<Author>
{
    /// <summary>
    /// Configures the fields and metadata for the <see cref="Author"/> GraphQL object type.
    /// </summary>
    /// <param name="descriptor">
    /// The object type descriptor used to define the Author type in the GraphQL schema.
    /// </param>
    protected override void Configure(IObjectTypeDescriptor<Author> descriptor)
    {
        descriptor.Description("Represents an author of a book");

        descriptor
            .Field(a => a.Name)
            .Description("The full name of the author");
    }
}
