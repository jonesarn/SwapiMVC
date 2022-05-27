using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq;

namespace SwapiMVC.Models
{
    public class ResultViewModel<TResult>
    {
        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("next")]
        public string Next { get; set; }

        [JsonPropertyName("previous")]
        public string Previous { get; set; }

        [JsonPropertyName("results")]
        public IEnumerable<TResult> Results { get; set; }
        public string NextPageNum => Next?.Split("?page=").LastOrDefault();
        public string PreviousPageNum => Previous?.Split("?page=").LastOrDefault();
    }
}