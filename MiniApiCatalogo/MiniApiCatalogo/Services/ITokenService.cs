using MiniApiCatalogo.Models;

namespace MiniApiCatalogo.Services
{
    public interface ITokenService
    {
        string GerarToken(string key,string issuer, string audience,UserModel user);
    }
}
