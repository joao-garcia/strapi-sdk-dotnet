namespace Strapi.SDK
{
    using System;
    using System.Net;

    [Serializable]
    public class StrapiApiException : ApplicationException
    {
        public StrapiApiException()
        {
        }

        public StrapiApiException(HttpStatusCode httpStatusCode, string message, string content) : base(message)
        {
            HttpStatusCode = httpStatusCode;
            Content = content;
        }

        public HttpStatusCode HttpStatusCode { get; set; }
        public string Content { get; set; }
    }
}