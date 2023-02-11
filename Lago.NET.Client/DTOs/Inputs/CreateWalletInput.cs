using System.Text.Json.Serialization;

namespace Lago.NET.Client.DTOs.Inputs
{
    public class CreateWalletInput
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("rate_amount")]
        public string RateAmount { get; set; }

        [JsonPropertyName("paid_credits")]
        public string PaidCredits { get; set; }

        [JsonPropertyName("granted_credits")]
        public string GrantedCredits { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("expiration_date")]
        public string ExpirationDate { get; set; }

        [JsonPropertyName("external_customer_id")]
        public string ExternalCustomerId { get; set; }
    }

    public class CreateWalletInputWrapper
    {
        public CreateWalletInputWrapper(CreateWalletInput createWalletInput)
        {
            Wallet = createWalletInput;
        }

        [JsonPropertyName("wallet")]
        public CreateWalletInput Wallet { get; set; }
    }
}