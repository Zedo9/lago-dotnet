using System.Text.Json;
using System.Text.Json.Serialization;

using Refit;

namespace Lago.NET.Client.Serialization
{
    internal static class SerializerSettings
    {
        internal static readonly IHttpContentSerializer DefaultSerializerSettings =
            new SystemTextJsonContentSerializer(new JsonSerializerOptions()
            {
                PropertyNamingPolicy = new JsonSnakeCaseNamingPolicy(),
                PropertyNameCaseInsensitive = false,
                WriteIndented = false,
                Converters = { new JsonStringEnumConverter(new JsonSnakeCaseNamingPolicy()) }
            });
    }
}