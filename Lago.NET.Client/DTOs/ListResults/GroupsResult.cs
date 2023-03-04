using System.Collections.Generic;

using Lago.NET.Client.DTOs.Shared;
using Lago.NET.Client.Models;

namespace Lago.NET.Client.DTOs.ListResults
{
    public class GroupsResult : ListResult
    {
        public IEnumerable<Group> Groups { get; set; }
    }
}