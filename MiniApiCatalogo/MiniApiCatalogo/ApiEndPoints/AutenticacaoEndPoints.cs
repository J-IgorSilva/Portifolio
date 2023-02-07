using Microsoft.AspNetCore.Authorization;
using MiniApiCatalogo.Models;
using MiniApiCatalogo.Services;

namespace MiniApiCatalogo.ApiEndPoints
{
    public static class AutenticacaoEndPoints
    {
        public static void MapAutenticacaoEndPoints(this WebApplication app)
        {
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
        }
    }
}
