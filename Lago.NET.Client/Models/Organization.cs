using System;

namespace Lago.NET.Client.Models
{
    public class Organization
    {
        public string Name { get; set; }

        public DateTime CreatedAt { get; set; }

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

        public string TimeZone { get; set; }

        public OrgBillingConfiguration BillingConfiguration { get; set; }
    }

    internal class OrganizationWrapper
    {
        public Organization Organization { get; set; }
    }
}