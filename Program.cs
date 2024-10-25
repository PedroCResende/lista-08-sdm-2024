using Microsoft.EntityFrameworkCore;
using BibliotecaApi.Data;
using BibliotecaApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<BibliotecaContext>(options =>
    options.UseSqlite("Data Source=biblioteca.db"));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapPost("/bibliotecas", async (Biblioteca biblioteca, BibliotecaContext db) =>
{
    db.Bibliotecas.Add(biblioteca);
    await db.SaveChangesAsync();
    return Results.Created($"/bibliotecas/{biblioteca.Id}", biblioteca);
});

app.MapGet("/bibliotecas", async (BibliotecaContext db) =>
    await db.Bibliotecas.ToListAsync());

app.MapGet("/bibliotecas/{id}", async (int id, BibliotecaContext db) =>
{
    var biblioteca = await db.Bibliotecas.FindAsync(id);
    return biblioteca is not null ? Results.Ok(biblioteca) : Results.NotFound();
});

app.MapPut("/bibliotecas/{id}", async (int id, Biblioteca biblioteca, BibliotecaContext db) =>
{
    if (id != biblioteca.Id) return Results.BadRequest();
    var existingBiblioteca = await db.Bibliotecas.FindAsync(id);
    if (existingBiblioteca is null) return Results.NotFound();

    existingBiblioteca.Nome = biblioteca.Nome;
    existingBiblioteca.Inicio_Funcionamento = biblioteca.Inicio_Funcionamento;
    existingBiblioteca.Fim_Funcionamento = biblioteca.Fim_Funcionamento;
    existingBiblioteca.Inauguracao = biblioteca.Inauguracao;
    existingBiblioteca.Contato = biblioteca.Contato;

    await db.SaveChangesAsync();
    return Results.NoContent();
});

app.MapDelete("/bibliotecas/{id}", async (int id, BibliotecaContext db) =>
{
    var biblioteca = await db.Bibliotecas.FindAsync(id);
    if (biblioteca is null) return Results.NotFound();

    db.Bibliotecas.Remove(biblioteca);
    await db.SaveChangesAsync();
    return Results.NoContent();
});

app.Run();
