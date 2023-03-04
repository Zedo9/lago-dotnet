using System.Collections.Generic;

using Lago.NET.Client.DTOs.Shared;
using Lago.NET.Client.Models;

namespace Lago.NET.Client.DTOs.ListResults
{
    public class CustomersResult : ListResult
    {
        public IEnumerable<Customer> Customers { get; set; }
    }
}