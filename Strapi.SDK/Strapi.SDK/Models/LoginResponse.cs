namespace Strapi.SDK
{
    public class LoginResponse
    {
        public string Jwt { get; set; }

        public User User { get; set; }
    }
}