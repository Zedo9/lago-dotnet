using System;

namespace Lago.NET.Client.DTOs.Inputs
{
    public class UpdateWalletInput
    {
        public string Name { get; set; }

        public DateTime ExpirationDate { get; set; }
    }

    internal class UpdateWalletInputWrapper
    {
        public UpdateWalletInputWrapper(UpdateWalletInput updateWalletInput)
        {
            Wallet = updateWalletInput;
        }

        public UpdateWalletInput Wallet { get; set; }
    }
}