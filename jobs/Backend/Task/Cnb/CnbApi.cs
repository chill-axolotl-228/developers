using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ExchangeRateUpdater.Cnb
{
    internal interface IBankApi
    {
        Task<IEnumerable<CnbExchangeRate>> GetTodayExchangeRates();
    }

    internal sealed class BankApi : IBankApi
    {
        private readonly HttpClient _httpClient;

        public BankApi(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<CnbExchangeRate>> GetTodayExchangeRates()
        {
            var exchangeRatesEndpoint = "https://api.cnb.cz/cnbapi/exrates/daily?lang=EN";
            var response = await _httpClient.GetFromJsonAsync<CnbExchangeRates>(exchangeRatesEndpoint);
            return response.Rates;
        }
    }
}
