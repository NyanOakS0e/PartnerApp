namespace Eagle.Api.ServiceInterfaces
{
    public interface IAuthService
    {
        string CreateAccessToken(string userGuid, string username, IEnumerable<string> roles);
    }
}