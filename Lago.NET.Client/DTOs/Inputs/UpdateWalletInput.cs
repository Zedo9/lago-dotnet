using System;
using System.Text.Json.Serialization;

namespace Lago.NET.Client.DTOs.Inputs
{
    public class UpdateWalletInput
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("expiration_date")]
        public DateTime ExpirationDate { get; set; }
    }

    public class UpdateWalletInputWrapper
    {
        public UpdateWalletInputWrapper(UpdateWalletInput updateWalletInput)
        {
            Wallet = updateWalletInput;
        }

        [JsonPropertyName("wallet")]
        public UpdateWalletInput Wallet { get; set; }
    }
}