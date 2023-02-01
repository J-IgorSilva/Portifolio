namespace MiniApiCatalogo.Services
{
    public interface ITokenService
    {
        string GetToken(string key,string issuer, string audience,UserModel user);
    }
}
