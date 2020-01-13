using Microsoft.Extensions.Configuration;

namespace Domain.Core.Helpers
{
    public static class ConfigurationResolver
    {
        public static IConfiguration GetConfiguration()
        {
            return new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
        }
    }
}
