namespace Lago.NET.Client.DTOs.Inputs
{
    public class UpdateAddOnInput
    {
        public string Name { get; set; }

        public string Code { get; set; }

        public int AmountCents { get; set; }

        public string AmountCurrency { get; set; }

        public string Description { get; set; }
    }

    internal class UpdateAddOnInputWrapper
    {
        internal UpdateAddOnInputWrapper(UpdateAddOnInput updateAddOnInput)
        {
            AddOn = updateAddOnInput;
        }

        public UpdateAddOnInput AddOn { get; set; }
    }
}