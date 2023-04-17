using Newtonsoft.Json.Linq;


    
       
  public class BTC
    {
       
        private decimal _lastPrice;

        public async Task<decimal> CalculateAveragePrice()
        {
            List<decimal> prices = new List<decimal>();

            for (int i = 0; i < 8; i++)
            {
                HttpClient client = new HttpClient();
                string url = $"https://api.kucoin.com/api/v1/market/stats?symbol=BTC-USDT";
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                JObject json = JObject.Parse(responseBody);
                _lastPrice = (decimal)json["data"]["last"];
                prices.Add(_lastPrice);

                Console.WriteLine($"Last price for BTC : ${_lastPrice} ");

                await Task.Delay(TimeSpan.FromHours(1));
            }

            decimal averagePrice = prices.Average();
            return averagePrice;
        }

        public decimal GetLastPrice()
        {
            return _lastPrice;
        }
    }


