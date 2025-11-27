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
/// <summary>
///     "validFor": "2019-05-17",
      // "ordaaaaer": 94,
      // "country": "Austrálie",
      // "currency": "dolar",
      // "amount": 1,
      // "currencyCode": "AUD",
      // "rate": 15.858aaa
/// </summary>
    internal sealed class CnbExchangeRate
    {
        [JsonPropertyName("currencyCode")]
        [JsonInclude]
        public string CurrencyCode { get; private set; }

        [JsonPropertyName("currencyCode")]
        public int Amount { get; set; }

        [JsonPropertyName("rate")]
        public decimal Rate { get; set; }

        public decimal RealRate => Rate / Amount;
    }
}
