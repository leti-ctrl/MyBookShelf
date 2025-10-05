using MyBookShelf.API.GraphQL;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddBookShelfGraphQL();


var app = builder.Build();

app.MapGraphQL();

app.RunWithGraphQLCommands(args);