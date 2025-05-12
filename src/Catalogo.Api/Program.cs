using Catalogo.Api.Extensins;
using Catalogo.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddInfrastructure(builder.Configuration);//adiciona a infraestrutura ao projeto, como o banco de dados e o logger

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

await app.ApplyMigration();//aguarda a migração ser concluida 

app.UseHttpsRedirection();

app.Run();
