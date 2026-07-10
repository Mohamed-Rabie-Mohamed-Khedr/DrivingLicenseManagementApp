public static class DAHelper
{
    internal static string connectionString { get; private set; }
    public static void SetConnectionString(string connStr)
    {
        connectionString = connStr;
    }
}