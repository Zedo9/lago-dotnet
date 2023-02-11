using System.Net.Http;
using System.Net.Http.Headers;

namespace Lago.NET.Client.Extensions
{
    public static class HttpClientExtensions
    {
        public static HttpClient AddHeaders(
            this HttpClient httpClient,
            string apiKey)
        {
            var headers = httpClient.DefaultRequestHeaders;

            headers.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);

            headers.Accept.Clear();
            headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            return httpClient;
        }

    }
}