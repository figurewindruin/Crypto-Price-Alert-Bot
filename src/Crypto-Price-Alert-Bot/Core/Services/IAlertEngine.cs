using CryptoPriceAlertBot.Core.Models;

namespace CryptoPriceAlertBot.Core.Services
{
    public interface IAlertEngine
    {
        List<Alert> Evaluate(List<PriceSnapshot> current, List<PriceSnapshot> previous, double threshold);
    }
}
