using System.Text.Json.Serialization;

namespace Lago.NET.Client.DTOs.Shared
{
    public class MetaData
    {
        [JsonPropertyName("current_page")]
        public int CurrentPage { get; set; }

        [JsonPropertyName("next_page")]
        public int? NextPage { get; set; }

        [JsonPropertyName("prev_page")]
        public int? PreviousPage { get; set; }

        [JsonPropertyName("total_pages")]
        public int TotalPages { get; set; }

        [JsonPropertyName("total_count")]
        public int TotalCount { get; set; }
    }
}