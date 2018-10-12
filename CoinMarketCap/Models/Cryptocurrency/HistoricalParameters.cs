﻿using System;
using Newtonsoft.Json;

namespace CoinMarketCap.Models.Cryptocurrency
{
    public class HistoricalParameters
    {
        [JsonProperty("timestamp")]
        public DateTime Timestamp { get; set; }

        [JsonProperty("start")]
        public int Start { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("convert")]
        public int Convert { get; set; }

        [JsonProperty("sort")]
        public int Sort { get; set; }

        [JsonProperty("sort_dir")]
        public int SortDir { get; set; }

        [JsonProperty("cryptocurrency_type")]
        public int CryptocurrencyType { get; set; }
    }
}