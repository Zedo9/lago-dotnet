using Refit;

namespace Lago.NET.Client.DTOs.Filters
{
    public class PageFilter
    {
        protected PageFilter() { }
        public PageFilter(int perPage, int page)
        {
            PerPage = perPage;
            Page = page;
        }

        [AliasAs("per_page")]
        public int? PerPage { get; set; }

        [AliasAs("page")]
        public int? Page { get; set; }
    }
}

