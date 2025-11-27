namespace DesignPattern.Factory
{
    public static class DatabaseFactory
    {
        public static IDatabase CreateDatabase(DatabaseType databaseType)
        {
            if (databaseType == DatabaseType.Oracle) return new OracleDatabase();
            else if (databaseType == DatabaseType.SqlServer) return new SqlServerDatabase();
            else throw new ArgumentException("Unknown database type: " + databaseType);
        }
    }
}
