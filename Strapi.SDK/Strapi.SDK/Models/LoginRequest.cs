namespace Strapi.SDK
{
    public class LoginRequest
    {
        public string Identifier { get; }
        public string Password { get; }


        public LoginRequest(string username, string password)
        {
            this.Identifier = username;
            this.Password = password;
        }
    }
}