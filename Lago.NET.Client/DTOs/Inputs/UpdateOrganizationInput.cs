using Lago.NET.Client.Models;

namespace Lago.NET.Client.DTOs.Inputs
{
    public class UpdateOrganizationInput
    {
        public string Name { get; set; }

        public string WebhookUrl { get; set; }

        public string Country { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string State { get; set; }

        public string Zipcode { get; set; }

        public string Email { get; set; }

        public string City { get; set; }

        public string LegalName { get; set; }

        public string LegalNumber { get; set; }

        public string Timezone { get; set; }

        public OrgBillingConfiguration BillingConfiguration { get; set; }
    }

    public class UpdateOrganizationInputWrapper
    {
        public UpdateOrganizationInputWrapper(UpdateOrganizationInput updateOrganizationInput)
        {
            Organization = updateOrganizationInput;
        }

        public UpdateOrganizationInput Organization { get; set; }
    }
}