using Microsoft.EntityFrameworkCore;
using MiniApiCatalogo.Context;
using MiniApiCatalogo.Models;

namespace MiniApiCatalogo.ApiEndPoints
{
    public static class CategoriasEndPoints
    {
        public static void MapCategoriasEndPoints(this WebApplication app)
        {
            app.MapGet("/", () => "Catalogo de Produtos");

            app.MapPost("/categorias", async (Categoria categoria, AppDbContext db) =>
            {
                db.Categorias.Add(categoria);
                await db.SaveChangesAsync();
                return Results.Created($"/categorias/{categoria.CategoriaId}", categoria);
            });

            app.MapGet("/categorias", async (AppDbContext db) => await db.Categorias.ToListAsync()).RequireAuthorization();


            app.MapPut("/categorias/{ id:int}", async (int id, Categoria categoria, AppDbContext db) =>
            {
                if (categoria.CategoriaId != id)
                {
                    return Results.NotFound();
                }
                var categoriaDb = await db.FindAsync<Categoria>(id);
                if (categoriaDb != null)
                {
                    return Results.NotFound(categoriaDb);
                }
                categoriaDb.Nome = categoria.Nome;
                categoriaDb.Descricao = categoria.Descricao;
                await db.SaveChangesAsync();
                return Results.Ok(id);
            });
        }
    }
}
