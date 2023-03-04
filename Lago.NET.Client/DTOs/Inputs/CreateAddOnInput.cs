namespace Lago.NET.Client.DTOs.Inputs
{
    public class CreateAddOnInput
    {
        public CreateAddOnInput(
            string name,
            string code,
            int amountCents,
            string amountCurrency,
            string description = null)
        {
            Name = name;
            Code = code;
            AmountCents = amountCents;
            AmountCurrency = amountCurrency;
            Description = description;
        }

        public string Name { get; set; }

        public string Code { get; set; }

        public int AmountCents { get; set; }

        public string AmountCurrency { get; set; }

        public string Description { get; set; }
    }

    internal class CreateAddOnInputWrapper
    {
        internal CreateAddOnInputWrapper(CreateAddOnInput createAddonInput)
        {
            AddOn = createAddonInput;
        }

        public CreateAddOnInput AddOn { get; set; }
    }
}