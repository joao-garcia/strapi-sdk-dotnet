using Newtonsoft.Json;

namespace Strapi.SDK
{
    public class ClientConfiguration
    {
        static ClientConfiguration()
        {
            JsonConvert.DefaultSettings = () => new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                DateTimeZoneHandling = DateTimeZoneHandling.Utc
            };
        }

        public static ClientConfiguration Default { get; } = new ClientConfiguration();

        public string Token { get; set; }
        public string BaseUrl { get; set; }
    }
}