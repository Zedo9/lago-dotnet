using System;

namespace Lago.NET.Client.Models
{
    public class AddOn
    {
        /// <summary>
        /// Unique identifier of the Add-on in Lago application.
        /// </summary>
        public string LagoId { get; set; }

        /// <summary>
        /// Date of Addon creation.
        /// </summary>
        public DateTime CreatedAt { get; set; }

        public string Name { get; set; }

        public string Code { get; set; }

        public int AmountCents { get; set; }

        public string AmountCurrency { get; set; }

        public string Description { get; set; }
    }

    internal class AddOnWrapper
    {
        public AddOn AddOn { get; set; }
    }
}