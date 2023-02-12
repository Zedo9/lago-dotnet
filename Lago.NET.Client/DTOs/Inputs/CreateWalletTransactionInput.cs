using System.Text.Json.Serialization;

namespace Lago.NET.Client.DTOs.Inputs
{
    public class CreateWalletTransactionInput
    {
        [JsonPropertyName("wallet_id")]
        public string LagoWalletId { get; set; }

        [JsonPropertyName("paid_credits")]
        public string PaidCredits { get; set; }

        [JsonPropertyName("granted_credits")]
        public string GrantedCredits { get; set; }
    }

    internal class CreateWalletTransactionInputWrapper
    {
        public CreateWalletTransactionInputWrapper(CreateWalletTransactionInput createWalletTransactionInput)
        {
            WalletTransaction = createWalletTransactionInput;
        }
        [JsonPropertyName("wallet_transaction")]
        public CreateWalletTransactionInput WalletTransaction { get; set; }
    }
}