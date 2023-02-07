using MiniApiCatalogo.Context;
using Microsoft.EntityFrameworkCore;
using MiniApiCatalogo.Models;
using MiniApiCatalogo.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var conexaoPadrao = builder.Configuration.GetConnectionString("DefaultConnetion");

builder.Services.AddDbContext<AppDbContext>(options => options.UseMySql(conexaoPadrao,ServerVersion.AutoDetect(conexaoPadrao)));

builder.Services.AddSingleton<ITokenService>(new TokenServices());

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,

        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        ValidAudience = builder.Configuration["Jwt:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
};
});

builder.Services.AddAuthorization();

var app = builder.Build();

//----------EndpoitLogin--------

app.MapPost("/login", [AllowAnonymous] (UserModel useModel, ITokenService tokenService) =>
{
    if (useModel == null)
    {
        return Results.BadRequest("Login Invalido");
    }
    if (useModel.UserName == "igor" && useModel.Password == "19101993")
    {
        var tokenString = tokenService.GerarToken(app.Configuration["Jwt:Key"], app.Configuration["Jwt:Issuer"],
            app.Configuration["Jwt:Audience"], useModel);
        return Results.Ok(new { token = tokenString });
    }
    else
    {
        return Results.BadRequest("Login Invalido");
    }
}).Produces(StatusCodes.Status400BadRequest).Produces(StatusCodes.Status200OK).WithName("Login").WithTags("Authentication");

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


//-------------EndPoitProdutos--------------------------------

app.MapPost("/produtos", async (Produto produto, AppDbContext db) =>
{
    db.Produtos.Add(produto);
    await db.SaveChangesAsync();
    return Results.Created($"/produtos/{produto.ProdutoId}", produto);
});


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthentication();
app.UseAuthorization();

app.Run();
