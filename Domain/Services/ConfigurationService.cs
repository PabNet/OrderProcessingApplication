using Microsoft.Extensions.Configuration;

namespace OrderProcessingApplication.Domain.Services
{
    public class ConfigurationService
    {
        private readonly IConfigurationRoot _configuration;

        public ConfigurationService(IConfigurationRoot configuration)
        {
            _configuration = configuration;
        }

        public string? GetValue(string key)
        {
            return _configuration[key];
        }
    }
}