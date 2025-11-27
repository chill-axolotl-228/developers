using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ExchangeRateUpdater.Cnb
{
    internal class CnbExchangeRates
    {
        [JsonPropertyName("rates")]
        [JsonInclude]
        public IEnumerable<CnbExchangeRate> Rates { get; private set; }
    }
    
    internal sealed class CnbExchangeRate
    {
        [JsonPropertyName("currencyCode")]
        public string CurrencyCode { get; init; }

        [JsonPropertyName("amount")]
        public int Amount { get; init; }

        [JsonPropertyName("rate")]
        public decimal Rate { get; init; }

        public decimal RealRate => Rate / Amount;
    }
}
