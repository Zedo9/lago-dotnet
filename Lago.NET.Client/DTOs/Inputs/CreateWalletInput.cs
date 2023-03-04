namespace Lago.NET.Client.DTOs.Inputs
{
    public class CreateWalletInput
    {
        public string Name { get; set; }

        public string RateAmount { get; set; }

        public string PaidCredits { get; set; }

        public string GrantedCredits { get; set; }

        public string Currency { get; set; }

        public string ExpirationDate { get; set; }

        public string ExternalCustomerId { get; set; }
    }

    internal class CreateWalletInputWrapper
    {
        public CreateWalletInputWrapper(CreateWalletInput createWalletInput)
        {
            Wallet = createWalletInput;
        }

        public CreateWalletInput Wallet { get; set; }
    }
}