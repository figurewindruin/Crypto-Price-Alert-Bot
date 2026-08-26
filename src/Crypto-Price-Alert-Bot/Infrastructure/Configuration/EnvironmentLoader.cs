using Microsoft.Extensions.Configuration;

namespace CryptoPriceAlertBot.Infrastructure.Configuration
{
    public static class EnvironmentLoader
    {
        public static IConfigurationRoot Load(string[]? args = null)
        {
            return new ConfigurationBuilder()
                .AddEnvironmentVariables("CRYPTOALERTBOT_")
                .AddCommandLine(args ?? Array.Empty<string>())
                .Build();
        }
    }
}
