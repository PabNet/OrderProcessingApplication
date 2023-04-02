namespace OrderProcessingApplication.DTO.Constants
{
    public static class DomainConstantStorage
    {
        private const string DbSection = "DB:", ConnectionStringsSection = $"{DbSection}ConnectionStrings:";
        public const string PostgreSqlConnectionString = $"{ConnectionStringsSection}PostgreSQL";
    }
}