namespace Lago.NET.Client.DTOs.Inputs
{
    public class CreateWalletTransactionInput
    {
        public string LagoWalletId { get; set; }

        public string PaidCredits { get; set; }

        public string GrantedCredits { get; set; }
    }

    internal class CreateWalletTransactionInputWrapper
    {
        public CreateWalletTransactionInputWrapper(CreateWalletTransactionInput createWalletTransactionInput)
        {
            WalletTransaction = createWalletTransactionInput;
        }

        public CreateWalletTransactionInput WalletTransaction { get; set; }
    }
}