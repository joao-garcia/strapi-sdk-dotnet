namespace Strapi.SDK
{
    public class User
    {
        public string Username { get; set; }
        public string Id { get; set; }
        public string Email { get; set; }
        public string Blocked { get; set; }
        public bool IsAdmin { get; set; }
    }
}