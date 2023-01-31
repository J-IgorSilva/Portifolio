using MiniApiCatalogo.Context;
using Microsoft.EntityFrameworkCore;
using MiniApiCatalogo.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var conexaoPadrao = builder.Configuration.GetConnectionString("DefaultConnetion");

builder.Services.AddDbContext<AppDbContext>(options => options.UseMySql(conexaoPadrao,ServerVersion.AutoDetect(conexaoPadrao)));

var app = builder.Build();

app.MapGet("/", () => "Catalogo de Produtos");

app.MapPost("/categorias", async (Categoria categoria, AppDbContext db) =>
{
    db.Categorias.Add(categoria);
    await db.SaveChangesAsync();
    return Results.Created($"/categorias/{categoria.CategoriaId}", categoria);
});

app.MapGet("/categorias",async(AppDbContext db)=> await db.Categorias.ToListAsync());

app.MapGet("/categorias/{ id:int}", async (int id, Categoria categoria, AppDbContext db) =>
{
    return await db.Categorias.FindAsync(id)
    is Categoria categori
    ? Results.Ok(categoria)
    : Results.NotFound();
});
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.Run();
