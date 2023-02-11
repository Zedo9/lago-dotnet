using System.Collections.Generic;
using System.Text.Json.Serialization;

using Lago.NET.Client.DTOs.Shared;
using Lago.NET.Client.Models;

namespace Lago.NET.Client.DTOs.ListResults
{
    public class WalletsResult : ListResult<Wallet>
    {
        [JsonPropertyName("wallets")]
        public IEnumerable<Wallet> Wallets { get; set; }
    }
}