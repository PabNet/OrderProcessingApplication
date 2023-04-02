using Microsoft.EntityFrameworkCore;
using OrderProcessingApplication.DTO.Entities;
using static OrderProcessingApplication.DTO.Constants.DomainConstantStorage;

namespace OrderProcessingApplication.Domain.Services
{
    public sealed class PostgresOrderContext : DbContext
    {
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<OrderItem> OrderItems { get; set; } = null!;
        public DbSet<Provider> Providers { get; set; } = null!;
        
        private readonly ConfigurationService _configurationService;

        public PostgresOrderContext(ConfigurationService configurationService)
        {
            _configurationService = configurationService;
            Database.EnsureCreated();
        }

        private void DeleteDataBase()
        {
            Database.EnsureDeleted();
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = _configurationService.GetValue(PostgreSqlConnectionString);
            optionsBuilder.UseLazyLoadingProxies().UseNpgsql(connectionString);
        }
    }
}