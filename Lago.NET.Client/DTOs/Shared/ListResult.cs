using System.Text.Json.Serialization;

namespace Lago.NET.Client.DTOs.Shared
{
    public class ListResult<T>
    {
        [JsonPropertyName("meta")]
        public MetaData Meta { get; set; }
    }
}