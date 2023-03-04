namespace Lago.NET.Tests.Fixtures
{
    public static class Responses
    {
        public static string GetJson(string resourceName)
        {
            return System.IO.File.ReadAllText($"Responses/{resourceName}.json");
        }

        public static string GetIndexJson(string resourceName)
        {
            return System.IO.File.ReadAllText($"Responses/{resourceName}_index.json");
        }
    }
}