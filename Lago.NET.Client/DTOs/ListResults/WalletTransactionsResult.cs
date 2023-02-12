using System.Collections.Generic;
using System.Text.Json.Serialization;

using Lago.NET.Client.DTOs.Shared;
using Lago.NET.Client.Models;

namespace Lago.NET.Client.DTOs.ListResults
{
    public class WalletTransactionsResult : ListResult
    {
        [JsonPropertyName("wallet_transactions")]
        public IEnumerable<WalletTransaction> WalletTransactions { get; set; }
    }
}