using System.Text.Json.Serialization;

namespace Lago.NET.Client.DTOs.Inputs
{
    public class UpdateAddOnInput
    {
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

    internal class UpdateAddOnInputWrapper
    {
        internal UpdateAddOnInputWrapper(UpdateAddOnInput updateAddOnInput)
        {
            AddOn = updateAddOnInput;
        }

        [JsonPropertyName("add_on")]
        public UpdateAddOnInput AddOn { get; set; }
    }
}