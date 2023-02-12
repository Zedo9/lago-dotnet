using System.Collections.Generic;
using System.Text.Json.Serialization;

using Lago.NET.Client.DTOs.Shared;
using Lago.NET.Client.Models;

namespace Lago.NET.Client.DTOs.ListResults
{
    public class AddOnsResult : ListResult
    {
        [JsonPropertyName("add_ons")]
        public IEnumerable<AddOn> AddOns { get; set; }
    }
}