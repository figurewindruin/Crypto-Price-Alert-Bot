using CryptoPriceAlertBot.Core.Models;

namespace CryptoPriceAlertBot.Core.Services
{
    public interface IPriceProvider
    {
        Task<PriceSnapshot> GetPriceAsync(string symbol, string currency, CancellationToken cancellationToken = default);
    }
}
