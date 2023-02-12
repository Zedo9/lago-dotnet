using System.Text.Json.Serialization;

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
            this.Name = name;
            this.Code = code;
            this.AmountCents = amountCents;
            this.AmountCurrency = amountCurrency;
            this.Description = description;
        }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("amount_cents")]
        public int AmountCents { get; set; }

        [JsonPropertyName("amount_currency")]
        public string AmountCurrency { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }
    }

    internal class CreateAddOnInputWrapper
    {
        internal CreateAddOnInputWrapper(CreateAddOnInput createAddonInput)
        {
            AddOn = createAddonInput;
        }

        [JsonPropertyName("add_on")]
        public CreateAddOnInput AddOn { get; set; }
    }
}