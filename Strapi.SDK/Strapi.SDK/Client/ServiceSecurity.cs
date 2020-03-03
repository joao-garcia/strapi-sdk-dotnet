using System.Threading.Tasks;

namespace Strapi.SDK
{
    public class ServiceSecurity : ClientBase
    {
        protected override string ServiceUrl { get => "admin/auth/local"; }

        public ServiceSecurity()
        {
        }

        public ServiceSecurity(ClientConfiguration serviceInfo) : base(serviceInfo)
        {
        }

        public async Task<LoginResponse> Login(LoginRequest request)
        {
            request.EnsureArgument(nameof(request));

            return await Execute<LoginResponse>(ServiceUrl, HttpMethodName.POST, request);
        }
    }
}