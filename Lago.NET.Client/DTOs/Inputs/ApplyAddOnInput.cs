namespace Lago.NET.Client.DTOs.Inputs
{
    public class ApplyAddOnInput
    {
        public ApplyAddOnInput(string externalCustomerId, string addOnCode)
        {
            ExternalCustomerId = externalCustomerId;
            AddOnCode = addOnCode;
        }

        public string ExternalCustomerId { get; set; }

        public string AddOnCode { get; set; }

        public int AmountCents { get; set; }

        public string AmountCurrency { get; set; }
    }

    internal class CreateAppliedAddOnInputWrapper
    {
        public CreateAppliedAddOnInputWrapper(ApplyAddOnInput createAppliedAddOnInput)
        {
            AppliedAddOn = createAppliedAddOnInput;
        }

        public ApplyAddOnInput AppliedAddOn { get; set; }
    }
}