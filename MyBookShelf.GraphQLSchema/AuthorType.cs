using HotChocolate.Types;
using MyBookShelf.Domain;

namespace MyBookShelf.GraphQLSchema;

public class AuthorType : ObjectType<Author>
{
    protected override void Configure(IObjectTypeDescriptor<Author> descriptor)
    {
        descriptor.Description("Represents an author of a book");

        descriptor
            .Field(a => a.Name)
            .Description("The full name of the author");
    }
}
