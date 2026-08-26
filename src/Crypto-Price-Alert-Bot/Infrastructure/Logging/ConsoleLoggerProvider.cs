using Microsoft.Extensions.Logging;

namespace CryptoPriceAlertBot.Infrastructure.Logging
{
    public class ConsoleLoggerProvider : ILoggerProvider
    {
        public ILogger CreateLogger(string categoryName) => new ConsoleLogger(categoryName);
        public void Dispose() { }
    }
}
