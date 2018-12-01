﻿using Newtonsoft.Json;

namespace CoinMarketCap.Models.Cryptocurrency
{
    public class LatestQuoteParams
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("convert")]
        public string Convert { get; set; }
    }
}
