namespace Lago.NET.Tests.Fixtures
{
    public static class JsonFixtures
    {
        public readonly static string BillableMetricJSON = System.IO.File.ReadAllText("Fixtures/billable_metric.json");

        public readonly static string BillableMetricsJSON = System.IO.File.ReadAllText("Fixtures/billable_metric_index.json");
    }
}