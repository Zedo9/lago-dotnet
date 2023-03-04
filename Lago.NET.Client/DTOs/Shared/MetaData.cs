namespace Lago.NET.Client.DTOs.Shared
{
    public class MetaData
    {
        public int CurrentPage { get; set; }

        public int? NextPage { get; set; }

        public int? PrevPage { get; set; }

        public int TotalPages { get; set; }

        public int TotalCount { get; set; }
    }
}